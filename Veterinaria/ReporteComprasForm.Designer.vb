﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReporteComprasForm
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lbproductos = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbproductos
        '
        Me.lbproductos.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbproductos.AutoSize = True
        Me.lbproductos.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbproductos.Location = New System.Drawing.Point(232, 9)
        Me.lbproductos.Name = "lbproductos"
        Me.lbproductos.Size = New System.Drawing.Size(405, 55)
        Me.lbproductos.TabIndex = 4
        Me.lbproductos.Text = "Reporte Compras"
        Me.lbproductos.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ReporteComprasForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lbproductos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ReporteComprasForm"
        Me.Text = "ReporteComprasForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbproductos As Label
End Class
