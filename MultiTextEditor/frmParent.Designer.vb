<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmParent
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmParent))
        Me.ttpInfo = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileSaveAs = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditCut = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditPaste = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuWindows = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuWindowsCascade = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuWindowsVertical = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuWindowsHorizontal = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuWindowsCarList = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuWindowsShipped = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelpAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbCarList = New System.Windows.Forms.ToolStripButton()
        Me.tsbShipped = New System.Windows.Forms.ToolStripButton()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuEdit, Me.mnuWindows, Me.mnuHelp})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(506, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        Me.ttpInfo.SetToolTip(Me.MenuStrip1, "function menu")
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileNew, Me.mnuFileOpen, Me.mnuFileSave, Me.mnuFileSaveAs, Me.mnuFileExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "&File"
        '
        'mnuFileNew
        '
        Me.mnuFileNew.Name = "mnuFileNew"
        Me.mnuFileNew.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.mnuFileNew.Size = New System.Drawing.Size(146, 22)
        Me.mnuFileNew.Text = "&New"
        '
        'mnuFileOpen
        '
        Me.mnuFileOpen.Name = "mnuFileOpen"
        Me.mnuFileOpen.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.mnuFileOpen.Size = New System.Drawing.Size(146, 22)
        Me.mnuFileOpen.Text = "&Open"
        '
        'mnuFileSave
        '
        Me.mnuFileSave.Name = "mnuFileSave"
        Me.mnuFileSave.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.mnuFileSave.Size = New System.Drawing.Size(146, 22)
        Me.mnuFileSave.Text = "&Save"
        '
        'mnuFileSaveAs
        '
        Me.mnuFileSaveAs.Name = "mnuFileSaveAs"
        Me.mnuFileSaveAs.Size = New System.Drawing.Size(146, 22)
        Me.mnuFileSaveAs.Text = "Save &As"
        '
        'mnuFileExit
        '
        Me.mnuFileExit.Name = "mnuFileExit"
        Me.mnuFileExit.Size = New System.Drawing.Size(146, 22)
        Me.mnuFileExit.Text = "&Exit"
        '
        'mnuEdit
        '
        Me.mnuEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuEditCopy, Me.mnuEditCut, Me.mnuEditPaste})
        Me.mnuEdit.Name = "mnuEdit"
        Me.mnuEdit.Size = New System.Drawing.Size(39, 20)
        Me.mnuEdit.Text = "&Edit"
        '
        'mnuEditCopy
        '
        Me.mnuEditCopy.Name = "mnuEditCopy"
        Me.mnuEditCopy.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.mnuEditCopy.Size = New System.Drawing.Size(144, 22)
        Me.mnuEditCopy.Text = "&Copy"
        '
        'mnuEditCut
        '
        Me.mnuEditCut.Name = "mnuEditCut"
        Me.mnuEditCut.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.mnuEditCut.Size = New System.Drawing.Size(144, 22)
        Me.mnuEditCut.Text = "Cu&t"
        '
        'mnuEditPaste
        '
        Me.mnuEditPaste.Name = "mnuEditPaste"
        Me.mnuEditPaste.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.mnuEditPaste.Size = New System.Drawing.Size(144, 22)
        Me.mnuEditPaste.Text = "&Paste"
        '
        'mnuWindows
        '
        Me.mnuWindows.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuWindowsCascade, Me.mnuWindowsVertical, Me.mnuWindowsHorizontal, Me.ToolStripSeparator1, Me.mnuWindowsCarList, Me.mnuWindowsShipped})
        Me.mnuWindows.Name = "mnuWindows"
        Me.mnuWindows.Size = New System.Drawing.Size(68, 20)
        Me.mnuWindows.Text = "&Windows"
        '
        'mnuWindowsCascade
        '
        Me.mnuWindowsCascade.Name = "mnuWindowsCascade"
        Me.mnuWindowsCascade.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Q), System.Windows.Forms.Keys)
        Me.mnuWindowsCascade.Size = New System.Drawing.Size(221, 22)
        Me.mnuWindowsCascade.Text = "Cascade"
        '
        'mnuWindowsVertical
        '
        Me.mnuWindowsVertical.Name = "mnuWindowsVertical"
        Me.mnuWindowsVertical.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.mnuWindowsVertical.Size = New System.Drawing.Size(221, 22)
        Me.mnuWindowsVertical.Text = "Tile Vertical"
        Me.mnuWindowsVertical.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'mnuWindowsHorizontal
        '
        Me.mnuWindowsHorizontal.Name = "mnuWindowsHorizontal"
        Me.mnuWindowsHorizontal.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.mnuWindowsHorizontal.Size = New System.Drawing.Size(221, 22)
        Me.mnuWindowsHorizontal.Text = "Tile Horizontal"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(218, 6)
        '
        'mnuWindowsCarList
        '
        Me.mnuWindowsCarList.Name = "mnuWindowsCarList"
        Me.mnuWindowsCarList.Size = New System.Drawing.Size(221, 22)
        Me.mnuWindowsCarList.Text = "Open Car List"
        '
        'mnuWindowsShipped
        '
        Me.mnuWindowsShipped.Name = "mnuWindowsShipped"
        Me.mnuWindowsShipped.Size = New System.Drawing.Size(221, 22)
        Me.mnuWindowsShipped.Text = "Open average units shipped"
        '
        'mnuHelp
        '
        Me.mnuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuHelpAbout})
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.Size = New System.Drawing.Size(44, 20)
        Me.mnuHelp.Text = "&Help"
        '
        'mnuHelpAbout
        '
        Me.mnuHelpAbout.Name = "mnuHelpAbout"
        Me.mnuHelpAbout.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.mnuHelpAbout.Size = New System.Drawing.Size(126, 22)
        Me.mnuHelpAbout.Text = "&About"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbCarList, Me.tsbShipped})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New System.Drawing.Size(506, 31)
        Me.ToolStrip1.TabIndex = 3
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsbCarList
        '
        Me.tsbCarList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbCarList.Image = CType(resources.GetObject("tsbCarList.Image"), System.Drawing.Image)
        Me.tsbCarList.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbCarList.Name = "tsbCarList"
        Me.tsbCarList.Size = New System.Drawing.Size(23, 28)
        Me.tsbCarList.Text = "ToolStripButton1"
        '
        'tsbShipped
        '
        Me.tsbShipped.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbShipped.Image = CType(resources.GetObject("tsbShipped.Image"), System.Drawing.Image)
        Me.tsbShipped.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbShipped.Name = "tsbShipped"
        Me.tsbShipped.Size = New System.Drawing.Size(23, 28)
        Me.tsbShipped.Text = "ToolStripButton2"
        '
        'frmParent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(506, 450)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.Name = "frmParent"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ttpInfo As ToolTip
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuFileNew As ToolStripMenuItem
    Friend WithEvents mnuFileOpen As ToolStripMenuItem
    Friend WithEvents mnuFileSave As ToolStripMenuItem
    Friend WithEvents mnuFileSaveAs As ToolStripMenuItem
    Friend WithEvents mnuFileExit As ToolStripMenuItem
    Friend WithEvents mnuEdit As ToolStripMenuItem
    Friend WithEvents mnuEditCopy As ToolStripMenuItem
    Friend WithEvents mnuEditCut As ToolStripMenuItem
    Friend WithEvents mnuEditPaste As ToolStripMenuItem
    Friend WithEvents mnuHelp As ToolStripMenuItem
    Friend WithEvents mnuHelpAbout As ToolStripMenuItem
    Friend WithEvents mnuWindows As ToolStripMenuItem
    Friend WithEvents mnuWindowsCascade As ToolStripMenuItem
    Friend WithEvents mnuWindowsVertical As ToolStripMenuItem
    Friend WithEvents mnuWindowsHorizontal As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents mnuWindowsCarList As ToolStripMenuItem
    Friend WithEvents mnuWindowsShipped As ToolStripMenuItem
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents tsbCarList As ToolStripButton
    Friend WithEvents tsbShipped As ToolStripButton
End Class
