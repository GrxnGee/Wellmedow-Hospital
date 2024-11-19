Imports System.Data.SqlClient
Imports System.Net
Imports System.Security.Cryptography
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip

Public Class addStaff
    Dim sql As String
    Dim cmd As New SqlCommand

    Private connectingString As String = "Server = DESKTOP-S7LHQVM\WELLMEADOWSHOSP;Database=DBwellmeadow;Trusted_Connection=True;"
    Dim sqlConnection As New SqlConnection(connectingString)







    Private Sub myConnection()
        If sqlConnection.State = ConnectionState.Closed Then
            sqlConnection.Open()
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Add()
    End Sub

    Private Sub Add()

        Using conn As New SqlConnection("Server = DESKTOP-S7LHQVM\WELLMEADOWSHOSP;Database=DBwellmeadow;Trusted_Connection=True;")
            conn.Open()


            Dim sql As String = "INSERT INTO Staff (S_ID, S_FNme, S_LName, S_Birth, S_Sex, S_Address, S_Tel, S_Graduated, Salary, Position) " &
                            "VALUES (@S_ID, @S_FNme, @S_LName, @S_Birth, @S_Sex, @S_Address, @S_Tel, @S_Graduated, @Salary, @Position)"

            Using cmd As New SqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@S_ID", S_IDTextBox.Text)
                cmd.Parameters.AddWithValue("@S_FNme", S_LNameTextBox.Text)
                cmd.Parameters.AddWithValue("@S_LName", S_FNmeTextBox.Text)
                cmd.Parameters.AddWithValue("@S_Birth", S_BirthDateTimePicker.Value)
                cmd.Parameters.AddWithValue("@S_Sex", Csex.Text)
                cmd.Parameters.AddWithValue("@S_Address", S_AddressTextBox.Text)
                cmd.Parameters.AddWithValue("@S_Tel", S_TelTextBox.Text)
                cmd.Parameters.AddWithValue("@S_Graduated", Cgrad.Text)
                cmd.Parameters.AddWithValue("@Salary", SalaryTextBox.Text)
                cmd.Parameters.AddWithValue("@Position", Cposi.Text)


                cmd.ExecuteNonQuery()
            End Using

            Me.Close()
        End Using
    End Sub

    Private Sub Cgrad_Click(sender As Object, e As EventArgs) Handles Cgrad.Click
        Cgrad.Items.Clear()
        Cgrad.Items.Add("Bachelor of Science")
        Cgrad.Items.Add("Master's of Science")
        Cgrad.Items.Add("Professional of Science")
    End Sub

    Private Sub Cposi_Click(sender As Object, e As EventArgs) Handles Cposi.Click
        Cposi.Items.Clear()
        Cposi.Items.Add("Junior Nurse")
        Cposi.Items.Add("Nurse")
        Cposi.Items.Add("Charge Nurse")
        Cposi.Items.Add("Doctors")
        Cposi.Items.Add("Auxiliaries")
    End Sub

    Private Sub Csex_Click_1(sender As Object, e As EventArgs) Handles Csex.Click
        Csex.Items.Clear()
        Csex.Items.Add("Male")
        Csex.Items.Add("Female")
    End Sub
End Class