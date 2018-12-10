<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExportingToExcelForm
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
        Me.SourceColumnsListBox = New System.Windows.Forms.ListBox()
        Me.OutputColumnsListBox = New System.Windows.Forms.ListBox()
        Me.ToOutputBtn = New System.Windows.Forms.Button()
        Me.ToSourceBtn = New System.Windows.Forms.Button()
        Me.CancelBtn = New System.Windows.Forms.Button()
        Me.AcceptBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'SourceColumnsListBox
        '
        Me.SourceColumnsListBox.FormattingEnabled = True
        Me.SourceColumnsListBox.Location = New System.Drawing.Point(12, 12)
        Me.SourceColumnsListBox.Name = "SourceColumnsListBox"
        Me.SourceColumnsListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.SourceColumnsListBox.Size = New System.Drawing.Size(208, 225)
        Me.SourceColumnsListBox.TabIndex = 0
        '
        'OutputColumnsListBox
        '
        Me.OutputColumnsListBox.FormattingEnabled = True
        Me.OutputColumnsListBox.Location = New System.Drawing.Point(284, 12)
        Me.OutputColumnsListBox.Name = "OutputColumnsListBox"
        Me.OutputColumnsListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.OutputColumnsListBox.Size = New System.Drawing.Size(208, 225)
        Me.OutputColumnsListBox.TabIndex = 1
        '
        'ToOutputBtn
        '
        Me.ToOutputBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToOutputBtn.Location = New System.Drawing.Point(226, 60)
        Me.ToOutputBtn.Name = "ToOutputBtn"
        Me.ToOutputBtn.Size = New System.Drawing.Size(51, 39)
        Me.ToOutputBtn.TabIndex = 2
        Me.ToOutputBtn.Text = "=>"
        Me.ToOutputBtn.UseVisualStyleBackColor = True
        '
        'ToSourceBtn
        '
        Me.ToSourceBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToSourceBtn.Location = New System.Drawing.Point(227, 134)
        Me.ToSourceBtn.Name = "ToSourceBtn"
        Me.ToSourceBtn.Size = New System.Drawing.Size(51, 39)
        Me.ToSourceBtn.TabIndex = 3
        Me.ToSourceBtn.Text = "<="
        Me.ToSourceBtn.UseVisualStyleBackColor = True
        '
        'CancelBtn
        '
        Me.CancelBtn.Location = New System.Drawing.Point(439, 266)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(75, 23)
        Me.CancelBtn.TabIndex = 4
        Me.CancelBtn.Text = "Cancel"
        Me.CancelBtn.UseVisualStyleBackColor = True
        '
        'AcceptBtn
        '
        Me.AcceptBtn.Location = New System.Drawing.Point(335, 266)
        Me.AcceptBtn.Name = "AcceptBtn"
        Me.AcceptBtn.Size = New System.Drawing.Size(75, 23)
        Me.AcceptBtn.TabIndex = 5
        Me.AcceptBtn.Text = "Accept"
        Me.AcceptBtn.UseVisualStyleBackColor = True
        '
        'ExportingToExcelForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(556, 313)
        Me.ControlBox = False
        Me.Controls.Add(Me.AcceptBtn)
        Me.Controls.Add(Me.CancelBtn)
        Me.Controls.Add(Me.ToSourceBtn)
        Me.Controls.Add(Me.ToOutputBtn)
        Me.Controls.Add(Me.OutputColumnsListBox)
        Me.Controls.Add(Me.SourceColumnsListBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "ExportingToExcelForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Selecting data to export..."
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SourceColumnsListBox As ListBox
    Friend WithEvents OutputColumnsListBox As ListBox
    Friend WithEvents ToOutputBtn As Button
    Friend WithEvents ToSourceBtn As Button
    Friend WithEvents CancelBtn As Button
    Friend WithEvents AcceptBtn As Button
End Class
