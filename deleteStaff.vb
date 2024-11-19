Imports System.Data.SqlClient
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class deleteStaff

    Private connectingString As String = "Server = DESKTOP-S7LHQVM\WELLMEADOWSHOSP;Database=DBwellmeadow;Trusted_Connection=True;"
    Dim sqlConnection As New SqlConnection(connectingString)

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim IDsearch = ComboBox1.Text

        Dim sql = "SELECT TOP 1 * FROM Staff WHERE S_ID = '" & IDsearch & "' "
        Dim cmd = sqlConnection.CreateCommand

        cmd.CommandText = sql
        sqlConnection.Open()
        Dim sqlreader = cmd.ExecuteReader()

        Do While sqlreader.Read()
            ComboBox1.Text = sqlreader.Item("S_ID")
            S_FNmeTextBox.Text = sqlreader.Item("S_FNme")
            S_LNameTextBox.Text = sqlreader.Item("S_LName")
            S_BirthDateTimePicker.Text = sqlreader.Item("S_Birth")
            S_SexTextBox.Text = sqlreader.Item("S_Sex")
            S_AddressTextBox.Text = sqlreader.Item("S_Address")
            S_TelTextBox.Text = sqlreader.Item("S_Tel")
            S_GraduatedTextBox.Text = sqlreader.Item("S_Graduated")
            SalaryTextBox.Text = sqlreader.Item("Salary")
            PositionTextBox.Text = sqlreader.Item("Position")

        Loop

        sqlreader.Close()
        sqlConnection.Close()

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        Dim IDdelete = ComboBox1.Text


        sqlConnection.Open()

        Dim sql1 = "DELETE FROM StaffShift WHERE S_ID = '" & IDdelete & "' "
        Dim cmd1 = sqlConnection.CreateCommand

        cmd1.CommandText = sql1

        Dim sqlreader1 = cmd1.ExecuteReader()
        sqlreader1.Close()


        Dim sql2 = "DELETE FROM Qualification WHERE S_ID = '" & IDdelete & "' "
        Dim cmd2 = sqlConnection.CreateCommand

        cmd2.CommandText = sql2

        Dim sqlreader2 = cmd2.ExecuteReader()
        sqlreader2.Close()



        Dim sql3 = "DELETE FROM WorkExp WHERE S_ID = '" & IDdelete & "' "
        Dim cmd3 = sqlConnection.CreateCommand

        cmd3.CommandText = sql3

        Dim sqlreader3 = cmd3.ExecuteReader()
        sqlreader3.Close()


        Dim sql = "DELETE FROM Staff WHERE S_ID = '" & IDdelete & "' "
        Dim cmd = sqlConnection.CreateCommand

        cmd.CommandText = sql

        Dim sqlreader = cmd.ExecuteReader()

        Do While sqlreader.Read()
            ComboBox1.Text = sqlreader.Item("S_ID")
            S_FNmeTextBox.Text = sqlreader.Item("S_FNme")
            S_LNameTextBox.Text = sqlreader.Item("S_LName")
            S_BirthDateTimePicker.Text = sqlreader.Item("S_Birth")
            S_SexTextBox.Text = sqlreader.Item("S_Sex")
            S_AddressTextBox.Text = sqlreader.Item("S_Address")
            S_TelTextBox.Text = sqlreader.Item("S_Tel")
            S_GraduatedTextBox.Text = sqlreader.Item("S_Graduated")
            SalaryTextBox.Text = sqlreader.Item("Salary")
            PositionTextBox.Text = sqlreader.Item("Position")

        Loop

        sqlreader.Close()
        sqlConnection.Close()


        Me.Close()
    End Sub



    Private Sub Staff(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Clear()
        Dim connectionString As String = ("Server = DESKTOP-S7LHQVM\WELLMEADOWSHOSP;Database=DBwellmeadow;Trusted_Connection=True;")


        Using connection As New SqlConnection(connectionString)
            connection.Open()


            Dim sql As String = "SELECT S_ID FROM Staff"

            Using command As New SqlCommand(sql, connection)

                Using reader As SqlDataReader = command.ExecuteReader()
                    While reader.Read()

                        ComboBox1.Items.Add(reader("S_ID").ToString())
                    End While
                End Using
            End Using
        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim IDsearch As String = ComboBox1.Text
        sqlConnection.Open()


        Dim sql As String = "UPDATE Staff SET S_FNme = @S_FNme, S_LName = @S_LName, " &
                           "S_Birth = @S_Birth, S_Sex = @S_Sex, S_Address = @S_Address, " &
                           "S_Tel = @S_Tel, S_Graduated = @S_Graduated, Salary = @Salary " &
                           "WHERE S_ID = @S_ID"

        Using cmd As New SqlCommand(sql, sqlConnection)
            cmd.Parameters.AddWithValue("@S_FNme", S_FNmeTextBox.Text)
            cmd.Parameters.AddWithValue("@S_LName", S_LNameTextBox.Text)
            cmd.Parameters.AddWithValue("@S_Birth", S_BirthDateTimePicker.Value)
            cmd.Parameters.AddWithValue("@S_Sex", S_SexTextBox.Text)
            cmd.Parameters.AddWithValue("@S_Address", S_AddressTextBox.Text)
            cmd.Parameters.AddWithValue("@S_Tel", S_TelTextBox.Text)
            cmd.Parameters.AddWithValue("@S_Graduated", S_GraduatedTextBox.Text)
            cmd.Parameters.AddWithValue("@Salary", SalaryTextBox.Text)
            cmd.Parameters.AddWithValue("@S_ID", IDsearch)

            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                sqlConnection.Close()

        End Using
    End Sub

End Class