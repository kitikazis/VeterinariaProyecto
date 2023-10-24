Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports System.Drawing
Imports System.Runtime.Remoting.Messaging

Public Class Interfaz
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles BarraTitulo.Paint


    End Sub

    Private Sub Panel1_Paint_1(sender As Object, e As PaintEventArgs) Handles MenuVertical.Paint

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click

        Application.Exit()

    End Sub

    Private Sub PanelContendor_Paint(sender As Object, e As PaintEventArgs) Handles PanelContendor.Paint

    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles BtnMaximizar.Click
        Me.WindowState = FormWindowState.Maximized
        BtnMaximizar.Visible = False
        BtnRestaurar.Visible = True
    End Sub

    Private Sub BtnMinimizar_Click(sender As Object, e As EventArgs) Handles BtnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized

    End Sub

    Private Sub PictureBox1_Click_2(sender As Object, e As EventArgs) Handles BtnRestaurar.Click
        Me.WindowState = FormWindowState.Normal
        BtnRestaurar.Visible = False
        BtnMaximizar.Visible = True


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnProductos.Click
        AbrirFormHija(New FormProductos())
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnClientes.Click
        AbrirFormHija(New FormClientesUwu())
    End Sub
    Private isDragging As Boolean = False
    Private mouseOffset As Point
    Private Sub BarraTitulo_MouseDown(sender As Object, e As MouseEventArgs) Handles BarraTitulo.MouseDown
        If e.Button = MouseButtons.Left Then
            isDragging = True
            mouseOffset = e.Location
        End If
    End Sub

    Private Sub BarraTitulo_MouseMove(sender As Object, e As MouseEventArgs) Handles BarraTitulo.MouseMove
        If isDragging Then
            Dim newLocation As Point = e.Location + Me.Location - mouseOffset
            Me.Location = newLocation
        End If
    End Sub

    Private Sub BarraTitulo_MouseUp(sender As Object, e As MouseEventArgs) Handles BarraTitulo.MouseUp
        isDragging = False
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles BtnVentas.Click
        AbrirFormHija(New ReporteVentasForm())
        SubMenuReportes.Visible = False
    End Sub

    Private Sub BtnReportes_Click(sender As Object, e As EventArgs) Handles BtnReportes.Click

        SubMenuReportes.Visible = True

    End Sub

    Private Sub BtnCompras_Click(sender As Object, e As EventArgs) Handles BtnCompras.Click
        AbrirFormHija(New ReporteComprasForm())
        SubMenuReportes.Visible = False
    End Sub



    Private Sub SubMenuReportes_Paint(sender As Object, e As PaintEventArgs) Handles SubMenuReportes.Paint

    End Sub


    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles BtnVenta.Click
        AbrirFormHija(New FormVentas())
    End Sub

    Private Sub PictureBox1_Click_3(sender As Object, e As EventArgs) Handles PictureBox1.Click
        ' AbrirFormHija(New ReturnMessage())
    End Sub
    Private Sub AbrirFormHija(ByVal formHija As Object)
        If Me.PanelContendor.Controls.Count > 0 Then
            Me.PanelContendor.Controls.RemoveAt(0)
        End If

        Dim fh As Form = TryCast(formHija, Form)
        fh.TopLevel = False
        fh.Dock = DockStyle.Fill
        Me.PanelContendor.Controls.Add(fh)
        Me.PanelContendor.Tag = fh
        fh.Show()
    End Sub

    Private Sub BtnCompra_Click(sender As Object, e As EventArgs) Handles BtnCompra.Click
        AbrirFormHija(New FormCompras())
    End Sub

    Private Sub Btn_Empleados_Click(sender As Object, e As EventArgs) Handles Btn_Empleados.Click
        AbrirFormHija(New FormEmpleados())
    End Sub


    Private Sub Btn_Pagos_Click(sender As Object, e As EventArgs) Handles Btn_Pagos.Click
        AbrirFormHija(New FormPagos())
    End Sub

    Private Sub BtnPagos_Click(sender As Object, e As EventArgs) Handles BtnPagos.Click
        AbrirFormHija(New ReportePagosForm)
    End Sub
End Class
