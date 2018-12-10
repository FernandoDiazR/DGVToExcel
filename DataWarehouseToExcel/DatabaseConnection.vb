Imports System.Data.SqlClient
Imports System.Text

Public Class DatabaseConnection

    Private Property sqlconnection As SqlConnection
    ''' <summary>
    ''' Obtiene o establece la ubicación del servidor de base de datos.
    ''' </summary>
    Public Property DataSource As String
    ''' <summary>
    ''' Obtiene o establece el nombre de la base de datos.
    ''' </summary>
    Public Property Database As String

    Public Sub New()

    End Sub
    Public Sub New(ByVal dataSource As String, ByVal database As String)
        Me.DataSource = dataSource
        Me.Database = database
    End Sub

    Friend Sub FILL_DGV_Ventas(ByVal DGV As DataGridView)
        Dim dt As DataTable = New DataTable()
        Using sqlconnection = InitCon()
            sqlconnection.Open()
            Dim cmd As SqlCommand = New SqlCommand("SELECT TOP 20 * FROM Vista_Ventas_DW", sqlconnection)
            Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
            da.Fill(dt)
            MyDataTableUTF8(dt)
            DGV.DataSource = dt
        End Using
    End Sub


    Private Sub MyDataTableUTF8(ByVal dt As DataTable)
        For Each dc As DataColumn In dt.Columns
            dc.ColumnName = Encoding.UTF8.GetString(Encoding.GetEncoding(1252).GetBytes(dc.ColumnName))
        Next
    End Sub

    Public Function canConnect() As Boolean
        Dim connected = True
        Try
            Using sqlconnection = InitCon()
                sqlconnection.Open()
            End Using
        Catch ex As Exception
            connected = False
        End Try
        Return connected
    End Function

    Private Function InitCon() As SqlConnection
        Return New SqlConnection("Data Source=" + DataSource + ";Initial Catalog=" + Database + ";Integrated Security=True;")
    End Function

End Class
