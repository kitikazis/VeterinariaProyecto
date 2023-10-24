Public Class FormVentas
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
        ' Obtén la fecha y el total de venta de los controles correspondientes
        Dim fechaVenta As Date = DateTimeVentas.Value
        Dim totalVenta As Decimal = Decimal.Parse(TxtBoxTotalVenta.Text) ' Asegúrate de validar la entrada del usuario

        ' Agrega una nueva fila a la tabla
        Dim nuevaFila As VeterinariaDataSet.VentasRow = VeterinariaDataSet.Ventas.NewVentasRow()
        nuevaFila.FechaVenta = fechaVenta
        nuevaFila.TotalVenta = totalVenta

        ' Agrega la fila a la tabla
        VeterinariaDataSet.Ventas.Rows.Add(nuevaFila)

        ' Actualiza la base de datos
        Me.VentasTableAdapter.Update(Me.VeterinariaDataSet.Ventas)

        ' Obtén el ID de la nueva venta como número positivo
        Dim idVenta As Integer = nuevaFila.Id ' Supongamos que el nombre de la columna de ID es "IDVenta"
        If idVenta < 0 Then
            idVenta = Math.Abs(idVenta) ' Convierte el valor negativo a positivo
        End If

        ' Muestra el ID de la venta, puedes usarlo para informar al usuario.
        MessageBox.Show("Venta agregada con ID: " & idVenta)

        ' Limpia los controles después de agregar la venta
        DateTimeVentas.Value = DateTime.Now ' Puedes configurar la fecha actual u otra por defecto
        TxtBoxTotalVenta.Clear()
    End Sub





    Private Sub DateTimeVentas_ValueChanged(sender As Object, e As EventArgs) Handles DateTimeVentas.ValueChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click

    End Sub


    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtnEnviar_Click(sender As Object, e As EventArgs) Handles BtnEnviar.Click

    End Sub
End Class