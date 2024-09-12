Option Explicit On
'Roman Shade Control

' Remote control of the Roman Shades hanging on the French Doors on the East side of the house.

' This module interfaces with the Hunter Douglas Connection Interface for the PowerRise 2.0 with Platinum Technology system.
' http://www.automatedshadeinc.com/files/controls-hunterdouglas/connection%20interface_5110540109_0510.pdf

' There are 2 Roman shades, one on each door.  They can be controlled independently.
' The north-most shade is Shade 1
' The south-most shade is Shade 2

' To control, a command in the following format must be sent:

' Request: 2 integer values
' First value:  The number of the shade to control (either 1 or 2)
' Second value:  Up/down (1 or 0)
' Termination value:  Chr(10) or Chr(13)

Public Class frmBlindControl
    Const iSHADE1DELAYUP As Integer = 250
    Const iSHADE1DELAYDN As Integer = 130
    Const iSHADE2DELAYUP As Integer = 250
    Const iSHADE2DELAYDN As Integer = 104
    Const iNUMSHADES As Integer = 5

    Public Structure _Shades
        Public iRetries As Integer
        Public bEnabled As Boolean
        Public lblStatus As Label
        Public lblShadeLevel As Label
        Public tbShadeLevel As TrackBar
        Public gbShade As GroupBox
        Public bAutoInitiatedMove As Boolean
        Public bOverride As Boolean
    End Structure

    Dim ArduinoRoman As TcpClient
    Dim ArduinoSomfy As TcpClient
    Dim RomanNetworkStream As NetworkStream
    Dim RomanStreamReader As StreamReader
    Dim RomanStreamWriter As StreamWriter
    Dim SomfyNetworkStream As NetworkStream
    Dim SomfyStreamReader As StreamReader
    Dim SomfyStreamWriter As StreamWriter
    Dim Shades(iNUMSHADES) As _Shades
    Dim iOldDaylight As Integer
    Dim iOldHouseOccupied As Integer
    Dim bTempRaise_BackDoor, bTempRaise_FrontRoom, bTempRaise_GreatRoom As Boolean
    Dim bStartup As Boolean = True

    Private Sub frmBlindControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim tabNewRequests As WatchdogDataSet.Blinds_ControlDataTable
        Dim i As Integer

        Event_HistoryTableAdapter.InsertQuery("9031")
        Blinds_HistoryTableAdapter.InsertQuery("000")

        bStartup = True

        lblLastMove.Text = ""
        lblLastUpdated.Text = ""

        For i = 0 To iNUMSHADES - 1
            Shades(i).iRetries = 0
        Next i

        Shades(0).lblStatus = lblShade1Status
        Shades(1).lblStatus = lblShade2Status
        Shades(2).lblStatus = lblShade3Status
        Shades(3).lblStatus = lblShade4Status
        Shades(4).lblStatus = lblShade5Status

        Shades(0).lblShadeLevel = lblShade1
        Shades(1).lblShadeLevel = lblShade2
        Shades(2).lblShadeLevel = lblShade3
        Shades(3).lblShadeLevel = lblShade4
        Shades(4).lblShadeLevel = lblShade5

        Shades(0).tbShadeLevel = tbShade1Level
        Shades(1).tbShadeLevel = tbShade2Level
        Shades(2).tbShadeLevel = Nothing
        Shades(3).tbShadeLevel = Nothing
        Shades(4).tbShadeLevel = Nothing

        Shades(0).gbShade = GroupBox1
        Shades(1).gbShade = GroupBox2
        Shades(2).gbShade = GroupBox3
        Shades(3).gbShade = GroupBox4
        Shades(4).gbShade = GroupBox5

        For i = 0 To iNUMSHADES - 1
            Shades(i).bAutoInitiatedMove = False
            Shades(i).bOverride = False
        Next i

        LoadParameters()

        If RomanConnect() <> 0 Then
            btnConnectRoman.BackColor = Color.Red
            For i = 0 To 1
                Shades(i).bEnabled = False
                Shades(i).lblStatus.Text = "x"
                LogEvent(i + 1, 902)  'Disabled
                tResetDisabledShades.Start()
            Next
        Else
            btnConnectRoman.BackColor = SystemColors.Control
            For i = 0 To 1
                Shades(i).bEnabled = True
                Shades(i).lblStatus.Text = "."
            Next
        End If

        If SomfyConnect() <> 0 Then
            btnConnectSomfy.BackColor = Color.Red
            For i = 2 To iNUMSHADES - 1
                Shades(i).bEnabled = False
                Shades(i).lblStatus.Text = "x"
                LogEvent(i + 1, 902)  'Disabled
                tResetDisabledShades.Start()
            Next
        Else
            btnConnectSomfy.BackColor = SystemColors.Control
            For i = 2 To iNUMSHADES - 1
                Shades(i).bEnabled = True
                Shades(i).lblStatus.Text = "."
            Next
        End If

        tabNewRequests = Blinds_ControlTableAdapter.GetData
        For i = 0 To tabNewRequests.Rows.Count - 1
            Shades(i).lblShadeLevel.Text = tabNewRequests.Rows(i).Item(2).ToString
            If tabNewRequests.Rows(i).Item(0) = 1 Then
                tbShade1Level.Value = 10 - (tabNewRequests.Rows(i).Item(2) / 10)
            End If

            If tabNewRequests.Rows(i).Item(0) = 2 Then
                tbShade2Level.Value = 10 - (tabNewRequests.Rows(i).Item(2) / 10)
            End If
        Next

        iOldDaylight = Event_Current_StateTableAdapter.GetOutsideLight()
        iOldHouseOccupied = Event_Current_StateTableAdapter.GetHouseOccupied()
        bTempRaise_BackDoor = False
        bTempRaise_FrontRoom = False
        bTempRaise_GreatRoom = False

        t3Min.Start()
        tCheckDB.Start()
        bStartup = False

    End Sub

    Private Sub frmBlindControl_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        Try
            'SaveParameters()
            Blinds_HistoryTableAdapter.InsertQuery("001")
            Event_HistoryTableAdapter.InsertQuery("9032")

            If btnConnectRoman.BackColor = SystemColors.Control Then
                RomanStreamReader.Close()
                RomanStreamReader.Dispose()
                RomanStreamWriter.Close()
                RomanStreamWriter.Dispose()
                SomfyStreamReader.Close()
                SomfyStreamReader.Dispose()
                SomfyStreamWriter.Close()
                SomfyStreamWriter.Dispose()
                ArduinoRoman.Close()
                ArduinoRoman = Nothing
                ArduinoSomfy.Close()
                ArduinoSomfy = Nothing
            End If
        Catch ex As Exception
            'do nothing
        End Try

    End Sub

