using System;
using System.Data;

namespace Samples
{
  /// <summary>
  /// Summary description for TransactionsDemo.
  /// </summary>
  public class TransactionsDemo : Demo
  {
    const string descriptionShort = "This sample project demonstrates working with SQLite database engine transactions in dotConnect for SQLite database engine. The sample demonstrates how to get a SQLiteTransaction object from a SQLiteConnection object, how to commit or rollback a transaction.";
    const string descriptionFull = "This sample project demonstrates working with SQLite database engine transactions in dotConnect for SQLite database engine. The sample demonstrates how to get a SQLiteTransaction object from a SQLiteConnection object, how to commit or rollback a transaction.";

    public TransactionsDemo() 
      : base("Transactions", descriptionShort, descriptionFull) {
    }

    protected override BaseDemoControl CreateDemoControl(IDbConnection connection){

      return new TransactionsDemoControl((Devart.Data.SQLite.SQLiteConnection)connection);
    }

  }
}
