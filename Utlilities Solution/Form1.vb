Public Class MainFrm
    Private Sub BillsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles BillsBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.BillsBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.UtilitiesDataSet)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub MainFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'UtilitiesDataSet.Bills' table. You can move, or remove it, as needed.
        Try
            Me.BillsTableAdapter.Fill(Me.UtilitiesDataSet.Bills)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class
