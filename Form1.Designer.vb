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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.tbShade2Level = New System.Windows.Forms.TrackBar()
        Me.lblShade2Status = New System.Windows.Forms.Label()
        Me.lblShade2 = New System.Windows.Forms.Label()
        Me.btnShade2Move = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tbShade1Level = New System.Windows.Forms.TrackBar()
        Me.lblShade1Status = New System.Windows.Forms.Label()
        Me.lblShade1 = New System.Windows.Forms.Label()
        Me.btnShade1Move = New System.Windows.Forms.Button()
        Me.lblLastMove = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbAutomationEnabled = New System.Windows.Forms.CheckBox()
        Me.lblLastUpdated = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        CType(Me.tbShade2Level, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.tbShade1Level, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.tbShade2Level)
        Me.GroupBox2.Controls.Add(Me.lblShade2Status)
        Me.GroupBox2.Controls.Add(Me.lblShade2)
        Me.GroupBox2.Controls.Add(Me.btnShade2Move)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(112, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(81, 181)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "2:  Back Door (S)"
        '
        'tbShade2Level
        '
        Me.tbShade2Level.Location = New System.Drawing.Point(17, 48)
        Me.tbShade2Level.Name = "tbShade2Level"
        Me.tbShade2Level.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.tbShade2Level.Size = New System.Drawing.Size(45, 107)
        Me.tbShade2Level.TabIndex = 15
        '
        'lblShade2Status
        '
        Me.lblShade2Status.AutoSize = True
        Me.lblShade2Status.Location = New System.Drawing.Point(44, 158)
        Me.lblShade2Status.Name = "lblShade2Status"
        Me.lblShade2Status.Size = New System.Drawing.Size(7, 9)
        Me.lblShade2Status.TabIndex = 14
        Me.lblShade2Status.Text = "."
        '
        'lblShade2
        '
        Me.lblShade2.AutoSize = True
        Me.lblShade2.Location = New System.Drawing.Point(14, 158)
        Me.lblShade2.Name = "lblShade2"
        Me.lblShade2.Size = New System.Drawing.Size(9, 9)
        Me.lblShade2.TabIndex = 13
        Me.lblShade2.Text = "0"
        '
        'btnShade2Move
        '
        Me.btnShade2Move.Location = New System.Drawing.Point(6, 19)
        Me.btnShade2Move.Name = "btnShade2Move"
        Me.btnShade2Move.Size = New System.Drawing.Size(44, 23)
        Me.btnShade2Move.TabIndex = 11
        Me.btnShade2Move.Text = "Move Shade"
        Me.btnShade2Move.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tbShade1Level)
        Me.GroupBox1.Controls.Add(Me.lblShade1Status)
        Me.GroupBox1.Controls.Add(Me.lblShade1)
        Me.GroupBox1.Controls.Add(Me.btnShade1Move)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(81, 181)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "1:  Back Door (N)"
        '
        'tbShade1Level
        '
        Me.tbShade1Level.Location = New System.Drawing.Point(12, 48)
        Me.tbShade1Level.Name = "tbShade1Level"
        Me.tbShade1Level.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.tbShade1Level.Size = New System.Drawing.Size(45, 107)
        Me.tbShade1Level.TabIndex = 7
        '
        'lblShade1Status
        '
        Me.lblShade1Status.AutoSize = True
        Me.lblShade1Status.Location = New System.Drawing.Point(38, 158)
        Me.lblShade1Status.Name = "lblShade1Status"
        Me.lblShade1Status.Size = New System.Drawing.Size(7, 9)
        Me.lblShade1Status.TabIndex = 6
        Me.lblShade1Status.Text = "."
        '
        'lblShade1
        '
        Me.lblShade1.AutoSize = True
        Me.lblShade1.Location = New System.Drawing.Point(9, 158)
        Me.lblShade1.Name = "lblShade1"
        Me.lblShade1.Size = New System.Drawing.Size(9, 9)
        Me.lblShade1.TabIndex = 5
        Me.lblShade1.Text = "0"
        '
        'btnShade1Move
        '
        Me.btnShade1Move.Location = New System.Drawing.Point(6, 19)
        Me.btnShade1Move.Name = "btnShade1Move"
        Me.btnShade1Move.Size = New System.Drawing.Size(44, 23)
        Me.btnShade1Move.TabIndex = 3
        Me.btnShade1Move.Text = "Move Shade"
        Me.btnShade1Move.UseVisualStyleBackColor = True
        '
        'lblLastMove
        '
        Me.lblLastMove.AutoSize = True
        Me.lblLastMove.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastMove.Location = New System.Drawing.Point(87, 243)
        Me.lblLastMove.Name = "lblLastMove"
        Me.lblLastMove.Size = New System.Drawing.Size(106, 13)
        Me.lblLastMove.TabIndex = 19
        Me.lblLastMove.Text = "12/31/2000 12:00:00"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 243)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Last Move:"
        '
        'cbAutomationEnabled
        '
        Me.cbAutomationEnabled.AutoSize = True
        Me.cbAutomationEnabled.Location = New System.Drawing.Point(12, 199)
        Me.cbAutomationEnabled.Name = "cbAutomationEnabled"
        Me.cbAutomationEnabled.Size = New System.Drawing.Size(121, 17)
        Me.cbAutomationEnabled.TabIndex = 17
        Me.cbAutomationEnabled.Text = "Automation Enabled"
        Me.cbAutomationEnabled.UseVisualStyleBackColor = True
        '
        'lblLastUpdated
        '
        Me.lblLastUpdated.AutoSize = True
        Me.lblLastUpdated.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastUpdated.Location = New System.Drawing.Point(87, 224)
        Me.lblLastUpdated.Name = "lblLastUpdated"
        Me.lblLastUpdated.Size = New System.Drawing.Size(106, 13)
        Me.lblLastUpdated.TabIndex = 16
        Me.lblLastUpdated.Text = "12/31/2000 12:00:00"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 224)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Last DB Check:"
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(24, 261)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 14
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnConnect
        '
        Me.btnConnect.Location = New System.Drawing.Point(105, 261)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(75, 23)
        Me.btnConnect.TabIndex = 13
        Me.btnConnect.Text = "Connect"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'frmBlindControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(205, 292)
        Me.Controls.Add(Me.lblLastMove)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbAutomationEnabled)
        Me.Controls.Add(Me.lblLastUpdated)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnConnect)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmBlindControl"
        Me.Text = "WD Blind Control"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.tbShade2Level, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.tbShade1Level, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents cbAutomationEnabled As System.Windows.Forms.CheckBox
    Friend WithEvents lblLastUpdated As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnConnect As System.Windows.Forms.Button

End Class
