'Luke Richards
'NETD 2202
'2020/4/17
'MDI

Option Strict On

Public Class frmParent
    Dim childCount As Integer = 0
    ' makes a new file
    Private Sub mnuFileNew_Click(sender As Object, e As EventArgs) Handles mnuFileNew.Click
        Dim frmtextEditor As New frmTextEditor()
        childCount += 1
        frmtextEditor.MdiParent = Me
        frmtextEditor.Show()
    End Sub
    ' opens files
    Public Sub mnuFileOpen_Click(sender As Object, e As EventArgs) Handles mnuFileOpen.Click
        Dim child As frmTextEditor = DirectCast(ActiveMdiChild, frmTextEditor)
        If Not IsNothing(child) Then
            child.open()
        End If
    End Sub

    'calls the save function
    Public Sub mnuFileSave_Click(sender As Object, e As EventArgs) Handles mnuFileSave.Click
        Dim child As frmTextEditor = DirectCast(ActiveMdiChild, frmTextEditor)
        If Not IsNothing(child) Then
            child.save()
        End If
    End Sub
    ' calls the save as function
    Public Sub mnuFileSaveAs_Click(sender As Object, e As EventArgs) Handles mnuFileSaveAs.Click
        Dim child As frmTextEditor = DirectCast(ActiveMdiChild, frmTextEditor)
        If Not IsNothing(child) Then
            child.saveAs()
        End If
    End Sub
    ' closes program, see formclosing for prompt
    Public Sub mnuFileExit_Click(sender As Object, e As EventArgs) Handles mnuFileExit.Click
        Dim child As frmTextEditor = DirectCast(ActiveMdiChild, frmTextEditor)
        If Not IsNothing(child) Then
            child.Close()
        End If
    End Sub
    ' for heathens who dont use shortcuts for copying
    Public Sub mnuEditCopy_Click(sender As Object, e As EventArgs) Handles mnuEditCopy.Click
        Dim child As frmTextEditor = DirectCast(ActiveMdiChild, frmTextEditor)
        If Not IsNothing(child) Then
            If Not child.txtMain.SelectedText = "" Then
                Clipboard.SetText(child.txtMain.SelectedText)
            End If
        End If
    End Sub
    ' for heathens who dont use shortcuts for cutting
    Public Sub mnuEditCut_Click(sender As Object, e As EventArgs) Handles mnuEditCut.Click
        Dim child As frmTextEditor = DirectCast(ActiveMdiChild, frmTextEditor)
        If Not IsNothing(child) Then
            If Not child.txtMain.SelectedText = "" Then
                Clipboard.SetText(child.txtMain.SelectedText)
                child.txtMain.SelectedText = ""
            End If
        End If
    End Sub
    ' for heathens who dont use shortcuts for pasting
    Public Sub mnuEditPaste_Click(sender As Object, e As EventArgs) Handles mnuEditPaste.Click
        Dim child As frmTextEditor = DirectCast(ActiveMdiChild, frmTextEditor)
        If Not IsNothing(child) Then
            child.txtMain.SelectedText = Clipboard.GetText()
        End If
    End Sub
    ' help dialog
    Public Sub mnuHelpAbout_Click(sender As Object, e As EventArgs) Handles mnuHelpAbout.Click
        MsgBox("NetD 2202" +
               Environment.NewLine +
               Environment.NewLine +
               "Lab 5 " +
               Environment.NewLine +
               Environment.NewLine +
               "Luke Richards")
    End Sub
    'cascades forms
    Private Sub CascadeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuWindowsCascade.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub
    ' orders vertical
    Private Sub TileVerticalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuWindowsVertical.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub
    ' order horizontal
    Private Sub TileHorizontalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuWindowsHorizontal.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)

    End Sub

    Dim availableC As Boolean = True
    Dim availableS As Boolean = True
    ' makes a car list form
    Private Sub OpenCarListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuWindowsCarList.Click
        If availableC Then
            Dim carList As New frmCarInventory()
            carList.MdiParent = Me
            carList.Show()
        End If
    End Sub
    ' makes a average units shipped form
    Private Sub OpenAverageUnitsShippedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuWindowsShipped.Click
        If availableS Then
            Dim unitsShipped As New frmAverageUnitsShipped()
            unitsShipped.MdiParent = Me
            unitsShipped.Show()
        End If

    End Sub
    ' makes a average units shipped form
    Private Sub tsbShipped_Click(sender As Object, e As EventArgs) Handles tsbShipped.Click
        If availableS Then
            Dim unitsShipped As New frmAverageUnitsShipped()
            unitsShipped.MdiParent = Me
            unitsShipped.Show()
        End If
    End Sub
    ' makes a car list form
    Private Sub tsbCarList_Click(sender As Object, e As EventArgs) Handles tsbCarList.Click
        If availableC Then
            Dim carList As New frmCarInventory()
            carList.MdiParent = Me
            carList.Show()
        End If

    End Sub
End Class
