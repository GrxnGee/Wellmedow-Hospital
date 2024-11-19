Public Class AddNewStaff
    Private Sub StaffBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.StaffBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Hospital)

    End Sub

    Private Sub StaffBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)
        Me.Validate()
        Me.StaffBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Hospital)

    End Sub

    Private Sub AddNewStaff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Hospital.Staff' table. You can move, or remove it, as needed.
        Me.StaffTableAdapter.Fill(Me.Hospital.Staff)

    End Sub
End Class