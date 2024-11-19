Public Class WardRequest


    Private Sub WardRequest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Hospital.WardRequest' table. You can move, or remove it, as needed.
        Me.WardRequestTableAdapter.Fill(Me.Hospital.WardRequest)

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        addNewRequest.Show()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Me.Close()
        Dim newForm As New WardRequest()
        newForm.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        EditReq.Show()
    End Sub
End Class