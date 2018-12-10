Imports Microsoft.SqlServer.Management.IntegrationServices
Imports System.Data.SqlClient
Public Class DataWarehouse
    Private ReadOnly conString = "Data Source=" + ISConf.Server + ";Initial Catalog=master;Integrated Security=SSPI;"
    Public IntegrationServices As IntegrationServices
    Private Catalog As Catalog
    Private Folder As CatalogFolder
    Private Project As ProjectInfo
    Private Package As PackageInfo

    Private Sub CreateDW()
        Using con As New SqlConnection(conString)
            Me.IntegrationServices = New IntegrationServices(con)
            Me.Catalog = IntegrationServices.Catalogs("SSISDB")
            Me.Folder = Catalog.Folders(ISConf.Folder)
            Me.Project = Folder.Projects(ISConf.ProjectName)
            Me.Package = Project.Packages(ISConf.Package_CreateDW)
            Me.Package.Execute(False, Nothing)
        End Using
    End Sub

    Private Sub ImportDataToDW()
        Using con As New SqlConnection(conString)
            Me.IntegrationServices = New IntegrationServices(con)
            Me.Catalog = IntegrationServices.Catalogs("SSISDB")
            Me.Folder = Catalog.Folders(ISConf.Folder)
            Me.Project = Folder.Projects(ISConf.ProjectName)
            Me.Package = Project.Packages(ISConf.Package_Import_To_DW)
            Me.Package.Execute(False, Nothing)
        End Using
    End Sub


    Public Sub RecreateDW()
        CreateDW()
        System.Threading.Thread.Sleep(1000)
        ImportDataToDW()
        System.Threading.Thread.Sleep(3000)
    End Sub

End Class
