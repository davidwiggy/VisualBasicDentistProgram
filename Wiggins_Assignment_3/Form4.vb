'**********************************************************************************************************************************************
'Program     :  Wiggins_Assignment_3                                                                                                          *
'Programmer  :  Timothy Wiggins                                                                                                               *
'Purpose     :  This is form4. The user can select or type in any old customer number to get a report on all the information pertaining to    *
'Purpose     :  that customer. This form dynamically adds patient numbers to a list and the user can select any of these numbers. Once the    *
'Purpose     :  user is finish with the current customer information a clear button is used to clear the table and select another customer.   *
'**********************************************************************************************************************************************
Imports System.Xml

Public Class Form4

    Public fileName As String = "OLD_CUST.xml"
    Public flag As Boolean = False

    '*************************************************************************************************
    'Purpose     : To load a table on form creation with a list of the old customers.                *
    'Passed In   : sender, e                                                                         *
    'Returned    : Nothing                                                                           *
    '*************************************************************************************************
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim nodes As XmlNode
        Dim doc As New XmlDocument
        doc.Load(fileName)
        For Each nodes In doc.SelectNodes("Patients/Patient")
            Dim PatNumber As String = nodes.ChildNodes(0).InnerText
            Dim boolFound As Boolean = False
            For Each LvItem As ListViewItem In Me.lvPatientNumbers.Items
                If LvItem.SubItems(0).Text.Contains(PatNumber) Then
                    boolFound = True
                    Exit For
                End If
            Next
            If Not boolFound Then
                lvPatientNumbers.Items.Add(New ListViewItem(nodes.ChildNodes(0).InnerText.ToString))
            End If
        Next
    End Sub

    '****************************************************************************************************
    'Purpose     : To first check and make sure the table is empty, then all the information pertaining *
    'Purpose     : to the select customer is loaded into the table dynamically. The xml file is opened  *
    'Purpose     : and the information is pulled from the file and loaded into the table. Then the total*
    'Purpose     : amount owed is calculated and displayed.                                             *
    'Passed In   : sender, e                                                                            *
    'Returned    : Nothing                                                                              *
    '****************************************************************************************************
    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        Dim nodes As XmlNode
        Dim doc As New XmlDocument
        Dim counter As Integer = 0
        Dim totalAcc As Double = 0
        Dim recordFound As Boolean = False

        doc.Load(fileName)
        If flag = False Then
            flag = True
            For Each nodes In doc.SelectNodes("Patients/Patient")
                If txtPatNum.Text = nodes.ChildNodes(0).InnerText Then
                    recordFound = True
                    Dim boolFound As Boolean = False
                    For Each lvItem As ListViewItem In Me.lvPatRecords.Items
                        If lvItem.SubItems(0).Text.Contains(txtPatNum.Text) Then
                            boolFound = True
                        End If
                    Next
                    If boolFound = False And txtPatNum.Text = nodes.ChildNodes(0).InnerText Then
                        lvPatRecords.Items.Add(New ListViewItem({nodes.ChildNodes(0).InnerText, nodes.ChildNodes(1).InnerText,
                                                                 nodes.ChildNodes(2).InnerText, nodes.ChildNodes(3).InnerText,
                                                                 nodes.ChildNodes(4).InnerText}))
                        For i As Integer = 0 To procedureCode.Length - 1
                            If CInt(nodes.ChildNodes(4).InnerText) = procedureCode(i) Then
                                lvPatRecords.Items(counter).SubItems.Add(FormatCurrency(cost(i).ToString))
                                lvPatRecords.Items(counter).SubItems.Add(description(i).ToString)
                                totalAcc += cost(i)
                                counter += 1
                            End If
                        Next
                    End If
                    If boolFound = True Then
                        For i As Integer = 0 To procedureCode.Length - 1
                            If CInt(nodes.ChildNodes(4).InnerText) = procedureCode(i) And (nodes.ChildNodes(0).InnerText = txtPatNum.Text) Then
                                lvPatRecords.Items.Add(New ListViewItem({"", "", "", ""}))
                                lvPatRecords.Items(counter).SubItems.Add(nodes.ChildNodes(4).InnerText)
                                lvPatRecords.Items(counter).SubItems.Add(FormatCurrency(cost(i).ToString))
                                lvPatRecords.Items(counter).SubItems.Add(description(i).ToString)
                                totalAcc += cost(i)
                                counter += 1
                            End If
                        Next
                    End If
                End If
            Next
            If recordFound = True Then
                lvPatRecords.Items.Add(New ListViewItem({"", "", "", "", ""}))
                lvPatRecords.Items(counter).SubItems.Add("Total Costs")
                counter += 1
                lvPatRecords.Items.Add(New ListViewItem({"", "", "", "", ""}))
                lvPatRecords.Items(counter).SubItems.Add(FormatCurrency(totalAcc.ToString))
            Else
                MessageBox.Show("Patient Number Not Found.")
            End If
        Else
            MessageBox.Show("You must clear the table first.")
        End If 'End of flag condition

    End Sub

    '*************************************************************************************************
    'Purpose     : To validate the entered patient number.                                           *
    'Passed In   : sender, e                                                                         *
    'Returned    : Nothing                                                                           *
    '*************************************************************************************************
    Private Sub txtPatNum_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtPatNum.Validating
        If IsNumeric(txtPatNum.Text) Then
            If txtPatNum.Text.Length = 4 Then
                ErrorProvider1.Clear()
                e.Cancel = False
            Else
                e.Cancel = True
                ErrorProvider1.SetError(txtPatNum, "Must be a four digit Number.")
                MessageBox.Show("Patient number must be a four digit number.")
            End If
        Else
            e.Cancel = True
            ErrorProvider1.SetError(txtPatNum, "Must be a numeric number.")
            MessageBox.Show("You must enter a numeric number.")
        End If
    End Sub

    '*************************************************************************************************
    'Purpose     : To clear the loaded table.                                                        *
    'Passed In   : sender, e                                                                         *
    'Returned    : Nothing                                                                           *
    '*************************************************************************************************
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        For Each item In lvPatRecords.Items
            lvPatRecords.Items.Remove(CType(item, ListViewItem))
            flag = False
        Next
        txtPatNum.Text = Nothing
    End Sub

    '*************************************************************************************************
    'Purpose     : To hide this form and make form1 visible.                                         *
    'Passed In   : sender, e                                                                         *
    'Returned    : Nothing                                                                           *
    '*************************************************************************************************
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Form1.Visible = True
        Me.Visible = False
    End Sub

    '*************************************************************************************************
    'Purpose     : If a user selects the patient number form the list it is placed into the txtbox.  *
    'Passed In   : sender, e                                                                         *
    'Returned    : Nothing                                                                           *
    '*************************************************************************************************
    Private Sub lvPatientNumbers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvPatientNumbers.SelectedIndexChanged
        txtPatNum.Text = lvPatientNumbers.FocusedItem.SubItems(0).Text
    End Sub
End Class
