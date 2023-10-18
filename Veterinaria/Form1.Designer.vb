<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.BarraTitulo = New System.Windows.Forms.Panel()
        Me.BtnRestaurar = New System.Windows.Forms.PictureBox()
        Me.BtnMaximizar = New System.Windows.Forms.PictureBox()
        Me.BtnMinimizar = New System.Windows.Forms.PictureBox()
        Me.BtnCerrar = New System.Windows.Forms.PictureBox()
        Me.MenuVertical = New System.Windows.Forms.Panel()
        Me.SubMenuReportes = New System.Windows.Forms.Panel()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.BtnPagos = New System.Windows.Forms.Button()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.BtnCompras = New System.Windows.Forms.Button()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.BtnVentas = New System.Windows.Forms.Button()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.BtnReportes = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Btn_Pagos = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Btn_Empleados = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.BtnCompra = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BtnClientes = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtnVenta = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnProductos = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelContendor = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BarraTitulo.SuspendLayout()
        CType(Me.BtnRestaurar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnMaximizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuVertical.SuspendLayout()
        Me.SubMenuReportes.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BarraTitulo
        '
        Me.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.BarraTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BarraTitulo.Controls.Add(Me.Label1)
        Me.BarraTitulo.Controls.Add(Me.BtnRestaurar)
        Me.BarraTitulo.Controls.Add(Me.BtnMaximizar)
        Me.BarraTitulo.Controls.Add(Me.BtnMinimizar)
        Me.BarraTitulo.Controls.Add(Me.BtnCerrar)
        Me.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarraTitulo.Location = New System.Drawing.Point(0, 0)
        Me.BarraTitulo.Name = "BarraTitulo"
        Me.BarraTitulo.Size = New System.Drawing.Size(1300, 38)
        Me.BarraTitulo.TabIndex = 0
        '
        'BtnRestaurar
        '
        Me.BtnRestaurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRestaurar.Image = CType(resources.GetObject("BtnRestaurar.Image"), System.Drawing.Image)
        Me.BtnRestaurar.Location = New System.Drawing.Point(1230, 7)
        Me.BtnRestaurar.Name = "BtnRestaurar"
        Me.BtnRestaurar.Size = New System.Drawing.Size(25, 25)
        Me.BtnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnRestaurar.TabIndex = 2
        Me.BtnRestaurar.TabStop = False
        Me.BtnRestaurar.Visible = False
        '
        'BtnMaximizar
        '
        Me.BtnMaximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnMaximizar.Image = CType(resources.GetObject("BtnMaximizar.Image"), System.Drawing.Image)
        Me.BtnMaximizar.Location = New System.Drawing.Point(1230, 7)
        Me.BtnMaximizar.Name = "BtnMaximizar"
        Me.BtnMaximizar.Size = New System.Drawing.Size(25, 25)
        Me.BtnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnMaximizar.TabIndex = 2
        Me.BtnMaximizar.TabStop = False
        '
        'BtnMinimizar
        '
        Me.BtnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnMinimizar.Image = CType(resources.GetObject("BtnMinimizar.Image"), System.Drawing.Image)
        Me.BtnMinimizar.Location = New System.Drawing.Point(1199, 7)
        Me.BtnMinimizar.Name = "BtnMinimizar"
        Me.BtnMinimizar.Size = New System.Drawing.Size(25, 25)
        Me.BtnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnMinimizar.TabIndex = 1
        Me.BtnMinimizar.TabStop = False
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCerrar.Image = CType(resources.GetObject("BtnCerrar.Image"), System.Drawing.Image)
        Me.BtnCerrar.Location = New System.Drawing.Point(1261, 7)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(25, 25)
        Me.BtnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnCerrar.TabIndex = 0
        Me.BtnCerrar.TabStop = False
        '
        'MenuVertical
        '
        Me.MenuVertical.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.MenuVertical.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MenuVertical.Controls.Add(Me.SubMenuReportes)
        Me.MenuVertical.Controls.Add(Me.Panel7)
        Me.MenuVertical.Controls.Add(Me.BtnReportes)
        Me.MenuVertical.Controls.Add(Me.Panel6)
        Me.MenuVertical.Controls.Add(Me.Btn_Pagos)
        Me.MenuVertical.Controls.Add(Me.Panel5)
        Me.MenuVertical.Controls.Add(Me.Btn_Empleados)
        Me.MenuVertical.Controls.Add(Me.Panel4)
        Me.MenuVertical.Controls.Add(Me.BtnCompra)
        Me.MenuVertical.Controls.Add(Me.Panel3)
        Me.MenuVertical.Controls.Add(Me.BtnClientes)
        Me.MenuVertical.Controls.Add(Me.Panel2)
        Me.MenuVertical.Controls.Add(Me.BtnVenta)
        Me.MenuVertical.Controls.Add(Me.Panel1)
        Me.MenuVertical.Controls.Add(Me.BtnProductos)
        Me.MenuVertical.Controls.Add(Me.PictureBox1)
        Me.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuVertical.Location = New System.Drawing.Point(0, 38)
        Me.MenuVertical.Name = "MenuVertical"
        Me.MenuVertical.Size = New System.Drawing.Size(220, 612)
        Me.MenuVertical.TabIndex = 1
        '
        'SubMenuReportes
        '
        Me.SubMenuReportes.Controls.Add(Me.Panel11)
        Me.SubMenuReportes.Controls.Add(Me.BtnPagos)
        Me.SubMenuReportes.Controls.Add(Me.Panel10)
        Me.SubMenuReportes.Controls.Add(Me.BtnCompras)
        Me.SubMenuReportes.Controls.Add(Me.Panel9)
        Me.SubMenuReportes.Controls.Add(Me.BtnVentas)
        Me.SubMenuReportes.Location = New System.Drawing.Point(57, 499)
        Me.SubMenuReportes.Name = "SubMenuReportes"
        Me.SubMenuReportes.Size = New System.Drawing.Size(162, 112)
        Me.SubMenuReportes.TabIndex = 0
        Me.SubMenuReportes.Visible = False
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Panel11.Location = New System.Drawing.Point(0, 72)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(5, 28)
        Me.Panel11.TabIndex = 11
        '
        'BtnPagos
        '
        Me.BtnPagos.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BtnPagos.FlatAppearance.BorderSize = 0
        Me.BtnPagos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.BtnPagos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPagos.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPagos.ForeColor = System.Drawing.Color.White
        Me.BtnPagos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnPagos.Location = New System.Drawing.Point(3, 72)
        Me.BtnPagos.Name = "BtnPagos"
        Me.BtnPagos.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.BtnPagos.Size = New System.Drawing.Size(159, 28)
        Me.BtnPagos.TabIndex = 10
        Me.BtnPagos.Text = "Reporte Pagos"
        Me.BtnPagos.UseVisualStyleBackColor = False
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Panel10.Location = New System.Drawing.Point(0, 37)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(5, 28)
        Me.Panel10.TabIndex = 11
        '
        'BtnCompras
        '
        Me.BtnCompras.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BtnCompras.FlatAppearance.BorderSize = 0
        Me.BtnCompras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.BtnCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCompras.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCompras.ForeColor = System.Drawing.Color.White
        Me.BtnCompras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCompras.Location = New System.Drawing.Point(3, 37)
        Me.BtnCompras.Name = "BtnCompras"
        Me.BtnCompras.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.BtnCompras.Size = New System.Drawing.Size(159, 28)
        Me.BtnCompras.TabIndex = 10
        Me.BtnCompras.Text = "Reporte Compras"
        Me.BtnCompras.UseVisualStyleBackColor = False
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Panel9.Location = New System.Drawing.Point(0, 3)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(5, 28)
        Me.Panel9.TabIndex = 9
        '
        'BtnVentas
        '
        Me.BtnVentas.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BtnVentas.FlatAppearance.BorderSize = 0
        Me.BtnVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.BtnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnVentas.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVentas.ForeColor = System.Drawing.Color.White
        Me.BtnVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnVentas.Location = New System.Drawing.Point(3, 3)
        Me.BtnVentas.Name = "BtnVentas"
        Me.BtnVentas.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.BtnVentas.Size = New System.Drawing.Size(159, 28)
        Me.BtnVentas.TabIndex = 8
        Me.BtnVentas.Text = "Reporte Ventas"
        Me.BtnVentas.UseVisualStyleBackColor = False
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Panel7.Location = New System.Drawing.Point(3, 461)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(5, 32)
        Me.Panel7.TabIndex = 7
        '
        'BtnReportes
        '
        Me.BtnReportes.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BtnReportes.FlatAppearance.BorderSize = 0
        Me.BtnReportes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.BtnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnReportes.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReportes.ForeColor = System.Drawing.Color.White
        Me.BtnReportes.Image = CType(resources.GetObject("BtnReportes.Image"), System.Drawing.Image)
        Me.BtnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnReportes.Location = New System.Drawing.Point(6, 461)
        Me.BtnReportes.Name = "BtnReportes"
        Me.BtnReportes.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.BtnReportes.Size = New System.Drawing.Size(213, 32)
        Me.BtnReportes.TabIndex = 6
        Me.BtnReportes.Text = "Reportes"
        Me.BtnReportes.UseVisualStyleBackColor = False
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Panel6.Location = New System.Drawing.Point(3, 414)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(5, 32)
        Me.Panel6.TabIndex = 7
        '
        'Btn_Pagos
        '
        Me.Btn_Pagos.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Btn_Pagos.FlatAppearance.BorderSize = 0
        Me.Btn_Pagos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Btn_Pagos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Pagos.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Pagos.ForeColor = System.Drawing.Color.White
        Me.Btn_Pagos.Image = CType(resources.GetObject("Btn_Pagos.Image"), System.Drawing.Image)
        Me.Btn_Pagos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Pagos.Location = New System.Drawing.Point(6, 414)
        Me.Btn_Pagos.Name = "Btn_Pagos"
        Me.Btn_Pagos.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Btn_Pagos.Size = New System.Drawing.Size(213, 32)
        Me.Btn_Pagos.TabIndex = 6
        Me.Btn_Pagos.Text = "Pagos"
        Me.Btn_Pagos.UseVisualStyleBackColor = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Panel5.Location = New System.Drawing.Point(3, 365)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(5, 32)
        Me.Panel5.TabIndex = 7
        '
        'Btn_Empleados
        '
        Me.Btn_Empleados.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Btn_Empleados.FlatAppearance.BorderSize = 0
        Me.Btn_Empleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Btn_Empleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Empleados.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Empleados.ForeColor = System.Drawing.Color.White
        Me.Btn_Empleados.Image = CType(resources.GetObject("Btn_Empleados.Image"), System.Drawing.Image)
        Me.Btn_Empleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Empleados.Location = New System.Drawing.Point(6, 365)
        Me.Btn_Empleados.Name = "Btn_Empleados"
        Me.Btn_Empleados.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Btn_Empleados.Size = New System.Drawing.Size(213, 32)
        Me.Btn_Empleados.TabIndex = 6
        Me.Btn_Empleados.Text = "Empleados"
        Me.Btn_Empleados.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Panel4.Location = New System.Drawing.Point(3, 316)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(5, 32)
        Me.Panel4.TabIndex = 7
        '
        'BtnCompra
        '
        Me.BtnCompra.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BtnCompra.FlatAppearance.BorderSize = 0
        Me.BtnCompra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.BtnCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCompra.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCompra.ForeColor = System.Drawing.Color.White
        Me.BtnCompra.Image = CType(resources.GetObject("BtnCompra.Image"), System.Drawing.Image)
        Me.BtnCompra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCompra.Location = New System.Drawing.Point(6, 316)
        Me.BtnCompra.Name = "BtnCompra"
        Me.BtnCompra.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.BtnCompra.Size = New System.Drawing.Size(213, 32)
        Me.BtnCompra.TabIndex = 6
        Me.BtnCompra.Text = "Compras"
        Me.BtnCompra.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(3, 265)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(5, 32)
        Me.Panel3.TabIndex = 7
        '
        'BtnClientes
        '
        Me.BtnClientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BtnClientes.FlatAppearance.BorderSize = 0
        Me.BtnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.BtnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClientes.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClientes.ForeColor = System.Drawing.Color.White
        Me.BtnClientes.Image = CType(resources.GetObject("BtnClientes.Image"), System.Drawing.Image)
        Me.BtnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnClientes.Location = New System.Drawing.Point(6, 265)
        Me.BtnClientes.Name = "BtnClientes"
        Me.BtnClientes.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.BtnClientes.Size = New System.Drawing.Size(213, 32)
        Me.BtnClientes.TabIndex = 6
        Me.BtnClientes.Text = "Clientes"
        Me.BtnClientes.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(3, 218)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(5, 32)
        Me.Panel2.TabIndex = 5
        '
        'BtnVenta
        '
        Me.BtnVenta.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BtnVenta.FlatAppearance.BorderSize = 0
        Me.BtnVenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.BtnVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnVenta.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVenta.ForeColor = System.Drawing.Color.White
        Me.BtnVenta.Image = CType(resources.GetObject("BtnVenta.Image"), System.Drawing.Image)
        Me.BtnVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnVenta.Location = New System.Drawing.Point(6, 218)
        Me.BtnVenta.Name = "BtnVenta"
        Me.BtnVenta.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.BtnVenta.Size = New System.Drawing.Size(213, 32)
        Me.BtnVenta.TabIndex = 4
        Me.BtnVenta.Text = "Ventas"
        Me.BtnVenta.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(3, 171)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(5, 32)
        Me.Panel1.TabIndex = 3
        '
        'BtnProductos
        '
        Me.BtnProductos.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BtnProductos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnProductos.FlatAppearance.BorderSize = 0
        Me.BtnProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.BtnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnProductos.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnProductos.ForeColor = System.Drawing.Color.White
        Me.BtnProductos.Image = CType(resources.GetObject("BtnProductos.Image"), System.Drawing.Image)
        Me.BtnProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnProductos.Location = New System.Drawing.Point(6, 171)
        Me.BtnProductos.Name = "BtnProductos"
        Me.BtnProductos.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.BtnProductos.Size = New System.Drawing.Size(213, 32)
        Me.BtnProductos.TabIndex = 1
        Me.BtnProductos.Text = "Productos"
        Me.BtnProductos.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.Veterinaria.My.Resources.Resources._20230921_124537
        Me.PictureBox1.Location = New System.Drawing.Point(12, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(193, 151)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PanelContendor
        '
        Me.PanelContendor.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.PanelContendor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContendor.Location = New System.Drawing.Point(220, 38)
        Me.PanelContendor.Name = "PanelContendor"
        Me.PanelContendor.Size = New System.Drawing.Size(1080, 612)
        Me.PanelContendor.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.CausesValidation = False
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label1.Location = New System.Drawing.Point(559, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(183, 37)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Veterinaria"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1300, 650)
        Me.Controls.Add(Me.PanelContendor)
        Me.Controls.Add(Me.MenuVertical)
        Me.Controls.Add(Me.BarraTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.BarraTitulo.ResumeLayout(False)
        Me.BarraTitulo.PerformLayout()
        CType(Me.BtnRestaurar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnMaximizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuVertical.ResumeLayout(False)
        Me.SubMenuReportes.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BarraTitulo As Panel
    Friend WithEvents MenuVertical As Panel
    Friend WithEvents PanelContendor As Panel
    Friend WithEvents BtnCerrar As PictureBox
    Friend WithEvents BtnMinimizar As PictureBox
    Friend WithEvents BtnMaximizar As PictureBox
    Friend WithEvents BtnRestaurar As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnProductos As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents BtnReportes As Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Btn_Pagos As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Btn_Empleados As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents BtnCompra As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents BtnClientes As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtnVenta As Button
    Friend WithEvents SubMenuReportes As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents BtnVentas As Button
    Friend WithEvents Panel11 As Panel
    Friend WithEvents BtnPagos As Button
    Friend WithEvents Panel10 As Panel
    Friend WithEvents BtnCompras As Button
    Private WithEvents Label1 As Label
End Class
