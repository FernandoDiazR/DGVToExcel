﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PrincipalForm
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
        Me.DGV_Ventas = New System.Windows.Forms.DataGridView()
        Me.ExportBtn = New System.Windows.Forms.Button()
        Me.ExitBtn = New System.Windows.Forms.Button()
        CType(Me.DGV_Ventas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGV_Ventas
        '
        Me.DGV_Ventas.AllowUserToAddRows = False
        Me.DGV_Ventas.AllowUserToDeleteRows = False
        Me.DGV_Ventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Ventas.Location = New System.Drawing.Point(12, 91)
        Me.DGV_Ventas.Name = "DGV_Ventas"
        Me.DGV_Ventas.ReadOnly = True
        Me.DGV_Ventas.RowHeadersVisible = False
        Me.DGV_Ventas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Ventas.Size = New System.Drawing.Size(822, 385)
        Me.DGV_Ventas.TabIndex = 0
        '
        'ExportBtn
        '
        Me.ExportBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExportBtn.Location = New System.Drawing.Point(324, 482)
        Me.ExportBtn.Name = "ExportBtn"
        Me.ExportBtn.Size = New System.Drawing.Size(159, 41)
        Me.ExportBtn.TabIndex = 1
        Me.ExportBtn.Text = "Exportar a excel"
        Me.ExportBtn.UseVisualStyleBackColor = True
        '
        'ExitBtn
        '
        Me.ExitBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitBtn.Location = New System.Drawing.Point(728, 482)
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.Size = New System.Drawing.Size(106, 41)
        Me.ExitBtn.TabIndex = 2
        Me.ExitBtn.Text = "Salir"
        Me.ExitBtn.UseVisualStyleBackColor = True
        '
        'PrincipalForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(850, 530)
        Me.ControlBox = False
        Me.Controls.Add(Me.ExitBtn)
        Me.Controls.Add(Me.ExportBtn)
        Me.Controls.Add(Me.DGV_Ventas)
        Me.Name = "PrincipalForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ventana Principal"
        CType(Me.DGV_Ventas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DGV_Ventas As DataGridView
    Friend WithEvents ExportBtn As Button
    Friend WithEvents ExitBtn As Button
End Class
