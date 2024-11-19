Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Xml

Public Class deletePatient

    Private connectingString As String = "Server = DESKTOP-S7LHQVM\WELLMEADOWSHOSP;Database=DBwellmeadow;Trusted_Connection=True;"
    Dim sqlConnection As New SqlConnection(connectingString)

    Private Sub btnSearch_Click(sender As Object, e As EventArgs)
        Dim IDsearch = P_IDTextBox.Text

        Dim sql = "SELECT TOP 1 * FROM Patient WHERE P_ID = '" & IDsearch & "' "
        Dim cmd = sqlConnection.CreateCommand

        cmd.CommandText = sql
        sqlConnection.Open()
        Dim sqlreader = cmd.ExecuteReader()

        Do While sqlreader.Read()
            P_IDTextBox.Text = sqlreader.Item("P_ID")
            P_FNameTextBox.Text = sqlreader.Item("P_FName")
            P_LNameTextBox.Text = sqlreader.Item("P_LName")
            P_AddressTextBox.Text = sqlreader.Item("P_Address")
            P_SexTextBox.Text = sqlreader.Item("P_Sex")
            P_TypeTextBox.Text = sqlreader.Item("P_Type")
            P_BirthDateTimePicker.Text = sqlreader.Item("P_Birth")
            P_TelTextBox.Text = sqlreader.Item("P_Tel")
            P_SymptomTextBox.Text = sqlreader.Item("P_Symptom")

        Loop

        sqlreader.Close()
        sqlConnection.Close()

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs)
        Dim IDdelete = P_IDTextBox.Text

        Dim sql = "DELETE FROM Patient WHERE P_ID = '" & IDdelete & "' "
        Dim cmd = sqlConnection.CreateCommand

        cmd.CommandText = sql
        sqlConnection.Open()
        Dim sqlreader = cmd.ExecuteReader()

        Do While sqlreader.Read()
            P_IDTextBox.Text = sqlreader.Item("P_ID")
            P_FNameTextBox.Text = sqlreader.Item("P_FName")
            P_LNameTextBox.Text = sqlreader.Item("P_LName")
            P_AddressTextBox.Text = sqlreader.Item("P_Address")
            P_SexTextBox.Text = sqlreader.Item("P_Sex")
            P_TypeTextBox.Text = sqlreader.Item("P_Type")
            P_BirthDateTimePicker.Text = sqlreader.Item("P_Birth")
            P_TelTextBox.Text = sqlreader.Item("P_Tel")
            P_SymptomTextBox.Text = sqlreader.Item("P_Symptom")

        Loop

        sqlreader.Close()
        sqlConnection.Close()

        Me.Close()
    End Sub

    Private Sub deletePatient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Hospital.PatientReferral' table. You can move, or remove it, as needed.
        Me.PatientReferralTableAdapter.Fill(Me.Hospital.PatientReferral)

    End Sub

    Private Sub btnSearch_Click_1(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim IDsearch = TextBox1.Text

        Dim sql = "SELECT TOP 1 * FROM PatientReferral WHERE PRF_ID = '" & IDsearch & "' "
        Dim cmd = sqlConnection.CreateCommand

        cmd.CommandText = sql
        sqlConnection.Open()
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
            W_NumberTextBox1.Text = sqlreader.Item("W_Number")
        Loop


        sqlreader.Close()
        sqlConnection.Close()

        SearchWard()
    End Sub

    Private Sub SearchWard()

        Dim IDsearch = W_NumberTextBox1.Text

        Dim sql = "SELECT TOP 1 * FROM WardReport WHERE W_Number = '" & IDsearch & "' "
        Dim cmd = sqlConnection.CreateCommand

        cmd.CommandText = sql
        sqlConnection.Open()
        Dim sqlreader = cmd.ExecuteReader()

        Do While sqlreader.Read()

            W_NumberTextBox1.Text = sqlreader.Item("W_Number")
            W_TypeTextBox1.Text = sqlreader.Item("W_Type")
            W_LocationTextBox.Text = sqlreader.Item("W_Location")
            W_ExtTelTextBox.Text = sqlreader.Item("W_ExtTel")
        Loop

        sqlreader.Close()
        sqlConnection.Close()
    End Sub
    Private Sub btnDelete_Click_1(sender As Object, e As EventArgs) Handles btnDelete.Click

        DeleteRelative()
        DeleteWardReport()
        DeleteReferral()
        Me.Close()
    End Sub

    Private Sub DeleteRelative()
        Dim IDdelete = Pr_IDTextBox.Text

        Dim sql = "DELETE FROM PatientRelatives WHERE Pr_ID = '" & IDdelete & "' "
        Dim cmd = sqlConnection.CreateCommand

        cmd.CommandText = sql
        sqlConnection.Open()
        Dim sqlreader = cmd.ExecuteReader()

        Do While sqlreader.Read()
            Pr_IDTextBox.Text = sqlreader.Item("Pr_ID")
            Pr_FNameTextBox.Text = sqlreader.Item("Pr_FName")
            Pr_LNameTextBox.Text = sqlreader.Item("Pr_LName")
            Pr_AddressTextBox.Text = sqlreader.Item("Pr_Address")
            Pr_TelTextBox.Text = sqlreader.Item("Pr_Tel")
            Pr_RelationshipTextBox.Text = sqlreader.Item("Pr_Relationship")
            P_IDTextBox.Text = sqlreader.Item("P_ID")
        Loop

        sqlreader.Close()
        sqlConnection.Close()
    End Sub



    Private Sub DeleteWardReport()
        Dim IDdelete = W_NumberTextBox1.Text

        Dim sql = "DELETE FROM WardReport WHERE W_Number = '" & IDdelete & "' "
        Dim cmd = sqlConnection.CreateCommand

        cmd.CommandText = sql
        sqlConnection.Open()
        Dim sqlreader = cmd.ExecuteReader()

        Do While sqlreader.Read()
            W_NumberTextBox1.Text = sqlreader.Item("W_Number")
            W_TypeTextBox1.Text = sqlreader.Item("W_Type")
            W_LocationTextBox.Text = sqlreader.Item("W_Location")
            W_ExtTelTextBox.Text = sqlreader.Item("W_ExtTel")
            P_IDTextBox.Text = sqlreader.Item("P_ID")
            P_FNameTextBox.Text = sqlreader.Item("P_FName")
            P_LNameTextBox.Text = sqlreader.Item("P_LName")
        Loop

        sqlreader.Close()
        sqlConnection.Close()
    End Sub

    Private Sub DeleteReferral()
        Dim IDdelete = PRF_IDTextBox.Text

        Dim sql = "DELETE FROM PatientReferral WHERE PRF_ID = '" & IDdelete & "' "
        Dim cmd = sqlConnection.CreateCommand

        cmd.CommandText = sql
        sqlConnection.Open()
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
        sqlConnection.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim IDsearch As String = PRF_IDTextBox.Text

        ' Construct an UPDATE statement to modify data in the "PatientReferral" table
        Dim sql As String = "UPDATE PatientReferral SET " &
            "P_ID = @P_ID, P_FName = @P_FName, P_LName = @P_LName, P_Address = @P_Address, " &
            "P_Sex = @P_Sex, P_Type = @P_Type, P_Birth = @P_Birth, P_Tel = @P_Tel, " &
            "P_Symptom = @P_Symptom, Pr_ID = @Pr_ID, Pr_FName = @Pr_FName, Pr_LName = @Pr_LName, " &
            "Pr_Address = @Pr_Address, Pr_Tel = @Pr_Tel, Pr_Relationship = @Pr_Relationship, " &
            "L_ID = @L_ID, L_FName = @L_FName, L_LName = @L_LName, L_Address = @L_Address, " &
            "L_Tel = @L_Tel, L_ClinicID = @L_ClinicID WHERE PRF_ID = @PRF_ID"

        Using cmd As New SqlCommand(sql, sqlConnection)
            cmd.Parameters.AddWithValue("@P_ID", P_IDTextBox.Text)
            cmd.Parameters.AddWithValue("@P_FName", P_FNameTextBox.Text)
            cmd.Parameters.AddWithValue("@P_LName", P_LNameTextBox.Text)
            cmd.Parameters.AddWithValue("@P_Address", P_AddressTextBox.Text)
            cmd.Parameters.AddWithValue("@P_Sex", P_SexTextBox.Text)
            cmd.Parameters.AddWithValue("@P_Type", P_TypeTextBox.Text)
            cmd.Parameters.AddWithValue("@P_Birth", P_BirthDateTimePicker.Value)
            cmd.Parameters.AddWithValue("@P_Tel", P_TelTextBox.Text)
            cmd.Parameters.AddWithValue("@P_Symptom", P_SymptomTextBox.Text)
            cmd.Parameters.AddWithValue("@Pr_ID", Pr_IDTextBox.Text)
            cmd.Parameters.AddWithValue("@Pr_FName", Pr_FNameTextBox.Text)
            cmd.Parameters.AddWithValue("@Pr_LName", Pr_LNameTextBox.Text)
            cmd.Parameters.AddWithValue("@Pr_Address", Pr_AddressTextBox.Text)
            cmd.Parameters.AddWithValue("@Pr_Tel", Pr_TelTextBox.Text)
            cmd.Parameters.AddWithValue("@Pr_Relationship", Pr_RelationshipTextBox.Text)
            cmd.Parameters.AddWithValue("@L_ID", L_IDTextBox.Text)
            cmd.Parameters.AddWithValue("@L_FName", L_FNameTextBox.Text)
            cmd.Parameters.AddWithValue("@L_LName", L_LNameTextBox.Text)
            cmd.Parameters.AddWithValue("@L_Address", L_AddressTextBox.Text)
            cmd.Parameters.AddWithValue("@L_Tel", L_TelTextBox.Text)
            cmd.Parameters.AddWithValue("@L_ClinicID", L_ClinicIDTextBox.Text)
            cmd.Parameters.AddWithValue("@PRF_ID", IDsearch)

            Try
                sqlConnection.Open()
                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    MessageBox.Show("Data updated successfully.")
                Else
                    MessageBox.Show("No rows were updated.")
                End If
            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message)
            Finally
                sqlConnection.Close()
            End Try
        End Using
    End Sub

End Class