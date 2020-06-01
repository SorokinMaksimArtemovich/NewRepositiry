Imports Devart.Data.SQLite
Imports System
Imports System.Data

Namespace Samples
  Public Class DataReaderDemo
    Inherits Demo

    ' Fields
    Private Shadows Const descriptionFull As String = "This sample project demonstrates using SQLiteDataReader class to obtain data from a query. The sample executes SQL statement at the SQLiteCommand and gets SQLiteDataReader to retrieve data." & ChrW(13) & ChrW(10) & "You can retrieve data from any existing table or from several tables like 'SELECT Ename, Hiredate, Loc FROM Dept INNER JOIN Emp ON Emp.DeptNo = Dept.DeptNo'. Just write the correct SQL query at the top area and click 'Execute' button."
    Private Shadows Const descriptionShort As String = "This sample project demonstrates using SQLiteDataReader class to obtain data from a query. The sample executes SQL statement at the SQLiteCommand and gets SQLiteDataReader to retrieve data."

    ' Methods
    Public Sub New()
      MyBase.New("DataReader", descriptionShort, descriptionFull)
    End Sub

    Protected Overrides Function CreateDemoControl(ByVal connection As IDbConnection) As BaseDemoControl
      Return New DataReaderDemoControl(DirectCast(connection, SQLiteConnection))
    End Function
  End Class
End Namespace