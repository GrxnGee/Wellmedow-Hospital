Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip

Public Class addShift


    Private connectingString As String = "Server = DESKTOP-S7LHQVM\WELLMEADOWSHOSP;Database=DBwellmeadow;Trusted_Connection=True;"
    Dim sqlConnection As New SqlConnection(connectingString)

    Private Sub StaffShiftBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.StaffShiftBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Hospital)

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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim IDsearch = ComboBox1.Text

        Dim sql = "SELECT S_FNme, S_LName FROM Staff WHERE S_ID = '" & IDsearch & "' "
        Dim cmd = sqlConnection.CreateCommand

        cmd.CommandText = sql
        sqlConnection.Open()
        Dim sqlreader = cmd.ExecuteReader()

        Do While sqlreader.Read()
            StaffName.Text = sqlreader.Item("S_FNme") & " " & sqlreader.Item("S_LName")
        Loop

        sqlreader.Close()
        sqlConnection.Close()
    End Sub

    Private Sub ComboBox3_Click(sender As Object, e As EventArgs) Handles ComboBox3.Click
        ComboBox3.Items.Clear()
        ComboBox3.Items.Add("Day")
        ComboBox3.Items.Add("Night")
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Using conn As New SqlConnection("Server = DESKTOP-S7LHQVM\WELLMEADOWSHOSP;Database=DBwellmeadow;Trusted_Connection=True;")
            conn.Open()


            Dim sql As String = "INSERT INTO StaffShift (SS_ID, S_ID, W_Number, Shift, Shift_Time) " &
                            "VALUES (@SS_ID, @S_ID, @W_Number, @Shift, @Shift_Time)"

            Using cmd As New SqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@SS_ID", SS_IDTextBox.Text)
                cmd.Parameters.AddWithValue("@S_ID", ComboBox1.Text)
                cmd.Parameters.AddWithValue("@W_Number", ComboBox2.Text)
                cmd.Parameters.AddWithValue("@Shift", ComboBox3.Text)
                cmd.Parameters.AddWithValue("@Shift_Time", Shift_TimeDateTimePicker.Value)


                cmd.ExecuteNonQuery()
            End Using

            Me.Close()
        End Using

        Me.Close()
        Dim newForm As New addShift()
        newForm.Show()
    End Sub


    Private Sub addShift_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Hospital.Staff' table. You can move, or remove it, as needed.
        Me.StaffShiftTableAdapter.Fill(Me.Hospital.StaffShift)

    End Sub

End Class