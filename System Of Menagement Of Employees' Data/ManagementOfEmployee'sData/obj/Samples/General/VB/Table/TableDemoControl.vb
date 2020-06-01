Imports Devart.Data.SQLite
Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Globalization
Imports System.Windows.Forms

Namespace Samples
  Public Class TableDemoControl
    Inherits BaseDemoControl

    ' Fields
    Private sqlConnection As SQLiteConnection
    Private WithEvents command As Devart.Data.SQLite.SQLiteCommand
    Private WithEvents dataAdapter As Devart.Data.SQLite.SQLiteDataAdapter
    Private WithEvents commandBuilder As Devart.Data.SQLite.SQLiteCommandBuilder
    Private WithEvents dataSet As System.Data.DataSet
    Private WithEvents topPanel As System.Windows.Forms.Panel
    Private WithEvents lbDatabase As System.Windows.Forms.Label
    Private WithEvents cbDatabase As System.Windows.Forms.ComboBox
    Private WithEvents lbTableName As System.Windows.Forms.Label
    Private WithEvents cbTableName As System.Windows.Forms.ComboBox
    Private WithEvents btUpdate As System.Windows.Forms.Button
    Private WithEvents btClear As System.Windows.Forms.Button
    Private WithEvents btFill As System.Windows.Forms.Button
    Private WithEvents dataGrid As System.Windows.Forms.DataGrid

    ' Methods
    Public Sub New()
      Me.components = Nothing
      Me.InitializeComponent()
    End Sub

    Public Sub New(ByVal connection As SQLiteConnection)
      Me.New()
      Me.sqlConnection = connection
      Me.command.Connection = Me.sqlConnection
      cbDatabase.Text = command.Connection.Database
      cbTableName.Text = Me.command.CommandText
    End Sub

    'UserControl overrides dispose to clean up the component list.
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
      Me.command = New Devart.Data.SQLite.SQLiteCommand()
      Me.dataAdapter = New Devart.Data.SQLite.SQLiteDataAdapter()
      Me.commandBuilder = New Devart.Data.SQLite.SQLiteCommandBuilder()
      Me.dataSet = New System.Data.DataSet()
      Me.topPanel = New System.Windows.Forms.Panel()
      Me.lbDatabase = New System.Windows.Forms.Label()
      Me.cbDatabase = New System.Windows.Forms.ComboBox()
      Me.lbTableName = New System.Windows.Forms.Label()
      Me.cbTableName = New System.Windows.Forms.ComboBox()
      Me.btUpdate = New System.Windows.Forms.Button()
      Me.btClear = New System.Windows.Forms.Button()
      Me.btFill = New System.Windows.Forms.Button()
      Me.dataGrid = New System.Windows.Forms.DataGrid()
      CType(Me.dataSet, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.topPanel.SuspendLayout()
      CType(Me.dataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      '
      'command
      '
      Me.command.CommandType = System.Data.CommandType.TableDirect
      Me.command.CommandText = "Dept"
      Me.command.Name = "command"
      Me.command.Owner = Me
      '
      'dataAdapter
      '
      Me.dataAdapter.SelectCommand = Me.command
      '
      'commandBuilder
      '
      Me.commandBuilder.DataAdapter = Me.dataAdapter
      Me.commandBuilder.Quoted = True
      Me.commandBuilder.UpdatingFields = ""
      '
      'dataSet
      '
      Me.dataSet.DataSetName = "NewDataSet"
      Me.dataSet.Locale = New System.Globalization.CultureInfo("en-US")
      '
      'topPanel
      '
      Me.topPanel.Controls.Add(Me.lbDatabase)
      Me.topPanel.Controls.Add(Me.cbDatabase)
      Me.topPanel.Controls.Add(Me.lbTableName)
      Me.topPanel.Controls.Add(Me.cbTableName)
      Me.topPanel.Controls.Add(Me.btUpdate)
      Me.topPanel.Controls.Add(Me.btClear)
      Me.topPanel.Controls.Add(Me.btFill)
      Me.topPanel.Dock = System.Windows.Forms.DockStyle.Top
      Me.topPanel.Location = New System.Drawing.Point(0, 0)
      Me.topPanel.Name = "topPanel"
      Me.topPanel.Size = New System.Drawing.Size(477, 64)
      Me.topPanel.TabIndex = 3
      '
      'lbDatabase
      '
      Me.lbDatabase.Location = New System.Drawing.Point(8, 36)
      Me.lbDatabase.Name = "lbDatabase"
      Me.lbDatabase.Size = New System.Drawing.Size(56, 16)
      Me.lbDatabase.TabIndex = 8
      Me.lbDatabase.Text = "Database"
      '
      'cbDatabase
      '
      Me.cbDatabase.Location = New System.Drawing.Point(67, 32)
      Me.cbDatabase.Name = "cbDatabase"
      Me.cbDatabase.Size = New System.Drawing.Size(160, 21)
      Me.cbDatabase.Sorted = True
      Me.cbDatabase.TabIndex = 7
      '
      'lbTableName
      '
      Me.lbTableName.Location = New System.Drawing.Point(232, 36)
      Me.lbTableName.Name = "lbTableName"
      Me.lbTableName.Size = New System.Drawing.Size(64, 16)
      Me.lbTableName.TabIndex = 6
      Me.lbTableName.Text = "Table name"
      '
      'cbTableName
      '
      Me.cbTableName.Location = New System.Drawing.Point(296, 32)
      Me.cbTableName.Name = "cbTableName"
      Me.cbTableName.Size = New System.Drawing.Size(172, 21)
      Me.cbTableName.Sorted = True
      Me.cbTableName.TabIndex = 5
      '
      'btUpdate
      '
      Me.btUpdate.FlatStyle = System.Windows.Forms.FlatStyle.System
      Me.btUpdate.Location = New System.Drawing.Point(152, 0)
      Me.btUpdate.Name = "btUpdate"
      Me.btUpdate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
      Me.btUpdate.Size = New System.Drawing.Size(75, 23)
      Me.btUpdate.TabIndex = 4
      Me.btUpdate.Text = "Update"
      '
      'btClear
      '
      Me.btClear.FlatStyle = System.Windows.Forms.FlatStyle.System
      Me.btClear.Location = New System.Drawing.Point(76, 0)
      Me.btClear.Name = "btClear"
      Me.btClear.Size = New System.Drawing.Size(75, 23)
      Me.btClear.TabIndex = 3
      Me.btClear.Text = "Clear"
      '
      'btFill
      '
      Me.btFill.FlatStyle = System.Windows.Forms.FlatStyle.System
      Me.btFill.Location = New System.Drawing.Point(0, 0)
      Me.btFill.Name = "btFill"
      Me.btFill.Size = New System.Drawing.Size(75, 23)
      Me.btFill.TabIndex = 2
      Me.btFill.Text = "Fill"
      '
      'dataGrid
      '
      Me.dataGrid.AllowNavigation = False
      Me.dataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
      Me.dataGrid.CaptionVisible = False
      Me.dataGrid.DataMember = ""
      Me.dataGrid.DataSource = Me.dataSet
      Me.dataGrid.Dock = System.Windows.Forms.DockStyle.Fill
      Me.dataGrid.HeaderForeColor = System.Drawing.SystemColors.ControlText
      Me.dataGrid.Location = New System.Drawing.Point(0, 64)
      Me.dataGrid.Name = "dataGrid"
      Me.dataGrid.Size = New System.Drawing.Size(477, 270)
      Me.dataGrid.TabIndex = 8
      '
      'TableDemoControl
      '
      Me.Controls.Add(Me.dataGrid)
      Me.Controls.Add(Me.topPanel)
      Me.Name = "TableDemoControl"
      Me.Size = New System.Drawing.Size(477, 334)
      CType(Me.dataSet, System.ComponentModel.ISupportInitialize).EndInit()
      Me.topPanel.ResumeLayout(False)
      CType(Me.dataGrid, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ResumeLayout(False)

    End Sub

    ' Methods
    Private Sub btFill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFill.Click
      Me.dataAdapter.Fill(Me.dataSet, "Table")
      Me.dataGrid.DataMember = "Table"
      MyBase.fieldWriteStatus1 = (Me.dataSet.Tables.Item(0).Rows.Count & " rows in table " & Me.cbTableName.Text)
      MyBase.OnWriteStatus()
    End Sub

    Private Sub btClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btClear.Click
      Me.dataGrid.DataMember = String.Empty
      Me.dataSet.Clear()
      Dim table As DataTable
      For Each table In Me.dataSet.Tables
        table.Columns.Clear()
      Next
      MyBase.fieldWriteStatus1 = ""
      MyBase.OnWriteStatus()
    End Sub

    Private Sub btUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btUpdate.Click
      Me.dataAdapter.Update(Me.dataSet, "Table")
    End Sub

    Private Sub cbDatabase_DropDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbDatabase.DropDown
      If (Me.sqlConnection.State = ConnectionState.Closed) Then
        Me.sqlConnection.Open()
      End If
      Me.cbDatabase.Items.Clear()
      Dim databases As DataTable
      databases = sqlConnection.GetSchema("Catalogs")
      Dim row As DataRow
      For Each row In databases.Rows
        Me.cbDatabase.Items.Add(row.Item(0))
      Next
    End Sub


    Private Sub cbDatabase_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbDatabase.TextChanged
      Me.cbTableName.Items.Clear()
      Me.cbTableName.Text = ""
    End Sub

    Private Sub cbTableName_DropDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbTableName.DropDown
      If (Me.sqlConnection.State = ConnectionState.Closed) Then
        Me.sqlConnection.Open()
      End If
      If (Me.cbTableName.Items.Count = 0) Then
        Dim tables As DataTable
        tables = sqlConnection.GetSchema("Tables", New String() {cbDatabase.Text})
        Dim row As DataRow
        For Each row In tables.Rows
          Dim tname As String = row("name").ToString()
          Me.cbTableName.Items.Add(tname)
        Next
      End If
    End Sub

    Private Sub cbTableName_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbTableName.Leave
      command.CommandText = commandBuilder.QuoteIdentifier(cbTableName.Text)
      Me.commandBuilder.RefreshSchema()
    End Sub
  End Class
End Namespace
