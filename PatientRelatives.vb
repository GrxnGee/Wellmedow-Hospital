Public Class PatientRelatives
    Friend Shared Sub Open()
        Throw New NotImplementedException()
    End Sub

    Private Sub PatientRelatives_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Hospital.PatientRelatives' table. You can move, or remove it, as needed.
        Me.PatientRelativesTableAdapter.Fill(Me.Hospital.PatientRelatives)

    End Sub
End Class