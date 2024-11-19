Public Class Form1
    Private Sub btnStaff_Click(sender As Object, e As EventArgs) Handles btnStaff.Click
        Staff.Show()
    End Sub

    Private Sub btnPatient_Click(sender As Object, e As EventArgs) Handles btnPatient.Click
        RefOrAlo.Show()
    End Sub

    Private Sub btnMedicine_Click(sender As Object, e As EventArgs) Handles btnMedicine.Click
        Medicine.Show()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnWardReport_Click(sender As Object, e As EventArgs) Handles btnWardReport.Click
        wardReport.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Supply.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        staffReport.Show()
    End Sub
End Class
