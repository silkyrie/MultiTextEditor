'Luke richards
'NETD 2202
'2020/4/3
'text editor


Option Strict On
Imports System.IO

Public Class frmTextEditor
    Dim saved As Boolean = True 'for the confirm prompt
    Dim filePath As String = "" ' effectively what file we are editing
    ' this opens the dialog to get a filepath then calls the save function
    Public Sub saveAs()
        Dim accessedFile As SaveFileDialog = New SaveFileDialog
        accessedFile.Filter = "txt files|*.txt"
        If accessedFile.ShowDialog() = 1 Then
            filePath = accessedFile.FileName
            Me.Text = filePath
            save()
        End If
    End Sub
    ' writes the textbox contents to the file at specified location, creates the file if it does not exist
    Public Sub save()
        If filePath = "" Then
            saveAs()
        Else
            Dim openfile As FileStream = New FileStream(filePath, FileMode.Create, FileAccess.Write)
            Dim writer As StreamWriter = New StreamWriter(openfile)
            writer.Write(txtMain.Text)
            writer.Close()
            openfile.Close()
            saved = True
        End If
    End Sub

    Public Sub open()
        Dim reader As StreamReader
        Dim accessedFile As OpenFileDialog = New OpenFileDialog
        Dim openfile As FileStream
        accessedFile.Filter = "txt files|*.txt"
        If accessedFile.ShowDialog() = 1 Then
            filePath = accessedFile.FileName
            Me.Text = filePath
            openfile = New FileStream(filePath, FileMode.Open, FileAccess.Read)
            reader = New StreamReader(openfile)
            txtMain.Text = reader.ReadToEnd
            openfile.Close()
            saved = True
        End If
    End Sub
    ' calls save function if there unsaved work about to be lost
    Public Sub confirmClose()
        If Not saved Then
            If MsgBox("unsaved work would be lost. would you like to save?", vbYesNo) = vbYes Then
                save()
            End If
        End If
    End Sub
    ' opens and reads files into the textbox, also changes filepath variable
    ' for checking if the file has been saved
    Public Sub txtMain_TextChanged(sender As Object, e As EventArgs) Handles txtMain.TextChanged
        If saved Then
            Me.Text = Me.Text + "*"
        End If
        saved = False
    End Sub
    ' calls the confirm close when the form would close, even gets alt+f4
    Public Sub frmTextEditor_FormClosing_1(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        confirmClose()
    End Sub
End Class
