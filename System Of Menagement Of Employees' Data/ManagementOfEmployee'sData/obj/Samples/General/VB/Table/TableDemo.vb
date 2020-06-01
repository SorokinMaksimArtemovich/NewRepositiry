Imports Devart.Data.SQLite
Imports System
Imports System.Data

Namespace Samples
  Public Class TableDemo
    Inherits Demo

    ' Fields
    Private Shadows Const descriptionFull As String = "This sample project demonstrates data mapping from SQLite database engine tables. The sample sets CommandType property of SQLiteCommand to TableDirect to access data from the table."
    Private Shadows Const descriptionShort As String = "This sample project demonstrates data mapping from SQLite database engine tables. The sample sets CommandType property of SQLiteCommand to TableDirect to access data from the table."

    ' Methods
    Public Sub New()
      MyBase.New("Table", descriptionShort, descriptionFull)
    End Sub

    Protected Overrides Function CreateDemoControl(ByVal connection As IDbConnection) As BaseDemoControl
      Return New TableDemoControl(DirectCast(connection, SQLiteConnection))
    End Function
  End Class
End Namespace