#Region "Parameters"
    Private Sub SaveParameters()
        Dim FILE_NAME As String = "WDBlindControlParameter.xml"
        Dim objWriter As New System.IO.StreamWriter(FILE_NAME)
        Dim strParameter As String

        strParameter = "<Parameter>"
        strParameter = strParameter & "<Automation_Enable>"
        If ckbAutomationEnabled.Checked Then
            strParameter = strParameter & "True"
        Else
            strParameter = strParameter & "False"
        End If
        strParameter = strParameter & "</Automation_Enable>"
        strParameter = strParameter & "<Shade1>"
        strParameter = strParameter & "<Automation_Enable>"
        If ckbShade1EnableAutomation.Checked Then
            strParameter = strParameter & "True"
        Else
            strParameter = strParameter & "False"
        End If
        strParameter = strParameter & "</Automation_Enable>"
        strParameter = strParameter & "<Max_Temp>" & mtxtMaxTempBackDoor.Text & "</Max_Temp>"
        strParameter = strParameter & "</Shade1>"

        strParameter = strParameter & "<Shade2>"
        strParameter = strParameter & "<Automation_Enable>"
        If ckbShade2EnableAutomation.Checked Then
            strParameter = strParameter & "True"
        Else
            strParameter = strParameter & "False"
        End If
        strParameter = strParameter & "</Automation_Enable>"
        strParameter = strParameter & "<Max_Temp>" & mtxtMaxTempBackDoor.Text & "</Max_Temp>"
        strParameter = strParameter & "</Shade2>"

        strParameter = strParameter & "<Shade3>"
        strParameter = strParameter & "<Automation_Enable>"
        If ckbShade3EnableAutomation.Checked Then
            strParameter = strParameter & "True"
        Else
            strParameter = strParameter & "False"
        End If
        strParameter = strParameter & "</Automation_Enable>"
        strParameter = strParameter & "<Max_Temp>" & mtxtMaxTempFrontRoom.Text & "</Max_Temp>"
        strParameter = strParameter & "<XMasTree_Enable>"
        If ckbTree.Checked Then
            strParameter = strParameter & "True"
        Else
            strParameter = strParameter & "False"
        End If
        strParameter = strParameter & "</XMasTree_Enable>"
        strParameter = strParameter & "</Shade3>"

        strParameter = strParameter & "<Shade4>"
        strParameter = strParameter & "<Automation_Enable>"
        If ckbShade4EnableAutomation.Checked Then
            strParameter = strParameter & "True"
        Else
            strParameter = strParameter & "False"
        End If
        strParameter = strParameter & "</Automation_Enable>"
        strParameter = strParameter & "<Max_Temp>" & mtxtMaxTempGreatRoom.Text & "</Max_Temp>"
        strParameter = strParameter & "</Shade4>"

        strParameter = strParameter & "<Shade5>"
        strParameter = strParameter & "<Automation_Enable>"
        If ckbShade5EnableAutomation.Checked Then
            strParameter = strParameter & "True"
        Else
            strParameter = strParameter & "False"
        End If
        strParameter = strParameter & "</Automation_Enable>"
        strParameter = strParameter & "<Max_Temp>" & mtxtMaxTempDiningRoom.Text & "</Max_Temp>"
        strParameter = strParameter & "</Shade5>"
        strParameter = strParameter & "</Parameter>"

        objWriter.Write(strParameter)
        objWriter.Close()
    End Sub

    Private Sub LoadParameters()
        Dim xmlData As DataSet = New DataSet()

        'Load Parameters
        Try
            xmlData.ReadXml("WDBlindControlParameter.xml")
            If xmlData.Tables(0).Rows(0).ItemArray(0) = "True" Then    'Overall Automation Enable
                ckbAutomationEnabled.Checked = True
            Else
                ckbAutomationEnabled.Checked = False
            End If

            If xmlData.Tables(1).Rows(0).ItemArray(0) = "True" Then    'Shade 1 Automation Enable
                ckbShade1EnableAutomation.Checked = True
            Else
                ckbShade1EnableAutomation.Checked = False
            End If
            mtxtMaxTempBackDoor.Text = xmlData.Tables(1).Rows(0).ItemArray(1)   'Shade 1 & 2 Max Temp

            If xmlData.Tables(2).Rows(0).ItemArray(0) = "True" Then    'Shade 2 Automation Enable
                ckbShade2EnableAutomation.Checked = True
            Else
                ckbShade2EnableAutomation.Checked = False
            End If

            If xmlData.Tables(3).Rows(0).ItemArray(0) = "True" Then     'Shade 3 Automation Enable
                ckbShade3EnableAutomation.Checked = True
            Else
                ckbShade3EnableAutomation.Checked = False
            End If
            mtxtMaxTempFrontRoom.Text = xmlData.Tables(3).Rows(0).ItemArray(1)     'Shade 3 Max Temp
            If xmlData.Tables(3).Rows(0).ItemArray(2) = "True" Then     'Shade 3 XMas Tree Enable
                ckbTree.Checked = True
            Else
                ckbTree.Checked = False
            End If

            If xmlData.Tables(4).Rows(0).ItemArray(0) = "True" Then     'Shade 4 Automation Enable
                ckbShade4EnableAutomation.Checked = True
            Else
                ckbShade4EnableAutomation.Checked = False
            End If
            mtxtMaxTempGreatRoom.Text = xmlData.Tables(4).Rows(0).ItemArray(1)    'Shade 4 Max Temp

            If xmlData.Tables(5).Rows(0).ItemArray(0) = "True" Then     'Shade 5 Automation Enable
                ckbShade5EnableAutomation.Checked = True
            Else
                ckbShade5EnableAutomation.Checked = False
            End If
            mtxtMaxTempDiningRoom.Text = xmlData.Tables(5).Rows(0).ItemArray(1)   'Shade 5 Max Temp

        Catch ex As Exception
            ckbAutomationEnabled.Checked = False
            ckbShade1EnableAutomation.Checked = True
            mtxtMaxTempBackDoor.Text = 78
            ckbShade2EnableAutomation.Checked = True
            ckbShade3EnableAutomation.Checked = True
            mtxtMaxTempFrontRoom.Text = 78
            ckbTree.Checked = False
            ckbShade4EnableAutomation.Checked = True
            mtxtMaxTempGreatRoom.Text = 78
            ckbShade5EnableAutomation.Checked = True
            mtxtMaxTempDiningRoom.Text = 78
        End Try

    End Sub


#End Region

