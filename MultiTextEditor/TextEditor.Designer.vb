<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTextEditor
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
        Me.ttpInfo = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtMain = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtMain
        '
        Me.txtMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtMain.Location = New System.Drawing.Point(0, 0)
        Me.txtMain.Multiline = True
        Me.txtMain.Name = "txtMain"
        Me.txtMain.Size = New System.Drawing.Size(201, 305)
        Me.txtMain.TabIndex = 1
        Me.ttpInfo.SetToolTip(Me.txtMain, "type here")
        '
        'frmTextEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(201, 305)
        Me.Controls.Add(Me.txtMain)
        Me.Name = "frmTextEditor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New File"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ttpInfo As ToolTip
    Friend WithEvents txtMain As TextBox
End Class
