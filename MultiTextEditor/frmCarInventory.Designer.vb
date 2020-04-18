<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCarInventory
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.cmbMake = New System.Windows.Forms.ComboBox()
        Me.txtModel = New System.Windows.Forms.TextBox()
        Me.nudYear = New System.Windows.Forms.NumericUpDown()
        Me.chkNew = New System.Windows.Forms.CheckBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbvCarList = New System.Windows.Forms.ListView()
        Me.chdNew = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chdID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chdMake = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chdModel = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chdyear = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chdprice = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.txtError = New System.Windows.Forms.TextBox()
        Me.ttpInfo = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.nudYear, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbMake
        '
        Me.cmbMake.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMake.FormattingEnabled = True
        Me.cmbMake.Location = New System.Drawing.Point(98, 31)
        Me.cmbMake.Name = "cmbMake"
        Me.cmbMake.Size = New System.Drawing.Size(121, 21)
        Me.cmbMake.TabIndex = 1
        Me.ttpInfo.SetToolTip(Me.cmbMake, "make of the car you are entering/editing")
        '
        'txtModel
        '
        Me.txtModel.Location = New System.Drawing.Point(98, 58)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.Size = New System.Drawing.Size(121, 20)
        Me.txtModel.TabIndex = 3
        Me.ttpInfo.SetToolTip(Me.txtModel, "model of the car you are entering/editing is")
        '
        'nudYear
        '
        Me.nudYear.Location = New System.Drawing.Point(98, 85)
        Me.nudYear.Maximum = New Decimal(New Integer() {2020, 0, 0, 0})
        Me.nudYear.Minimum = New Decimal(New Integer() {1920, 0, 0, 0})
        Me.nudYear.Name = "nudYear"
        Me.nudYear.Size = New System.Drawing.Size(120, 20)
        Me.nudYear.TabIndex = 5
        Me.ttpInfo.SetToolTip(Me.nudYear, "the year of the car you are entering/editing")
        Me.nudYear.Value = New Decimal(New Integer() {1920, 0, 0, 0})
        '
        'chkNew
        '
        Me.chkNew.AutoSize = True
        Me.chkNew.Location = New System.Drawing.Point(97, 137)
        Me.chkNew.Name = "chkNew"
        Me.chkNew.Size = New System.Drawing.Size(15, 14)
        Me.chkNew.TabIndex = 9
        Me.ttpInfo.SetToolTip(Me.chkNew, "whether the car you are entering/editing is new")
        Me.chkNew.UseVisualStyleBackColor = True
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(97, 111)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(121, 20)
        Me.txtPrice.TabIndex = 7
        Me.ttpInfo.SetToolTip(Me.txtPrice, "Price of the car you are entering/editing")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&make"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "m&odel"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "&year"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "&Price"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(27, 137)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(27, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "&new"
        '
        'lbvCarList
        '
        Me.lbvCarList.CheckBoxes = True
        Me.lbvCarList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chdNew, Me.chdID, Me.chdMake, Me.chdModel, Me.chdyear, Me.chdprice})
        Me.lbvCarList.FullRowSelect = True
        Me.lbvCarList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lbvCarList.HideSelection = False
        Me.lbvCarList.Location = New System.Drawing.Point(12, 157)
        Me.lbvCarList.MultiSelect = False
        Me.lbvCarList.Name = "lbvCarList"
        Me.lbvCarList.Size = New System.Drawing.Size(309, 159)
        Me.lbvCarList.TabIndex = 11
        Me.ttpInfo.SetToolTip(Me.lbvCarList, "displays current inventory")
        Me.lbvCarList.UseCompatibleStateImageBehavior = False
        Me.lbvCarList.View = System.Windows.Forms.View.Details
        '
        'chdNew
        '
        Me.chdNew.Text = "New"
        Me.chdNew.Width = 34
        '
        'chdID
        '
        Me.chdID.Text = "ID"
        Me.chdID.Width = 27
        '
        'chdMake
        '
        Me.chdMake.Text = "Make"
        Me.chdMake.Width = 52
        '
        'chdModel
        '
        Me.chdModel.Text = "Model"
        Me.chdModel.Width = 72
        '
        'chdyear
        '
        Me.chdyear.Text = "year"
        Me.chdyear.Width = 45
        '
        'chdprice
        '
        Me.chdprice.Text = "price"
        Me.chdprice.Width = 51
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(12, 414)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(75, 23)
        Me.btnEnter.TabIndex = 10
        Me.btnEnter.Text = "&enter"
        Me.ttpInfo.SetToolTip(Me.btnEnter, "enters the information specified into inventory")
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(98, 414)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 12
        Me.btnReset.Text = "&reset"
        Me.ttpInfo.SetToolTip(Me.btnReset, "Clears and resets the form")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'txtError
        '
        Me.txtError.Location = New System.Drawing.Point(12, 322)
        Me.txtError.Multiline = True
        Me.txtError.Name = "txtError"
        Me.txtError.ReadOnly = True
        Me.txtError.Size = New System.Drawing.Size(309, 86)
        Me.txtError.TabIndex = 14
        Me.ttpInfo.SetToolTip(Me.txtError, "box for error messages")
        '
        'frmCarInventory
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(333, 449)
        Me.Controls.Add(Me.txtError)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.lbvCarList)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.chkNew)
        Me.Controls.Add(Me.nudYear)
        Me.Controls.Add(Me.txtModel)
        Me.Controls.Add(Me.cmbMake)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCarInventory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Car inventory"
        CType(Me.nudYear, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbMake As ComboBox
    Friend WithEvents txtModel As TextBox
    Friend WithEvents nudYear As NumericUpDown
    Friend WithEvents chkNew As CheckBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lbvCarList As ListView
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents chdNew As ColumnHeader
    Friend WithEvents chdMake As ColumnHeader
    Friend WithEvents chdModel As ColumnHeader
    Friend WithEvents chdyear As ColumnHeader
    Friend WithEvents chdprice As ColumnHeader
    Friend WithEvents chdID As ColumnHeader
    Friend WithEvents txtError As TextBox
    Friend WithEvents ttpInfo As ToolTip
End Class
