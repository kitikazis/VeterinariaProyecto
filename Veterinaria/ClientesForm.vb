Public Class ClientesForm
    Private Sub PacientesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles PacientesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PacientesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.VeterinariaDataSet)

    End Sub

    Private Sub ClientesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'VeterinariaDataSet.Servicios' Puede moverla o quitarla según sea necesario.
        Me.ServiciosTableAdapter.Fill(Me.VeterinariaDataSet.Servicios)
        'TODO: esta línea de código carga datos en la tabla 'VeterinariaDataSet.Pacientes' Puede moverla o quitarla según sea necesario.
        Me.PacientesTableAdapter.Fill(Me.VeterinariaDataSet.Pacientes)

    End Sub

    Private Sub ClientesForm_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class