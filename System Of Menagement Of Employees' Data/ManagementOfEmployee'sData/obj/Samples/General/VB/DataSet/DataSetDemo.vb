Imports Devart.Data.SQLite
Imports System
Imports System.Data

Namespace Samples
  Public Class DataSetDemo
    Inherits Demo

    ' Fields
    Private Shadows Const descriptionFull As String = "This sample project demonstrates using untyped dataset with dotConnect for SQLite database engine to review and update data. The sample uses SQLiteDataAdapter to fill a dataset and post updated data to SQLite database engine database. SQLiteDataAdapter uses SQLiteCommandBuilder class to automatically generate SQL queries for INSERT/UPDATE/DELETE operations."
    Private Shadows Const descriptionShort As String = "This sample project demonstrates using untyped dataset with dotConnect for SQLite database engine to review and update data. The sample uses SQLiteDataAdapter to fill a dataset and post updated data to SQLite database engine database. SQLiteDataAdapter uses SQLiteCommandBuilder class to automatically generate SQL queries for INSERT/UPDATE/DELETE operations."

    ' Methods
    Public Sub New()
      MyBase.New("DataSet", descriptionShort, descriptionFull, "DataSet.bmp")
    End Sub

    Protected Overrides Function CreateDemoControl(ByVal connection As IDbConnection) As BaseDemoControl
      Return New DataSetDemoControl(DirectCast(connection, SQLiteConnection))
    End Function
  End Class
End Namespace