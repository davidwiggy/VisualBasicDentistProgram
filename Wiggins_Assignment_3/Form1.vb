'**********************************************************************************************************************************************
'Program     :  Wiggins_Assignment_3                                                                                                          *
'Programmer  :  Timothy Wiggins                                                                                                               *
'Purpose     :  This is form1. This form allows for the selection of three different forms that all perform different actions. This program   *
'            :  acts as dental records. Thats loads an xml file and allows the user to select the patient number to find all patient records. *
'            :  It also calculates the number of old customers in the xml file and adds up the total amount of billing for procedured         *
'            :  by the dentist. It also allows the entry of a new customer in a new xml file that appends each new customer onto the new      *
'            :  customer file.                                                                                                                *
'OLD_CUST: Patient Numbers: 2345, 3345, 7899, 2234, 4677, 7889, 8899, 3456,                                                                   *
'**********************************************************************************************************************************************

Imports System.Xml

Public Class Form1

    Public Const ProcedurePath As String = "procedures.xml"

    '*************************************************************************************************
    'Purpose     : To make form 2 visible and hide form 1                                            *
    'Passed In   : sender, e                                                                         *
    'Returned    : Nothing.                                                                          *
    '*************************************************************************************************
    Private Sub btnForm2_Click(sender As Object, e As EventArgs) Handles btnForm2.Click
        Form2.Visible = True
        Me.Visible = False
    End Sub

    '*************************************************************************************************
    'Purpose     : This loads on the start of this program it pulls information from an xml file and *
    'Purpose     : puts it dynamically into an array.                                                *
    'Passed In   : sender, e                                                                         *
    'Returned    : Nothing.                                                                          *
    '*************************************************************************************************
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnForm2.Text = "Form &2" & Environment.NewLine & "Add New Patient"
        btnForm3.Text = "Form &3" & Environment.NewLine & "Get Old Customers report"
        btnForm4.Text = "Form &4" & Environment.NewLine & "Get Old Customers Billing Report"
        Dim settings As New XmlReaderSettings
        settings.IgnoreComments = True
        settings.IgnoreWhitespace = True
        Dim reader As XmlReader = XmlReader.Create(ProcedurePath, settings)

        If reader.ReadToDescendant("Procedure") Then
            Dim x As Integer = 0
            Do
                ReDim Preserve procedureCode(x)
                procedureCode(x) = CInt(reader.ReadElementString())

                ReDim Preserve description(x)
                description(x) = reader.ReadElementString()

                ReDim Preserve cost(x)
                cost(x) = CDbl(reader.ReadElementString())

                x += 1
            Loop While reader.ReadToNextSibling("Procedure")

        End If
    End Sub

    '*************************************************************************************************
    'Purpose     : Hides this form and makes form 3 visible                                          *
    'Passed In   : sender, e                                                                         *
    'Returned    : Nothing.                                                                          *
    '*************************************************************************************************
    Private Sub btnForm3_Click(sender As Object, e As EventArgs) Handles btnForm3.Click
        Form3.Visible = True
        Me.Visible = False
    End Sub

    '*************************************************************************************************
    'Purpose     : Kills the program                                                                 *
    'Passed In   : sender, e                                                                         *
    'Returned    : Nothing.                                                                          *
    '*************************************************************************************************
    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        Me.Dispose()
    End Sub

    '*************************************************************************************************
    'Purpose     : Hides this form and makes form 4 visible                                          *
    'Passed In   : sender, e                                                                         *
    'Returned    : Nothing.                                                                          *
    '*************************************************************************************************
    Private Sub btnForm4_Click(sender As Object, e As EventArgs) Handles btnForm4.Click
        Form4.Visible = True
        Me.Visible = False
    End Sub
End Class
