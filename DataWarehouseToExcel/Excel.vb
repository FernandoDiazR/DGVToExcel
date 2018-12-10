﻿Imports Microsoft.Office.Interop.Excel
Friend Module Excel

    Property OpenAfterSaved As Boolean

    Property WorkSheetName As String

    Property ExportedIndices As New List(Of Integer)

    ''' <summary>
    ''' Exportar datos de un DataGridView a un archivo de Excel (.xlsx/.xls) en la ubicación deseada.
    ''' </summary>
    ''' <param name="DGV">DataGridView que contiene los datos a exportar.</param>
    Friend Sub ExportData(ByVal DGV As DataGridView)
        Dim app As Application, wb As Workbook, ws As Worksheet
        app = New Application()
        wb = app.Workbooks.Add(Type.Missing)
        ws = Nothing

        ws = DirectCast(wb.ActiveSheet, Worksheet)
        If IsNothing(WorkSheetName) Then
            MsgBox("There's no Worksheet name assigned to the Workbook.")
            Return
        End If
        ws.Name = WorkSheetName

        If ExportedIndices.Count = 0 Then
            For index = 0 To DGV.Columns.Count - 1
                ExportedIndices.Add(index)
            Next
        End If

        Dim counter = 0
        For index = 1 To DGV.Columns.Count
            If ExportedIndices.Contains(index - 1) Then
                ws.Cells(1, index - counter) = DGV.Columns(index - 1).HeaderText
                ws.Cells(1, index - counter).Font.Bold = True
            Else
                counter = counter + 1
            End If
        Next

        For row = 0 To DGV.Rows.Count - 1
            counter = 0
            For col = 0 To DGV.Columns.Count - 1
                If ExportedIndices.Contains(col) Then
                    ws.Cells(row + 2, col + 1 - counter) = DGV.Rows(row).Cells(col).Value
                Else
                    counter = counter + 1
                End If
            Next
        Next
        ws.Columns.EntireColumn.AutoFit()
        app.DisplayAlerts = False
        SaveExcelDialog(wb)
        app.Quit()
    End Sub

    Private Sub SaveExcelDialog(ByRef WorkBookFile As Workbook)
        Dim save As New SaveFileDialog() With {
            .Title = "Save as Excel File...",
            .Filter = "Excel Workbook (2013-2016)|*.xlsx|Excel Workbook (97-2003)|*.xls",
            .FileName = "Ventas",
            .DefaultExt = ".xlsx"
        }
        If save.ShowDialog() = DialogResult.OK Then
            WorkBookFile.SaveCopyAs(save.FileName)
            WorkBookFile.Saved = True
            MsgBox("Saved Successfully!")
            If OpenAfterSaved Then
                Process.Start(save.FileName)
            End If
        Else
            WorkBookFile.Saved = False
        End If
    End Sub


End Module
