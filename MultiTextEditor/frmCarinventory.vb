'luke Richards
'100749790
'last modified: 24/3/2020
'a form thats stores/modifies an inventory of cars


Option Strict On

Public Class frmCarInventory
    Dim carList As New List(Of Car)
    ' adding stuff to the dropdownlist
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbMake.Items.Add("Ford")
        cmbMake.Items.Add("Hyundai")
        cmbMake.Items.Add("Volkswagen")
        cmbMake.Items.Add("Jeep")
        cmbMake.Items.Add("Dodge")
    End Sub

    'calls validate then enters new/edits list view item
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        If validateInput() Then
            If lbvCarList.SelectedIndices.Count > 0 Then
                carList(lbvCarList.SelectedIndices(0)) = New Car(chkNew.Checked, cmbMake.Text, txtModel.Text, Convert.ToInt32(nudYear.Value), Decimal.Parse(txtPrice.Text))
                lbvCarList.SelectedIndices.Clear()
            Else
                carList.Add(New Car(chkNew.Checked, cmbMake.Text, txtModel.Text, Convert.ToInt32(nudYear.Value), Decimal.Parse(txtPrice.Text)))
                lbvCarList.Items.Add(carList(carList.Count - 1).getListItem)
            End If
        End If
        populate()
    End Sub

    'calls the populate function reseting the code
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        populate()
    End Sub

    'clears entire form then repopulates the listview
    Private Sub populate()
        lbvCarList.Items.Clear()
        For i As Integer = 0 To carList.Count - 1
            lbvCarList.Items.Add(carList(i).getListItem)
        Next
        cmbMake.Text = ""
        txtModel.Text = ""
        nudYear.Value = 2020
        txtPrice.Text = ""
        chkNew.Checked = False
    End Sub

    ' checks if input is valid, throws errors if not then returns boolean
    Private Function validateInput() As Boolean
        Dim isValid As Boolean = True
        Dim converted As Decimal
        txtError.Text = ""
        If (cmbMake.Text = "") Then
            isValid = False
            txtError.Text = txtError.Text + "Must select a make " + Environment.NewLine
        End If
        If (txtModel.Text = "") Then
            isValid = False
            txtError.Text = txtError.Text + "Must state car's model" + Environment.NewLine
        End If
        If (txtModel.Text = "") Then
            isValid = False
            txtError.Text = txtError.Text + "Must enter a price for the car" + Environment.NewLine
        ElseIf Not Decimal.TryParse(txtModel.Text, converted) Then
            isValid = False
            txtError.Text = txtError.Text + "not a valid number" + Environment.NewLine
        ElseIf Not converted > 0 Then
            isValid = False
            txtError.Text = txtError.Text + "price must be greater than 0" + Environment.NewLine
        End If
        Return isValid
    End Function

    'ME CLOSE
    Private Sub btnExit_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    ' this is just some qol I thought Id add, it just throws the currently selected item in the form when it changes
    Private Sub lbvCarList_ItemSelectionChanged(sender As Object, e As ListViewItemSelectionChangedEventArgs) Handles lbvCarList.ItemSelectionChanged
        If lbvCarList.SelectedIndices.Count > 0 Then
            cmbMake.Text = carList(lbvCarList.SelectedIndices(0)).getMake
            txtModel.Text = carList(lbvCarList.SelectedIndices(0)).getModel
            nudYear.Value = carList(lbvCarList.SelectedIndices(0)).getYear
            txtPrice.Text = carList(lbvCarList.SelectedIndices(0)).getPrice.ToString()
            chkNew.Checked = carList(lbvCarList.SelectedIndices(0)).getIsNew
        Else
            cmbMake.Text = "Ford"
            txtModel.Text = "2"
            nudYear.Value = 2020
            txtPrice.Text = "2"
            chkNew.Checked = False
        End If
    End Sub

End Class
' Its a car, it has thing like a price and a model and stuff
Class Car
    Shared Count As Integer = 0
    Private newStatus As Boolean
    Private identificationNumber As Integer
    Private make As String
    Private model As String
    Private year As Integer
    Private price As Decimal

    Friend Sub New(isNew As Boolean, make As String, model As String, year As Integer, price As Decimal)
        Me.newStatus = isNew
        Me.identificationNumber = Car.Count
        Me.make = make
        Me.model = model
        Me.year = year
        Me.price = price
        Car.Count += 1
    End Sub

    Public Function getListItem() As ListViewItem
        Dim output As New ListViewItem()
        output.Checked = Me.newStatus
        output.SubItems.Add(Me.identificationNumber.ToString())
        output.SubItems.Add(Me.make)
        output.SubItems.Add(Me.model)
        output.SubItems.Add(Me.year.ToString())
        output.SubItems.Add(Me.price.ToString())
        Return output
    End Function
    Public Shared Sub clearCount()
        Car.Count = 0
    End Sub
    Public ReadOnly Property getMake As String
        Get
            Return make
        End Get
    End Property
    Public ReadOnly Property getModel As String
        Get
            Return model
        End Get
    End Property
    Public ReadOnly Property getYear As Integer
        Get
            Return year
        End Get
    End Property
    Public ReadOnly Property getPrice As Decimal
        Get
            Return price
        End Get
    End Property
    Public ReadOnly Property getIsNew As Boolean
        Get
            Return newStatus
        End Get
    End Property


End Class
