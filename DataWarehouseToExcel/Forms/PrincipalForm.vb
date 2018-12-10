Public Class PrincipalForm


    Private DW As New DataWarehouse()
    Private con As New DatabaseConnection("ICHI\SQLDEVELOPER2016", "DW_VIVERO")
    Private limit As Integer = 1

    Private Sub PrincipalForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If con.canConnect() Then
            RefreshDGV()
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
        Excel.LimitRows = Me.limit

        If SelectExportForm.IsAccepted Then
            Excel.ExportData(DGV_Ventas)
        Else
            MsgBox("Se ha cancelado la selección.")
        End If
    End Sub

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Application.Exit()
    End Sub

    Private Sub RefreshBtn_Click(sender As Object, e As EventArgs) Handles RefreshBtn.Click
        Try
            RefreshDGV()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub RefreshDGV()
        If con.canConnect Then
            con.FILL_DGV_Ventas(DGV_Ventas)
        End If
    End Sub

    Private Sub RecrearDWToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RecrearDWToolStripMenuItem.Click
        Try
            DW.RecreateDW()
            MsgBox("Data Warehouse recreada.")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CambiarLimiteAExportarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CambiarLimiteAExportarToolStripMenuItem.Click
        Dim res = InputBox("Ingrese el nuevo límite para exportar en Excel: ", "Cambiar límite", Me.limit)
        Dim newLimit As Integer
        If Integer.TryParse(res, newLimit) Then
            If newLimit < 1 Then
                MsgBox("Nuevo límite no puede ser inferior a 1.")
            Else
                Me.limit = newLimit
            End If
        Else
            MsgBox("El dato ingresado no corresponde a un número válido.")
        End If
    End Sub
End Class
