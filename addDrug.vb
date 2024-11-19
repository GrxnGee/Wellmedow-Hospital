Imports System.Data.SqlClient
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip

Public Class addDrug


    Private connectingString As String = "Server = DESKTOP-S7LHQVM\WELLMEADOWSHOSP;Database=DBwellmeadow;Trusted_Connection=True;"
    Dim sqlConnection As New SqlConnection(connectingString)

    Private Sub Add()

        Using conn As New SqlConnection("Server = DESKTOP-S7LHQVM\WELLMEADOWSHOSP;Database=DBwellmeadow;Trusted_Connection=True;")
            conn.Open()


            Dim sql As String = "INSERT INTO Drug (D_ID, D_Name, D_Descrip, D_Dose, D_MOA, D_Quantity, D_reorderLevel, D_costPerunit) " &
                            "VALUES (@D_ID, @D_Name, @D_Descrip, @D_Dose, @D_MOA, @D_Quantity, @D_reorderLevel, @D_costPerunit)"

            Using cmd As New SqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@D_ID", D_IDTextBox.Text)
                cmd.Parameters.AddWithValue("@D_Name", D_NameTextBox.Text)
                cmd.Parameters.AddWithValue("@D_Descrip", D_DescripTextBox.Text)
                cmd.Parameters.AddWithValue("@D_Dose", D_DoseTextBox.Text)
                cmd.Parameters.AddWithValue("@D_MOA", D_MOATextBox.Text)
                cmd.Parameters.AddWithValue("@D_Quantity", D_QuantityTextBox.Text)
                cmd.Parameters.AddWithValue("@D_reorderLevel", D_reorderLevelTextBox.Text)
                cmd.Parameters.AddWithValue("@D_costPerunit", D_costPerunitTextBox.Text)



                cmd.ExecuteNonQuery()
            End Using

        End Using
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Add()
    End Sub

    Private Sub addDrug_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DrugTableAdapter.Fill(Me.Hospital.Drug)
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Me.Close()
        Dim newForm As New addDrug()
        newForm.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim IDsearch As String = D_IDTextBox.Text
        sqlConnection.Open()

        Dim sql As String = "UPDATE Drug SET D_ID = @D_ID, D_Name = @D_Name, D_Descrip = @D_Descrip, D_Dose = @D_Dose, D_MOA = @D_MOA, D_Quantity = @D_Quantity, D_reorderLevel = @D_reorderLevel, D_costPerunit = @D_costPerunit WHERE D_ID = @SearchID"

        Using cmd As New SqlCommand(sql, sqlConnection)
            cmd.Parameters.AddWithValue("@D_ID", D_IDTextBox.Text)
            cmd.Parameters.AddWithValue("@D_Name", D_NameTextBox.Text)
            cmd.Parameters.AddWithValue("@D_Descrip", D_DescripTextBox.Text)
            cmd.Parameters.AddWithValue("@D_Dose", D_DoseTextBox.Text)
            cmd.Parameters.AddWithValue("@D_MOA", D_MOATextBox.Text)
            cmd.Parameters.AddWithValue("@D_Quantity", D_QuantityTextBox.Text)
            cmd.Parameters.AddWithValue("@D_reorderLevel", D_reorderLevelTextBox.Text)
            cmd.Parameters.AddWithValue("@D_costPerunit", D_costPerunitTextBox.Text)
            cmd.Parameters.AddWithValue("@SearchID", IDsearch)

            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()


        End Using

        sqlConnection.Close()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        Dim IDsearch = D_IDTextBox.Text


        Dim sql3 = "DELETE FROM Medication WHERE D_ID = '" & IDsearch & "' "
        Dim cmd3 = sqlConnection.CreateCommand
        sqlConnection.Open()
        cmd3.CommandText = sql3

        Dim sqlreader3 = cmd3.ExecuteReader()

        sqlreader3.Close()

        Dim sql2 = "DELETE FROM WardRequest WHERE D_ID = '" & IDsearch & "' "
        Dim cmd2 = sqlConnection.CreateCommand

        cmd2.CommandText = sql2

        Dim sqlreader2 = cmd2.ExecuteReader()

        sqlreader2.Close()



        Dim sql = "DELETE FROM Drug WHERE D_ID = '" & IDsearch & "' "
        Dim cmd = sqlConnection.CreateCommand

        cmd.CommandText = sql

        Dim sqlreader = cmd.ExecuteReader()

        sqlreader.Close()
        sqlConnection.Close()

    End Sub

End Class