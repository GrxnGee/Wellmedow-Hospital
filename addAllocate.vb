Imports System.Data.SqlClient
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class addAllocate

    Private connectingString As String = "Server = DESKTOP-S7LHQVM\WELLMEADOWSHOSP;Database=DBwellmeadow;Trusted_Connection=True;"
    Dim sqlConnection As New SqlConnection(connectingString)




    Private Sub Patient(sender As Object, e As EventArgs) Handles MyBase.Load
        Pnum.Items.Clear()
        Dim connectionString As String = ("Server = DESKTOP-S7LHQVM\WELLMEADOWSHOSP;Database=DBwellmeadow;Trusted_Connection=True;")


        Using connection As New SqlConnection(connectionString)
            connection.Open()


            Dim sql As String = "SELECT P_ID FROM PatientReferral"

            Using command As New SqlCommand(sql, connection)

                Using reader As SqlDataReader = command.ExecuteReader()
                    While reader.Read()

                        Pnum.Items.Add(reader("P_ID").ToString())
                    End While
                End Using
            End Using
        End Using
    End Sub


    Private Sub Staff(sender As Object, e As EventArgs) Handles MyBase.Load
        S_num.Items.Clear()
        Dim connectionString As String = ("Server = DESKTOP-S7LHQVM\WELLMEADOWSHOSP;Database=DBwellmeadow;Trusted_Connection=True;")


        Using connection As New SqlConnection(connectionString)
            connection.Open()


            Dim sql As String = "SELECT S_ID FROM Staff"

            Using command As New SqlCommand(sql, connection)

                Using reader As SqlDataReader = command.ExecuteReader()
                    While reader.Read()

                        S_num.Items.Add(reader("S_ID").ToString())
                    End While
                End Using
            End Using
        End Using
    End Sub


    Private Sub Wards(sender As Object, e As EventArgs) Handles MyBase.Load
        Wnum.Items.Clear()
        Dim connectionString As String = ("Server = DESKTOP-S7LHQVM\WELLMEADOWSHOSP;Database=DBwellmeadow;Trusted_Connection=True;")


        Using connection As New SqlConnection(connectionString)
            connection.Open()


            Dim sql As String = "SELECT W_Number FROM Wards"

            Using command As New SqlCommand(sql, connection)

                Using reader As SqlDataReader = command.ExecuteReader()
                    While reader.Read()

                        Wnum.Items.Add(reader("W_Number").ToString())
                    End While
                End Using
            End Using
        End Using
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Using conn As New SqlConnection("Server = DESKTOP-S7LHQVM\WELLMEADOWSHOSP;Database=DBwellmeadow;Trusted_Connection=True;")
            conn.Open()


            Dim sql As String = "INSERT INTO PatientAllocate (A_ID, P_ID, W_Number, A_Date, S_ID, P_Symptom) " &
                            "VALUES (@A_ID, @P_ID, @W_Number, @A_Date, @S_ID, @P_Symptom)"

            Using cmd As New SqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@A_ID", A_IDTextBox.Text)
                cmd.Parameters.AddWithValue("@P_ID", Pnum.Text)
                cmd.Parameters.AddWithValue("@W_Number", Wnum.Text)
                cmd.Parameters.AddWithValue("@A_Date", A_DateDateTimePicker.Value)
                cmd.Parameters.AddWithValue("@S_ID", S_num.Text)
                cmd.Parameters.AddWithValue("@P_Symptom", P_SymptomTextBox.Text)



                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim IDsearch = Pnum.Text

        Dim sql = "SELECT TOP 1 * FROM PatientReferral WHERE P_ID = '" & IDsearch & "' "
        Dim cmd = sqlConnection.CreateCommand

        cmd.CommandText = sql
        sqlConnection.Open()
        Dim sqlreader = cmd.ExecuteReader()

        Do While sqlreader.Read()
            Fname.Text = sqlreader.Item("P_FName")
            Lname.Text = sqlreader.Item("P_LName")
        Loop

        sqlreader.Close()
        sqlConnection.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim IDsearch = S_num.Text

        Dim sql = "SELECT TOP 1 * FROM Staff WHERE S_ID = '" & IDsearch & "' "
        Dim cmd = sqlConnection.CreateCommand

        cmd.CommandText = sql
        sqlConnection.Open()
        Dim sqlreader = cmd.ExecuteReader()

        Do While sqlreader.Read()
            Sfname.Text = sqlreader.Item("S_FNme")
            Slname.Text = sqlreader.Item("S_LName")
        Loop

        sqlreader.Close()
        sqlConnection.Close()
    End Sub
End Class