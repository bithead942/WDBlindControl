<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBlindControl
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBlindControl))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ckbShade2EnableAutomation = New System.Windows.Forms.CheckBox()
        Me.tbShade2Level = New System.Windows.Forms.TrackBar()
        Me.lblShade2Status = New System.Windows.Forms.Label()
        Me.lblShade2 = New System.Windows.Forms.Label()
        Me.btnShade2Move = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.mtxtMaxTempBackDoor = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ckbShade1EnableAutomation = New System.Windows.Forms.CheckBox()
        Me.tbShade1Level = New System.Windows.Forms.TrackBar()
        Me.lblShade1Status = New System.Windows.Forms.Label()
        Me.lblShade1 = New System.Windows.Forms.Label()
        Me.btnShade1Move = New System.Windows.Forms.Button()
        Me.lblLastMove = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ckbAutomationEnabled = New System.Windows.Forms.CheckBox()
        Me.lblLastUpdated = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnConnectRoman = New System.Windows.Forms.Button()
        Me.tCheckDB = New System.Windows.Forms.Timer(Me.components)
        Me.tResetDisabledShades = New System.Windows.Forms.Timer(Me.components)
        Me.t3Min = New System.Windows.Forms.Timer(Me.components)
        Me.Blinds_ControlDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Blinds_ControlBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WatchdogDataSet = New WDBlindControl.WatchdogDataSet()
        Me.Blinds_HistoryDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Blinds_HistoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Event_Current_StateDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn59 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Event_Current_StateBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Temp_Current_StateDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn64 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Temp_Current_StateBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Event_HistoryDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn65 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn66 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Event_HistoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.mtxtMaxTempFrontRoom = New System.Windows.Forms.MaskedTextBox()
        Me.ckbShade3EnableAutomation = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnShade3DownClosed = New System.Windows.Forms.Button()
        Me.btnShade3DownOpen = New System.Windows.Forms.Button()
        Me.lblShade3Status = New System.Windows.Forms.Label()
        Me.lblShade3 = New System.Windows.Forms.Label()
        Me.btnShade3FullyUp = New System.Windows.Forms.Button()
        Me.btnConnectSomfy = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.mtxtMaxTempGreatRoom = New System.Windows.Forms.MaskedTextBox()
        Me.ckbShade4EnableAutomation = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnShade4Close = New System.Windows.Forms.Button()
        Me.lblShade4Status = New System.Windows.Forms.Label()
        Me.lblShade4 = New System.Windows.Forms.Label()
        Me.btnShade4Open = New System.Windows.Forms.Button()
        Me.Blinds_ControlTableAdapter = New WDBlindControl.WatchdogDataSetTableAdapters.Blinds_ControlTableAdapter()
        Me.TableAdapterManager = New WDBlindControl.WatchdogDataSetTableAdapters.TableAdapterManager()
        Me.Blinds_HistoryTableAdapter = New WDBlindControl.WatchdogDataSetTableAdapters.Blinds_HistoryTableAdapter()
        Me.Event_Current_StateTableAdapter = New WDBlindControl.WatchdogDataSetTableAdapters.Event_Current_StateTableAdapter()
        Me.Temp_Current_StateTableAdapter = New WDBlindControl.WatchdogDataSetTableAdapters.Temp_Current_StateTableAdapter()
        Me.Event_HistoryTableAdapter = New WDBlindControl.WatchdogDataSetTableAdapters.Event_HistoryTableAdapter()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.mtxtMaxTempDiningRoom = New System.Windows.Forms.MaskedTextBox()
        Me.ckbShade5EnableAutomation = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnShade5DownClosed = New System.Windows.Forms.Button()
        Me.btnShade5DownOpen = New System.Windows.Forms.Button()
        Me.lblShade5Status = New System.Windows.Forms.Label()
        Me.lblShade5 = New System.Windows.Forms.Label()
        Me.btnShade5FullyUp = New System.Windows.Forms.Button()
        Me.t10Min = New System.Windows.Forms.Timer(Me.components)
        Me.tOverrideReset = New System.Windows.Forms.Timer(Me.components)
        Me.ckbTree = New System.Windows.Forms.CheckBox()
        Me.GroupBox2.SuspendLayout()
        CType(Me.tbShade2Level, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.tbShade1Level, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Blinds_ControlDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Blinds_ControlBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WatchdogDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Blinds_HistoryDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Blinds_HistoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Event_Current_StateDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Event_Current_StateBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Temp_Current_StateDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Temp_Current_StateBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Event_HistoryDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Event_HistoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ckbShade2EnableAutomation)
        Me.GroupBox2.Controls.Add(Me.tbShade2Level)
        Me.GroupBox2.Controls.Add(Me.lblShade2Status)
        Me.GroupBox2.Controls.Add(Me.lblShade2)
        Me.GroupBox2.Controls.Add(Me.btnShade2Move)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(95, 9)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(81, 172)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "2:  Back Door (S)"
        '
        'ckbShade2EnableAutomation
        '
        Me.ckbShade2EnableAutomation.AutoSize = True
        Me.ckbShade2EnableAutomation.Checked = True
        Me.ckbShade2EnableAutomation.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ckbShade2EnableAutomation.Location = New System.Drawing.Point(58, 153)
        Me.ckbShade2EnableAutomation.Name = "ckbShade2EnableAutomation"
        Me.ckbShade2EnableAutomation.Size = New System.Drawing.Size(15, 14)
        Me.ckbShade2EnableAutomation.TabIndex = 18
        Me.ckbShade2EnableAutomation.UseVisualStyleBackColor = True
        '
        'tbShade2Level
        '
        Me.tbShade2Level.Location = New System.Drawing.Point(19, 40)
        Me.tbShade2Level.Name = "tbShade2Level"
        Me.tbShade2Level.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.tbShade2Level.Size = New System.Drawing.Size(45, 90)
        Me.tbShade2Level.TabIndex = 15
        '
        'lblShade2Status
        '
        Me.lblShade2Status.AutoSize = True
        Me.lblShade2Status.Location = New System.Drawing.Point(41, 156)
        Me.lblShade2Status.Name = "lblShade2Status"
        Me.lblShade2Status.Size = New System.Drawing.Size(7, 9)
        Me.lblShade2Status.TabIndex = 14
        Me.lblShade2Status.Text = "."
        '
        'lblShade2
        '
        Me.lblShade2.AutoSize = True
        Me.lblShade2.Location = New System.Drawing.Point(14, 156)
        Me.lblShade2.Name = "lblShade2"
        Me.lblShade2.Size = New System.Drawing.Size(9, 9)
        Me.lblShade2.TabIndex = 13
        Me.lblShade2.Text = "0"
        '
        'btnShade2Move
        '
        Me.btnShade2Move.Location = New System.Drawing.Point(7, 19)
        Me.btnShade2Move.Name = "btnShade2Move"
        Me.btnShade2Move.Size = New System.Drawing.Size(65, 18)
        Me.btnShade2Move.TabIndex = 11
        Me.btnShade2Move.Text = "Move"
        Me.btnShade2Move.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.mtxtMaxTempBackDoor)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.ckbShade1EnableAutomation)
        Me.GroupBox1.Controls.Add(Me.tbShade1Level)
        Me.GroupBox1.Controls.Add(Me.lblShade1Status)
        Me.GroupBox1.Controls.Add(Me.lblShade1)
        Me.GroupBox1.Controls.Add(Me.btnShade1Move)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(8, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(81, 172)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "1:  Back Door (N)"
        '
        'mtxtMaxTempBackDoor
        '
        Me.mtxtMaxTempBackDoor.Location = New System.Drawing.Point(56, 130)
        Me.mtxtMaxTempBackDoor.Mask = "00"
        Me.mtxtMaxTempBackDoor.Name = "mtxtMaxTempBackDoor"
        Me.mtxtMaxTempBackDoor.Size = New System.Drawing.Size(20, 17)
        Me.mtxtMaxTempBackDoor.TabIndex = 29
        Me.mtxtMaxTempBackDoor.Text = "99"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 9)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Temp Max:"
        '
        'ckbShade1EnableAutomation
        '
        Me.ckbShade1EnableAutomation.AutoSize = True
        Me.ckbShade1EnableAutomation.Checked = True
        Me.ckbShade1EnableAutomation.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ckbShade1EnableAutomation.Location = New System.Drawing.Point(58, 153)
        Me.ckbShade1EnableAutomation.Name = "ckbShade1EnableAutomation"
        Me.ckbShade1EnableAutomation.Size = New System.Drawing.Size(15, 14)
        Me.ckbShade1EnableAutomation.TabIndex = 19
        Me.ckbShade1EnableAutomation.UseVisualStyleBackColor = True
        '
        'tbShade1Level
        '
        Me.tbShade1Level.Location = New System.Drawing.Point(17, 40)
        Me.tbShade1Level.Name = "tbShade1Level"
        Me.tbShade1Level.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.tbShade1Level.Size = New System.Drawing.Size(45, 90)
        Me.tbShade1Level.TabIndex = 7
        '
        'lblShade1Status
        '
        Me.lblShade1Status.AutoSize = True
        Me.lblShade1Status.Location = New System.Drawing.Point(38, 156)
        Me.lblShade1Status.Name = "lblShade1Status"
        Me.lblShade1Status.Size = New System.Drawing.Size(7, 9)
        Me.lblShade1Status.TabIndex = 6
        Me.lblShade1Status.Text = "."
        '
        'lblShade1
        '
        Me.lblShade1.AutoSize = True
        Me.lblShade1.Location = New System.Drawing.Point(12, 156)
        Me.lblShade1.Name = "lblShade1"
        Me.lblShade1.Size = New System.Drawing.Size(9, 9)
        Me.lblShade1.TabIndex = 5
        Me.lblShade1.Text = "0"
        '
        'btnShade1Move
        '
        Me.btnShade1Move.Location = New System.Drawing.Point(6, 19)
        Me.btnShade1Move.Name = "btnShade1Move"
        Me.btnShade1Move.Size = New System.Drawing.Size(69, 18)
        Me.btnShade1Move.TabIndex = 3
        Me.btnShade1Move.Text = "Move"
        Me.btnShade1Move.UseVisualStyleBackColor = True
        '
        'lblLastMove
        '
        Me.lblLastMove.AutoSize = True
        Me.lblLastMove.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastMove.Location = New System.Drawing.Point(247, 204)
        Me.lblLastMove.Name = "lblLastMove"
        Me.lblLastMove.Size = New System.Drawing.Size(71, 9)
        Me.lblLastMove.TabIndex = 19
        Me.lblLastMove.Text = "12/31/2000 12:00:00"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(169, 204)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 9)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Last Move:"
        '
        'ckbAutomationEnabled
        '
        Me.ckbAutomationEnabled.AutoSize = True
        Me.ckbAutomationEnabled.Checked = True
        Me.ckbAutomationEnabled.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ckbAutomationEnabled.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckbAutomationEnabled.Location = New System.Drawing.Point(12, 187)
        Me.ckbAutomationEnabled.Name = "ckbAutomationEnabled"
        Me.ckbAutomationEnabled.Size = New System.Drawing.Size(121, 17)
        Me.ckbAutomationEnabled.TabIndex = 17
        Me.ckbAutomationEnabled.Text = "Automation Enabled"
        Me.ckbAutomationEnabled.UseVisualStyleBackColor = True
        '
        'lblLastUpdated
        '
        Me.lblLastUpdated.AutoSize = True
        Me.lblLastUpdated.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastUpdated.Location = New System.Drawing.Point(247, 191)
        Me.lblLastUpdated.Name = "lblLastUpdated"
        Me.lblLastUpdated.Size = New System.Drawing.Size(71, 9)
        Me.lblLastUpdated.TabIndex = 16
        Me.lblLastUpdated.Text = "12/31/2000 12:00:00"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(169, 191)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 9)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Last DB Check:"
        '
        'btnReset
        '
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(18, 218)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 20)
        Me.btnReset.TabIndex = 14
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnConnectRoman
        '
        Me.btnConnectRoman.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConnectRoman.Location = New System.Drawing.Point(110, 218)
        Me.btnConnectRoman.Name = "btnConnectRoman"
        Me.btnConnectRoman.Size = New System.Drawing.Size(75, 20)
        Me.btnConnectRoman.TabIndex = 13
        Me.btnConnectRoman.Text = "Connect Roman"
        Me.btnConnectRoman.UseVisualStyleBackColor = True
        '
        'tCheckDB
        '
        Me.tCheckDB.Interval = 6000
        '
        'tResetDisabledShades
        '
        Me.tResetDisabledShades.Interval = 600000
        '
        't3Min
        '
        Me.t3Min.Interval = 5000
        '
        'Blinds_ControlDataGridView
        '
        Me.Blinds_ControlDataGridView.AutoGenerateColumns = False
        Me.Blinds_ControlDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Blinds_ControlDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.Blinds_ControlDataGridView.DataSource = Me.Blinds_ControlBindingSource
        Me.Blinds_ControlDataGridView.Location = New System.Drawing.Point(356, 187)
        Me.Blinds_ControlDataGridView.Name = "Blinds_ControlDataGridView"
        Me.Blinds_ControlDataGridView.Size = New System.Drawing.Size(10, 10)
        Me.Blinds_ControlDataGridView.TabIndex = 20
        Me.Blinds_ControlDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Blind_ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Blind_ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Blind_Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Blind_Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Blind_Current_State"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Blind_Current_State"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Blind_Request_State"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Blind_Request_State"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'Blinds_ControlBindingSource
        '
        Me.Blinds_ControlBindingSource.DataMember = "Blinds_Control"
        Me.Blinds_ControlBindingSource.DataSource = Me.WatchdogDataSet
        '
        'WatchdogDataSet
        '
        Me.WatchdogDataSet.DataSetName = "WatchdogDataSet"
        Me.WatchdogDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Blinds_HistoryDataGridView
        '
        Me.Blinds_HistoryDataGridView.AutoGenerateColumns = False
        Me.Blinds_HistoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Blinds_HistoryDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.Blinds_HistoryDataGridView.DataSource = Me.Blinds_HistoryBindingSource
        Me.Blinds_HistoryDataGridView.Location = New System.Drawing.Point(372, 187)
        Me.Blinds_HistoryDataGridView.Name = "Blinds_HistoryDataGridView"
        Me.Blinds_HistoryDataGridView.Size = New System.Drawing.Size(10, 10)
        Me.Blinds_HistoryDataGridView.TabIndex = 20
        Me.Blinds_HistoryDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Event_ID"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Event_ID"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Event_Timestamp"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Event_Timestamp"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'Blinds_HistoryBindingSource
        '
        Me.Blinds_HistoryBindingSource.DataMember = "Blinds_History"
        Me.Blinds_HistoryBindingSource.DataSource = Me.WatchdogDataSet
        '
        'Event_Current_StateDataGridView
        '
        Me.Event_Current_StateDataGridView.AutoGenerateColumns = False
        Me.Event_Current_StateDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Event_Current_StateDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn59})
        Me.Event_Current_StateDataGridView.DataSource = Me.Event_Current_StateBindingSource
        Me.Event_Current_StateDataGridView.Location = New System.Drawing.Point(388, 187)
        Me.Event_Current_StateDataGridView.Name = "Event_Current_StateDataGridView"
        Me.Event_Current_StateDataGridView.Size = New System.Drawing.Size(10, 10)
        Me.Event_Current_StateDataGridView.TabIndex = 20
        Me.Event_Current_StateDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Row_ID"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Row_ID"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn59
        '
        Me.DataGridViewTextBoxColumn59.DataPropertyName = "Stair_Lights"
        Me.DataGridViewTextBoxColumn59.HeaderText = "Stair_Lights"
        Me.DataGridViewTextBoxColumn59.Name = "DataGridViewTextBoxColumn59"
        '
        'Event_Current_StateBindingSource
        '
        Me.Event_Current_StateBindingSource.DataMember = "Event_Current_State"
        Me.Event_Current_StateBindingSource.DataSource = Me.WatchdogDataSet
        '
        'Temp_Current_StateDataGridView
        '
        Me.Temp_Current_StateDataGridView.AutoGenerateColumns = False
        Me.Temp_Current_StateDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Temp_Current_StateDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn64})
        Me.Temp_Current_StateDataGridView.DataSource = Me.Temp_Current_StateBindingSource
        Me.Temp_Current_StateDataGridView.Location = New System.Drawing.Point(404, 187)
        Me.Temp_Current_StateDataGridView.Name = "Temp_Current_StateDataGridView"
        Me.Temp_Current_StateDataGridView.Size = New System.Drawing.Size(10, 10)
        Me.Temp_Current_StateDataGridView.TabIndex = 20
        Me.Temp_Current_StateDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn64
        '
        Me.DataGridViewTextBoxColumn64.DataPropertyName = "Kitchen"
        Me.DataGridViewTextBoxColumn64.HeaderText = "Kitchen"
        Me.DataGridViewTextBoxColumn64.Name = "DataGridViewTextBoxColumn64"
        '
        'Temp_Current_StateBindingSource
        '
        Me.Temp_Current_StateBindingSource.DataMember = "Temp_Current_State"
        Me.Temp_Current_StateBindingSource.DataSource = Me.WatchdogDataSet
        '
        'Event_HistoryDataGridView
        '
        Me.Event_HistoryDataGridView.AutoGenerateColumns = False
        Me.Event_HistoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Event_HistoryDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn65, Me.DataGridViewTextBoxColumn66})
        Me.Event_HistoryDataGridView.DataSource = Me.Event_HistoryBindingSource
        Me.Event_HistoryDataGridView.Location = New System.Drawing.Point(421, 187)
        Me.Event_HistoryDataGridView.Name = "Event_HistoryDataGridView"
        Me.Event_HistoryDataGridView.Size = New System.Drawing.Size(10, 10)
        Me.Event_HistoryDataGridView.TabIndex = 20
        Me.Event_HistoryDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn65
        '
        Me.DataGridViewTextBoxColumn65.DataPropertyName = "Event_ID"
        Me.DataGridViewTextBoxColumn65.HeaderText = "Event_ID"
        Me.DataGridViewTextBoxColumn65.Name = "DataGridViewTextBoxColumn65"
        '
        'DataGridViewTextBoxColumn66
        '
        Me.DataGridViewTextBoxColumn66.DataPropertyName = "Event_Timestamp"
        Me.DataGridViewTextBoxColumn66.HeaderText = "Event_Timestamp"
        Me.DataGridViewTextBoxColumn66.Name = "DataGridViewTextBoxColumn66"
        '
        'Event_HistoryBindingSource
        '
        Me.Event_HistoryBindingSource.DataMember = "Event_History"
        Me.Event_HistoryBindingSource.DataSource = Me.WatchdogDataSet
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ckbTree)
        Me.GroupBox3.Controls.Add(Me.mtxtMaxTempFrontRoom)
        Me.GroupBox3.Controls.Add(Me.ckbShade3EnableAutomation)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.btnShade3DownClosed)
        Me.GroupBox3.Controls.Add(Me.btnShade3DownOpen)
        Me.GroupBox3.Controls.Add(Me.lblShade3Status)
        Me.GroupBox3.Controls.Add(Me.lblShade3)
        Me.GroupBox3.Controls.Add(Me.btnShade3FullyUp)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(182, 9)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(81, 172)
        Me.GroupBox3.TabIndex = 16
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "3:  Living Room"
        '
        'mtxtMaxTempFrontRoom
        '
        Me.mtxtMaxTempFrontRoom.Location = New System.Drawing.Point(55, 133)
        Me.mtxtMaxTempFrontRoom.Mask = "00"
        Me.mtxtMaxTempFrontRoom.Name = "mtxtMaxTempFrontRoom"
        Me.mtxtMaxTempFrontRoom.Size = New System.Drawing.Size(20, 17)
        Me.mtxtMaxTempFrontRoom.TabIndex = 28
        Me.mtxtMaxTempFrontRoom.Text = "99"
        '
        'ckbShade3EnableAutomation
        '
        Me.ckbShade3EnableAutomation.AutoSize = True
        Me.ckbShade3EnableAutomation.Checked = True
        Me.ckbShade3EnableAutomation.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ckbShade3EnableAutomation.Location = New System.Drawing.Point(55, 155)
        Me.ckbShade3EnableAutomation.Name = "ckbShade3EnableAutomation"
        Me.ckbShade3EnableAutomation.Size = New System.Drawing.Size(15, 14)
        Me.ckbShade3EnableAutomation.TabIndex = 17
        Me.ckbShade3EnableAutomation.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 9)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Temp Max:"
        '
        'btnShade3DownClosed
        '
        Me.btnShade3DownClosed.Location = New System.Drawing.Point(8, 83)
        Me.btnShade3DownClosed.Name = "btnShade3DownClosed"
        Me.btnShade3DownClosed.Size = New System.Drawing.Size(65, 26)
        Me.btnShade3DownClosed.TabIndex = 16
        Me.btnShade3DownClosed.Text = "Down Shades Closed"
        Me.btnShade3DownClosed.UseVisualStyleBackColor = True
        '
        'btnShade3DownOpen
        '
        Me.btnShade3DownOpen.Location = New System.Drawing.Point(8, 51)
        Me.btnShade3DownOpen.Name = "btnShade3DownOpen"
        Me.btnShade3DownOpen.Size = New System.Drawing.Size(65, 26)
        Me.btnShade3DownOpen.TabIndex = 15
        Me.btnShade3DownOpen.Text = "Down Shades Open"
        Me.btnShade3DownOpen.UseVisualStyleBackColor = True
        '
        'lblShade3Status
        '
        Me.lblShade3Status.AutoSize = True
        Me.lblShade3Status.Location = New System.Drawing.Point(38, 158)
        Me.lblShade3Status.Name = "lblShade3Status"
        Me.lblShade3Status.Size = New System.Drawing.Size(7, 9)
        Me.lblShade3Status.TabIndex = 14
        Me.lblShade3Status.Text = "."
        '
        'lblShade3
        '
        Me.lblShade3.AutoSize = True
        Me.lblShade3.Location = New System.Drawing.Point(11, 158)
        Me.lblShade3.Name = "lblShade3"
        Me.lblShade3.Size = New System.Drawing.Size(9, 9)
        Me.lblShade3.TabIndex = 13
        Me.lblShade3.Text = "0"
        '
        'btnShade3FullyUp
        '
        Me.btnShade3FullyUp.Location = New System.Drawing.Point(8, 19)
        Me.btnShade3FullyUp.Name = "btnShade3FullyUp"
        Me.btnShade3FullyUp.Size = New System.Drawing.Size(65, 26)
        Me.btnShade3FullyUp.TabIndex = 11
        Me.btnShade3FullyUp.Text = "Fully Up"
        Me.btnShade3FullyUp.UseVisualStyleBackColor = True
        '
        'btnConnectSomfy
        '
        Me.btnConnectSomfy.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConnectSomfy.Location = New System.Drawing.Point(201, 218)
        Me.btnConnectSomfy.Name = "btnConnectSomfy"
        Me.btnConnectSomfy.Size = New System.Drawing.Size(75, 20)
        Me.btnConnectSomfy.TabIndex = 21
        Me.btnConnectSomfy.Text = "Connect Somfy"
        Me.btnConnectSomfy.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.mtxtMaxTempGreatRoom)
        Me.GroupBox4.Controls.Add(Me.ckbShade4EnableAutomation)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.btnShade4Close)
        Me.GroupBox4.Controls.Add(Me.lblShade4Status)
        Me.GroupBox4.Controls.Add(Me.lblShade4)
        Me.GroupBox4.Controls.Add(Me.btnShade4Open)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(269, 9)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(81, 172)
        Me.GroupBox4.TabIndex = 18
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "4:  Great Room"
        '
        'mtxtMaxTempGreatRoom
        '
        Me.mtxtMaxTempGreatRoom.Location = New System.Drawing.Point(56, 134)
        Me.mtxtMaxTempGreatRoom.Mask = "00"
        Me.mtxtMaxTempGreatRoom.Name = "mtxtMaxTempGreatRoom"
        Me.mtxtMaxTempGreatRoom.Size = New System.Drawing.Size(20, 17)
        Me.mtxtMaxTempGreatRoom.TabIndex = 26
        Me.mtxtMaxTempGreatRoom.Text = "99"
        '
        'ckbShade4EnableAutomation
        '
        Me.ckbShade4EnableAutomation.AutoSize = True
        Me.ckbShade4EnableAutomation.Checked = True
        Me.ckbShade4EnableAutomation.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ckbShade4EnableAutomation.Location = New System.Drawing.Point(58, 153)
        Me.ckbShade4EnableAutomation.Name = "ckbShade4EnableAutomation"
        Me.ckbShade4EnableAutomation.Size = New System.Drawing.Size(15, 14)
        Me.ckbShade4EnableAutomation.TabIndex = 17
        Me.ckbShade4EnableAutomation.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 139)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 9)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Temp Max:"
        '
        'btnShade4Close
        '
        Me.btnShade4Close.Location = New System.Drawing.Point(6, 51)
        Me.btnShade4Close.Name = "btnShade4Close"
        Me.btnShade4Close.Size = New System.Drawing.Size(65, 26)
        Me.btnShade4Close.TabIndex = 16
        Me.btnShade4Close.Text = "Close Blinds"
        Me.btnShade4Close.UseVisualStyleBackColor = True
        '
        'lblShade4Status
        '
        Me.lblShade4Status.AutoSize = True
        Me.lblShade4Status.Location = New System.Drawing.Point(41, 156)
        Me.lblShade4Status.Name = "lblShade4Status"
        Me.lblShade4Status.Size = New System.Drawing.Size(7, 9)
        Me.lblShade4Status.TabIndex = 14
        Me.lblShade4Status.Text = "."
        '
        'lblShade4
        '
        Me.lblShade4.AutoSize = True
        Me.lblShade4.Location = New System.Drawing.Point(14, 156)
        Me.lblShade4.Name = "lblShade4"
        Me.lblShade4.Size = New System.Drawing.Size(9, 9)
        Me.lblShade4.TabIndex = 13
        Me.lblShade4.Text = "0"
        '
        'btnShade4Open
        '
        Me.btnShade4Open.Location = New System.Drawing.Point(8, 19)
        Me.btnShade4Open.Name = "btnShade4Open"
        Me.btnShade4Open.Size = New System.Drawing.Size(65, 26)
        Me.btnShade4Open.TabIndex = 11
        Me.btnShade4Open.Text = "Open Blinds"
        Me.btnShade4Open.UseVisualStyleBackColor = True
        '
        'Blinds_ControlTableAdapter
        '
        Me.Blinds_ControlTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Blinds_ControlTableAdapter = Me.Blinds_ControlTableAdapter
        Me.TableAdapterManager.Blinds_HistoryTableAdapter = Me.Blinds_HistoryTableAdapter
        Me.TableAdapterManager.Event_Current_StateTableAdapter = Me.Event_Current_StateTableAdapter
        Me.TableAdapterManager.Event_HistoryTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WDBlindControl.WatchdogDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Blinds_HistoryTableAdapter
        '
        Me.Blinds_HistoryTableAdapter.ClearBeforeFill = True
        '
        'Event_Current_StateTableAdapter
        '
        Me.Event_Current_StateTableAdapter.ClearBeforeFill = True
        '
        'Temp_Current_StateTableAdapter
        '
        Me.Temp_Current_StateTableAdapter.ClearBeforeFill = True
        '
        'Event_HistoryTableAdapter
        '
        Me.Event_HistoryTableAdapter.ClearBeforeFill = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.mtxtMaxTempDiningRoom)
        Me.GroupBox5.Controls.Add(Me.ckbShade5EnableAutomation)
        Me.GroupBox5.Controls.Add(Me.Label6)
        Me.GroupBox5.Controls.Add(Me.btnShade5DownClosed)
        Me.GroupBox5.Controls.Add(Me.btnShade5DownOpen)
        Me.GroupBox5.Controls.Add(Me.lblShade5Status)
        Me.GroupBox5.Controls.Add(Me.lblShade5)
        Me.GroupBox5.Controls.Add(Me.btnShade5FullyUp)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(356, 9)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(81, 172)
        Me.GroupBox5.TabIndex = 22
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "5:  Dining Room"
        '
        'mtxtMaxTempDiningRoom
        '
        Me.mtxtMaxTempDiningRoom.Location = New System.Drawing.Point(55, 131)
        Me.mtxtMaxTempDiningRoom.Mask = "00"
        Me.mtxtMaxTempDiningRoom.Name = "mtxtMaxTempDiningRoom"
        Me.mtxtMaxTempDiningRoom.Size = New System.Drawing.Size(20, 17)
        Me.mtxtMaxTempDiningRoom.TabIndex = 28
        Me.mtxtMaxTempDiningRoom.Text = "99"
        '
        'ckbShade5EnableAutomation
        '
        Me.ckbShade5EnableAutomation.AutoSize = True
        Me.ckbShade5EnableAutomation.Checked = True
        Me.ckbShade5EnableAutomation.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ckbShade5EnableAutomation.Location = New System.Drawing.Point(55, 153)
        Me.ckbShade5EnableAutomation.Name = "ckbShade5EnableAutomation"
        Me.ckbShade5EnableAutomation.Size = New System.Drawing.Size(15, 14)
        Me.ckbShade5EnableAutomation.TabIndex = 17
        Me.ckbShade5EnableAutomation.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 139)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 9)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Temp Max:"
        '
        'btnShade5DownClosed
        '
        Me.btnShade5DownClosed.Location = New System.Drawing.Point(8, 83)
        Me.btnShade5DownClosed.Name = "btnShade5DownClosed"
        Me.btnShade5DownClosed.Size = New System.Drawing.Size(65, 26)
        Me.btnShade5DownClosed.TabIndex = 16
        Me.btnShade5DownClosed.Text = "Down Shades Closed"
        Me.btnShade5DownClosed.UseVisualStyleBackColor = True
        '
        'btnShade5DownOpen
        '
        Me.btnShade5DownOpen.Location = New System.Drawing.Point(8, 51)
        Me.btnShade5DownOpen.Name = "btnShade5DownOpen"
        Me.btnShade5DownOpen.Size = New System.Drawing.Size(65, 26)
        Me.btnShade5DownOpen.TabIndex = 15
        Me.btnShade5DownOpen.Text = "Down Shades Open"
        Me.btnShade5DownOpen.UseVisualStyleBackColor = True
        '
        'lblShade5Status
        '
        Me.lblShade5Status.AutoSize = True
        Me.lblShade5Status.Location = New System.Drawing.Point(38, 156)
        Me.lblShade5Status.Name = "lblShade5Status"
        Me.lblShade5Status.Size = New System.Drawing.Size(7, 9)
        Me.lblShade5Status.TabIndex = 14
        Me.lblShade5Status.Text = "."
        '
        'lblShade5
        '
        Me.lblShade5.AutoSize = True
        Me.lblShade5.Location = New System.Drawing.Point(11, 156)
        Me.lblShade5.Name = "lblShade5"
        Me.lblShade5.Size = New System.Drawing.Size(9, 9)
        Me.lblShade5.TabIndex = 13
        Me.lblShade5.Text = "0"
        '
        'btnShade5FullyUp
        '
        Me.btnShade5FullyUp.Location = New System.Drawing.Point(8, 19)
        Me.btnShade5FullyUp.Name = "btnShade5FullyUp"
        Me.btnShade5FullyUp.Size = New System.Drawing.Size(65, 26)
        Me.btnShade5FullyUp.TabIndex = 11
        Me.btnShade5FullyUp.Text = "Fully Up"
        Me.btnShade5FullyUp.UseVisualStyleBackColor = True
        '
        't10Min
        '
        Me.t10Min.Interval = 600000
        '
        'tOverrideReset
        '
        Me.tOverrideReset.Interval = 7200000
        '
        'ckbTree
        '
        Me.ckbTree.AutoSize = True
        Me.ckbTree.Location = New System.Drawing.Point(8, 115)
        Me.ckbTree.Name = "ckbTree"
        Me.ckbTree.Size = New System.Drawing.Size(65, 14)
        Me.ckbTree.TabIndex = 29
        Me.ckbTree.Text = "X-mas Tree"
        Me.ckbTree.UseVisualStyleBackColor = True
        '
        'frmBlindControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(444, 245)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.btnConnectSomfy)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Event_HistoryDataGridView)
        Me.Controls.Add(Me.Temp_Current_StateDataGridView)
        Me.Controls.Add(Me.Event_Current_StateDataGridView)
        Me.Controls.Add(Me.Blinds_HistoryDataGridView)
        Me.Controls.Add(Me.Blinds_ControlDataGridView)
        Me.Controls.Add(Me.lblLastMove)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ckbAutomationEnabled)
        Me.Controls.Add(Me.lblLastUpdated)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnConnectRoman)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmBlindControl"
        Me.Text = "WDBlindControl"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.tbShade2Level, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.tbShade1Level, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Blinds_ControlDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Blinds_ControlBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WatchdogDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Blinds_HistoryDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Blinds_HistoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Event_Current_StateDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Event_Current_StateBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Temp_Current_StateDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Temp_Current_StateBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Event_HistoryDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Event_HistoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents tbShade2Level As System.Windows.Forms.TrackBar
    Friend WithEvents lblShade2Status As System.Windows.Forms.Label
    Friend WithEvents lblShade2 As System.Windows.Forms.Label
    Friend WithEvents btnShade2Move As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents tbShade1Level As System.Windows.Forms.TrackBar
    Friend WithEvents lblShade1Status As System.Windows.Forms.Label
    Friend WithEvents lblShade1 As System.Windows.Forms.Label
    Friend WithEvents btnShade1Move As System.Windows.Forms.Button
    Friend WithEvents lblLastMove As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ckbAutomationEnabled As System.Windows.Forms.CheckBox
    Friend WithEvents lblLastUpdated As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnConnectRoman As System.Windows.Forms.Button
    Friend WithEvents tCheckDB As System.Windows.Forms.Timer
    Friend WithEvents tResetDisabledShades As System.Windows.Forms.Timer
    Friend WithEvents t3Min As System.Windows.Forms.Timer
    Friend WithEvents WatchdogDataSet As WDBlindControl.WatchdogDataSet
    Friend WithEvents Blinds_ControlBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Blinds_ControlTableAdapter As WDBlindControl.WatchdogDataSetTableAdapters.Blinds_ControlTableAdapter
    Friend WithEvents TableAdapterManager As WDBlindControl.WatchdogDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Blinds_HistoryTableAdapter As WDBlindControl.WatchdogDataSetTableAdapters.Blinds_HistoryTableAdapter
    Friend WithEvents Blinds_ControlDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Blinds_HistoryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Event_Current_StateTableAdapter As WDBlindControl.WatchdogDataSetTableAdapters.Event_Current_StateTableAdapter
    Friend WithEvents Blinds_HistoryDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Event_Current_StateBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Event_Current_StateDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn28 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn29 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn30 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn31 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn32 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn33 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn34 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn35 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn36 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn37 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn38 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn39 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn40 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn41 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn42 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn43 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn44 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn45 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn46 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn47 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn48 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn49 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn50 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn51 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn52 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn53 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn54 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn55 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn56 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn57 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn58 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn59 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn60 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn61 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn62 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn63 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Temp_Current_StateBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Temp_Current_StateTableAdapter As WDBlindControl.WatchdogDataSetTableAdapters.Temp_Current_StateTableAdapter
    Friend WithEvents Temp_Current_StateDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn64 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Event_HistoryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Event_HistoryTableAdapter As WDBlindControl.WatchdogDataSetTableAdapters.Event_HistoryTableAdapter
    Friend WithEvents Event_HistoryDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn65 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn66 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnShade3DownClosed As System.Windows.Forms.Button
    Friend WithEvents btnShade3DownOpen As System.Windows.Forms.Button
    Friend WithEvents lblShade3Status As System.Windows.Forms.Label
    Friend WithEvents lblShade3 As System.Windows.Forms.Label
    Friend WithEvents btnShade3FullyUp As System.Windows.Forms.Button
    Friend WithEvents btnConnectSomfy As System.Windows.Forms.Button
    Friend WithEvents ckbShade2EnableAutomation As System.Windows.Forms.CheckBox
    Friend WithEvents ckbShade1EnableAutomation As System.Windows.Forms.CheckBox
    Friend WithEvents ckbShade3EnableAutomation As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents ckbShade4EnableAutomation As System.Windows.Forms.CheckBox
    Friend WithEvents btnShade4Close As System.Windows.Forms.Button
    Friend WithEvents lblShade4Status As System.Windows.Forms.Label
    Friend WithEvents lblShade4 As System.Windows.Forms.Label
    Friend WithEvents btnShade4Open As System.Windows.Forms.Button
    Friend WithEvents mtxtMaxTempBackDoor As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents mtxtMaxTempFrontRoom As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents mtxtMaxTempGreatRoom As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents mtxtMaxTempDiningRoom As System.Windows.Forms.MaskedTextBox
    Friend WithEvents ckbShade5EnableAutomation As System.Windows.Forms.CheckBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnShade5DownClosed As System.Windows.Forms.Button
    Friend WithEvents btnShade5DownOpen As System.Windows.Forms.Button
    Friend WithEvents lblShade5Status As System.Windows.Forms.Label
    Friend WithEvents lblShade5 As System.Windows.Forms.Label
    Friend WithEvents btnShade5FullyUp As System.Windows.Forms.Button
    Friend WithEvents t10Min As System.Windows.Forms.Timer
    Friend WithEvents tOverrideReset As System.Windows.Forms.Timer
    Friend WithEvents ckbTree As System.Windows.Forms.CheckBox

End Class
