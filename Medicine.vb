Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Medicine

    Private connectingString As String = "Server = DESKTOP-S7LHQVM\WELLMEADOWSHOSP;Database=DBwellmeadow;Trusted_Connection=True;"
    Dim sqlConnection As New SqlConnection(connectingString)
    Private Sub MedicationBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.MedicationBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Hospital)

    End Sub


    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Me.Close()
        Dim newForm As New Medicine()
        newForm.Show()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        addMedicine.Show()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        deleteMedicine.Show()
    End Sub


    Private Sub PatientID(sender As Object, e As EventArgs) Handles MyBase.Load
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


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Search.Click
        Dim IDsearch As String = ComboBox1.Text
        Dim sql As String = "SELECT M_ID, P_FName, P_LName, D_Name, D_Descrip, D_UPD, Start_Date, End_Date
                            FROM Medication, Drug, PatientReferral
                            WHERE M_ID = @IDsearch AND Medication.P_ID = PatientReferral.P_ID AND Drug.D_ID = Medication.D_ID"

        Using sqlConnection As New SqlConnection("Server = DESKTOP-S7LHQVM\WELLMEADOWSHOSP;Database=DBwellmeadow;Trusted_Connection=True;")
            sqlConnection.Open()

            Using cmd As New SqlCommand(sql, sqlConnection)
                cmd.Parameters.AddWithValue("@IDsearch", IDsearch)

                Using sqlreader As SqlDataReader = cmd.ExecuteReader()


                    While sqlreader.Read()
                        MedicationGrivView.Rows.Add(sqlreader("M_ID"), sqlreader("P_FName"), sqlreader("P_LName"), sqlreader("D_Name"), sqlreader("D_Descrip"), sqlreader("D_UPD"), sqlreader("Start_Date"), sqlreader("End_Date"))
                    End While


                End Using
            End Using

            sqlConnection.Close()
        End Using
    End Sub


End Class