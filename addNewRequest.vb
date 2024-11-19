Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement


Public Class addNewRequest

    Private connectingString As String = "Server = DESKTOP-S7LHQVM\WELLMEADOWSHOSP;Database=DBwellmeadow;Trusted_Connection=True;"
    Dim sqlConnection As New SqlConnection(connectingString)
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
        Dim IDsearch = ComboBox1.Text

        Dim sql = "SELECT D_Name, D_Descrip FROM Drug WHERE D_ID = '" & IDsearch & "' "
        Dim cmd = SqlConnection.CreateCommand

        cmd.CommandText = sql
        SqlConnection.Open()
        Dim sqlreader = cmd.ExecuteReader()
        Do While sqlreader.Read()
            TextBox1.Text = sqlreader.Item("D_Name") & " " & sqlreader.Item("D_Descrip")
        Loop

        sqlreader.Close()
        SqlConnection.Close()
    End Sub



    Private Sub Add()

        Using conn As New SqlConnection("Server = DESKTOP-S7LHQVM\WELLMEADOWSHOSP;Database=DBwellmeadow;Trusted_Connection=True;")
            conn.Open()


            Dim sql As String = "INSERT INTO WardRequest (Re_ID, W_Number, D_ID, Quantity, Re_Date) " &
                            "VALUES (@Re_ID, @W_Number, @D_ID, @Quantity, @Re_Date)"

            Using cmd As New SqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@Re_ID", Re_IDTextBox.Text)
                cmd.Parameters.AddWithValue("@W_Number", ComboBox2.Text)
                cmd.Parameters.AddWithValue("@D_ID", ComboBox1.Text)
                cmd.Parameters.AddWithValue("@Quantity", QuantityTextBox.Text)
                cmd.Parameters.AddWithValue("@Re_Date", Re_DateDateTimePicker.Value)



                cmd.ExecuteNonQuery()
            End Using

        End Using
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Add()
    End Sub
End Class