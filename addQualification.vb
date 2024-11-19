Imports System.Data.SqlClient
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip

Public Class addQualification

    Private connectingString As String = "Server = DESKTOP-S7LHQVM\WELLMEADOWSHOSP;Database=DBwellmeadow;Trusted_Connection=True;"
    Dim sqlConnection As New SqlConnection(connectingString)
    Private Sub QualificationBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.QualificationBindingSource.EndEdit()
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

    Private Sub Add()

        Using conn As New SqlConnection("Server = DESKTOP-S7LHQVM\WELLMEADOWSHOSP;Database=DBwellmeadow;Trusted_Connection=True;")
            conn.Open()


            Dim sql As String = "INSERT INTO Qualification (Q_ID, S_ID, Q_Type, Q_Date, Q_Institution) " &
                            "VALUES (@Q_ID, @S_ID, @Q_Type, @Q_Date, @Q_Institution)"

            Using cmd As New SqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@Q_ID", Q_IDTextBox.Text)
                cmd.Parameters.AddWithValue("@S_ID", ComboBox1.Text)
                cmd.Parameters.AddWithValue("@Q_Type", Q_TypeTextBox.Text)
                cmd.Parameters.AddWithValue("@Q_Date", Q_DateDateTimePicker.Value)
                cmd.Parameters.AddWithValue("@Q_Institution", Q_InstitutionTextBox.Text)



                cmd.ExecuteNonQuery()
            End Using

            Me.Close()
        End Using
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Add()
    End Sub
End Class