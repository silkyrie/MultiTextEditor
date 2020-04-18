' Luke Richards
' 100749790
' Units shipped average for lab 3 but this time it takes the results of three employees
' 2020/2/26
'
Option Strict On
Public Class frmAverageUnitsShipped
    ''Declarations
    Dim count As Integer = 0
    Dim input As Integer = 0
    Dim average As Double = 0
    Dim unitStats(2, 6) As Integer
    Dim outputBoxes(2, 1) As TextBox
    Dim employee As Integer = 0
    'Dim invisibleColor As Color
    Const DaysInAWeek As Integer = 7
    Private Sub averageUnitsShipped_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        outputBoxes(0, 0) = txtListBox1
        outputBoxes(1, 0) = txtListBox2
        outputBoxes(2, 0) = txtListBox3
        outputBoxes(0, 1) = txtOutput1
        outputBoxes(1, 1) = txtOutput2
        outputBoxes(2, 1) = txtOutput3
        'invisibleColor = lblError.ForeColor' ignore this requirements say otherwise but I like it so it stays
    End Sub
    '' when the user uses enter utton to add another number to the running total
    '' if the day 7 number gets entered it calculates average,displays,then disables input
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

        If (count < unitStats.Length And Int32.TryParse(txtInput.Text, input)) Then ''validation
            If (input >= 0 And input <= 5000) Then
                outputBoxes(employee, 0).Text = outputBoxes(employee, 0).Text + input.ToString() + Environment.NewLine
                unitStats(employee, count) = input
                count += 1
                txtInput.Text = ""
                If (count + 1 > DaysInAWeek) Then ''output/calculation begin if true
                    For i As Integer = 0 To DaysInAWeek - 1
                        average += unitStats(employee, i)
                    Next
                    average = Math.Round(average / DaysInAWeek, 2) ' average for employee
                    outputBoxes(employee, 1).Text = average.ToString()
                    employee += 1
                    count = 0 ' reset count if not being used again for a new employee will be used during the calculation of the total average
                    lblDay.Text = "day " + (count + 1).ToString()
                    average = 0
                    If (employee > 2) Then '' everything is filled out
                        btnEnter.Enabled = False
                        lblDay.Text = ""
                        txtInput.Enabled = False
                        average = average / unitStats.Length
                        For Each item As Integer In unitStats 'calculate total average
                            average += item
                            count += 1 ' for calculating average
                        Next
                        average = Math.Round(average / count, 2)
                        txtOutput4.Text = average.ToString()
                    End If
                Else
                    lblDay.Text = "day" + (count + 1).ToString() '' change the day if its not day 7
                End If
            Else ' error message for out of range
                MsgBox(input.ToString() + " is not between 0 and 5000")
            End If
        Else ' error message if not number
            'lblError.ForeColor = Color.Red ' ignore this requirements say otherwise but I like it so it stays
            MsgBox("Must be a valid integer")
        End If



    End Sub
    '' resets all controls and variables to default
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        reset()
    End Sub

    ' this sub resets everything
    Public Sub reset()
        count = 0
        input = 0
        average = 0
        lblDay.Text = "day 1"
        For i As Integer = 0 To 2 'I already had the arrays
            For ii As Integer = 0 To DaysInAWeek - 1
                unitStats(i, ii) = 0
            Next
            For ii As Integer = 0 To 1
                outputBoxes(i, ii).Text = ""
            Next
        Next
        txtOutput4.Text = ""
        txtInput.Text = ""
        btnEnter.Enabled = True
        txtInput.Enabled = True
        employee = 0
    End Sub
    '' ME CLOSE
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    ' this just makes the error message "disappear" 
    Private Sub txtInput_TextChanged(sender As Object, e As EventArgs) Handles txtInput.TextChanged
        'lblError.ForeColor = invisibleColor' ignore this requirements say otherwise but I like it so it stays

    End Sub


End Class
