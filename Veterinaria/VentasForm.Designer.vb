<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VentasForm
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
        Me.components = New System.ComponentModel.Container()
        Me.lbproductos = New System.Windows.Forms.Label()
        Me.VeterinariaDataSet = New Veterinaria.VeterinariaDataSet()
        Me.VentasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VentasTableAdapter = New Veterinaria.VeterinariaDataSetTableAdapters.VentasTableAdapter()
        Me.TableAdapterManager = New Veterinaria.VeterinariaDataSetTableAdapters.TableAdapterManager()
        Me.VentasDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnBorrarVentas = New System.Windows.Forms.Button()
        Me.BtnAgregarVenta = New System.Windows.Forms.Button()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtBoxTotalVenta = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimeVentas = New System.Windows.Forms.DateTimePicker()
        Me.BtnEnviar = New System.Windows.Forms.Button()
        CType(Me.VeterinariaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbproductos
        '
        Me.lbproductos.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbproductos.AutoSize = True
        Me.lbproductos.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbproductos.Location = New System.Drawing.Point(505, 9)
        Me.lbproductos.Name = "lbproductos"
        Me.lbproductos.Size = New System.Drawing.Size(174, 55)
        Me.lbproductos.TabIndex = 3
        Me.lbproductos.Text = "Ventas"
        Me.lbproductos.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'VeterinariaDataSet
        '
        Me.VeterinariaDataSet.DataSetName = "VeterinariaDataSet"
        Me.VeterinariaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VentasBindingSource
        '
        Me.VentasBindingSource.DataMember = "Ventas"
        Me.VentasBindingSource.DataSource = Me.VeterinariaDataSet
        '
        'VentasTableAdapter
        '
        Me.VentasTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CitasTableAdapter = Nothing
        Me.TableAdapterManager.DetalleVentaTableAdapter = Nothing
        Me.TableAdapterManager.DueñosTableAdapter = Nothing
        Me.TableAdapterManager.EmpleadosTableAdapter = Nothing
        Me.TableAdapterManager.FacturacionTableAdapter = Nothing
        Me.TableAdapterManager.HistoriasClinicasTableAdapter = Nothing
        Me.TableAdapterManager.InventarioTableAdapter = Nothing
        Me.TableAdapterManager.LogisticaTableAdapter = Nothing
        Me.TableAdapterManager.PacientesTableAdapter = Nothing
        Me.TableAdapterManager.ProveedoresTableAdapter = Nothing
        Me.TableAdapterManager.ServiciosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Veterinaria.VeterinariaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuarioTableAdapter = Nothing
        Me.TableAdapterManager.VentasTableAdapter = Me.VentasTableAdapter
        Me.TableAdapterManager.VeterinariosTableAdapter = Nothing
        '
        'VentasDataGridView
        '
        Me.VentasDataGridView.AutoGenerateColumns = False
        Me.VentasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VentasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.VentasDataGridView.DataSource = Me.VentasBindingSource
        Me.VentasDataGridView.Location = New System.Drawing.Point(416, 146)
        Me.VentasDataGridView.Name = "VentasDataGridView"
        Me.VentasDataGridView.Size = New System.Drawing.Size(345, 220)
        Me.VentasDataGridView.TabIndex = 3
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "FechaVenta"
        Me.DataGridViewTextBoxColumn2.HeaderText = "FechaVenta"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "TotalVenta"
        Me.DataGridViewTextBoxColumn3.HeaderText = "TotalVenta"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'BtnBorrarVentas
        '
        Me.BtnBorrarVentas.BackColor = System.Drawing.Color.Brown
        Me.BtnBorrarVentas.Location = New System.Drawing.Point(416, 390)
        Me.BtnBorrarVentas.Name = "BtnBorrarVentas"
        Me.BtnBorrarVentas.Size = New System.Drawing.Size(150, 41)
        Me.BtnBorrarVentas.TabIndex = 4
        Me.BtnBorrarVentas.Text = "Borrar"
        Me.BtnBorrarVentas.UseVisualStyleBackColor = False
        '
        'BtnAgregarVenta
        '
        Me.BtnAgregarVenta.BackColor = System.Drawing.Color.Green
        Me.BtnAgregarVenta.Location = New System.Drawing.Point(801, 343)
        Me.BtnAgregarVenta.Name = "BtnAgregarVenta"
        Me.BtnAgregarVenta.Size = New System.Drawing.Size(150, 41)
        Me.BtnAgregarVenta.TabIndex = 9
        Me.BtnAgregarVenta.Text = "Agregar"
        Me.BtnAgregarVenta.UseVisualStyleBackColor = False
        '
        'BtnEditar
        '
        Me.BtnEditar.BackColor = System.Drawing.Color.Gold
        Me.BtnEditar.Location = New System.Drawing.Point(801, 276)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(150, 41)
        Me.BtnEditar.TabIndex = 16
        Me.BtnEditar.Text = "Editar"
        Me.BtnEditar.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(798, 221)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Total de Venta"
        '
        'TxtBoxTotalVenta
        '
        Me.TxtBoxTotalVenta.Location = New System.Drawing.Point(801, 237)
        Me.TxtBoxTotalVenta.Name = "TxtBoxTotalVenta"
        Me.TxtBoxTotalVenta.Size = New System.Drawing.Size(100, 20)
        Me.TxtBoxTotalVenta.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(798, 158)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Fecha de Venta"
        '
        'DateTimeVentas
        '
        Me.DateTimeVentas.Location = New System.Drawing.Point(801, 174)
        Me.DateTimeVentas.Name = "DateTimeVentas"
        Me.DateTimeVentas.Size = New System.Drawing.Size(200, 20)
        Me.DateTimeVentas.TabIndex = 10
        '
        'BtnEnviar
        '
        Me.BtnEnviar.BackColor = System.Drawing.Color.DarkTurquoise
        Me.BtnEnviar.Location = New System.Drawing.Point(801, 405)
        Me.BtnEnviar.Name = "BtnEnviar"
        Me.BtnEnviar.Size = New System.Drawing.Size(150, 41)
        Me.BtnEnviar.TabIndex = 17
        Me.BtnEnviar.Text = "Enviar"
        Me.BtnEnviar.UseVisualStyleBackColor = False
        '
        'VentasForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1222, 558)
        Me.Controls.Add(Me.BtnEnviar)
        Me.Controls.Add(Me.BtnEditar)
        Me.Controls.Add(Me.DateTimeVentas)
        Me.Controls.Add(Me.BtnAgregarVenta)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtBoxTotalVenta)
        Me.Controls.Add(Me.BtnBorrarVentas)
        Me.Controls.Add(Me.VentasDataGridView)
        Me.Controls.Add(Me.lbproductos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "VentasForm"
        Me.Text = "VentasForm"
        CType(Me.VeterinariaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbproductos As Label
    Friend WithEvents VeterinariaDataSet As VeterinariaDataSet
    Friend WithEvents VentasBindingSource As BindingSource
    Friend WithEvents VentasTableAdapter As VeterinariaDataSetTableAdapters.VentasTableAdapter
    Friend WithEvents TableAdapterManager As VeterinariaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents VentasDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents BtnBorrarVentas As Button
    Friend WithEvents BtnAgregarVenta As Button
    Friend WithEvents BtnEditar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtBoxTotalVenta As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DateTimeVentas As DateTimePicker
    Friend WithEvents BtnEnviar As Button
End Class
