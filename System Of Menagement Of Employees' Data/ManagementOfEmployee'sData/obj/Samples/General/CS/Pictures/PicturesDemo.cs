using System;
using System.Data;

namespace Samples
{
  /// <summary>
  /// Summary description for PicturesDemo.
  /// </summary>
  public class PicturesDemo : Demo
  {
    const string descriptionShort = "This sample project demonstrates using dotConnect for SQLite database engine for working with BLOB objects as graphics. The sample demonstrates how to retrieve binary data from SQLite database engine database and display it at the monitor, load and save pictures into the file and the database.";
    const string descriptionFull = @"This sample project demonstrates using dotConnect for SQLite database engine for working with BLOB objects as graphics. The sample demonstrates how to retrieve binary data from SQLite database engine database and display it at the monitor, load and save pictures into the file and the database.";

    public PicturesDemo() 
      : base("Pictures", descriptionShort, descriptionFull) {
    }

    protected override BaseDemoControl CreateDemoControl(IDbConnection connection){

      return new PicturesDemoControl((Devart.Data.SQLite.SQLiteConnection)connection);
    }

    public override string CreateSql {
      get {
        return @"CREATE TABLE sqlitenet_pictures (
      UID INTEGER PRIMARY KEY AUTOINCREMENT,
      NAME VARCHAR(50),
      PICTURE BLOB
      );";
      }
    }

    public override string DropSql {
      get {
        return @"DROP TABLE sqlitenet_pictures;";
      }
    }
  }
}
