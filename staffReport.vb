Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class staffReport

    Private connectingString As String = "Server = DESKTOP-S7LHQVM\WELLMEADOWSHOSP;Database=DBwellmeadow;Trusted_Connection=True;"
    Dim sqlConnection As New SqlConnection(connectingString)





    Private Sub staffReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        Dim connectionString As String = ("Server = DESKTOP-S7LHQVM\WELLMEADOWSHOSP;Database=DBwellmeadow;Trusted_Connection=True;")

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim sqls As String = "SELECT Position, COUNT(*) AS Count 
                                FROM Staff
                                GROUP BY Position"


            Using command As New SqlCommand(sqls, connection)


                Using reader As SqlDataReader = command.ExecuteReader()
                    While reader.Read()

                        Dim diseaseName As String = reader("Position").ToString()
                        Dim diseaseCount As Integer = Convert.ToInt32(reader("Count"))


                        Chart1.Series("StaffPosition").Points.AddXY(diseaseName, diseaseCount)
                    End While
                End Using
            End Using
        End Using


        Dim sql As String = "SELECT S_ID, S_FNme, S_LName, Position
                            FROM Staff"

        Using sqlConnection As New SqlConnection("Server = DESKTOP-S7LHQVM\WELLMEADOWSHOSP;Database=DBwellmeadow;Trusted_Connection=True;")
            sqlConnection.Open()

            Using cmd As New SqlCommand(sql, sqlConnection)

                Using sqlreader As SqlDataReader = cmd.ExecuteReader()


                    While sqlreader.Read()
                        StaffDataGridView.Rows.Add(sqlreader("S_ID"), sqlreader("S_FNme"), sqlreader("S_LName"), sqlreader("Position"))
                    End While


                End Using
            End Using

            sqlConnection.Close()
        End Using
    End Sub

End Class