#Region "Handle Events"

    Private Sub LogEvent(iShade As Integer, iNewLevel As Integer)

        Select Case iNewLevel
            Case 0
                If iShade = 1 Then
                    Blinds_HistoryTableAdapter.InsertQuery("100")
                End If
                If iShade = 2 Then
                    Blinds_HistoryTableAdapter.InsertQuery("200")
                End If
                If iShade = 3 Then
                    Blinds_HistoryTableAdapter.InsertQuery("300")
                End If
                If iShade = 4 Then
                    Blinds_HistoryTableAdapter.InsertQuery("400")
                End If
                If iShade = 5 Then
                    Blinds_HistoryTableAdapter.InsertQuery("500")
                End If
            Case 10
                If iShade = 1 Then
                    Blinds_HistoryTableAdapter.InsertQuery("110")
                End If
                If iShade = 2 Then
                    Blinds_HistoryTableAdapter.InsertQuery("210")
                End If
            Case 20
                If iShade = 1 Then
                    Blinds_HistoryTableAdapter.InsertQuery("120")
                End If
                If iShade = 2 Then
                    Blinds_HistoryTableAdapter.InsertQuery("220")
                End If
            Case 30
                If iShade = 1 Then
                    Blinds_HistoryTableAdapter.InsertQuery("130")
                End If
                If iShade = 2 Then
                    Blinds_HistoryTableAdapter.InsertQuery("230")
                End If
            Case 40
                If iShade = 1 Then
                    Blinds_HistoryTableAdapter.InsertQuery("140")
                End If
                If iShade = 2 Then
                    Blinds_HistoryTableAdapter.InsertQuery("240")
                End If
            Case 50
                If iShade = 1 Then
                    Blinds_HistoryTableAdapter.InsertQuery("150")
                End If
                If iShade = 2 Then
                    Blinds_HistoryTableAdapter.InsertQuery("250")
                End If
                If iShade = 3 Then
                    Blinds_HistoryTableAdapter.InsertQuery("350")
                End If
                If iShade = 5 Then
                    Blinds_HistoryTableAdapter.InsertQuery("550")
                End If
            Case 60
                If iShade = 1 Then
                    Blinds_HistoryTableAdapter.InsertQuery("160")
                End If
                If iShade = 2 Then
                    Blinds_HistoryTableAdapter.InsertQuery("260")
                End If
            Case 70
                If iShade = 1 Then
                    Blinds_HistoryTableAdapter.InsertQuery("170")
                End If
                If iShade = 2 Then
                    Blinds_HistoryTableAdapter.InsertQuery("270")
                End If
            Case 80
                If iShade = 1 Then
                    Blinds_HistoryTableAdapter.InsertQuery("180")
                End If
                If iShade = 2 Then
                    Blinds_HistoryTableAdapter.InsertQuery("280")
                End If
            Case 90
                If iShade = 1 Then
                    Blinds_HistoryTableAdapter.InsertQuery("190")
                End If
                If iShade = 2 Then
                    Blinds_HistoryTableAdapter.InsertQuery("290")
                End If
            Case 100
                If iShade = 1 Then
                    Blinds_HistoryTableAdapter.InsertQuery("199")
                End If
                If iShade = 2 Then
                    Blinds_HistoryTableAdapter.InsertQuery("299")
                End If
                If iShade = 3 Then
                    Blinds_HistoryTableAdapter.InsertQuery("399")
                End If
                If iShade = 4 Then
                    Blinds_HistoryTableAdapter.InsertQuery("499")
                End If
                If iShade = 5 Then
                    Blinds_HistoryTableAdapter.InsertQuery("599")
                End If
            Case 901                                                'Enabled
                If iShade = 1 Then
                    Blinds_HistoryTableAdapter.InsertQuery("901")
                End If
                If iShade = 2 Then
                    Blinds_HistoryTableAdapter.InsertQuery("903")
                End If
                If iShade = 3 Then
                    Blinds_HistoryTableAdapter.InsertQuery("905")
                End If
                If iShade = 4 Then
                    Blinds_HistoryTableAdapter.InsertQuery("907")
                End If
                If iShade = 5 Then
                    Blinds_HistoryTableAdapter.InsertQuery("909")
                End If
            Case 902                                                'Disabled
                If iShade = 1 Then
                    Blinds_HistoryTableAdapter.InsertQuery("902")
                End If
                If iShade = 2 Then
                    Blinds_HistoryTableAdapter.InsertQuery("904")
                End If
                If iShade = 3 Then
                    Blinds_HistoryTableAdapter.InsertQuery("906")
                End If
                If iShade = 4 Then
                    Blinds_HistoryTableAdapter.InsertQuery("908")
                End If
                If iShade = 5 Then
                    Blinds_HistoryTableAdapter.InsertQuery("910")
                End If
        End Select
    End Sub

    Private Sub MoveSuccess(iShade As Integer, iNewVal As Integer)

        If Shades(iShade - 1).bEnabled = False Then
            LogEvent(iShade, 901)
        End If

        Shades(iShade - 1).iRetries = 0
        Shades(iShade - 1).bEnabled = True
        Shades(iShade - 1).lblStatus.Text = "."
        Shades(iShade - 1).lblShadeLevel.Text = iNewVal.ToString

        If iShade = 1 Or iShade = 2 Then
            Shades(iShade - 1).tbShadeLevel.Value = 10 - (iNewVal / 10)
        End If

        Blinds_ControlTableAdapter.Update_Current_State(iNewVal, iShade)
        Blinds_ControlTableAdapter.Reset_New_Requests(iShade)

        If Shades(iShade - 1).bAutoInitiatedMove = False Then
            Shades(iShade - 1).bOverride = True
            tOverrideReset.Start()
        End If
        If Shades(iShade - 1).bOverride Then
            Shades(iShade - 1).gbShade.BackColor = Color.Yellow
        Else
            Shades(iShade - 1).gbShade.BackColor = SystemColors.Control
        End If
        Shades(iShade - 1).bAutoInitiatedMove = False   'Reset

        LogEvent(iShade, iNewVal)
        btnConnectRoman.BackColor = SystemColors.Control
    End Sub

    Private Sub MoveError(iShade As Integer)

        Shades(iShade - 1).iRetries += 1
        If Shades(iShade - 1).iRetries >= 3 Then
            Shades(iShade - 1).bEnabled = False
            LogEvent(iShade, 902)
            tResetDisabledShades.Start()
            If iShade = 1 Or iShade = 2 Then
                RomanConnect()
            End If
            If iShade = 3 Then
                SomfyConnect()
            End If
        End If

        If Shades(iShade - 1).bEnabled Then
            Shades(iShade - 1).lblStatus.Text = "-"
        Else
            Shades(iShade - 1).lblStatus.Text = "x"
        End If

        Blinds_HistoryTableAdapter.InsertQuery("999")
    End Sub


#End Region

