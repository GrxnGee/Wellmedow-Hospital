Imports System.Data.SqlClient
Imports System.Net
Imports System.Security.Cryptography
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip

Public Class addMedicine
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


            Dim sql As String = "INSERT INTO Medication (M_ID, P_ID, D_ID, D_UPD, Start_Date, End_Date) " &
                            "VALUES (@M_ID, @P_ID,@D_ID, @D_UPD, @Start_Date, @End_Date)"

            Using cmd As New SqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@M_ID", M_IDTextBox.Text)
                cmd.Parameters.AddWithValue("@P_ID", ComboBox2.Text)
                cmd.Parameters.AddWithValue("@D_ID", ComboBox1.Text)
                cmd.Parameters.AddWithValue("@D_UPD", D_UPDTextBox.Text)
                cmd.Parameters.AddWithValue("@Start_Date", Start_DateDateTimePicker.Value)
                cmd.Parameters.AddWithValue("@End_Date", End_DateDateTimePicker.Value)


                cmd.ExecuteNonQuery()
            End Using

            Me.Close()
        End Using
    End Sub


    Private Sub DrugID(sender As Object, e As EventArgs) Handles MyBase.Load

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

    Private Sub PatientID(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox2.Items.Clear()
        Dim connectionString As String = ("Server = DESKTOP-S7LHQVM\WELLMEADOWSHOSP;Database=DBwellmeadow;Trusted_Connection=True;")


        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim sql As String = "SELECT P_ID, P_FName FROM PatientReferral"

            Using command As New SqlCommand(sql, connection)

                Using reader As SqlDataReader = command.ExecuteReader()
                    While reader.Read()

                        ComboBox2.Items.Add(reader("P_ID").ToString())
                    End While
                End Using
            End Using
        End Using

    End Sub

    Private Sub Patient()
        Dim IDsearch = ComboBox2.Text

        Dim sql = "SELECT P_FName, P_LName FROM PatientReferral WHERE P_ID = '" & IDsearch & "' "
        Dim cmd = sqlConnection.CreateCommand

        cmd.CommandText = sql
        sqlConnection.Open()
        Dim sqlreader = cmd.ExecuteReader()

        Do While sqlreader.Read()
            patientName.Text = sqlreader.Item("P_FName") & " " & sqlreader.Item("P_LName")
        Loop

        sqlreader.Close()
        sqlConnection.Close()
    End Sub

    Private Sub Drug()
        Dim IDsearch = ComboBox1.Text

        Dim sql = "SELECT D_Name, D_Descrip FROM Drug WHERE D_ID = '" & IDsearch & "' "
        Dim cmd = sqlConnection.CreateCommand

        cmd.CommandText = sql
        sqlConnection.Open()
        Dim sqlreader = cmd.ExecuteReader()

        Do While sqlreader.Read()
            TextBox2.Text = sqlreader.Item("D_Name") & " " & sqlreader.Item("D_Descrip")
        Loop

        sqlreader.Close()
        sqlConnection.Close()
    End Sub

    Private Sub ComboBox2_TextUpdate(sender As Object, e As EventArgs) Handles ComboBox2.TextUpdate
        Patient()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Patient()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Drug()
    End Sub
End Class