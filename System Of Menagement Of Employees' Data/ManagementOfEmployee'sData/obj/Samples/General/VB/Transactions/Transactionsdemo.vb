Imports Devart.Data.SQLite
Imports System
Imports System.Data

Namespace Samples
  Public Class TransactionsDemo
    Inherits Demo

    ' Fields
    Private Shadows Const descriptionFull As String = "This sample project demonstrates working with SQLite database engine transactions in dotConnect for SQLite database engine. The sample demonstrates how to get a SQLiteTransaction object from a SQLiteConnection object, how to commit or rollback a transaction."
    Private Shadows Const descriptionShort As String = "This sample project demonstrates working with SQLite database engine transactions in dotConnect for SQLite database engine. The sample demonstrates how to get a SQLiteTransaction object from a SQLiteConnection object, how to commit or rollback a transaction."

    ' Methods
    Public Sub New()
      MyBase.New("Transactions", descriptionShort, descriptionFull)
    End Sub

    Protected Overrides Function CreateDemoControl(ByVal connection As IDbConnection) As BaseDemoControl
      Return New TransactionsDemoControl(DirectCast(connection, SQLiteConnection))
    End Function
  End Class
End Namespace