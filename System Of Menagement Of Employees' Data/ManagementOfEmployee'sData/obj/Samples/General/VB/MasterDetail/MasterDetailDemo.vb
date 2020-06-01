Imports Devart.Data.SQLite
Imports System
Imports System.Data

Namespace Samples
  Public Class MasterDetailDemo
    Inherits Demo

    ' Fields
    Private Shadows Const descriptionFull As String = "This sample project demonstrates setting master-detail relation in an untyped dataset. The sample fills two tables in a dataset using two SQLiteDataAdapters and sets master-detail relation between them. For successfull Select/Update commands SQLiteDataAdapter requires SQLiteCommandBuilder and SQLiteCommand with a valid SQLiteConnection. After DataSet is filled, you can navigate in the top DataGrid, which shows the parent table Dept, and see rows of the child table Emp in the bottom DataGrid."
    Private Shadows Const descriptionShort As String = "This sample project demonstrates setting master-detail relation in an untyped dataset. The sample fills two tables in a dataset using SQLiteDataAdapter and sets master-detail relation between them."

    ' Methods
    Public Sub New()
      MyBase.New("MasterDetail", descriptionShort, descriptionFull, "MasterDetail.bmp")
    End Sub

    Protected Overrides Function CreateDemoControl(ByVal connection As IDbConnection) As BaseDemoControl
      Return New MasterDetailDemoControl(DirectCast(connection, SQLiteConnection))
    End Function
  End Class
End Namespace