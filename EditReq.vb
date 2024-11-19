Imports System.Data.SqlClient

Public Class EditReq

    Private connectingString As String = "Server = DESKTOP-S7LHQVM\WELLMEADOWSHOSP;Database=DBwellmeadow;Trusted_Connection=True;"
    Dim sqlConnection As New SqlConnection(connectingString)

    Private Sub ReqID(sender As Object, e As EventArgs) Handles MyBase.Load

        ComboBox3.Items.Clear()


        Dim connectionString As String = ("Server = DESKTOP-S7LHQVM\WELLMEADOWSHOSP;Database=DBwellmeadow;Trusted_Connection=True;")


        Using connection As New SqlConnection(connectionString)
            connection.Open()


            Dim sql As String = "SELECT Re_ID FROM WardRequest"

            Using command As New SqlCommand(sql, connection)

                Using reader As SqlDataReader = command.ExecuteReader()
                    While reader.Read()

                        ComboBox3.Items.Add(reader("Re_ID").ToString())
                    End While
                End Using
            End Using
        End Using
    End Sub

    Private Sub Wards(sender As Object, e As EventArgs) Handles MyBase.Load

        ComboBox2.Items.Clear()


        Dim connectionString As String = ("Server = DESKTOP-S7LHQVM\WELLMEADOWSHOSP;Database=DBwellmeadow;Trusted_Connection=True;")


        Using connection As New SqlConnection(connectionString)
            connection.Open()


            Dim sql As String = "SELECT W_Number FROM Wards"

            Using command As New SqlCommand(sql, connection)

                Using reader As SqlDataReader = command.ExecuteReader()
                    While reader.Read()

                        ComboBox2.Items.Add(reader("W_Number").ToString())
                    End While
                End Using
            End Using
        End Using
    End Sub

    Private Sub Drug(sender As Object, e As EventArgs) Handles MyBase.Load

        ComboBox1.Items.Clear()


        Dim connectionString As String = ("Server = DESKTOP-S7LHQVM\WELLMEADOWSHOSP;Database=DBwellmeadow;Trusted_Connection=True;")


        Using connection As New SqlConnection(connectionString)
            connection.Open()


            Dim sql As String = "SELECT D_ID FROM Drug"

            Using command As New SqlCommand(sql, connection)

                Using reader As SqlDataReader = command.ExecuteReader()
                    While reader.Read()

                        ComboBox1.Items.Add(reader("D_ID").ToString())
                    End While
                End Using
            End Using
        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim IDsearch = ComboBox3.Text

        Dim sql = "SELECT W_Number, D_ID, Quantity, Re_Date FROM WardRequest WHERE Re_ID = '" & IDsearch & "' "
        Dim cmd = SqlConnection.CreateCommand

        cmd.CommandText = sql
        SqlConnection.Open()
        Dim sqlreader = cmd.ExecuteReader()
        Do While sqlreader.Read()
            ComboBox2.Text = sqlreader.Item("W_Number")
            ComboBox1.Text = sqlreader.Item("D_ID")
            QuantityTextBox.Text = sqlreader.Item("Quantity")
            Re_DateDateTimePicker.Text = sqlreader.Item("Re_Date")
        Loop

        sqlreader.Close()
        SqlConnection.Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim IDsearch As String = ComboBox3.Text
        sqlConnection.Open()
        Dim sql As String = "UPDATE WardRequest SET W_Number = @W_Number, D_ID = @D_ID, Quantity = @Quantity, Re_Date = @Re_Date WHERE Re_ID = @Re_ID"
        Dim cmd As New SqlCommand(sql, sqlConnection)


        cmd.Parameters.AddWithValue("@W_Number", ComboBox2.Text)
        cmd.Parameters.AddWithValue("@D_ID", ComboBox1.Text)
        cmd.Parameters.AddWithValue("@Quantity", QuantityTextBox.Text)
        cmd.Parameters.AddWithValue("@Re_Date", Re_DateDateTimePicker.Value)
        cmd.Parameters.AddWithValue("@Re_ID", IDsearch)


        Dim rowsAffected As Integer = cmd.ExecuteNonQuery()


        sqlConnection.Close()
    End Sub
End Class