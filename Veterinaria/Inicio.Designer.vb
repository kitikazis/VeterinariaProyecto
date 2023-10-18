<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Inicio
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
        Me.SuspendLayout()
        '
        'Inicio
        '
        Me.ClientSize = New System.Drawing.Size(875, 423)
        Me.Name = "Inicio"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents VeterinariaDataSet As VeterinariaDataSet
    Friend WithEvents VentasBindingSource As BindingSource
    Friend WithEvents VentasTableAdapter As VeterinariaDataSetTableAdapters.VentasTableAdapter
    Friend WithEvents TableAdapterManager As VeterinariaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PictureBox1 As PictureBox
End Class