#Region "Buttons"
    Private Sub btnShade1Move_Click(sender As Object, e As EventArgs) Handles btnShade1Move.Click
        Blinds_ControlTableAdapter.Request_State_Change((10 - tbShade1Level.Value) * 10, 1)
        GroupBox1.BackColor = Color.LightSalmon

        Blinds_HistoryTableAdapter.InsertQuery("002")
    End Sub

    Private Sub btnShade2Move_Click(sender As Object, e As EventArgs) Handles btnShade2Move.Click
        Blinds_ControlTableAdapter.Request_State_Change((10 - tbShade2Level.Value) * 10, 2)
        GroupBox2.BackColor = Color.LightSalmon

        Blinds_HistoryTableAdapter.InsertQuery("002")
    End Sub

    Private Sub btnShade3FullyUp_Click(sender As Object, e As EventArgs) Handles btnShade3FullyUp.Click
        Blinds_ControlTableAdapter.Request_State_Change(0, 3)
        GroupBox3.BackColor = Color.LightSalmon

        Blinds_HistoryTableAdapter.InsertQuery("002")
    End Sub

    Private Sub btnShade3DownOpen_Click(sender As Object, e As EventArgs) Handles btnShade3DownOpen.Click
        Blinds_ControlTableAdapter.Request_State_Change(50, 3)
        GroupBox3.BackColor = Color.LightSalmon

        Blinds_HistoryTableAdapter.InsertQuery("002")
    End Sub

    Private Sub btnShade3DownClosed_Click(sender As Object, e As EventArgs) Handles btnShade3DownClosed.Click
        Blinds_ControlTableAdapter.Request_State_Change(100, 3)
        GroupBox3.BackColor = Color.LightSalmon

        Blinds_HistoryTableAdapter.InsertQuery("002")
    End Sub

    Private Sub btnShade4Open_Click(sender As Object, e As EventArgs) Handles btnShade4Open.Click
        Blinds_ControlTableAdapter.Request_State_Change(0, 4)
        GroupBox4.BackColor = Color.LightSalmon

        Blinds_HistoryTableAdapter.InsertQuery("002")
    End Sub

    Private Sub btnShade4Close_Click(sender As Object, e As EventArgs) Handles btnShade4Close.Click
        Blinds_ControlTableAdapter.Request_State_Change(100, 4)
        GroupBox4.BackColor = Color.LightSalmon

        Blinds_HistoryTableAdapter.InsertQuery("002")
    End Sub

    Private Sub btnShade5FullyUp_Click(sender As Object, e As EventArgs) Handles btnShade5FullyUp.Click
        Blinds_ControlTableAdapter.Request_State_Change(0, 5)
        GroupBox5.BackColor = Color.LightSalmon

        Blinds_HistoryTableAdapter.InsertQuery("002")
    End Sub

    Private Sub btnShade5DownOpen_Click(sender As Object, e As EventArgs) Handles btnShade5DownOpen.Click
        Blinds_ControlTableAdapter.Request_State_Change(50, 5)
        GroupBox5.BackColor = Color.LightSalmon

        Blinds_HistoryTableAdapter.InsertQuery("002")
    End Sub

    Private Sub btnShade5DownClosed_Click(sender As Object, e As EventArgs) Handles btnShade5DownClosed.Click
        Blinds_ControlTableAdapter.Request_State_Change(100, 5)
        GroupBox5.BackColor = Color.LightSalmon

        Blinds_HistoryTableAdapter.InsertQuery("002")
    End Sub

    Private Sub btnConnectRoman_Click(sender As Object, e As EventArgs) Handles btnConnectRoman.Click
        If RomanConnect() <> 0 Then
            btnConnectRoman.BackColor = Color.Red
        Else
            btnConnectRoman.BackColor = SystemColors.Control
        End If
    End Sub

    Private Sub btnConnectSomfy_Click(sender As Object, e As EventArgs) Handles btnConnectSomfy.Click
        If SomfyConnect() <> 0 Then
            btnConnectSomfy.BackColor = Color.Red
        Else
            btnConnectSomfy.BackColor = SystemColors.Control
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        'Raise shades to the top
        Blinds_ControlTableAdapter.Request_State_Change(0, 1)
        Blinds_ControlTableAdapter.Request_State_Change(0, 2)
        Blinds_ControlTableAdapter.Request_State_Change(0, 3)
        Blinds_ControlTableAdapter.Request_State_Change(0, 4)
        Blinds_ControlTableAdapter.Request_State_Change(0, 5)
    End Sub


    Private Sub ckbAutomationEnabled_CheckedChanged(sender As Object, e As EventArgs) Handles ckbAutomationEnabled.CheckedChanged
        If Not bStartup Then
            SaveParameters()
        End If
    End Sub

    Private Sub ckbShade1EnableAutomation_CheckedChanged(sender As Object, e As EventArgs) Handles ckbShade1EnableAutomation.CheckedChanged
        If Not bStartup Then
            SaveParameters()
        End If
    End Sub

    Private Sub ckbShade2EnableAutomation_CheckedChanged(sender As Object, e As EventArgs) Handles ckbShade2EnableAutomation.CheckedChanged
        If Not bStartup Then
            SaveParameters()
        End If
    End Sub

    Private Sub ckbShade3EnableAutomation_CheckedChanged(sender As Object, e As EventArgs) Handles ckbShade3EnableAutomation.CheckedChanged
        If Not bStartup Then
            SaveParameters()
        End If
    End Sub

    Private Sub ckbShade4EnableAutomation_CheckedChanged(sender As Object, e As EventArgs) Handles ckbShade4EnableAutomation.CheckedChanged
        If Not bStartup Then
            SaveParameters()
        End If
    End Sub

    Private Sub ckbShade5EnableAutomation_CheckedChanged(sender As Object, e As EventArgs) Handles ckbShade5EnableAutomation.CheckedChanged
        If Not bStartup Then
            SaveParameters()
        End If
    End Sub

#End Region

