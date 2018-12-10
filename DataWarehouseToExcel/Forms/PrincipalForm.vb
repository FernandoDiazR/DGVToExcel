Public Class PrincipalForm

    Private DW As New DataWarehouse()
    Private con As New DatabaseConnection("ICHI\SQLDEVELOPER2016", "DW_VIVERO")

    Private Sub PrincipalForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If con.canConnect() Then
            con.FILL_DGV_Ventas(DGV_Ventas)
        Else
            MsgBox("No se pudo conectar")
        End If
    End Sub

    Private Sub ExportBtn_Click(sender As Object, e As EventArgs) Handles ExportBtn.Click
        Excel.WorkSheetName = "ProductosVendidos"
        Excel.OpenAfterSaved = True

        Dim dic As New Dictionary(Of Integer, String)
        For index = 0 To DGV_Ventas.Columns.Count - 1
            dic.Add(index, DGV_Ventas.Columns(index).HeaderText)
        Next

        Dim SelectExportForm = New ExportingToExcelForm(dic)

        SelectExportForm.ShowDialog()

        Excel.ExportedIndices = SelectExportForm.IndicesToExport()

        If SelectExportForm.IsAccepted Then
            Excel.ExportData(DGV_Ventas)
        Else
            MsgBox("Se ha cancelado la selección.")
        End If
    End Sub

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Application.Exit()
    End Sub
End Class
