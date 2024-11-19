Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class PatientAllocate

    Private connectingString As String = "Server = DESKTOP-S7LHQVM\WELLMEADOWSHOSP;Database=DBwellmeadow;Trusted_Connection=True;"
    Dim sqlConnection As New SqlConnection(connectingString)

    Private Sub Qulificaธัยำ(sender As Object, e As EventArgs) Handles MyBase.Load

        ComboBox1.Items.Clear()


        Dim connectionString As String = ("Server = DESKTOP-S7LHQVM\WELLMEADOWSHOSP;Database=DBwellmeadow;Trusted_Connection=True;")


        Using connection As New SqlConnection(connectionString)
            connection.Open()


            Dim sql As String = "SELECT A_ID FROM PatientAllocate"

            Using command As New SqlCommand(sql, connection)

                Using reader As SqlDataReader = command.ExecuteReader()
                    While reader.Read()

                        ComboBox1.Items.Add(reader("A_ID").ToString())
                    End While
                End Using
            End Using
        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim IDsearch = ComboBox1.Text

        Dim sql = "DELETE FROM PatientAllocate WHERE A_ID = '" & IDsearch & "' "
        Dim cmd = sqlConnection.CreateCommand

        cmd.CommandText = sql
        sqlConnection.Open()
        Dim sqlreader = cmd.ExecuteReader()

        Do While sqlreader.Read()
            ComboBox1.Text = sqlreader.Item("A_ID")
            P_IDTextBox.Text = sqlreader.Item("P_ID")
            W_NumberTextBox.Text = sqlreader.Item("W_Number")
            A_DateDateTimePicker.Text = sqlreader.Item("A_Date")
            S_IDTextBox.Text = sqlreader.Item("S_ID")
            P_SymptomTextBox.Text = sqlreader.Item("P_Symptom")


        Loop

        sqlreader.Close()
        sqlConnection.Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        addAllocate.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim IDsearch = ComboBox1.Text

        Dim sql = "SELECT TOP 1 A_ID, P_ID, W_Number, A_Date, S_ID, P_Symptom FROM PatientAllocate WHERE A_ID = '" & IDsearch & "' "
        Dim cmd = SqlConnection.CreateCommand

        cmd.CommandText = sql
        SqlConnection.Open()
        Dim sqlreader = cmd.ExecuteReader()

        Do While sqlreader.Read()
            P_IDTextBox.Text = sqlreader.Item("P_ID")
            W_NumberTextBox.Text = sqlreader.Item("W_Number")
            A_DateDateTimePicker.Text = sqlreader.Item("A_Date")
            S_IDTextBox.Text = sqlreader.Item("S_ID")
            P_SymptomTextBox.Text = sqlreader.Item("P_Symptom")
        Loop

        sqlreader.Close()
        SqlConnection.Close()
    End Sub

    Private Sub PatientAllocate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sql As String = "SELECT PatientAllocate.A_ID, PatientAllocate.P_ID, P_FName, P_LName, PatientAllocate.W_Number, A_Date, PatientAllocate.S_ID, S_FNme, S_LName, PatientAllocate.P_Symptom " &
                           "FROM PatientAllocate " &
                           "INNER JOIN Staff ON PatientAllocate.S_ID = Staff.S_ID " &
                           "INNER JOIN PatientReferral ON PatientReferral.P_ID = PatientAllocate.P_ID"

        Using sqlConnection As New SqlConnection("Server = DESKTOP-S7LHQVM\WELLMEADOWSHOSP;Database=DBwellmeadow;Trusted_Connection=True;")
            sqlConnection.Open()

            Using cmd As New SqlCommand(sql, sqlConnection)

                Using sqlreader As SqlDataReader = cmd.ExecuteReader()
                    While sqlreader.Read()
                        PatientAllocateDataGridView.Rows.Add(sqlreader("A_ID"), sqlreader("P_ID"), sqlreader("P_FName"), sqlreader("P_LName"), sqlreader("W_Number"), sqlreader("A_Date"), sqlreader("S_ID"), sqlreader("S_FNme"), sqlreader("S_LName"), sqlreader("P_Symptom"))
                    End While
                End Using
            End Using

            sqlConnection.Close()
        End Using
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim IDsearch As String = ComboBox1.Text
        sqlConnection.Open()
        ' Construct an UPDATE statement to modify data in the "Qualification" table
        Dim sql As String = "UPDATE PatientAllocate SET W_Number = @W_Number, A_Date = @A_Date, P_Symptom = @P_Symptom WHERE A_ID = @A_ID"
        Dim cmd As New SqlCommand(sql, sqlConnection)

        cmd.Parameters.AddWithValue("@W_Number", W_NumberTextBox.Text)
        cmd.Parameters.AddWithValue("@A_Date", A_DateDateTimePicker.Value)
        cmd.Parameters.AddWithValue("@P_Symptom", P_SymptomTextBox.Text)
        cmd.Parameters.AddWithValue("@A_ID", IDsearch)

        Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

            sqlConnection.Close()

    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Me.Close()
        Dim newForm As New PatientAllocate()
        newForm.Show()
    End Sub
End Class