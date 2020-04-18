<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAverageUnitsShipped
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
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.txtListBox1 = New System.Windows.Forms.TextBox()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblUnits = New System.Windows.Forms.Label()
        Me.lblDay = New System.Windows.Forms.Label()
        Me.ttpInfo = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtListBox2 = New System.Windows.Forms.TextBox()
        Me.txtListBox3 = New System.Windows.Forms.TextBox()
        Me.txtOutput1 = New System.Windows.Forms.TextBox()
        Me.txtOutput2 = New System.Windows.Forms.TextBox()
        Me.txtOutput3 = New System.Windows.Forms.TextBox()
        Me.txtOutput4 = New System.Windows.Forms.TextBox()
        Me.lblAverage = New System.Windows.Forms.Label()
        Me.lblTotalAverage = New System.Windows.Forms.Label()
        Me.lblEmployee1 = New System.Windows.Forms.Label()
        Me.lblEmployee2 = New System.Windows.Forms.Label()
        Me.lblEmployee3 = New System.Windows.Forms.Label()
        Me.lblError = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(174, 24)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(100, 20)
        Me.txtInput.TabIndex = 1
        Me.ttpInfo.SetToolTip(Me.txtInput, "units shipped input")
        '
        'txtListBox1
        '
        Me.txtListBox1.Location = New System.Drawing.Point(85, 116)
        Me.txtListBox1.Multiline = True
        Me.txtListBox1.Name = "txtListBox1"
        Me.txtListBox1.ReadOnly = True
        Me.txtListBox1.Size = New System.Drawing.Size(100, 161)
        Me.txtListBox1.TabIndex = 3
        Me.txtListBox1.TabStop = False
        Me.ttpInfo.SetToolTip(Me.txtListBox1, "entered values for employee 1")
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(85, 381)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(100, 50)
        Me.btnEnter.TabIndex = 14
        Me.btnEnter.Text = "&Enter"
        Me.ttpInfo.SetToolTip(Me.btnEnter, "add a new value")
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(215, 381)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(100, 50)
        Me.btnReset.TabIndex = 15
        Me.btnReset.Text = "&Reset"
        Me.ttpInfo.SetToolTip(Me.btnReset, "clear all values")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(347, 381)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 50)
        Me.btnExit.TabIndex = 16
        Me.btnExit.Text = "&Close"
        Me.ttpInfo.SetToolTip(Me.btnExit, "close the program")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblUnits
        '
        Me.lblUnits.AutoSize = True
        Me.lblUnits.Location = New System.Drawing.Point(110, 27)
        Me.lblUnits.Name = "lblUnits"
        Me.lblUnits.Size = New System.Drawing.Size(34, 13)
        Me.lblUnits.TabIndex = 0
        Me.lblUnits.Text = "&Units:"
        '
        'lblDay
        '
        Me.lblDay.AutoSize = True
        Me.lblDay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDay.Location = New System.Drawing.Point(343, 22)
        Me.lblDay.Name = "lblDay"
        Me.lblDay.Size = New System.Drawing.Size(47, 20)
        Me.lblDay.TabIndex = 17
        Me.lblDay.Text = "day 1"
        '
        'txtListBox2
        '
        Me.txtListBox2.Location = New System.Drawing.Point(215, 116)
        Me.txtListBox2.Multiline = True
        Me.txtListBox2.Name = "txtListBox2"
        Me.txtListBox2.ReadOnly = True
        Me.txtListBox2.Size = New System.Drawing.Size(100, 161)
        Me.txtListBox2.TabIndex = 6
        Me.txtListBox2.TabStop = False
        Me.ttpInfo.SetToolTip(Me.txtListBox2, "entered values for employee 2")
        '
        'txtListBox3
        '
        Me.txtListBox3.Location = New System.Drawing.Point(347, 116)
        Me.txtListBox3.Multiline = True
        Me.txtListBox3.Name = "txtListBox3"
        Me.txtListBox3.ReadOnly = True
        Me.txtListBox3.Size = New System.Drawing.Size(100, 161)
        Me.txtListBox3.TabIndex = 9
        Me.txtListBox3.TabStop = False
        Me.ttpInfo.SetToolTip(Me.txtListBox3, "entered values for employee 3")
        '
        'txtOutput1
        '
        Me.txtOutput1.Location = New System.Drawing.Point(85, 298)
        Me.txtOutput1.Multiline = True
        Me.txtOutput1.Name = "txtOutput1"
        Me.txtOutput1.ReadOnly = True
        Me.txtOutput1.Size = New System.Drawing.Size(100, 22)
        Me.txtOutput1.TabIndex = 4
        Me.txtOutput1.TabStop = False
        Me.txtOutput1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ttpInfo.SetToolTip(Me.txtOutput1, "Average for employee 1")
        '
        'txtOutput2
        '
        Me.txtOutput2.Location = New System.Drawing.Point(215, 298)
        Me.txtOutput2.Multiline = True
        Me.txtOutput2.Name = "txtOutput2"
        Me.txtOutput2.ReadOnly = True
        Me.txtOutput2.Size = New System.Drawing.Size(100, 22)
        Me.txtOutput2.TabIndex = 7
        Me.txtOutput2.TabStop = False
        Me.txtOutput2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ttpInfo.SetToolTip(Me.txtOutput2, "Average for employee 2")
        '
        'txtOutput3
        '
        Me.txtOutput3.Location = New System.Drawing.Point(347, 298)
        Me.txtOutput3.Multiline = True
        Me.txtOutput3.Name = "txtOutput3"
        Me.txtOutput3.ReadOnly = True
        Me.txtOutput3.Size = New System.Drawing.Size(100, 22)
        Me.txtOutput3.TabIndex = 10
        Me.txtOutput3.TabStop = False
        Me.txtOutput3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ttpInfo.SetToolTip(Me.txtOutput3, "Average for employee 3")
        '
        'txtOutput4
        '
        Me.txtOutput4.Location = New System.Drawing.Point(85, 338)
        Me.txtOutput4.Multiline = True
        Me.txtOutput4.Name = "txtOutput4"
        Me.txtOutput4.ReadOnly = True
        Me.txtOutput4.Size = New System.Drawing.Size(362, 22)
        Me.txtOutput4.TabIndex = 13
        Me.txtOutput4.TabStop = False
        Me.txtOutput4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ttpInfo.SetToolTip(Me.txtOutput4, "entered values")
        '
        'lblAverage
        '
        Me.lblAverage.AutoSize = True
        Me.lblAverage.Location = New System.Drawing.Point(32, 301)
        Me.lblAverage.Name = "lblAverage"
        Me.lblAverage.Size = New System.Drawing.Size(47, 13)
        Me.lblAverage.TabIndex = 11
        Me.lblAverage.Text = "Average"
        '
        'lblTotalAverage
        '
        Me.lblTotalAverage.AutoSize = True
        Me.lblTotalAverage.Location = New System.Drawing.Point(5, 341)
        Me.lblTotalAverage.Name = "lblTotalAverage"
        Me.lblTotalAverage.Size = New System.Drawing.Size(74, 13)
        Me.lblTotalAverage.TabIndex = 12
        Me.lblTotalAverage.Text = "Total Average"
        '
        'lblEmployee1
        '
        Me.lblEmployee1.AutoSize = True
        Me.lblEmployee1.Location = New System.Drawing.Point(82, 100)
        Me.lblEmployee1.Name = "lblEmployee1"
        Me.lblEmployee1.Size = New System.Drawing.Size(62, 13)
        Me.lblEmployee1.TabIndex = 2
        Me.lblEmployee1.Text = "Employee 1"
        '
        'lblEmployee2
        '
        Me.lblEmployee2.AutoSize = True
        Me.lblEmployee2.Location = New System.Drawing.Point(212, 100)
        Me.lblEmployee2.Name = "lblEmployee2"
        Me.lblEmployee2.Size = New System.Drawing.Size(62, 13)
        Me.lblEmployee2.TabIndex = 5
        Me.lblEmployee2.Text = "Employee 2"
        '
        'lblEmployee3
        '
        Me.lblEmployee3.AutoSize = True
        Me.lblEmployee3.Location = New System.Drawing.Point(344, 100)
        Me.lblEmployee3.Name = "lblEmployee3"
        Me.lblEmployee3.Size = New System.Drawing.Size(62, 13)
        Me.lblEmployee3.TabIndex = 8
        Me.lblEmployee3.Text = "Employee 3"
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblError.ForeColor = System.Drawing.SystemColors.Control
        Me.lblError.Location = New System.Drawing.Point(94, 66)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(326, 17)
        Me.lblError.TabIndex = 18
        Me.lblError.Text = "Must be a valid integer between 0 and 5000"
        '
        'frmAverageUnitsShipped
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(453, 468)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.lblEmployee3)
        Me.Controls.Add(Me.lblEmployee2)
        Me.Controls.Add(Me.lblEmployee1)
        Me.Controls.Add(Me.lblTotalAverage)
        Me.Controls.Add(Me.lblAverage)
        Me.Controls.Add(Me.txtOutput4)
        Me.Controls.Add(Me.txtOutput3)
        Me.Controls.Add(Me.txtOutput2)
        Me.Controls.Add(Me.txtOutput1)
        Me.Controls.Add(Me.txtListBox3)
        Me.Controls.Add(Me.txtListBox2)
        Me.Controls.Add(Me.lblDay)
        Me.Controls.Add(Me.lblUnits)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.txtListBox1)
        Me.Controls.Add(Me.txtInput)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAverageUnitsShipped"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Average Units Shipped"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtInput As TextBox
    Friend WithEvents txtListBox1 As TextBox
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblUnits As Label
    Friend WithEvents lblDay As Label
    Friend WithEvents ttpInfo As ToolTip
    Friend WithEvents txtListBox2 As TextBox
    Friend WithEvents txtListBox3 As TextBox
    Friend WithEvents txtOutput1 As TextBox
    Friend WithEvents txtOutput2 As TextBox
    Friend WithEvents txtOutput3 As TextBox
    Friend WithEvents txtOutput4 As TextBox
    Friend WithEvents lblAverage As Label
    Friend WithEvents lblTotalAverage As Label
    Friend WithEvents lblEmployee1 As Label
    Friend WithEvents lblEmployee2 As Label
    Friend WithEvents lblEmployee3 As Label
    Friend WithEvents lblError As Label
End Class