#Region "Shade Interface"

    Private Function RomanConnect() As Integer
        Try
            ArduinoRoman = Nothing
            RomanNetworkStream = Nothing
            RomanStreamReader = Nothing
            RomanStreamWriter = Nothing

            ArduinoRoman = New TcpClient
            ArduinoRoman.ReceiveTimeout = 3000
            ArduinoRoman.SendTimeout = 3000
            ArduinoRoman.Connect("192.168.1.191", 8888)
            RomanNetworkStream = ArduinoRoman.GetStream()
            RomanNetworkStream.ReadTimeout = 3000
            RomanNetworkStream.WriteTimeout = 3000

            RomanStreamWriter = New StreamWriter(RomanNetworkStream)
            RomanStreamReader = New StreamReader(RomanNetworkStream)
            RomanStreamWriter.Flush()
            'RomanStreamReader.ReadToEnd()
        Catch ex As Exception
            Return 1
        End Try

        Return 0
    End Function

    Private Function SomfyConnect() As Integer
        Try
            ArduinoSomfy = Nothing
            SomfyNetworkStream = Nothing
            SomfyStreamReader = Nothing
            SomfyStreamWriter = Nothing

            ArduinoSomfy = New TcpClient
            ArduinoSomfy.ReceiveTimeout = 1000
            ArduinoSomfy.SendTimeout = 1000
            ArduinoSomfy.Connect("192.168.1.190", 8888)
            SomfyNetworkStream = ArduinoSomfy.GetStream()
            SomfyNetworkStream.ReadTimeout = 1000
            SomfyNetworkStream.WriteTimeout = 1000

            SomfyStreamWriter = New StreamWriter(SomfyNetworkStream)
            SomfyStreamReader = New StreamReader(SomfyNetworkStream)
            SomfyStreamWriter.Flush()
            'SomfyStreamReader.ReadToEnd()
        Catch ex As Exception
            Return 1
        End Try

        Return 0
    End Function

    Private Function CheckRomanConnected() As Integer
        Dim bConnected As Boolean = False
        Dim i As Integer = 0

        While Not bConnected And i <= 3
            Dim strResult As String
            Try
                RomanStreamWriter.WriteLine("00" & Chr(13))   'Send garbage, no action taken
                RomanStreamWriter.Flush()
                strResult = RomanStreamReader.ReadLine()  'Read Echo
                Thread.Sleep(100)
                strResult = RomanStreamReader.ReadLine()  'Reach result
                bConnected = True
            Catch ex As Exception
                RomanConnect()
                i += 1
            End Try
        End While
        If Not bConnected And i >= 3 Then
            Return 1
        Else
            Return 0
        End If
    End Function

    Private Function CheckSomfyConnected() As Integer
        Dim bConnected As Boolean = False
        Dim i As Integer = 0

        While Not bConnected And i <= 3
            Dim strResult As String
            Try
                SomfyStreamWriter.WriteLine("??" & Chr(13))   'Send garbage, no action taken
                SomfyStreamWriter.Flush()
                strResult = SomfyStreamReader.ReadLine()  'Read Echo
                Thread.Sleep(100)
                strResult = SomfyStreamReader.ReadLine()  'Reach result
                bConnected = True
            Catch ex As Exception
                SomfyConnect()
                i += 1
            End Try
        End While
        If Not bConnected And i >= 3 Then
            Return 1
        Else
            Return 0
        End If
    End Function

    Private Function MoveSomfyShade(iShade As Integer, iRequestedLevel As Integer) As Integer
        Dim strCommand As String = ""
        Dim strResult As String = ""
        Dim bDone As Boolean
        Dim i As Integer
        Dim iSomfyResend As Integer

        If CheckSomfyConnected() = 0 And (Shades(iShade - 1).bAutoInitiatedMove = False Or Shades(iShade - 1).bOverride = False) Then
            If iRequestedLevel = 0 Then   'Fully Up
                strCommand = iShade.ToString & "2"
            End If
            If iRequestedLevel = 50 Then  'Fully Down, shade opened
                strCommand = iShade.ToString & "0"
            End If
            If iRequestedLevel = 100 Then 'Fully Down, shade closed
                strCommand = iShade.ToString & "1"
            End If

            If iShade = 4 Then    'Send multiple times for GreatRoom Blinds
                iSomfyResend = 3
            Else
                iSomfyResend = 1
            End If

            Try
                For j = 1 To iSomfyResend
                    SomfyStreamWriter.WriteLine(strCommand)                                  'Send command
                    SomfyStreamWriter.Flush()
                    bDone = False
                    i = 0

                    While Not bDone And i <= 3
                        strResult = SomfyStreamReader.ReadLine()
                        If strResult = strCommand Then
                            Thread.Sleep(250)
                            strResult = SomfyStreamReader.ReadLine()
                            If strResult = "0" Then
                                bDone = True
                            End If
                        Else
                            bDone = False
                            i += 1
                        End If
                    End While
                    Thread.Sleep(1000)
                Next j
            Catch ex As Exception
                bDone = False
            End Try

            If bDone Then
                lblLastMove.Text = Now.ToString
                Return 0
            Else
                Return 1
            End If
        Else
            Return 1
        End If
    End Function

    Private Function MoveRomanShade(iShade As Integer, iCurrentLevel As Integer, iRequestedLevel As Integer) As Integer
        Dim strCommand1, strCommand2 As String
        Dim iDelay As Integer = 0
        Dim strResult As String = ""
        Dim bDone As Boolean = False
        Dim i As Integer = 0

        If CheckRomanConnected() = 0 And (Shades(iShade - 1).bAutoInitiatedMove = False Or Shades(iShade - 1).bOverride = False) Then
            strCommand1 = iShade.ToString
            strCommand2 = iShade.ToString
            If iCurrentLevel < iRequestedLevel Then
                strCommand1 = strCommand1 & "0"  'Need to go down
                iDelay = (iRequestedLevel - iCurrentLevel)
                Select Case iShade
                    Case 1
                        iDelay = iDelay * iSHADE1DELAYDN
                    Case 2
                        iDelay = iDelay * iSHADE2DELAYDN
                End Select
                strCommand2 = strCommand2 & "1"
            ElseIf iCurrentLevel > iRequestedLevel Then
                strCommand1 = strCommand1 & "1"  'Need to go up
                iDelay = (iCurrentLevel - iRequestedLevel)
                Select Case iShade
                    Case 1
                        iDelay = iDelay * iSHADE1DELAYUP
                    Case 2
                        iDelay = iDelay * iSHADE2DELAYUP
                End Select
                strCommand2 = strCommand2 & "0"
            End If

            Try
                If iDelay > 0 Then
                    RomanStreamWriter.WriteLine(strCommand1)                                  'Send first pulse to start
                    RomanStreamWriter.Flush()

                    While Not bDone And i <= 3
                        strResult = RomanStreamReader.ReadLine()
                        If strResult = strCommand1 Then
                            Thread.Sleep(250)
                            strResult = RomanStreamReader.ReadLine()
                            If strResult = "0" Then
                                bDone = True
                            End If
                        Else
                            bDone = False
                            i += 1
                        End If
                    End While

                    If (iRequestedLevel <> 0) And (iRequestedLevel <> 100) Then
                        Thread.Sleep(iDelay)
                        RomanStreamWriter.WriteLine(strCommand2)                               'Send second pulse to stop
                        RomanStreamWriter.Flush()
                        bDone = False
                        While Not bDone And i <= 3
                            strResult = RomanStreamReader.ReadLine()
                            If strResult = strCommand2 Then
                                Thread.Sleep(250)
                                strResult = RomanStreamReader.ReadLine()
                                If strResult = "0" Then
                                    bDone = True
                                End If
                            Else
                                bDone = False
                                i += 1
                            End If
                        End While
                    End If

                    If bDone Then
                        lblLastMove.Text = Now.ToString
                        Return 0
                    Else
                        Return 1
                    End If
                Else
                    Return 0   'Already at level, no change required
                End If
            Catch ex As Exception
                Return 1
            End Try
        Else
            Return 1
        End If
    End Function


