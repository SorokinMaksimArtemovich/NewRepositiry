Imports Devart.Data.SQLite
Imports System.Web
Imports System.Data

Partial Class WebForm
  Inherits System.Web.UI.Page
  Protected WithEvents connection As Devart.Data.SQLite.SQLiteConnection
  Protected WithEvents command As Devart.Data.SQLite.SQLiteCommand
  Protected WithEvents dataAdapter As Devart.Data.SQLite.SQLiteDataAdapter
  Protected WithEvents commandBuilder As Devart.Data.SQLite.SQLiteCommandBuilder
  Protected WithEvents myDataSet As System.Data.DataSet

  'This call is required by the Web Form Designer.
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Me.connection = New Devart.Data.SQLite.SQLiteConnection()
    Me.command = New Devart.Data.SQLite.SQLiteCommand()
    Me.dataAdapter = New Devart.Data.SQLite.SQLiteDataAdapter()
    Me.commandBuilder = New Devart.Data.SQLite.SQLiteCommandBuilder()
    Me.myDataSet = New System.Data.DataSet()
    CType(Me.myDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
    '
    'connection
    '
    Me.connection.ConnectionString = "Data Source=test.db"
    Me.connection.Name = "SqlConnection"
    '
    'command
    '
    Me.command.CommandText = "SELECT * FROM Dept"
    Me.command.Connection = Me.connection
    Me.command.Name = "Command"
    '
    'dataAdapter
    '
    Me.dataAdapter.SelectCommand = Me.command
    '
    'commandBuilder
    '
    Me.commandBuilder.DataAdapter = Me.dataAdapter
    '
    'DataSet
    '
    Me.myDataSet.DataSetName = "NewDataSet"
    CType(Me.myDataSet, System.ComponentModel.ISupportInitialize).EndInit()
  End Sub

  Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
    'CODEGEN: This method call is required by the Web Form Designer
    'Do not modify it using the code editor.
    InitializeComponent()

    'MyBase.OnInit(e)
    tbServer.Text = connection.DataSource
    tbSQL.Text = command.CommandText
  End Sub


  Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    myDataSet = CType(HttpContext.Current.Session("dataset"), DataSet)
  End Sub

  Private Sub btTest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btTest.Click
    Try
      FillConnectionString()
      connection.Open()
      lbState.Text = "Success"
      lbState.ForeColor = System.Drawing.Color.Blue()
      connection.Close()
    Catch exception As Exception
      lbState.Text = "Failed"
      lbState.ForeColor = System.Drawing.Color.Red
      lbError.Text = exception.Message
    End Try
  End Sub

  Private Sub btFill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFill.Click
    Try
      FillConnectionString()
      Me.command.CommandText = tbSQL.Text
      Me.myDataSet = New System.Data.DataSet()
      Me.dataAdapter.Fill(myDataSet, "Table")
      HttpContext.Current.Session("dataset") = myDataSet
      lbInfo.Text = "Filled"
    Catch exception As Exception
      lbError.Text = exception.Message
    Finally
      BindGrid()
    End Try
  End Sub

  Private Sub btUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btUpdate.Click
    If myDataSet.Tables("Table") IsNot Nothing Then
      Try
        FillConnectionString()
        If Not (connection.State = ConnectionState.Open) Then
            connection.Open()
        End If
        Me.command.CommandText = tbSQL.Text
        Me.dataAdapter.Update(myDataSet, "Table")
        lbInfo.Text = "Updated"
      Catch exception As Exception
        lbError.Text = exception.Message
      Finally
        BindGrid()
      End Try
    End If
  End Sub

  Private Sub btInsertRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btInsertRecord.Click
    Dim row As DataRow = myDataSet.Tables("Table").NewRow()
    myDataSet.Tables("Table").Rows.Add(row)
    dataGrid.EditItemIndex = myDataSet.Tables("Table").Rows.Count - 1
    BindGrid()
  End Sub

  Private Sub dataGrid_EditCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dataGrid.EditCommand
    dataGrid.EditItemIndex = e.Item.ItemIndex
    BindGrid()
  End Sub

  Private Sub dataGrid_UpdateCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dataGrid.UpdateCommand
    Dim I As Integer
    For I = 2 To e.Item.Cells.Count - 1
      Dim ColValue As String = CType(e.Item.Cells.Item(I).Controls.Item(0), TextBox).Text
      If String.IsNullOrEmpty(ColValue) And myDataSet.Tables("Table").Columns(I - 2).DataType IsNot GetType(String) Then
          myDataSet.Tables("Table").Rows(e.Item.ItemIndex)(I - 2) = DBNull.Value
      Else
          myDataSet.Tables("Table").Rows(e.Item.ItemIndex)(I - 2) = ColValue
      End If
    Next I
    dataGrid.EditItemIndex = -1
    BindGrid()
  End Sub

  Private Sub dataGrid_CancelCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dataGrid.CancelCommand
    dataGrid.EditItemIndex = -1
    BindGrid()
  End Sub

  Private Sub dataGrid_DeleteCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dataGrid.DeleteCommand
    Dim view As DataView = New DataView(myDataSet.Tables("Table"))
    view.Delete(e.Item.ItemIndex)
    BindGrid()
  End Sub

  Private Sub BindGrid()
    If myDataSet.Tables("Table") IsNot Nothing Then
      dataGrid.DataSource = myDataSet.Tables("Table").DefaultView
      lbResult.Visible = True
      btInsertRecord.Visible = True
      If myDataSet.Tables("Table").GetChanges() IsNot Nothing Then
        lbInfo.Text = "Changed"
      End If
    Else
      dataGrid.DataSource = Nothing
      lbResult.Visible = False
      btInsertRecord.Visible = False
    End If

    dataGrid.DataBind()
  End Sub

  Private Sub FillConnectionString()
      connection.DataSource = tbServer.Text
  End Sub
End Class
