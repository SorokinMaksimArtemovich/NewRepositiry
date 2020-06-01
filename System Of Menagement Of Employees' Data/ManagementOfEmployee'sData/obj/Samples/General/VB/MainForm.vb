Namespace Samples
  Public Class MainForm
    Inherits MainFormBase

    ' Fields
    Friend WithEvents myMonitor As Devart.Data.SQLite.SQLiteMonitor
    Friend WithEvents scriptDrop As Devart.Data.SQLite.SQLiteScript
    Friend WithEvents scriptCreate As Devart.Data.SQLite.SQLiteScript
    Friend WithEvents myConnection As Devart.Data.SQLite.SQLiteConnection

    ' Methods
    Public Sub New()
      Me.InitializeComponent()
      MyBase.Connection = Me.myConnection
      MyBase.Monitor = Me.myMonitor
      MyBase.CreateSqlText = Me.scriptCreate.ScriptText
      MyBase.DropSqlText = Me.scriptDrop.ScriptText
      MyBase.CurrentScript = Me.scriptCreate
      MyBase.CatalogName = "dotConnect for SQLite samples"
    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
      If disposing Then
        If Not (components Is Nothing) Then
          components.Dispose()
        End If
      End If
      MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.    
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
      Me.myConnection = New Devart.Data.SQLite.SQLiteConnection()
      Me.myMonitor = New Devart.Data.SQLite.SQLiteMonitor()
      Me.scriptCreate = New Devart.Data.SQLite.SQLiteScript()
      Me.scriptDrop = New Devart.Data.SQLite.SQLiteScript()
      Me.SuspendLayout()
      '
      'lbDirect
      '
      Me.lbDirect.Size = New System.Drawing.Size(322, 43)
      Me.lbDirect.Text = "dotConnect for SQLite"
      Me.lbDirect.Visible = True
      '
      'myConnection
      '
      Me.myConnection.ConnectionString = "Data Source=test.db;FailIfMissing=false"
      Me.myConnection.Name = "myConnection"
      Me.myConnection.Owner = Me
      '
      'myMonitor
      '
      Me.myMonitor.IsActive = True
      '
      'scriptDrop
      '
      Me.scriptDrop.Connection = Me.myConnection
      Me.scriptDrop.Name = "scriptDrop"
      Me.scriptDrop.ScriptText = "DROP TABLE Emp;" & Microsoft.VisualBasic.ChrW(10) & "DROP TABLE Dept;"
      '
      'scriptCreate
      '
      Me.scriptCreate.Connection = Me.myConnection
      Me.scriptCreate.Name = "scriptCreate"
      Me.scriptCreate.ScriptText = "CREATE TABLE DEPT (" & ChrW(13) & ChrW(10) & _
		"  DEPTNO INTEGER PRIMARY KEY," & ChrW(13) & ChrW(10) & _
		"  DNAME VARCHAR(14)," & ChrW(13) & ChrW(10) & _
		"  LOC VARCHAR(13)" & ChrW(13) & ChrW(10) & _
		");" & ChrW(13) & ChrW(10) & ChrW(13) & ChrW(10) & _
		"CREATE TABLE EMP (" & ChrW(13) & ChrW(10) & _
		"  EMPNO INTEGER PRIMARY KEY," & ChrW(13) & ChrW(10) & _
		"  ENAME VARCHAR(10)," & ChrW(13) & ChrW(10) & _
		"  JOB VARCHAR(9)," & ChrW(13) & ChrW(10) & _
		"  MGR INTEGER," & ChrW(13) & ChrW(10) & _
		"  HIREDATE DATE," & ChrW(13) & ChrW(10) & _
		"  SAL REAL," & ChrW(13) & ChrW(10) & _
		"  COMM REAL," & ChrW(13) & ChrW(10) & _
		"  DEPTNO INTEGER REFERENCES DEPT" & ChrW(13) & ChrW(10) & _
		");" & ChrW(13) & ChrW(10) & _
		"INSERT INTO DEPT VALUES (10,'ACCOUNTING','NEW YORK');" & ChrW(13) & ChrW(10) & _
		"INSERT INTO DEPT VALUES (20,'RESEARCH','DALLAS');" & ChrW(13) & ChrW(10) & _
		"INSERT INTO DEPT VALUES (30,'SALES','CHICAGO');" & ChrW(13) & ChrW(10) & _
		"INSERT INTO DEPT VALUES (40,'OPERATIONS','BOSTON');" & ChrW(13) & ChrW(10) & ChrW(13) & ChrW(10) & _
		"INSERT INTO EMP VALUES(7369,'SMITH','CLERK',7902,'1980-12-17',800,NULL,20);" & ChrW(13) & ChrW(10) & _
		"INSERT INTO EMP VALUES" & ChrW(13) & ChrW(10) & "  (7499,'ALLEN','SALESMAN',7698,'1981-02-20',1600,300,30);" & ChrW(13) & ChrW(10) & ChrW(13) & ChrW(10) & _
		"INSERT INTO EMP VALUES" & ChrW(13) & ChrW(10) & "  (7521,'WARD','SALESMAN',7698,'1981-02-22',1250,500,30);" & ChrW(13) & ChrW(10) & ChrW(13) & ChrW(10) & _
		"INSERT INTO EMP VALUES" & ChrW(13) & ChrW(10) & "  (7566,'JONES','MANAGER',7839,'1981-04-02',2975,NULL,20);" & ChrW(13) & ChrW(10) & ChrW(13) & ChrW(10) & _
		"INSERT INTO EMP VALUES" & ChrW(13) & ChrW(10) & "  (7654,'MARTIN','SALESMAN',7698,'1981-09-28',1250,1400,30);   " & ChrW(13) & ChrW(10) & ChrW(13) & ChrW(10) & _
		"INSERT INTO EMP VALUES" & ChrW(13) & ChrW(10) & "  (7698,'BLAKE','MANAGER',7839,'1981-05-01',2850,NULL,30);" & ChrW(13) & ChrW(10) & ChrW(13) & ChrW(10) & _
		"INSERT INTO EMP VALUES" & ChrW(13) & ChrW(10) & "  (7782,'CLARK','MANAGER',7839,'1981-06-09',2450,NULL,10);" & ChrW(13) & ChrW(10) & ChrW(13) & ChrW(10) & _
		"INSERT INTO EMP VALUES" & ChrW(13) & ChrW(10) & "  (7788,'SCOTT','ANALYST',7566,'1987-07-13',3000,NULL,20);" & ChrW(13) & ChrW(10) & ChrW(13) & ChrW(10) & _
		"INSERT INTO EMP VALUES" & ChrW(13) & ChrW(10) & "  (7839,'KING','PRESIDENT',NULL,'1981-11-17',5000,NULL,10);" & ChrW(13) & ChrW(10) & ChrW(13) & ChrW(10) & _
		"INSERT INTO EMP VALUES" & ChrW(13) & ChrW(10) & "  (7844,'TURNER','SALESMAN',7698,'1981-09-08',1500,0,30);" & ChrW(13) & ChrW(10) & ChrW(13) & ChrW(10) & _
		"INSERT INTO EMP VALUES" & ChrW(13) & ChrW(10) & "  (7876,'ADAMS','CLERK',7788,'1987-07-13',1100,NULL,20);" & ChrW(13) & ChrW(10) & ChrW(13) & ChrW(10) & _
		"INSERT INTO EMP VALUES" & ChrW(13) & ChrW(10) & "  (7900,'JAMES','CLERK',7698,'1981-12-03',950,NULL,30);" & ChrW(13) & ChrW(10) & ChrW(13) & ChrW(10) & _
		"INSERT INTO EMP VALUES" & ChrW(13) & ChrW(10) & "  (7902,'FORD','ANALYST',7566,'1981-12-03',3000,NULL,20);" & ChrW(13) & ChrW(10) & ChrW(13) & ChrW(10) & _
		"INSERT INTO EMP VALUES" & ChrW(13) & ChrW(10) & "  (7934,'MILLER','CLERK',7782,'1982-01-23',1300,NULL,10);"
      '
      'MainForm
      '
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.ClientSize = New System.Drawing.Size(1016, 725)
      Me.Location = New System.Drawing.Point(0, 0)
      Me.Name = "MainForm"
      Me.Text = "dotConnect for SQLite Samples"
      Me.ResumeLayout(False)
    End Sub

    ' Methods
    Protected Overrides Sub CreateDemos()
      Dim sampleGroup1 As New ArrayList(12)
      sampleGroup1.Add(New CrystalDemo())
      sampleGroup1.Add(New DataReaderDemo())
      sampleGroup1.Add(New DataSetDemo())
      sampleGroup1.Add(New MasterDetailDemo())
      sampleGroup1.Add(New MetaDataDemo())
      sampleGroup1.Add(New PicturesDemo())
      sampleGroup1.Add(New TableDemo())
      sampleGroup1.Add(New TransactionsDemo())
      Dim catalog As New DemoCatalog("General demos", sampleGroup1)
      MyBase.samples.Add(catalog)
    End Sub
  End Class
End Namespace
