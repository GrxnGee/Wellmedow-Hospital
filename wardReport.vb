Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class wardReport

    Private connectingString As String = "Server = DESKTOP-S7LHQVM\WELLMEADOWSHOSP;Database=DBwellmeadow;Trusted_Connection=True;"
    Dim sqlConnection As New SqlConnection(connectingString)


    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim IDsearch As String = ComboBox1.Text
        Dim sql As String = "SELECT W_Number, W_Type, P_ID, P_FName, P_LName, W_Location, W_extTel
                        FROM WardReport
                        WHERE W_Number = @IDsearch"

        Using sqlConnection As New SqlConnection("Server = DESKTOP-S7LHQVM\WELLMEADOWSHOSP;Database=DBwellmeadow;Trusted_Connection=True;")
            sqlConnection.Open()

            Using cmd As New SqlCommand(sql, sqlConnection)
                cmd.Parameters.AddWithValue("@IDsearch", IDsearch)

                Using sqlreader As SqlDataReader = cmd.ExecuteReader()


                    While sqlreader.Read()
                        WardReportDataGridView.Rows.Add(sqlreader("W_Number"), sqlreader("W_Type"), sqlreader("P_ID"), sqlreader("P_FName"), sqlreader("P_LName"), sqlreader("W_Location"), sqlreader("W_extTel"))
                    End While


                End Using
            End Using

            sqlConnection.Close()
        End Using

        PatientCount()
        DayShift()
        NightShift()
        RetrieveDiseaseData()
    End Sub

    Private Sub PatientCount()
        Dim rowCount As Integer = WardReportDataGridView.Rows.Count - 1
        TextBox1.Text = rowCount.ToString()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Me.Close()
        Dim newForm As New wardReport()
        newForm.Show()
    End Sub


    Private Sub DayShift()
        Dim IDsearch = ComboBox1.Text
        Dim sql = "SELECT TOP 1 Staff.S_FNme, Staff.S_LName
FROM Staff
INNER JOIN StaffShift ON Staff.S_ID = StaffShift.S_ID
WHERE SS_ID = (SELECT MAX(SS_ID) FROM StaffShift WHERE W_Number = '" & IDsearch & "' AND Shift = 'Day')"
        Dim cmd = sqlConnection.CreateCommand

        cmd.CommandText = sql
        sqlConnection.Open()
        Dim sqlreader = cmd.ExecuteReader()

        Do While sqlreader.Read()
            ShiftDaytxt.Text = sqlreader.Item("S_FNme") & " " & sqlreader.Item("S_LName")
        Loop

        sqlreader.Close()
        sqlConnection.Close()
    End Sub

    Private Sub NightShift()
        Dim IDsearch = ComboBox1.Text
        Dim sql = "SELECT TOP 1 Staff.S_FNme, Staff.S_LName
FROM Staff
INNER JOIN StaffShift ON Staff.S_ID = StaffShift.S_ID
WHERE SS_ID = (SELECT MAX(SS_ID) FROM StaffShift WHERE W_Number = '" & IDsearch & "' AND Shift = 'Night')"
        Dim cmd = sqlConnection.CreateCommand

        cmd.CommandText = sql
        sqlConnection.Open()
        Dim sqlreader = cmd.ExecuteReader()

        Do While sqlreader.Read()
            ShiftNighttxt.Text = sqlreader.Item("S_FNme") & " " & sqlreader.Item("S_LName")
        Loop

        sqlreader.Close()
        sqlConnection.Close()
    End Sub
    Private Sub wardReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.WardsTableAdapter.Fill(Me.Hospital.Wards)

    End Sub


    Private Sub RetrieveDiseaseData()

        Dim connectionString As String = ("Server = DESKTOP-S7LHQVM\WELLMEADOWSHOSP;Database=DBwellmeadow;Trusted_Connection=True;")

        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim WardNum = ComboBox1.Text

            Dim sql As String = "SELECT P_Symptom, COUNT(*) AS Count 
                                FROM PatientReferral, WardReport
                                WHERE WardReport.W_Number = '" & WardNum & "' AND PatientReferral.W_Number = '" & WardNum & "' AND PatientReferral.P_ID = WardReport.P_ID
                                GROUP BY P_Symptom"


            Using command As New SqlCommand(sql, connection)


                Using reader As SqlDataReader = command.ExecuteReader()
                    While reader.Read()

                        Dim diseaseName As String = reader("P_Symptom").ToString()
                        Dim diseaseCount As Integer = Convert.ToInt32(reader("Count"))


                        Chart1.Series("DiseaseData").Points.AddXY(diseaseName, diseaseCount)
                    End While
                End Using
            End Using
        End Using
    End Sub

    Private Sub Wards(sender As Object, e As EventArgs) Handles MyBase.Load

        ComboBox1.Items.Clear()


        Dim connectionString As String = ("Server = DESKTOP-S7LHQVM\WELLMEADOWSHOSP;Database=DBwellmeadow;Trusted_Connection=True;")


        Using connection As New SqlConnection(connectionString)
            connection.Open()


            Dim sql As String = "SELECT W_Number FROM Wards"

            Using command As New SqlCommand(sql, connection)

                Using reader As SqlDataReader = command.ExecuteReader()
                    While reader.Read()

                        ComboBox1.Items.Add(reader("W_Number").ToString())
                    End While
                End Using
            End Using
        End Using
    End Sub


End Class