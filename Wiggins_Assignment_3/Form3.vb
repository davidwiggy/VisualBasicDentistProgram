'**********************************************************************************************************************************************
'Program     :  Wiggins_Assignment_3                                                                                                          *
'Programmer  :  Timothy Wiggins                                                                                                               *
'Purpose     :  This is form3 this form contains three buttons: report, clear, and back. The purpose of this form is to calculate the total   *
'Purpose     :  number of existing customers and then the total revenue for those customers.                                                  *
'**********************************************************************************************************************************************
Imports System.Xml

Public Class Form3

    '*************************************************************************************************
    'Purpose     : To calculate the total customers and revenue, then display it into labels.        *
    'Passed In   : sender, e                                                                         *
    'Returned    : Nothing                                                                           *
    '*************************************************************************************************
    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        Dim totalCustomers As Integer
        Dim totalCost As Double
        Dim fileName As String = "OLD_CUST.xml"
        Dim nodes As XmlNode
        Dim doc As New XmlDocument
        doc.Load(fileName)
        For Each nodes In doc.SelectNodes("Patients/Patient")
            totalCustomers = totalCustomers + 1
            Dim proCode As Integer = CInt(nodes.ChildNodes(4).InnerText)
            For i As Integer = 0 To procedureCode.Length - 1
                If proCode = procedureCode(i) Then
                    totalCost += cost(i)
                End If
            Next
        Next
        lblGrandTotal.Text = "The total cost of all the procedures is: " + FormatCurrency(totalCost.ToString)
        lblTotalCus.Text = "The total amount of old customers is: " + totalCustomers.ToString
    End Sub

    '*************************************************************************************************
    'Purpose     : To hide this form and make form 1 visible.                                        *
    'Passed In   : sender, e                                                                         *
    'Returned    : Nothing                                                                           *
    '*************************************************************************************************
    Private Sub btnBackForm3_Click(sender As Object, e As EventArgs) Handles btnBackForm3.Click
        Form1.Visible = True
        Me.Visible = False
    End Sub

    '*************************************************************************************************
    'Purpose     : To clear the labels that are used for total customers and total revenue.          *
    'Passed In   : sender, e                                                                         *
    'Returned    : Nothing                                                                           *
    '*************************************************************************************************
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblGrandTotal.Text = Nothing
        lblTotalCus.Text = Nothing
    End Sub
End Class