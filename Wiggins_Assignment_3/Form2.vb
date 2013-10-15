'**********************************************************************************************************************************************
'Program     :  Wiggins_Assignment_3                                                                                                          *
'Programmer  :  Timothy Wiggins                                                                                                               *
'Purpose     :  This is form2 this form allows the user to enter a new patient into an xml file called NEW_CUST.xml. The user enters the      *
'            :  patient name, first and last, patient number, gender and the procedure code that was proformed. All information is validated  *
'            :  as it is entered.                                                                                                             *
'**********************************************************************************************************************************************
Imports System.Xml

Public Class Form2

    Dim validPatNum As Boolean = False
    Dim validlast As Boolean = False
    Dim validfirst As Boolean = False
    Dim validGender As Boolean = False
    Dim indexNumforSelectedProcedureCodes As Integer = -1

    '*************************************************************************************************
    'Purpose     : To validated the patient number that is entered by the user.                      *
    'Passed In   : sender, e                                                                         *
    'Returned    : Nothing, however, the ncPatientNum variable is loaded from the entry.             *
    '*************************************************************************************************
    Private Sub txtPatientNum_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtPatientNum.Validating
        If IsNumeric(txtPatientNum.Text) Then
            If txtPatientNum.Text.Length = 4 Then
                ncPatientNum = CInt(txtPatientNum.Text)
                ErrorProvider1.Clear()
                e.Cancel = False
                validPatNum = True
            Else
                e.Cancel = True
                ErrorProvider1.SetError(txtPatientNum, "Must be a four digit Number.")
                MessageBox.Show("Patient number must be a four digit number.")
            End If
        Else
            e.Cancel = True
            ErrorProvider1.SetError(txtPatientNum, "Must be a numeric number.")
            MessageBox.Show("You must enter a numeric number.")
        End If
    End Sub

    '*************************************************************************************************
    'Purpose     : To validate the user entry for last name.                                         *
    'Passed In   : sender, e                                                                         *
    'Returned    : Nothing, however ncLastName is loaded.                                            *
    '*************************************************************************************************
    Private Sub txtLastName_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtLastName.Validating
        If txtLastName.Text.Length = 0 Then
            e.Cancel = True
            ErrorProvider1.SetError(txtLastName, "You must enter a name.")
            MessageBox.Show("You must enter a Last name.")
        Else
            ncLastName = txtLastName.Text
            validlast = True
            ErrorProvider1.Clear()
        End If
    End Sub

    '*************************************************************************************************
    'Purpose     : To validate user entry for first name.                                            *
    'Passed In   : sender, e                                                                         *
    'Returned    : Nothing, however ncFirstName is loaded.                                           *
    '*************************************************************************************************
    Private Sub txtFirstName_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtFirstName.Validating
        If txtFirstName.Text.Length = 0 Then
            e.Cancel = True
            ErrorProvider1.SetError(txtFirstName, "You must enter a name.")
            MessageBox.Show("You must enter a First Name.")
        Else
            ncFirstName = txtFirstName.Text
            ErrorProvider1.Clear()
            validfirst = True
        End If
    End Sub

    '*************************************************************************************************
    'Purpose     : This creates the list for the combo box from the procedure codes array.           *
    'Passed In   : sender, e                                                                         *
    'Returned    : Nothing.                                                                          *
    '*************************************************************************************************
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i As Integer = 0 To procedureCode.Length - 1
            cmbProcedureCodes.Items.Add(procedureCode(i))
        Next

    End Sub

    '*************************************************************************************************
    'Purpose     : This handles the a change event for the combo box.                                *
    'Passed In   : sender, e                                                                         *
    'Returned    : Nothing, However, it sets ncProCode and indexNumforSelectedProcedureCodes.        *
    '*************************************************************************************************
    Private Sub cmbProcedureCodes_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbProcedureCodes.SelectedValueChanged
        For i As Integer = 0 To procedureCode.Length - 1
            If cmbProcedureCodes.Text = CStr(procedureCode(i)) Then
                indexNumforSelectedProcedureCodes = i
                ncProCode = procedureCode(i)
            End If
        Next
        lblDescription.Text = "The selected procedure is: " + description(indexNumforSelectedProcedureCodes)
        lblCost.Text = "The cost is: " + FormatCurrency(cost(indexNumforSelectedProcedureCodes).ToString)
    End Sub

    '*************************************************************************************************
    'Purpose     : Checks that the form was filled out competely and then loads the data into a xml  *
    'Purpose     : file name NEW_CUST.xml.                                                           *
    'Passed In   : sender, e                                                                         *
    'Returned    : Nothing.                                                                          *
    '*************************************************************************************************
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If rbMale.Checked = True Then
            ncGender = "M"c
            validGender = True
        ElseIf rbFemale.Checked = True Then
            ncGender = "F"c
            validGender = True
        End If

        If validPatNum = True And validGender = True And validlast = True And validfirst = True And indexNumforSelectedProcedureCodes <> -1 Then
            ErrorProvider1.Clear()

            If Not IO.File.Exists("NEW_CUST.xml") Then

                Const path As String = "NEW_CUST.xml"
                Dim settings As New XmlWriterSettings
                settings.Indent = True
                settings.IndentChars = ("    ")

                Dim xmlOut As XmlWriter = XmlWriter.Create(path, settings)

                'Writing the start of the document
                xmlOut.WriteStartDocument()
                xmlOut.WriteStartElement("Customers")

                xmlOut.WriteStartElement("Customer")
                xmlOut.WriteElementString("PatientNumber", ncPatientNum.ToString)
                xmlOut.WriteElementString("Gender", ncGender.ToString)
                xmlOut.WriteElementString("LastName", ncLastName)
                xmlOut.WriteElementString("FirstName", ncFirstName)
                xmlOut.WriteElementString("ProcedureCode", ncProCode.ToString)

                xmlOut.WriteEndElement()
                xmlOut.Close()
                MessageBox.Show("Record wrote to new customer file.")
            Else
                Dim xmlDoc As New XmlDocument()
                xmlDoc.Load("NEW_CUST.xml")
                Dim root As XmlNode = xmlDoc.DocumentElement

                Dim elem As XmlElement = xmlDoc.CreateElement("Customer")
                Dim patNum As XmlElement = xmlDoc.CreateElement("PatientNumber")
                Dim gen As XmlElement = xmlDoc.CreateElement("Gender")
                Dim last As XmlElement = xmlDoc.CreateElement("LastName")
                Dim first As XmlElement = xmlDoc.CreateElement("FirstName")
                Dim pro As XmlElement = xmlDoc.CreateElement("ProcedureCode")

                patNum.InnerText = ncPatientNum.ToString
                gen.InnerText = ncGender
                last.InnerText = ncLastName
                first.InnerText = ncFirstName
                pro.InnerText = ncProCode.ToString

                root.AppendChild(elem)
                elem.AppendChild(patNum)
                elem.AppendChild(gen)
                elem.AppendChild(last)
                elem.AppendChild(first)
                elem.AppendChild(pro)

                xmlDoc.Save("NEW_CUST.xml")
                MessageBox.Show("Record wrote to EXISTING NEW_CUST file.")
            End If
        Else
            MessageBox.Show("You Must Fill out the form completely.")
            ErrorProvider1.SetError(btnSubmit, "You must fill out form completely.")
        End If
    End Sub

    '*************************************************************************************************
    'Purpose     : To make form 1 visible and hide form 2                                            *
    'Passed In   : sender, e                                                                         *
    'Returned    : Nothing.                                                                          *
    '*************************************************************************************************
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Form1.Visible = True
        Me.Visible = False
    End Sub

    '*************************************************************************************************
    'Purpose     : To clear all entered and selected data from the entry boxs.                       *
    'Passed In   : sender, e                                                                         *
    'Returned    : Nothing.                                                                          *
    '*************************************************************************************************
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        rbFemale.Checked = False
        rbMale.Checked = False
        cmbProcedureCodes.SelectedIndex = -1

        Dim ctrl As Control = Me.GetNextControl(Me, True)
        Do Until ctrl Is Nothing
            If TypeOf ctrl Is TextBox Then
                DirectCast(ctrl, TextBox).Clear()
            End If
            ctrl = Me.GetNextControl(ctrl, True)
        Loop

        lblDescription.Text = Nothing
        lblCost.Text = Nothing
        validPatNum = False
        validGender = False
        validlast = False
        validfirst = False
        indexNumforSelectedProcedureCodes = -1

        ncFirstName = Nothing
        ncGender = Nothing
        ncLastName = Nothing
        ncPatientNum = Nothing
        ncProCode = Nothing

    End Sub
End Class