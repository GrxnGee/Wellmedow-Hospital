Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class deleteMedicine


    Private connectingString As String = "Server = DESKTOP-S7LHQVM\WELLMEADOWSHOSP;Database=DBwellmeadow;Trusted_Connection=True;"
    Dim sqlConnection As New SqlConnection(connectingString)


    Private Sub DrugID(sender As Object, e As EventArgs) Handles MyBase.Load

        ComboBox1.Items.Clear()


        Dim connectionString As String = ("Server = DESKTOP-S7LHQVM\WELLMEADOWSHOSP;Database=DBwellmeadow;Trusted_Connection=True;")


        Using connection As New SqlConnection(connectionString)
            connection.Open()


            Dim sql As String = "SELECT M_ID FROM Medication"

            Using command As New SqlCommand(sql, connection)

                Using reader As SqlDataReader = command.ExecuteReader()
                    While reader.Read()

                        ComboBox1.Items.Add(reader("M_ID").ToString())
                    End While
                End Using
            End Using
        End Using
    End Sub

    Private Sub btnSearch_Click_1(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim IDsearch = ComboBox1.Text

        Dim sql = "SELECT TOP 1 * FROM Medication WHERE M_ID = '" & IDsearch & "' "
        Dim cmd = sqlConnection.CreateCommand

        cmd.CommandText = sql
        sqlConnection.Open()
        Dim sqlreader = cmd.ExecuteReader()

        Do While sqlreader.Read()
            ComboBox1.Text = sqlreader.Item("M_ID")
            P_IDTextBox.Text = sqlreader.Item("P_ID")
            D_IDTextBox.Text = sqlreader.Item("D_ID")
            D_UPDTextBox.Text = sqlreader.Item("D_UPD")
            Start_DateDateTimePicker.Text = sqlreader.Item("Start_Date")
            End_DateDateTimePicker.Text = sqlreader.Item("End_Date")


        Loop

        sqlreader.Close()
        sqlConnection.Close()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim IDsearch = ComboBox1.Text

        Dim sql = "DELETE FROM Medication WHERE M_ID = '" & IDsearch & "' "
        Dim cmd = sqlConnection.CreateCommand

        cmd.CommandText = sql
        sqlConnection.Open()
        Dim sqlreader = cmd.ExecuteReader()

        Do While sqlreader.Read()
            ComboBox1.Text = sqlreader.Item("M_ID")
            P_IDTextBox.Text = sqlreader.Item("P_ID")
            D_IDTextBox.Text = sqlreader.Item("D_ID")
            D_UPDTextBox.Text = sqlreader.Item("D_UPD")
            Start_DateDateTimePicker.Text = sqlreader.Item("Start_Date")
            End_DateDateTimePicker.Text = sqlreader.Item("End_Date")


        Loop

        sqlreader.Close()
        sqlConnection.Close()
        Me.Close()
    End Sub


    Private Sub MedicationBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.MedicationBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Hospital)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim IDsearch As String = ComboBox1.Text
        sqlConnection.Open()


        Dim sql As String = "UPDATE Medication SET D_ID = @D_ID, D_UPD = @D_UPD, Start_Date = @Start_Date, End_Date = @End_Date WHERE M_ID = @M_ID"

        Using cmd As New SqlCommand(sql, sqlConnection)
            cmd.Parameters.AddWithValue("@D_ID", D_IDTextBox.Text)
            cmd.Parameters.AddWithValue("@D_UPD", D_UPDTextBox.Text)
            cmd.Parameters.AddWithValue("@Start_Date", Start_DateDateTimePicker.Value)
            cmd.Parameters.AddWithValue("@End_Date", End_DateDateTimePicker.Value)
            cmd.Parameters.AddWithValue("@M_ID", IDsearch)

            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                sqlConnection.Close()

        End Using
    End Sub

End Class