#End Region

#Region "Timers"
    Private Sub t3Min_Tick(sender As Object, e As EventArgs) Handles t3Min.Tick
        Dim iDaylight As Integer
        Dim iHouseOccupied As Integer

        t3Min.Interval = 180000

        If ckbAutomationEnabled.Checked Then
            '0 = daylight, 1 = night
            iDaylight = Event_Current_StateTableAdapter.GetOutsideLight()
            '1 = occupied, 0 = unoccupied
            iHouseOccupied = Event_Current_StateTableAdapter.GetHouseOccupied()

            If iHouseOccupied = 0 And iHouseOccupied <> iOldHouseOccupied And iDaylight = 0 And Hour(Now) >= 7 Then   'Unoccuped - close blinds
                If ckbShade1EnableAutomation.Checked Then
                    Blinds_ControlTableAdapter.Request_State_Change(100, 1)
                    Shades(0).bAutoInitiatedMove = True
                    Blinds_HistoryTableAdapter.InsertQuery("005")
                Else
                    Blinds_HistoryTableAdapter.InsertQuery("009")  'Change Request Ignored
                End If
                If ckbShade2EnableAutomation.Checked Then
                    Blinds_ControlTableAdapter.Request_State_Change(100, 2)
                    Shades(1).bAutoInitiatedMove = True
                    Blinds_HistoryTableAdapter.InsertQuery("005")
                Else
                    Blinds_HistoryTableAdapter.InsertQuery("009")  'Change Request Ignored
                End If
                If ckbShade3EnableAutomation.Checked Then
                    Blinds_ControlTableAdapter.Request_State_Change(100, 3)
                    Shades(2).bAutoInitiatedMove = True
                    Blinds_HistoryTableAdapter.InsertQuery("005")
                Else
                    Blinds_HistoryTableAdapter.InsertQuery("009")  'Change Request Ignored
                End If
                If ckbShade4EnableAutomation.Checked Then
                    Blinds_ControlTableAdapter.Request_State_Change(100, 4)
                    Shades(3).bAutoInitiatedMove = True
                    Blinds_HistoryTableAdapter.InsertQuery("005")
                Else
                    Blinds_HistoryTableAdapter.InsertQuery("009")  'Change Request Ignored
                End If
                If ckbShade5EnableAutomation.Checked Then
                    Blinds_ControlTableAdapter.Request_State_Change(100, 5)
                    Shades(4).bAutoInitiatedMove = True
                    Blinds_HistoryTableAdapter.InsertQuery("005")
                Else
                    Blinds_HistoryTableAdapter.InsertQuery("009")  'Change Request Ignored
                End If
                iOldHouseOccupied = iHouseOccupied
            End If

            If iHouseOccupied = 0 And iHouseOccupied <> iOldHouseOccupied Then  'left at night, update variable, but do not move blinds
                iOldHouseOccupied = iHouseOccupied
            End If

            If iHouseOccupied = 1 And iHouseOccupied <> iOldHouseOccupied And iDaylight = 0 And Hour(Now) >= 7 Then   'Occuped - open blinds
                If ckbShade1EnableAutomation.Checked Then
                    Blinds_ControlTableAdapter.Request_State_Change(0, 1)
                    Shades(0).bAutoInitiatedMove = True
                    Blinds_HistoryTableAdapter.InsertQuery("006")
                Else
                    Blinds_HistoryTableAdapter.InsertQuery("009")  'Change Request Ignored
                End If
                If ckbShade2EnableAutomation.Checked Then
                    Blinds_ControlTableAdapter.Request_State_Change(0, 2)
                    Shades(1).bAutoInitiatedMove = True
                    Blinds_HistoryTableAdapter.InsertQuery("006")
                Else
                    Blinds_HistoryTableAdapter.InsertQuery("009")  'Change Request Ignored
                End If
                If ckbShade3EnableAutomation.Checked Then
                    Blinds_ControlTableAdapter.Request_State_Change(50, 3)
                    Shades(2).bAutoInitiatedMove = True
                    Blinds_HistoryTableAdapter.InsertQuery("006")
                Else
                    Blinds_HistoryTableAdapter.InsertQuery("009")  'Change Request Ignored
                End If
                If ckbShade4EnableAutomation.Checked Then
                    Blinds_ControlTableAdapter.Request_State_Change(0, 4)
                    Shades(3).bAutoInitiatedMove = True
                    Blinds_HistoryTableAdapter.InsertQuery("006")
                Else
                    Blinds_HistoryTableAdapter.InsertQuery("009")  'Change Request Ignored
                End If
                If ckbShade5EnableAutomation.Checked Then
                    Blinds_ControlTableAdapter.Request_State_Change(50, 5)
                    Shades(4).bAutoInitiatedMove = True
                    Blinds_HistoryTableAdapter.InsertQuery("006")
                Else
                    Blinds_HistoryTableAdapter.InsertQuery("009")  'Change Request Ignored
                End If
                iOldHouseOccupied = iHouseOccupied
            End If

            If iHouseOccupied = 1 And iHouseOccupied <> iOldHouseOccupied Then 'arrived at night, update variable, but do not move blinds
                iOldHouseOccupied = iHouseOccupied
            End If

            If iHouseOccupied = 1 And iDaylight = 0 And iDaylight <> iOldDaylight And Hour(Now) >= 7 Then   'Morning - open blinds
                If ckbShade1EnableAutomation.Checked Then
                    Blinds_ControlTableAdapter.Request_State_Change(0, 1)
                    Shades(0).bAutoInitiatedMove = True
                    Blinds_HistoryTableAdapter.InsertQuery("003")
                Else
                    Blinds_HistoryTableAdapter.InsertQuery("009")  'Change Request Ignored
                End If
                If ckbShade2EnableAutomation.Checked Then
                    Blinds_ControlTableAdapter.Request_State_Change(0, 2)
                    Shades(1).bAutoInitiatedMove = True
                    Blinds_HistoryTableAdapter.InsertQuery("003")
                Else
                    Blinds_HistoryTableAdapter.InsertQuery("009")  'Change Request Ignored
                End If
                If ckbShade3EnableAutomation.Checked Then
                    Blinds_ControlTableAdapter.Request_State_Change(50, 3)
                    Shades(2).bAutoInitiatedMove = True
                    Blinds_HistoryTableAdapter.InsertQuery("003")
                Else
                    Blinds_HistoryTableAdapter.InsertQuery("009")  'Change Request Ignored
                End If
                If ckbShade4EnableAutomation.Checked Then
                    Blinds_ControlTableAdapter.Request_State_Change(0, 4)
                    Shades(3).bAutoInitiatedMove = True
                    Blinds_HistoryTableAdapter.InsertQuery("003")
                Else
                    Blinds_HistoryTableAdapter.InsertQuery("009")  'Change Request Ignored
                End If
                If ckbShade5EnableAutomation.Checked Then
                    Blinds_ControlTableAdapter.Request_State_Change(50, 5)
                    Shades(4).bAutoInitiatedMove = True
                    Blinds_HistoryTableAdapter.InsertQuery("003")
                Else
                    Blinds_HistoryTableAdapter.InsertQuery("009")  'Change Request Ignored
                End If
                iOldDaylight = iDaylight
            End If

            If iHouseOccupied = 1 And iDaylight = 1 And iDaylight <> iOldDaylight Then                       'Night - close blinds
                If ckbShade1EnableAutomation.Checked Then
                    Blinds_ControlTableAdapter.Request_State_Change(100, 1)
                    Shades(0).bAutoInitiatedMove = True
                    Blinds_HistoryTableAdapter.InsertQuery("004")
                Else
                    Blinds_HistoryTableAdapter.InsertQuery("009")  'Change Request Ignored
                End If
                If ckbShade2EnableAutomation.Checked Then
                    Blinds_ControlTableAdapter.Request_State_Change(100, 2)
                    Shades(1).bAutoInitiatedMove = True
                    Blinds_HistoryTableAdapter.InsertQuery("004")
                Else
                    Blinds_HistoryTableAdapter.InsertQuery("009")  'Change Request Ignored
                End If
                If ckbShade3EnableAutomation.Checked And Not ckbTree.Checked Then
                    Blinds_ControlTableAdapter.Request_State_Change(100, 3)  'Close shade
                    Shades(2).bAutoInitiatedMove = True
                    Blinds_HistoryTableAdapter.InsertQuery("004")
                ElseIf ckbShade3EnableAutomation.Checked And ckbTree.Checked Then
                    Blinds_ControlTableAdapter.Request_State_Change(0, 3)    'Open the shade to show the Christmas Tree
                    Shades(2).bAutoInitiatedMove = True
                    Blinds_HistoryTableAdapter.InsertQuery("004")
                Else
                    Blinds_HistoryTableAdapter.InsertQuery("009")  'Change Request Ignored
                End If
                If ckbShade4EnableAutomation.Checked Then
                    Blinds_ControlTableAdapter.Request_State_Change(100, 4)
                    Shades(3).bAutoInitiatedMove = True
                    Blinds_HistoryTableAdapter.InsertQuery("004")
                Else
                    Blinds_HistoryTableAdapter.InsertQuery("009")  'Change Request Ignored
                End If
                If ckbShade5EnableAutomation.Checked Then
                    Blinds_ControlTableAdapter.Request_State_Change(100, 5)
                    Shades(4).bAutoInitiatedMove = True
                    Blinds_HistoryTableAdapter.InsertQuery("004")
                Else
                    Blinds_HistoryTableAdapter.InsertQuery("009")  'Change Request Ignored
                End If
                iOldDaylight = iDaylight
            End If

            If ckbTree.Checked And Hour(Now) = 23 And Minute(Now) <= 3 Then
                Blinds_ControlTableAdapter.Request_State_Change(100, 3)  'Close shade when Christmas tree turns off
                Shades(2).bAutoInitiatedMove = True
                Blinds_HistoryTableAdapter.InsertQuery("008")
            End If
        Else
            Blinds_HistoryTableAdapter.InsertQuery("009")  'Change Request Ignored
        End If

    End Sub

    Private Sub t10Min_Tick(sender As Object, e As EventArgs) Handles t10Min.Tick
        Dim iDaylight As Integer
        Dim iKitchenTemp As Integer
        Dim iLivingRoomTemp As Integer
        Dim iGreatRoomTemp As Integer
        Dim iHouseOccupied As Integer

        t3Min.Interval = 180000

        If ckbAutomationEnabled.Checked Then
            '0 = daylight, 1 = night
            iDaylight = Event_Current_StateTableAdapter.GetOutsideLight()
            'Get Temp
            iKitchenTemp = Temp_Current_StateTableAdapter.GetKitchenTemp()
            iLivingRoomTemp = Temp_Current_StateTableAdapter.GetLivingRoomTemp()
            iGreatRoomTemp = Temp_Current_StateTableAdapter.GetGreatRoomTemp()
            '1 = occupied, 0 = unoccupied
            iHouseOccupied = Event_Current_StateTableAdapter.GetHouseOccupied()

            If iHouseOccupied = 1 And iDaylight = 0 And iKitchenTemp >= CInt(mtxtMaxTempBackDoor.Text) And Not bTempRaise_BackDoor Then        'Kitchen Too hot - set blinds to 50%
                If ckbShade1EnableAutomation.Checked Then
                    Blinds_ControlTableAdapter.Request_State_Change(50, 1)
                    Shades(1).bAutoInitiatedMove = True
                End If
                If ckbShade2EnableAutomation.Checked Then
                    Blinds_ControlTableAdapter.Request_State_Change(50, 2)
                    Shades(2).bAutoInitiatedMove = True
                End If
                Blinds_HistoryTableAdapter.InsertQuery("007")
                bTempRaise_BackDoor = True
            End If

            If iHouseOccupied = 1 And iDaylight = 0 And iKitchenTemp < CInt(mtxtMaxTempBackDoor.Text) And Hour(Now) >= 7 And bTempRaise_BackDoor Then        'Kitchen Cooled off - open blinds
                If ckbShade1EnableAutomation.Checked Then
                    Blinds_ControlTableAdapter.Request_State_Change(0, 1)
                    Shades(1).bAutoInitiatedMove = True
                End If
                If ckbShade2EnableAutomation.Checked Then
                    Blinds_ControlTableAdapter.Request_State_Change(0, 2)
                    Shades(2).bAutoInitiatedMove = True
                End If
                Blinds_HistoryTableAdapter.InsertQuery("007")
                bTempRaise_BackDoor = False
            End If

            If iHouseOccupied = 1 And iDaylight = 0 And iLivingRoomTemp >= CInt(mtxtMaxTempFrontRoom.Text) And Not bTempRaise_FrontRoom Then        'Living Room Too hot - set blinds to down shades closed
                If ckbShade3EnableAutomation.Checked Then
                    Blinds_ControlTableAdapter.Request_State_Change(100, 3)
                    Shades(3).bAutoInitiatedMove = True
                End If
                Blinds_HistoryTableAdapter.InsertQuery("007")
                bTempRaise_FrontRoom = True
            End If

            If iHouseOccupied = 1 And iDaylight = 0 And iLivingRoomTemp < CInt(mtxtMaxTempFrontRoom.Text) And Hour(Now) >= 7 And bTempRaise_FrontRoom Then        'Living Room Cooled off - set blinds to down shades open
                If ckbShade3EnableAutomation.Checked Then
                    Blinds_ControlTableAdapter.Request_State_Change(0, 3)
                    Shades(3).bAutoInitiatedMove = True
                End If
                Blinds_HistoryTableAdapter.InsertQuery("007")
                bTempRaise_FrontRoom = False
            End If

            If iHouseOccupied = 1 And iDaylight = 0 And iGreatRoomTemp >= CInt(mtxtMaxTempGreatRoom.Text) And Not bTempRaise_GreatRoom Then        'Great Room Too hot - set blinds to down shades closed
                If ckbShade4EnableAutomation.Checked Then
                    Blinds_ControlTableAdapter.Request_State_Change(100, 4)
                    Shades(4).bAutoInitiatedMove = True
                End If
                Blinds_HistoryTableAdapter.InsertQuery("007")
                bTempRaise_GreatRoom = True
            End If

            If iHouseOccupied = 1 And iDaylight = 0 And iGreatRoomTemp < CInt(mtxtMaxTempGreatRoom.Text) And Hour(Now) >= 7 And bTempRaise_GreatRoom Then        'Great Room Cooled off - set blinds to down shades open
                If ckbShade4EnableAutomation.Checked Then
                    Blinds_ControlTableAdapter.Request_State_Change(0, 4)
                    Shades(4).bAutoInitiatedMove = True
                End If
                Blinds_HistoryTableAdapter.InsertQuery("007")
                bTempRaise_GreatRoom = False
            End If
        End If

    End Sub

    Private Sub tCheckDB_Tick(sender As Object, e As EventArgs) Handles tCheckDB.Tick
        Dim tabNewRequests As WatchdogDataSet.Blinds_ControlDataTable
        Dim i As Integer

        'Runs once every 6 seconds

        lblLastUpdated.Text = Now.ToString
        Try
            tabNewRequests = Blinds_ControlTableAdapter.Get_New_Requests
            If tabNewRequests.Rows.Count > 0 Then
                For i = 0 To tabNewRequests.Rows.Count - 1
                    If Shades(tabNewRequests.Rows(i).Item(0) - 1).bEnabled Then
                        If Shades(tabNewRequests.Rows(i).Item(0) - 1).bAutoInitiatedMove = False Then
                            Shades(tabNewRequests.Rows(i).Item(0) - 1).gbShade.BackColor = Color.Yellow
                        End If
                        If tabNewRequests.Rows(i).Item(0) >= 3 And tabNewRequests.Rows(i).Item(0) <= 5 Then
                            If MoveSomfyShade(tabNewRequests.Rows(i).Item(0), tabNewRequests.Rows(i).Item(3)) = 0 Then
                                MoveSuccess(tabNewRequests.Rows(i).Item(0), tabNewRequests.Rows(i).Item(3))
                            Else
                                MoveError(tabNewRequests.Rows(i).Item(0))
                            End If
                        Else
                            If MoveRomanShade(tabNewRequests.Rows(i).Item(0), tabNewRequests.Rows(i).Item(2), tabNewRequests.Rows(i).Item(3)) = 0 Then
                                MoveSuccess(tabNewRequests.Rows(i).Item(0), tabNewRequests.Rows(i).Item(3))
                            Else
                                MoveError(tabNewRequests.Rows(i).Item(0))
                            End If
                        End If
                    End If
                Next i

            End If
        Catch ex As Exception

        End Try
        tabNewRequests = Nothing

    End Sub

    Private Sub tResetDisabledShades_Tick(sender As Object, e As EventArgs) Handles tResetDisabledShades.Tick
        'Runs once every 10 minutes

        For i = 0 To iNUMSHADES - 1
            Shades(i).bEnabled = True
            Shades(i).iRetries = 0
            Shades(i).lblStatus.Text = "-"
        Next

        tResetDisabledShades.Enabled = False
    End Sub

    Private Sub tOverrideReset_Tick(sender As Object, e As EventArgs) Handles tOverrideReset.Tick
        'Runs 2 hours after override triggered

        For i = 0 To iNUMSHADES - 1
            If Shades(i).bOverride Then
                Shades(i).bOverride = False
                Shades(i).gbShade.BackColor = SystemColors.Control
            End If
        Next
        tOverrideReset.Enabled = False
    End Sub

