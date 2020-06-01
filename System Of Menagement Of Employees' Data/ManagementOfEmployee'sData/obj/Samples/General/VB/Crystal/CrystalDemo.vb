Imports Devart.Data.SQLite
Imports System
Imports System.Data

Namespace Samples
  Public Class CrystalDemo
    Inherits Demo

    ' Fields
    Private Shadows Const descriptionFull As String = "This sample project demonstrates using dotConnect for SQLite database engine for generating reports with Crystal Report."
    Private Shadows Const descriptionShort As String = "This sample project demonstrates using dotConnect for SQLite database engine for generating reports with Crystal Report."

    ' Methods
    Public Sub New()
      MyBase.New("Crystal", descriptionShort, descriptionFull, "Crystal.bmp")
    End Sub

    Protected Overrides Function CreateDemoControl(ByVal connection As IDbConnection) As BaseDemoControl
      Return New CrystalDemoControl(DirectCast(connection, SQLiteConnection))
    End Function
  End Class
End Namespace