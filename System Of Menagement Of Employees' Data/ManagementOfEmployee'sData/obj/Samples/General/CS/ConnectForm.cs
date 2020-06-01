
//////////////////////////////////////////////////
//  dotConnect for SQLite
//  Copyright © 2002 Devart. All rights reserved.
//  ConnectForm
//  Last modified:      
//////////////////////////////////////////////////

using System;
using System.ComponentModel;
using System.Windows.Forms;
using Devart.Data.SQLite;
using System.Data;
using System.Data.Common;

namespace Samples {

  /// <summary>
  /// Summary description for ConnectForm.
  /// </summary>
  public class ConnectForm : System.Windows.Forms.Form {

    private System.Windows.Forms.Button btConnect;
    private System.Windows.Forms.Button btCancel;
    private System.Windows.Forms.TextBox tbDataSource;
    private System.Windows.Forms.Label lbDataSource;

    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.Container components = null;
    private SQLiteConnection connection = null;
    private int retries = 3;
    private System.Windows.Forms.Button btBrowse;
    private string connectionString;

    public ConnectForm(DbConnection connection) {

      InitializeComponent();

      this.connection = (SQLiteConnection)connection;
      connectionString = connection.ConnectionString;
      tbDataSource.Text = connection.DataSource;
    }

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    protected override void Dispose(bool disposing) {

      if (disposing) {
        if (components != null) {
          components.Dispose();
        }
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code
    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.btConnect = new System.Windows.Forms.Button();
      this.btCancel = new System.Windows.Forms.Button();
      this.tbDataSource = new System.Windows.Forms.TextBox();
      this.lbDataSource = new System.Windows.Forms.Label();
      this.btBrowse = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // btConnect
      // 
      this.btConnect.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
      this.btConnect.Location = new System.Drawing.Point(327, 94);
      this.btConnect.Name = "btConnect";
      this.btConnect.Size = new System.Drawing.Size(75, 25);
      this.btConnect.TabIndex = 4;
      this.btConnect.Text = "Connect";
      this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
      // 
      // btCancel
      // 
      this.btCancel.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
      this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btCancel.Location = new System.Drawing.Point(407, 94);
      this.btCancel.Name = "btCancel";
      this.btCancel.Size = new System.Drawing.Size(75, 25);
      this.btCancel.TabIndex = 5;
      this.btCancel.Text = "Cancel";
      // 
      // tbDataSource
      // 
      this.tbDataSource.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
        | System.Windows.Forms.AnchorStyles.Right);
      this.tbDataSource.Location = new System.Drawing.Point(96, 40);
      this.tbDataSource.Name = "tbDataSource";
      this.tbDataSource.Size = new System.Drawing.Size(305, 20);
      this.tbDataSource.TabIndex = 2;
      this.tbDataSource.Text = "";
      // 
      // lbDataSource
      // 
      this.lbDataSource.AutoSize = true;
      this.lbDataSource.Location = new System.Drawing.Point(19, 40);
      this.lbDataSource.Name = "lbDataSource";
      this.lbDataSource.Size = new System.Drawing.Size(67, 13);
      this.lbDataSource.TabIndex = 1;
      this.lbDataSource.Text = "Data Source";
      // 
      // btBrowse
      // 
      this.btBrowse.Location = new System.Drawing.Point(407, 38);
      this.btBrowse.Name = "btBrowse";
      this.btBrowse.Size = new System.Drawing.Size(75, 25);
      this.btBrowse.TabIndex = 3;
      this.btBrowse.Text = "Browse ...";
      this.btBrowse.Click += new System.EventHandler(this.btBrowse_Click);
      // 
      // ConnectForm
      // 
      this.AcceptButton = this.btConnect;
      this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
      this.CancelButton = this.btCancel;
      this.ClientSize = new System.Drawing.Size(491, 128);
      this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                  this.btBrowse,
                                                                  this.tbDataSource,
                                                                  this.lbDataSource,
                                                                  this.btCancel,
                                                                  this.btConnect});
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.MinimumSize = new System.Drawing.Size(497, 160);
      this.Name = "ConnectForm";
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Connect";
      this.Closed += new System.EventHandler(this.ConnectForm_Closed);
      this.ResumeLayout(false);

    }
    #endregion

    private void btConnect_Click(object sender, System.EventArgs e) {

      connection.Close();
      connection.DataSource = tbDataSource.Text;

      try {
        Cursor.Current = Cursors.WaitCursor;

        connection.Open();

        Cursor.Current = Cursors.Default;

        DialogResult = DialogResult.OK;
      }
      catch (SQLiteException exception) {
        Cursor.Current = Cursors.Default;

        retries--;
        if (retries == 0)
          DialogResult = DialogResult.Cancel;

        string msg = exception.Message.Trim();

        ActiveControl = tbDataSource;
        MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void ConnectForm_Closed(object sender, System.EventArgs e) {
    
      if (DialogResult != DialogResult.OK) 
        connection.ConnectionString = connectionString;
    }

    private void btBrowse_Click(object sender, System.EventArgs e) {
      try{
        OpenFileDialog openDlg = new OpenFileDialog();
        openDlg.Filter = "db files (*.db)|*.db|All files (*.*)|*.*";
        openDlg.FilterIndex = 2;
        openDlg.FileName = tbDataSource.Text;
        openDlg.CheckFileExists = false;
        openDlg.CheckPathExists = false;
        if (openDlg.ShowDialog() == DialogResult.OK){
          tbDataSource.Text = openDlg.FileName;
        }
      }
      catch {
      
      }
    }
  }
}


