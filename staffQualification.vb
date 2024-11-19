Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class staffQualification

    Private connectingString As String = "Server = DESKTOP-S7LHQVM\WELLMEADOWSHOSP;Database=DBwellmeadow;Trusted_Connection=True;"
    Dim sqlConnection As New SqlConnection(connectingString)


    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        addQualification.Show()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Me.Close()
        Dim newForm As New staffQualification()
        newForm.Show()
    End Sub



    '    Private Sub Search()
    '        Dim IDsearch = TextBox1.Text

    '        Dim sql = "SELECT TOP 1 Q_ID, Qualification.S_ID, S_FNme, S_LName, Q_Type, Q_Date, Q_Institution
    'FROM Qualification, Staff
    'WHERE Q_Type LIKE '%[" & IDsearch & "]%' AND  S_FNme IN (SELECT S_FNme FROM Staff WHERE Qualification.S_ID = Staff.S_ID) AND S_LName IN (SELECT S_LName FROM Staff WHERE Qualification.S_ID = Staff.S_ID);"
    '        Dim cmd = sqlConnection.CreateCommand

    '        cmd.CommandText = sql
    '        sqlConnection.Open()
    '        Dim sqlreader = cmd.ExecuteReader()

    '        Do While sqlreader.Read()
    '            S_IDTextBox.Text = sqlreader.Item("S_ID")
    '            S_FNmeTextBox.Text = sqlreader.Item("S_FNme")
    '            S_LNameTextBox.Text = sqlreader.Item("S_LName")
    '            Q_TypeTextBox.Text = sqlreader.Item("Q_Type")
    '            Q_DateDateTimePicker.Text = sqlreader.Item("Q_Date")
    '            Q_InstitutionTextBox.Text = sqlreader.Item("Q_Institution")
    '        Loop

    '        sqlreader.Close()
    '        sqlConnection.Close()
    '    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim IDsearch As String = TextBox1.Text
        Dim sql = "SELECT Q_ID, Qualification.S_ID, S_FNme, S_LName, Q_Type, Q_Date, Q_Institution
FROM Qualification, Staff
WHERE Q_Type LIKE '%[" & IDsearch & "]%' AND  S_FNme IN (SELECT S_FNme FROM Staff WHERE Qualification.S_ID = Staff.S_ID) AND S_LName IN (SELECT S_LName FROM Staff WHERE Qualification.S_ID = Staff.S_ID);"

        Using sqlConnection As New SqlConnection("Server = DESKTOP-S7LHQVM\WELLMEADOWSHOSP;Database=DBwellmeadow;Trusted_Connection=True;")
            sqlConnection.Open()

            Using cmd As New SqlCommand(sql, sqlConnection)
                cmd.Parameters.AddWithValue("@IDsearch", IDsearch)

                Using sqlreader As SqlDataReader = cmd.ExecuteReader()


                    While sqlreader.Read()
                        QualificationDataGridView.Rows.Add(sqlreader("Q_ID"), sqlreader("S_ID"), sqlreader("S_FNme"), sqlreader("S_LName"), sqlreader("Q_Type"), sqlreader("Q_Date"), sqlreader("Q_Institution"))
                    End While


                End Using
            End Using

            sqlConnection.Close()
        End Using
    End Sub

    Private Sub QulificaID(sender As Object, e As EventArgs) Handles MyBase.Load

        ComboBox1.Items.Clear()


        Dim connectionString As String = ("Server = DESKTOP-S7LHQVM\WELLMEADOWSHOSP;Database=DBwellmeadow;Trusted_Connection=True;")


        Using connection As New SqlConnection(connectionString)
            connection.Open()


            Dim sql As String = "SELECT Q_ID FROM Qualification"

            Using command As New SqlCommand(sql, connection)

                Using reader As SqlDataReader = command.ExecuteReader()
                    While reader.Read()

                        ComboBox1.Items.Add(reader("Q_ID").ToString())
                    End While
                End Using
            End Using
        End Using
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim IDsearch = ComboBox1.Text

        Dim sql = "SELECT S_ID, Q_Type, Q_Date, Q_Institution FROM Qualification WHERE Q_ID = '" & IDsearch & "' "
        Dim cmd = sqlConnection.CreateCommand

        cmd.CommandText = sql
        sqlConnection.Open()
        Dim sqlreader = cmd.ExecuteReader()

        Do While sqlreader.Read()
            S_IDTextBox.Text = sqlreader.Item("S_ID")
            Q_TypeTextBox.Text = sqlreader.Item("Q_Type")
            Q_DateDateTimePicker.Text = sqlreader.Item("Q_Date")
            Q_InstitutionTextBox.Text = sqlreader.Item("Q_Institution")
        Loop

        sqlreader.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim IDsearch As String = ComboBox1.Text

        Dim sql As String = "UPDATE Qualification SET S_ID = @S_ID, Q_Type = @Q_Type, Q_Date = @Q_Date, Q_Institution = @Q_Institution WHERE Q_ID = @Q_ID"
        Dim cmd As New SqlCommand(sql, sqlConnection)


        cmd.Parameters.AddWithValue("@S_ID", S_IDTextBox.Text)
        cmd.Parameters.AddWithValue("@Q_Type", Q_TypeTextBox.Text)
        cmd.Parameters.AddWithValue("@Q_Date", Q_DateDateTimePicker.Value)
        cmd.Parameters.AddWithValue("@Q_Institution", Q_InstitutionTextBox.Text)
        cmd.Parameters.AddWithValue("@Q_ID", IDsearch)


        Dim rowsAffected As Integer = cmd.ExecuteNonQuery()


        sqlConnection.Close()

    End Sub






End Class
