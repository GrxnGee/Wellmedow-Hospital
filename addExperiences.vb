Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class addExperiences

    Private connectingString As String = "Server = DESKTOP-S7LHQVM\WELLMEADOWSHOSP;Database=DBwellmeadow;Trusted_Connection=True;"
    Dim sqlConnection As New SqlConnection(connectingString)

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

    Private Sub Add()

        Using conn As New SqlConnection("Server = DESKTOP-S7LHQVM\WELLMEADOWSHOSP;Database=DBwellmeadow;Trusted_Connection=True;")
            conn.Open()


            Dim sql As String = "INSERT INTO WorkExp (Ex_ID, S_ID, Position, Ex_StartDate, Ex_EndDate, Ex_Organization) " &
                            "VALUES (@Ex_ID, @S_ID, @Position, @Ex_StartDate, @Ex_EndDate, @Ex_Organization)"

            Using cmd As New SqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@Ex_ID", Ex_IDTextBox.Text)
                cmd.Parameters.AddWithValue("@S_ID", ComboBox1.Text)
                cmd.Parameters.AddWithValue("@Position", PositionTextBox.Text)
                cmd.Parameters.AddWithValue("@Ex_StartDate", Ex_StartDateDateTimePicker.Value)
                cmd.Parameters.AddWithValue("@Ex_EndDate", Ex_EndDateDateTimePicker.Value)
                cmd.Parameters.AddWithValue("@Ex_Organization", Ex_OrganizationTextBox.Text)



                cmd.ExecuteNonQuery()
            End Using

            Me.Close()
        End Using
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Add()
    End Sub
End Class