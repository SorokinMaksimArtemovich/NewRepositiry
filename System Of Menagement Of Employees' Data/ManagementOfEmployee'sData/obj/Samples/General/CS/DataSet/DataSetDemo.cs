using System;
using System.Data;

namespace Samples
{
  /// <summary>
  /// Summary description for DataSetDemo.
  /// </summary>
  public class DataSetDemo : Demo
  {
    const string descriptionShort = "This sample project demonstrates using untyped dataset with dotConnect for SQLite database engine to review and update data. The sample uses SQLiteDataAdapter to fill a dataset and post updated data to SQLite database engine database. SQLiteDataAdapter uses SQLiteCommandBuilder class to automatically generate SQL queries for INSERT/UPDATE/DELETE operations.";
    const string descriptionFull = @"This sample project demonstrates using untyped dataset with dotConnect for SQLite database engine to review and update data. The sample uses SQLiteDataAdapter to fill a dataset and post updated data to SQLite database engine database. SQLiteDataAdapter uses SQLiteCommandBuilder class to automatically generate SQL queries for INSERT/UPDATE/DELETE operations.";

    public DataSetDemo() 
      : base("DataSet", descriptionShort, descriptionFull, "Samples.DataSet.DataSet.bmp") {
    }

    protected override BaseDemoControl CreateDemoControl(IDbConnection connection){

      return new DataSetDemoControl((Devart.Data.SQLite.SQLiteConnection)connection);
    }

  }
}
