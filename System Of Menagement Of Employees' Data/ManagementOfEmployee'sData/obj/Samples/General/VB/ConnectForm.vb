'
'  MyDirect .NET
'  Copyright © 2002-2006 Devart. All rights reserved.
'  ConnectForm
'  Last modified:

Imports Devart.Data.SQLite
Imports System
Imports System.Data
Imports System.Data.Common
Imports System.Windows.Forms

Namespace Samples
  Public Class ConnectForm
    Inherits Form

    ' Fields

    Private connection As SQLiteConnection
    Private retries As Integer
    Private WithEvents btBrowse As System.Windows.Forms.Button
    Private WithEvents tbDataSource As System.Windows.Forms.TextBox
    Private WithEvents lbDataSource As System.Windows.Forms.Label
    Private WithEvents btCancel As System.Windows.Forms.Button
    Private WithEvents btConnect As System.Windows.Forms.Button
    Private connectionString As String

    ' Methods
    Public Sub New()
      Me.components = Nothing
      Me.connection = Nothing
      Me.retries = 3
      Me.InitializeComponent()
    End Sub

    Public Sub New(ByVal connection As IDbConnection)
      Me.components = Nothing
      Me.connection = Nothing
      Me.retries = 3
      Me.InitializeComponent()
      Me.connection = DirectCast(connection, SQLiteConnection)
      Me.tbDataSource.Text = Me.connection.DataSource
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
      Me.btBrowse = New System.Windows.Forms.Button
      Me.tbDataSource = New System.Windows.Forms.TextBox
      Me.lbDataSource = New System.Windows.Forms.Label
      Me.btCancel = New System.Windows.Forms.Button
      Me.btConnect = New System.Windows.Forms.Button
      Me.SuspendLayout()
      '
      'btBrowse
      '
      Me.btBrowse.Location = New System.Drawing.Point(406, 31)
      Me.btBrowse.Name = "btBrowse"
      Me.btBrowse.Size = New System.Drawing.Size(75, 25)
      Me.btBrowse.TabIndex = 8
      Me.btBrowse.Text = "Browse ..."
      '
      'tbDataSource
      '
      Me.tbDataSource.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.tbDataSource.Location = New System.Drawing.Point(93, 37)
      Me.tbDataSource.Name = "tbDataSource"
      Me.tbDataSource.Size = New System.Drawing.Size(305, 20)
      Me.tbDataSource.TabIndex = 7
      '
      'lbDataSource
      '
      Me.lbDataSource.AutoSize = True
      Me.lbDataSource.Location = New System.Drawing.Point(16, 37)
      Me.lbDataSource.Name = "lbDataSource"
      Me.lbDataSource.Size = New System.Drawing.Size(67, 13)
      Me.lbDataSource.TabIndex = 6
      Me.lbDataSource.Text = "Data Source"
      '
      'btCancel
      '
      Me.btCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
      Me.btCancel.Location = New System.Drawing.Point(404, 91)
      Me.btCancel.Name = "btCancel"
      Me.btCancel.Size = New System.Drawing.Size(75, 25)
      Me.btCancel.TabIndex = 10
      Me.btCancel.Text = "Cancel"
      '
      'btConnect
      '
      Me.btConnect.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.btConnect.Location = New System.Drawing.Point(324, 91)
      Me.btConnect.Name = "btConnect"
      Me.btConnect.Size = New System.Drawing.Size(75, 25)
      Me.btConnect.TabIndex = 9
      Me.btConnect.Text = "Connect"
      '
      'ConnectForm
      '
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.ClientSize = New System.Drawing.Size(491, 128)
      Me.Controls.Add(Me.btBrowse)
      Me.Controls.Add(Me.tbDataSource)
      Me.Controls.Add(Me.lbDataSource)
      Me.Controls.Add(Me.btCancel)
      Me.Controls.Add(Me.btConnect)
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
      Me.MaximizeBox = False
      Me.MinimizeBox = False
      Me.MinimumSize = New System.Drawing.Size(497, 160)
      Me.Name = "ConnectForm"
      Me.ShowInTaskbar = False
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
      Me.Text = "Connect"
      Me.ResumeLayout(False)
      Me.PerformLayout()

    End Sub

    Private Sub btConnect_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btConnect.Click
      Me.connection.Close()
      Me.connection.DataSource = tbDataSource.Text

      Try
        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        Me.connection.Open()
        Windows.Forms.Cursor.Current = Cursors.Default
        MyBase.DialogResult = Windows.Forms.DialogResult.OK
      Catch exception As SQLiteException
        Windows.Forms.Cursor.Current = Cursors.Default
        Me.retries -= 1
        If (Me.retries = 0) Then
          MyBase.DialogResult = Windows.Forms.DialogResult.Cancel
        End If

        Dim msg As String = exception.Message.Trim
        ActiveControl = tbDataSource
        MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
      End Try
    End Sub
    Private Sub ConnectForm_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
      If (Not DialogResult = Windows.Forms.DialogResult.OK) Then
        connection.ConnectionString = connectionString
      End If
    End Sub

    Private Sub btBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btBrowse.Click
      Try
        Dim openDlg As OpenFileDialog = New OpenFileDialog()
        openDlg.Filter = "db files (*.db)|*.db|All files (*.*)|*.*"
        openDlg.FilterIndex = 2
        openDlg.FileName = tbDataSource.Text
        openDlg.CheckFileExists = False
        openDlg.CheckPathExists = False

        If (openDlg.ShowDialog() = Windows.Forms.DialogResult.OK) Then
          tbDataSource.Text = openDlg.FileName
        End If
      Catch
      End Try
    End Sub
  End Class
End Namespace