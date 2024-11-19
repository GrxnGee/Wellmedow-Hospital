Public Class LocalDoctor


    Private Sub LocalDoctor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Hospital.LocalDoctor' table. You can move, or remove it, as needed.
        Me.LocalDoctorTableAdapter.Fill(Me.Hospital.LocalDoctor)

    End Sub
End Class