Imports System.Data.SqlClient

Public Class Patient
    Private connectingString As String = "Server = DESKTOP-S7LHQVM\WELLMEADOWSHOSP;Database=DBwellmeadow;Trusted_Connection=True;"
    Dim sqlConnection As New SqlConnection(connectingString)
    Private Sub Patient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Hospital.PatientReferral' table. You can move, or remove it, as needed.
        Me.PatientReferralTableAdapter.Fill(Me.Hospital.PatientReferral)
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        addPatient.Show()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Me.Close()
        Dim newForm As New Patient()
        newForm.Show()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        deletePatient.Show()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim IDsearch = TextBox1.Text

        Dim sql = "SELECT TOP 1 * FROM PatientReferral WHERE PRF_ID = '" & IDsearch & "' "
        Dim cmd = SqlConnection.CreateCommand

        cmd.CommandText = sql
        SqlConnection.Open()
        Dim sqlreader = cmd.ExecuteReader()

        Do While sqlreader.Read()
            PRF_IDTextBox.Text = sqlreader.Item("PRF_ID")
            P_IDTextBox.Text = sqlreader.Item("P_ID")
            P_FNameTextBox.Text = sqlreader.Item("P_FName")
            P_LNameTextBox.Text = sqlreader.Item("P_LName")
            P_AddressTextBox.Text = sqlreader.Item("P_Address")
            P_SexTextBox.Text = sqlreader.Item("P_Sex")
            P_TypeTextBox.Text = sqlreader.Item("P_Type")
            P_BirthDateTimePicker.Text = sqlreader.Item("P_Birth")
            P_TelTextBox.Text = sqlreader.Item("P_Tel")
            P_SymptomTextBox.Text = sqlreader.Item("P_Symptom")
            W_NumberTextBox.Text = sqlreader.Item("W_Number")
            Pr_IDTextBox.Text = sqlreader.Item("Pr_ID")
            Pr_FNameTextBox.Text = sqlreader.Item("Pr_FName")
            Pr_LNameTextBox.Text = sqlreader.Item("Pr_LName")
            Pr_AddressTextBox.Text = sqlreader.Item("Pr_Address")
            Pr_TelTextBox.Text = sqlreader.Item("Pr_Tel")
            Pr_RelationshipTextBox.Text = sqlreader.Item("Pr_Relationship")
            L_IDTextBox.Text = sqlreader.Item("L_ID")
            L_FNameTextBox.Text = sqlreader.Item("L_FName")
            L_LNameTextBox.Text = sqlreader.Item("L_LName")
            L_AddressTextBox.Text = sqlreader.Item("L_Address")
            L_TelTextBox.Text = sqlreader.Item("L_Tel")
            L_ClinicIDTextBox.Text = sqlreader.Item("L_ClinicID")
        Loop

        sqlreader.Close()
        SqlConnection.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        LocalDoctor.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PatientRelatives.Show()
    End Sub
End Class