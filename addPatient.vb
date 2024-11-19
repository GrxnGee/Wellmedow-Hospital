Imports System.Data.SqlClient
Imports System.Net
Imports System.Security.Cryptography
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip

Public Class addPatient
    Private connectingString As String = "Server = DESKTOP-S7LHQVM\WELLMEADOWSHOSP;Database=DBwellmeadow;Trusted_Connection=True;"
    Dim sqlConnection As New SqlConnection(connectingString)

    Dim sql1 As String
    Dim cmd As New SqlCommand


    Private Sub myConnection()
        If sqlConnection.State = ConnectionState.Closed Then
            sqlConnection.Open()
        End If
    End Sub

    Private Sub AddPatientReferral()

        Using conn As New SqlConnection("Server = DESKTOP-S7LHQVM\WELLMEADOWSHOSP;Database=DBwellmeadow;Trusted_Connection=True;")
            conn.Open()


            Dim sql1 As String = "INSERT INTO PatientReferral (PRF_ID, P_ID, P_FName, P_LName, P_Address, P_Sex, P_Type, P_Birth, P_Tel, P_Symptom, Pr_ID, Pr_FName, Pr_LName, Pr_Address, Pr_Tel, Pr_Relationship, L_ID, L_FName, L_LName, L_Address, L_Tel, L_ClinicID, W_Number) " &
                            "VALUES (@PRF_ID, @P_ID, @P_FName, @P_LName, @P_Address, @P_Sex, @P_Type, @P_Birth, @P_Tel, @P_Symptom, @Pr_ID, @Pr_FName, @Pr_LName, @Pr_Address, @Pr_Tel, @Pr_Relationship, @L_ID, @L_FName, @L_LName, @L_Address, @L_Tel, @L_ClinicID, @W_Number)"

            Using cmd As New SqlCommand(sql1, conn)
                cmd.Parameters.AddWithValue("@PRF_ID", TextBox6.Text)
                cmd.Parameters.AddWithValue("@P_ID", P_IDTextBox.Text)
                cmd.Parameters.AddWithValue("@P_FName", P_FNameTextBox.Text)
                cmd.Parameters.AddWithValue("@P_LName", P_LNameTextBox.Text)
                cmd.Parameters.AddWithValue("@P_Address", P_AddressTextBox.Text)
                cmd.Parameters.AddWithValue("@P_Sex", ComboBox1.Text)
                cmd.Parameters.AddWithValue("@P_Type", ComboBox2.Text)
                cmd.Parameters.AddWithValue("@P_Birth", P_BirthDateTimePicker.Value)
                cmd.Parameters.AddWithValue("@P_Tel", P_TelTextBox.Text)
                cmd.Parameters.AddWithValue("@P_Symptom", P_SymptomTextBox.Text)
                cmd.Parameters.AddWithValue("@Pr_ID", pr_id.Text)
                cmd.Parameters.AddWithValue("@Pr_FName", Pr_FNameTextBox.Text)
                cmd.Parameters.AddWithValue("@Pr_LName", Pr_LNameTextBox.Text)
                cmd.Parameters.AddWithValue("@Pr_Address", Pr_AddressTextBox.Text)
                cmd.Parameters.AddWithValue("@Pr_Tel", Pr_TelTextBox.Text)
                cmd.Parameters.AddWithValue("@Pr_Relationship", Pr_RelationshipTextBox.Text)
                cmd.Parameters.AddWithValue("@L_ID", TextBox5.Text)
                cmd.Parameters.AddWithValue("@L_FName", L_FNameTextBox.Text)
                cmd.Parameters.AddWithValue("@L_LName", L_LNameTextBox.Text)
                cmd.Parameters.AddWithValue("@L_Address", L_AddressTextBox.Text)
                cmd.Parameters.AddWithValue("@L_Tel", L_TelTextBox.Text)
                cmd.Parameters.AddWithValue("@L_ClinicID", L_ClinicIDTextBox.Text)
                cmd.Parameters.AddWithValue("@W_Number", W_NumberTextBox1.Text)

                cmd.ExecuteNonQuery()
            End Using
        End Using

    End Sub

    Private Sub AddPatientRelative()
        Using conn As New SqlConnection("Server = DESKTOP-S7LHQVM\WELLMEADOWSHOSP;Database=DBwellmeadow;Trusted_Connection=True;")
            conn.Open()



            Dim sql1 As String = "INSERT INTO PatientRelatives (Pr_ID, Pr_FName, Pr_LName, Pr_Address, Pr_Tel, Pr_Relationship, P_ID) " &
                            "VALUES (@Pr_ID, @Pr_FName, @Pr_LName, @Pr_Address, @Pr_Tel, @Pr_Relationship, @P_ID)"

            Using cmd As New SqlCommand(sql1, conn)
                cmd.Parameters.AddWithValue("@Pr_ID", pr_id.Text)
                cmd.Parameters.AddWithValue("@Pr_FName", Pr_FNameTextBox.Text)
                cmd.Parameters.AddWithValue("@Pr_LName", Pr_LNameTextBox.Text)
                cmd.Parameters.AddWithValue("@Pr_Address", Pr_AddressTextBox.Text)
                cmd.Parameters.AddWithValue("@Pr_Tel", Pr_TelTextBox.Text)
                cmd.Parameters.AddWithValue("@Pr_Relationship", Pr_RelationshipTextBox.Text)
                cmd.Parameters.AddWithValue("@P_ID", P_IDTextBox.Text)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Private Sub AddWardReport()
        Using conn As New SqlConnection("Server = DESKTOP-S7LHQVM\WELLMEADOWSHOSP;Database=DBwellmeadow;Trusted_Connection=True;")
            conn.Open()



            Dim sql1 As String = "INSERT INTO WardReport (W_Number, W_Type, W_Location, W_ExtTel, P_ID, P_FName, P_LName) " &
                            "VALUES (@W_Number, @W_Type, @W_Location, @W_ExtTel, @P_ID, @P_FName, @P_LName)"

            Using cmd As New SqlCommand(sql1, conn)
                cmd.Parameters.AddWithValue("@W_Number", W_NumberTextBox1.Text)
                cmd.Parameters.AddWithValue("@W_Type", W_TypeTextBox1.Text)
                cmd.Parameters.AddWithValue("@W_Location", W_LocationTextBox.Text)
                cmd.Parameters.AddWithValue("@W_ExtTel", W_ExtTelTextBox.Text)
                cmd.Parameters.AddWithValue("@P_ID", P_IDTextBox.Text)
                cmd.Parameters.AddWithValue("@P_FName", P_FNameTextBox.Text)
                cmd.Parameters.AddWithValue("@P_LName", P_LNameTextBox.Text)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Private Sub ComboBox1_Click(sender As Object, e As EventArgs) Handles ComboBox1.Click
        ComboBox1.Items.Clear()
        ComboBox1.Items.Add("Male")
        ComboBox1.Items.Add("Female")
    End Sub

    Private Sub ComboBox2_Click(sender As Object, e As EventArgs) Handles ComboBox2.Click
        ComboBox2.Items.Clear()
        ComboBox2.Items.Add("Out-Patient")
        ComboBox2.Items.Add("In-Patient")
    End Sub

    Private Sub btnSearchR_Click(sender As Object, e As EventArgs) Handles btnSearchR.Click
        Dim IDsearch = pr_id.Text

        Dim sql = "SELECT TOP 1 * FROM PatientRelatives WHERE Pr_ID = '" & IDsearch & "' "
        Dim cmd = sqlConnection.CreateCommand

        cmd.CommandText = sql
        sqlConnection.Open()
        Dim sqlreader = cmd.ExecuteReader()

        Do While sqlreader.Read()
            Pr_FNameTextBox.Text = sqlreader.Item("Pr_FName")
            Pr_LNameTextBox.Text = sqlreader.Item("Pr_LName")
            Pr_AddressTextBox.Text = sqlreader.Item("Pr_Address")
            Pr_TelTextBox.Text = sqlreader.Item("Pr_Tel")
            Pr_RelationshipTextBox.Text = sqlreader.Item("Pr_Relationship")
        Loop

        sqlreader.Close()
        sqlConnection.Close()
    End Sub

    Private Sub btnSearchLD_Click(sender As Object, e As EventArgs) Handles btnSearchLD.Click
        Dim IDsearch = TextBox5.Text

        Dim sql = "SELECT TOP 1 * FROM LocalDoctor WHERE L_ID = '" & IDsearch & "' "
        Dim cmd = sqlConnection.CreateCommand

        cmd.CommandText = sql
        sqlConnection.Open()
        Dim sqlreader = cmd.ExecuteReader()

        Do While sqlreader.Read()
            L_FNameTextBox.Text = sqlreader.Item("L_FName")
            L_LNameTextBox.Text = sqlreader.Item("L_LName")
            L_AddressTextBox.Text = sqlreader.Item("L_Address")
            L_TelTextBox.Text = sqlreader.Item("L_Tel")
            L_ClinicIDTextBox.Text = sqlreader.Item("L_ClinicID")
        Loop

        sqlreader.Close()
        sqlConnection.Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        AddPatientReferral()
        AddPatientRelative()
        AddWardReport()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
    Private Sub btnSearchWard_Click(sender As Object, e As EventArgs) Handles btnSearchWard.Click
        Dim IDsearch = W_NumberTextBox1.Text

        Dim sql = "SELECT TOP 1 * FROM Wards WHERE W_Number = '" & IDsearch & "' "
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
End Class