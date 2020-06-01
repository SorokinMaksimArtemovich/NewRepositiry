using System;
using System.Collections;

namespace Samples
{
  /// <summary>
  /// Summary description for MainForm.
  /// </summary>
  public class MainForm : MainFormBase
  {
    private Devart.Data.SQLite.SQLiteMonitor monitor;
    private Devart.Data.SQLite.SQLiteScript scriptDrop;
    private Devart.Data.SQLite.SQLiteScript scriptCreate;
    private Devart.Data.SQLite.SQLiteConnection myConnection;
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.Container components = null;

    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main() {

      MainFormBase mainForm = new MainForm();
      System.Windows.Forms.Application.Run(mainForm);
    }

    public MainForm()
      : base("dotConnect for SQLite samples") {

      InitializeComponent();
      Connection = this.myConnection;
      Monitor = this.monitor;
      CreateSqlText = this.scriptCreate.ScriptText;
      DropSqlText = this.scriptDrop.ScriptText;
      CurrentScript = this.scriptCreate;
    }

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    protected override void Dispose( bool disposing )
    {
      if( disposing )
      {
        if(components != null)
        {
          components.Dispose();
        }
      }
      base.Dispose( disposing );
    }

    #region Windows Form Designer generated code
    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.myConnection = new Devart.Data.SQLite.SQLiteConnection();
      this.monitor = new Devart.Data.SQLite.SQLiteMonitor();
      this.scriptDrop = new Devart.Data.SQLite.SQLiteScript();
      this.scriptCreate = new Devart.Data.SQLite.SQLiteScript();
      this.SuspendLayout();
      // 
      // lbDirect
      // 
      this.lbDirect.Size = new System.Drawing.Size(322, 43);
      this.lbDirect.Text = "dotConnect for SQLite";
      this.lbDirect.Visible = true;
      // 
      // myConnection
      // 
      this.myConnection.ConnectionString = "Data Source=test.db;FailIfMissing=false";
      this.myConnection.Name = "myConnection";
      this.myConnection.Owner = this;
      // 
      // monitor
      // 
      this.monitor.IsActive = true;
      // 
      // scriptDrop
      // 
      this.scriptDrop.Name = "scriptDrop";
      this.scriptDrop.ScriptText = "DROP TABLE Emp;\nDROP TABLE Dept;";
      this.scriptDrop.Connection = this.myConnection;
      // 
      // scriptCreate
      // 
      this.scriptCreate.Name = "scriptCreate";
      this.scriptCreate.ScriptText = @"CREATE TABLE DEPT (
  DEPTNO INTEGER PRIMARY KEY,
  DNAME VARCHAR(14),
  LOC VARCHAR(13)
);

CREATE TABLE EMP (
  EMPNO INTEGER PRIMARY KEY,
  ENAME VARCHAR(10),
  JOB VARCHAR(9),
  MGR INTEGER,
  HIREDATE DATE,
  SAL REAL,
  COMM REAL,
  DEPTNO INTEGER REFERENCES DEPT
);
INSERT INTO DEPT VALUES (10,'ACCOUNTING','NEW YORK');
INSERT INTO DEPT VALUES (20,'RESEARCH','DALLAS');
INSERT INTO DEPT VALUES (30,'SALES','CHICAGO');
INSERT INTO DEPT VALUES (40,'OPERATIONS','BOSTON');

INSERT INTO EMP VALUES
  (7369,'SMITH','CLERK',7902,'1980-12-17',800,NULL,20);

INSERT INTO EMP VALUES
  (7499,'ALLEN','SALESMAN',7698,'1981-02-20',1600,300,30);

INSERT INTO EMP VALUES
  (7521,'WARD','SALESMAN',7698,'1981-02-22',1250,500,30);

INSERT INTO EMP VALUES
  (7566,'JONES','MANAGER',7839,'1981-04-02',2975,NULL,20);

INSERT INTO EMP VALUES
  (7654,'MARTIN','SALESMAN',7698,'1981-09-28',1250,1400,30);   

INSERT INTO EMP VALUES
  (7698,'BLAKE','MANAGER',7839,'1981-05-01',2850,NULL,30);

INSERT INTO EMP VALUES
  (7782,'CLARK','MANAGER',7839,'1981-06-09',2450,NULL,10);

INSERT INTO EMP VALUES
  (7788,'SCOTT','ANALYST',7566,'1987-07-13',3000,NULL,20);

INSERT INTO EMP VALUES
  (7839,'KING','PRESIDENT',NULL,'1981-11-17',5000,NULL,10);

INSERT INTO EMP VALUES
  (7844,'TURNER','SALESMAN',7698,'1981-09-08',1500,0,30);

INSERT INTO EMP VALUES
  (7876,'ADAMS','CLERK',7788,'1987-07-13',1100,NULL,20);

INSERT INTO EMP VALUES
  (7900,'JAMES','CLERK',7698,'1981-12-03',950,NULL,30);

INSERT INTO EMP VALUES
  (7902,'FORD','ANALYST',7566,'1981-12-03',3000,NULL,20);

INSERT INTO EMP VALUES
  (7934,'MILLER','CLERK',7782,'1982-01-23',1300,NULL,10);
		";
      this.scriptCreate.Connection = this.myConnection;
      // 
      // MainForm
      // 
      this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
      this.ClientSize = new System.Drawing.Size(1016, 737);
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Name = "MainForm";
      this.Text = "dotConnect for SQLite Samples";
      this.ResumeLayout(false);
    }
    #endregion

    protected override void CreateDemos() {

     ArrayList sampleGroup1 = new ArrayList(12);
      sampleGroup1.Add(new CrystalDemo());
      sampleGroup1.Add(new DataReaderDemo());
      sampleGroup1.Add(new DataSetDemo());
      sampleGroup1.Add(new MasterDetailDemo());
      sampleGroup1.Add(new MetaDataDemo());
      sampleGroup1.Add(new PicturesDemo());
      sampleGroup1.Add(new TableDemo());
      sampleGroup1.Add(new TransactionsDemo());

      DemoCatalog catalog = new DemoCatalog("General demos", sampleGroup1);
      samples.Add(catalog);

    }
  }
}
