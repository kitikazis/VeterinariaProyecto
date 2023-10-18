Public Class VentasForm
    Private Sub VentasForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'VeterinariaDataSet.Ventas' Puede moverla o quitarla según sea necesario.
        Me.VentasTableAdapter.Fill(Me.VeterinariaDataSet.Ventas)

    End Sub

    Private Sub VentasBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.VentasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.VeterinariaDataSet)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnBorrarVentas.Click

        If VentasDataGridView.SelectedRows.Count > 0 Then

            Dim selectedRow As DataGridViewRow = VentasDataGridView.SelectedRows(0)


            VentasDataGridView.Rows.Remove(selectedRow)

            Me.VentasTableAdapter.Update(Me.VeterinariaDataSet.Ventas)
        Else
            MessageBox.Show("No row is selected for deletion.")
        End If
    End Sub


    Private Sub VentasDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles VentasDataGridView.CellContentClick

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TxtBoxTotalVenta.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub BtnAgregarVenta_Click(sender As Object, e As EventArgs) Handles BtnAgregarVenta.Click
        ' Obtener la fecha y el total desde los controles
        Dim fechaVenta As Date = DateTimeVentas.Value
        Dim totalVenta As Decimal

        If Decimal.TryParse(TxtBoxTotalVenta.Text, totalVenta) Then
            ' Agregar una nueva fila a la fuente de datos vinculada (por ejemplo, VentasBindingSource)
            Dim newRow As DataRow = Me.VeterinariaDataSet.Ventas.NewRow()
            newRow("FechaVenta") = fechaVenta
            newRow("TotalVenta") = totalVenta
            Me.VeterinariaDataSet.Ventas.Rows.Add(newRow)

            ' Actualizar la fuente de datos
            Me.VentasTableAdapter.Update(Me.VeterinariaDataSet.Ventas)

            ' Borrar el campo TxtBoxTotalVenta
            TxtBoxTotalVenta.Text = String.Empty
        Else
            MessageBox.Show("El valor del total no es válido.")
        End If
    End Sub




    Private Sub DateTimeVentas_ValueChanged(sender As Object, e As EventArgs) Handles DateTimeVentas.ValueChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        If VentasDataGridView.SelectedRows.Count > 0 Then
            ' Obtener la fila seleccionada
            Dim selectedRow As DataGridViewRow = VentasDataGridView.SelectedRows(0)

            ' Obtener los valores de las celdas de la fila seleccionada
            Dim fechaVenta As Date = CDate(selectedRow.Cells("FechaVenta").Value)
            Dim totalVenta As Decimal = CDec(selectedRow.Cells("TotalVenta").Value)

            ' Aquí puedes implementar la lógica para permitir la edición de los valores de fechaVenta y totalVenta,
            ' por ejemplo, mostrando un cuadro de diálogo o permitiendo la edición directamente en el DataGridView.

            ' Después de la edición, actualiza la fila de datos en tu conjunto de datos
            selectedRow.Cells("FechaVenta").Value = fechaVenta
            selectedRow.Cells("TotalVenta").Value = totalVenta

            ' Finalmente, guarda los cambios en la base de datos
            Me.VentasTableAdapter.Update(Me.VeterinariaDataSet.Ventas)
        Else
            MessageBox.Show("No se ha seleccionado ninguna fila para editar.")
        End If
    End Sub


    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtnEnviar_Click(sender As Object, e As EventArgs) Handles BtnEnviar.Click

    End Sub
End Class