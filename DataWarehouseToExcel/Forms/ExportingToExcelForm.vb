Public Class ExportingToExcelForm

    Private source As Dictionary(Of Integer, String)
    Private output As New Dictionary(Of Integer, String)

    Friend IsAccepted = False

    Public Sub New(ByVal source As Dictionary(Of Integer, String))
        InitializeComponent()
        Me.source = source
        ToSourceBtn.Enabled = False
    End Sub

    Private Sub ExportingToExcelForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitDataSources()
    End Sub

    Private Sub ToOutputBtn_Click(sender As Object, e As EventArgs) Handles ToOutputBtn.Click
        Dim selected As IList = SourceColumnsListBox.SelectedItems
        If selected.Count > 0 Then
            For Each element In selected
                source.Remove(element.Key)
                addToDictionary(element, output)
            Next
            UpdateSource()
            UpdateButtons()
        End If
    End Sub

    Private Sub ToSourceBtn_Click(sender As Object, e As EventArgs) Handles ToSourceBtn.Click
        Dim selected As IList = OutputColumnsListBox.SelectedItems
        If selected.Count > 0 Then
            For Each element In selected
                output.Remove(element.Key)
                addToDictionary(element, source)
            Next
            UpdateSource()
            UpdateButtons()
        End If
    End Sub

    Private Sub CancelBtn_Click(sender As Object, e As EventArgs) Handles CancelBtn.Click
        IsAccepted = False
        Me.Dispose()
    End Sub

    Private Sub AcceptBtn_Click(sender As Object, e As EventArgs) Handles AcceptBtn.Click
        IsAccepted = True
        Me.Dispose()
    End Sub

    Private Sub addToDictionary(ByVal element As Object, ByRef dictionary As Dictionary(Of Integer, String))
        If Not dictionary.ContainsKey(element.Key) Then
            dictionary.Add(element.Key, element.Value)
        End If
    End Sub

    Private Sub UpdateSource()
        OrderDictionary(source)
        OrderDictionary(output)
        OutputColumnsListBox.DataSource = output.ToList()
        SourceColumnsListBox.DataSource = source.ToList()
    End Sub

    Private Sub InitDataSources()
        SourceColumnsListBox.DataSource = source.ToList()
        SourceColumnsListBox.ValueMember = "Key"
        SourceColumnsListBox.DisplayMember = "Value"
        OutputColumnsListBox.DataSource = output.ToList()
        OutputColumnsListBox.ValueMember = "Key"
        OutputColumnsListBox.DisplayMember = "Value"
    End Sub

    Private Sub UpdateButtons()
        ToOutputBtn.Enabled = (SourceColumnsListBox.Items.Count > 0)
        ToSourceBtn.Enabled = (OutputColumnsListBox.Items.Count > 0)
    End Sub

    Private Sub OrderDictionary(ByRef dataCollection As Dictionary(Of Integer, String))
        Dim data = From dat In dataCollection
                   Order By dat.Key
        dataCollection = data.ToDictionary(Function(d) d.Key, Function(d) d.Value)
    End Sub

    Friend Function IndicesToExport() As List(Of Integer)
        Return output.Keys.ToList
    End Function

End Class