#End Region

#Region "Lost Focus"
    Private Sub mtxtMaxTempBackDoor_LostFocus(sender As Object, e As EventArgs) Handles mtxtMaxTempBackDoor.LostFocus
        If Not bStartup Then
            SaveParameters()
        End If
    End Sub

    Private Sub mtxtMaxTempFrontRoom_LostFocus(sender As Object, e As EventArgs) Handles mtxtMaxTempFrontRoom.LostFocus
        If Not bStartup Then
            SaveParameters()
        End If
    End Sub

    Private Sub mtxtMaxTempGreatRoom_LostFocus(sender As Object, e As EventArgs) Handles mtxtMaxTempGreatRoom.LostFocus
        If Not bStartup Then
            SaveParameters()
        End If
    End Sub

    Private Sub mtxtMaxTempDiningRoom_LostFocus(sender As Object, e As EventArgs) Handles mtxtMaxTempDiningRoom.LostFocus
        If Not bStartup Then
            SaveParameters()
        End If
    End Sub


    Private Sub ckbAutomationEnabled_LostFocus(sender As Object, e As EventArgs) Handles ckbAutomationEnabled.LostFocus
        If Not bStartup Then
            SaveParameters()
        End If
    End Sub

    Private Sub ckbShade1EnableAutomation_LostFocus(sender As Object, e As EventArgs) Handles ckbShade1EnableAutomation.LostFocus
        If Not bStartup Then
            SaveParameters()
        End If
    End Sub

    Private Sub ckbShade2EnableAutomation_LostFocus(sender As Object, e As EventArgs) Handles ckbShade2EnableAutomation.LostFocus
        If Not bStartup Then
            SaveParameters()
        End If
    End Sub

    Private Sub ckbShade3EnableAutomation_LostFocus(sender As Object, e As EventArgs) Handles ckbShade3EnableAutomation.LostFocus
        If Not bStartup Then
            SaveParameters()
        End If
    End Sub

    Private Sub ckbShade4EnableAutomation_LostFocus(sender As Object, e As EventArgs) Handles ckbShade4EnableAutomation.LostFocus
        If Not bStartup Then
            SaveParameters()
        End If
    End Sub

    Private Sub ckbShade5EnableAutomation_LostFocus(sender As Object, e As EventArgs) Handles ckbShade5EnableAutomation.LostFocus
        If Not bStartup Then
            SaveParameters()
        End If
    End Sub

    Private Sub ckbTree_LostFocus(sender As Object, e As EventArgs) Handles ckbTree.LostFocus
        If Not bStartup Then
            SaveParameters()
        End If
    End Sub

#End Region



End Class
