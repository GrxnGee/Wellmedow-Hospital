Imports System.Data.SqlClient

Public Class Experiences
    Private connectingString As String = "Server = DESKTOP-S7LHQVM\WELLMEADOWSHOSP;Database=DBwellmeadow;Trusted_Connection=True;"
    Dim sqlConnection As New SqlConnection(connectingString)

    Private Sub QulificaID(sender As Object, e As EventArgs) Handles MyBase.Load

        ComboBox1.Items.Clear()


        Dim connectionString As String = ("Server = DESKTOP-S7LHQVM\WELLMEADOWSHOSP;Database=DBwellmeadow;Trusted_Connection=True;")


        Using connection As New SqlConnection(connectionString)
            connection.Open()


            Dim sql As String = "SELECT Ex_ID FROM WorkExp"

            Using command As New SqlCommand(sql, connection)

                Using reader As SqlDataReader = command.ExecuteReader()
                    While reader.Read()

                        ComboBox1.Items.Add(reader("Ex_ID").ToString())
                    End While
                End Using
            End Using
        End Using
    End Sub




    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        addExperiences.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim IDsearch As String = TextBox1.Text

        Dim sql = "SELECT Ex_ID, WorkExp.S_ID, S_FNme, S_LName, WorkExp.Position, Ex_StartDate, Ex_EndDate, Ex_Organization
               FROM WorkExp 
               INNER JOIN Staff ON WorkExp.S_ID = Staff.S_ID
               WHERE WorkExp.Position LIKE @IDsearch"

        Using sqlConnection As New SqlConnection("Server = DESKTOP-S7LHQVM\WELLMEADOWSHOSP;Database=DBwellmeadow;Trusted_Connection=True;")
            sqlConnection.Open()

            Using cmd As New SqlCommand(sql, sqlConnection)
                cmd.Parameters.AddWithValue("@IDsearch", "%" & IDsearch & "%")

                Using sqlreader As SqlDataReader = cmd.ExecuteReader()
                    While sqlreader.Read()
                        WorkExpDataGridView.Rows.Add(sqlreader("Ex_ID"), sqlreader("S_ID"), sqlreader("S_FNme"), sqlreader("S_LName"), sqlreader("Position"), sqlreader("Ex_StartDate"), sqlreader("Ex_EndDate"), sqlreader("Ex_Organization"))
                    End While
                End Using
            End Using

            sqlConnection.Close()
        End Using
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim IDsearch = ComboBox1.Text

        Dim sql = "SELECT S_ID, Position, Ex_StartDate , Ex_EndDate, Ex_Organization FROM WorkExp WHERE Ex_ID = '" & IDsearch & "' "
        Dim cmd = SqlConnection.CreateCommand

        cmd.CommandText = sql
        SqlConnection.Open()
        Dim sqlreader = cmd.ExecuteReader()

        Do While sqlreader.Read()
            S_IDTextBox.Text = sqlreader.Item("S_ID")
            PositionTextBox.Text = sqlreader.Item("Position")
            Ex_StartDateDateTimePicker.Value = sqlreader.Item("Ex_StartDate")
            Ex_EndDateDateTimePicker.Value = sqlreader.Item("Ex_EndDate")
            Ex_OrganizationTextBox.Text = sqlreader.Item("Ex_Organization")
        Loop

        sqlreader.Close()
        sqlConnection.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim IDsearch As String = ComboBox1.Text
        sqlConnection.Open()

        Dim sql As String = "UPDATE WorkExp SET S_ID = @S_ID, Position = @Position, Ex_StartDate = @Ex_StartDate, Ex_EndDate = @Ex_EndDate, Ex_Organization = @Ex_Organization WHERE Ex_ID = @Ex_ID"

        Using cmd As New SqlCommand(sql, sqlConnection)
            cmd.Parameters.AddWithValue("@S_ID", S_IDTextBox.Text)
            cmd.Parameters.AddWithValue("@Position", PositionTextBox.Text)
            cmd.Parameters.AddWithValue("@Ex_StartDate", Ex_StartDateDateTimePicker.Value)
            cmd.Parameters.AddWithValue("@Ex_EndDate", Ex_EndDateDateTimePicker.Value)
            cmd.Parameters.AddWithValue("@Ex_Organization", Ex_OrganizationTextBox.Text)
            cmd.Parameters.AddWithValue("@Ex_ID", IDsearch)



            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()


                sqlConnection.Close()

        End Using
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Me.Close()
        Dim newForm As New Experiences()
        newForm.Show()
    End Sub
End Class