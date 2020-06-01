Imports System
Imports System.Diagnostics
Imports System.Windows.Forms

Namespace Samples
  Public Class AboutForm
    Inherits System.Windows.Forms.Form

    ' Fields

    Friend WithEvents pbBevel As System.Windows.Forms.PictureBox
    Friend WithEvents pictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btClose As System.Windows.Forms.Button
    Friend WithEvents lbWeb As System.Windows.Forms.LinkLabel
    Friend WithEvents lbMail As System.Windows.Forms.LinkLabel
    Friend WithEvents lbVersion As System.Windows.Forms.Label
    Friend WithEvents lbDbMonitorVer As System.Windows.Forms.Label
    Friend WithEvents label2 As System.Windows.Forms.Label
    Friend WithEvents label3 As System.Windows.Forms.Label
    Friend WithEvents label4 As System.Windows.Forms.Label
    Friend WithEvents label5 As System.Windows.Forms.Label
    Friend WithEvents lbDbMonitor As System.Windows.Forms.Label
    Friend WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents lbEdition As System.Windows.Forms.Label
    Friend WithEvents panel1 As System.Windows.Forms.Panel

    Private fieldServiceProvider As IServiceProvider
    Private Const sNotAvailable As String = "not available"
    Private Const sNotSupported As String = "not supported"
    Private Const sSupported As String = "supported"

    ' Methods
    Public Sub New()
      Me.InitializeComponent()
      Me.lbDbMonitorVer.Text = sNotSupported

      Me.lbEdition.Text = "Standard Edition"
		Me.lbVersion.Text = Devart.Data.SQLite.ProductInfo.Version
            Me.lbWeb.Links.Add(0, Me.lbWeb.Text.Length, "http://www.devart.com/dotconnect/sqlite")
            Me.lbMail.Links.Add(0, Me.lbMail.Text.Length, "mailto:support@devart.com")
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AboutForm))
            Me.panel1 = New System.Windows.Forms.Panel
            Me.lbEdition = New System.Windows.Forms.Label
            Me.label1 = New System.Windows.Forms.Label
            Me.lbDbMonitor = New System.Windows.Forms.Label
            Me.label5 = New System.Windows.Forms.Label
            Me.label4 = New System.Windows.Forms.Label
            Me.label3 = New System.Windows.Forms.Label
            Me.label2 = New System.Windows.Forms.Label
            Me.lbDbMonitorVer = New System.Windows.Forms.Label
            Me.lbVersion = New System.Windows.Forms.Label
            Me.lbMail = New System.Windows.Forms.LinkLabel
            Me.lbWeb = New System.Windows.Forms.LinkLabel
            Me.btClose = New System.Windows.Forms.Button
            Me.pictureBox1 = New System.Windows.Forms.PictureBox
            Me.pbBevel = New System.Windows.Forms.PictureBox
            Me.panel1.SuspendLayout()
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pbBevel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'panel1
            '
            Me.panel1.BackColor = System.Drawing.Color.White
            Me.panel1.Controls.Add(Me.lbEdition)
            Me.panel1.Controls.Add(Me.label1)
            Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
            Me.panel1.Location = New System.Drawing.Point(0, 0)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(354, 63)
            Me.panel1.TabIndex = 12
            '
            'lbEdition
            '
            Me.lbEdition.AutoSize = True
            Me.lbEdition.Font = New System.Drawing.Font("Tahoma", 10.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
            Me.lbEdition.ForeColor = System.Drawing.Color.Navy
            Me.lbEdition.Location = New System.Drawing.Point(37, 38)
            Me.lbEdition.Name = "lbEdition"
            Me.lbEdition.Size = New System.Drawing.Size(124, 17)
            Me.lbEdition.TabIndex = 4
            Me.lbEdition.Text = "Professional Edition"
            '
            'label1
            '
            Me.label1.AutoSize = True
            Me.label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
            Me.label1.ForeColor = System.Drawing.Color.Navy
            Me.label1.Location = New System.Drawing.Point(19, 12)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(223, 19)
            Me.label1.TabIndex = 3
            Me.label1.Text = "dotConnect for SQLite"
            '
            'lbDbMonitor
            '
            Me.lbDbMonitor.AutoSize = True
            Me.lbDbMonitor.Location = New System.Drawing.Point(24, 171)
            Me.lbDbMonitor.Name = "lbDbMonitor"
            Me.lbDbMonitor.Size = New System.Drawing.Size(60, 13)
            Me.lbDbMonitor.TabIndex = 22
            Me.lbDbMonitor.Text = "DBMonitor:"
            '
            'label5
            '
            Me.label5.AutoSize = True
            Me.label5.Location = New System.Drawing.Point(24, 75)
            Me.label5.Name = "label5"
            Me.label5.Size = New System.Drawing.Size(42, 13)
            Me.label5.TabIndex = 20
            Me.label5.Text = "Version"
            '
            'label4
            '
            Me.label4.AutoSize = True
            Me.label4.Location = New System.Drawing.Point(24, 147)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(39, 13)
            Me.label4.TabIndex = 18
            Me.label4.Text = "E-mail:"
            '
            'label3
            '
            Me.label3.AutoSize = True
            Me.label3.Location = New System.Drawing.Point(24, 123)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(33, 13)
            Me.label3.TabIndex = 17
            Me.label3.Text = "Web:"
            '
            'label2
            '
            Me.label2.AutoSize = True
            Me.label2.Location = New System.Drawing.Point(24, 99)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(266, 13)
            Me.label2.TabIndex = 16
            Me.label2.Text = "Copyright © 2002-2020 Devart. All rights reserved." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
            '
            'lbDbMonitorVer
            '
            Me.lbDbMonitorVer.AutoSize = True
            Me.lbDbMonitorVer.ForeColor = System.Drawing.Color.Navy
            Me.lbDbMonitorVer.Location = New System.Drawing.Point(104, 171)
            Me.lbDbMonitorVer.Name = "lbDbMonitorVer"
            Me.lbDbMonitorVer.Size = New System.Drawing.Size(60, 13)
            Me.lbDbMonitorVer.TabIndex = 23
            Me.lbDbMonitorVer.Text = "supported."
            '
            'lbVersion
            '
            Me.lbVersion.AutoSize = True
            Me.lbVersion.ForeColor = System.Drawing.Color.Navy
            Me.lbVersion.Location = New System.Drawing.Point(104, 75)
            Me.lbVersion.Name = "lbVersion"
            Me.lbVersion.Size = New System.Drawing.Size(43, 13)
            Me.lbVersion.TabIndex = 21
            Me.lbVersion.Text = "2.0.1.0"
            '
            'lbMail
            '
            Me.lbMail.AutoSize = True
            Me.lbMail.Location = New System.Drawing.Point(104, 147)
            Me.lbMail.Name = "lbMail"
            Me.lbMail.Size = New System.Drawing.Size(104, 13)
            Me.lbMail.TabIndex = 19
            Me.lbMail.TabStop = True
            Me.lbMail.Text = "support@devart.com"
            '
            'lbWeb
            '
            Me.lbWeb.AutoSize = True
            Me.lbWeb.Location = New System.Drawing.Point(104, 123)
            Me.lbWeb.Name = "lbWeb"
            Me.lbWeb.Size = New System.Drawing.Size(126, 13)
            Me.lbWeb.TabIndex = 15
            Me.lbWeb.TabStop = True
            Me.lbWeb.Text = "www.devart.com/dotconnect/sqlite"
            '
            'btClose
            '
            Me.btClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btClose.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.btClose.Location = New System.Drawing.Point(272, 232)
            Me.btClose.Name = "btClose"
            Me.btClose.Size = New System.Drawing.Size(75, 25)
            Me.btClose.TabIndex = 0
            Me.btClose.Text = "Close"
            '
            'pictureBox1
            '
            Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
            Me.pictureBox1.Location = New System.Drawing.Point(0, 63)
            Me.pictureBox1.Name = "pictureBox1"
            Me.pictureBox1.Size = New System.Drawing.Size(360, 8)
            Me.pictureBox1.TabIndex = 25
            Me.pictureBox1.TabStop = False
            '
            'pbBevel
            '
            Me.pbBevel.Image = CType(resources.GetObject("pbBevel.Image"), System.Drawing.Image)
            Me.pbBevel.Location = New System.Drawing.Point(0, 220)
            Me.pbBevel.Name = "pbBevel"
            Me.pbBevel.Size = New System.Drawing.Size(360, 8)
            Me.pbBevel.TabIndex = 24
            Me.pbBevel.TabStop = False
            '
            'AboutForm
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
            Me.ClientSize = New System.Drawing.Size(354, 263)
            Me.Controls.Add(Me.lbDbMonitor)
            Me.Controls.Add(Me.label5)
            Me.Controls.Add(Me.label4)
            Me.Controls.Add(Me.label3)
            Me.Controls.Add(Me.label2)
            Me.Controls.Add(Me.lbDbMonitorVer)
            Me.Controls.Add(Me.lbVersion)
            Me.Controls.Add(Me.lbMail)
            Me.Controls.Add(Me.lbWeb)
            Me.Controls.Add(Me.btClose)
            Me.Controls.Add(Me.pictureBox1)
            Me.Controls.Add(Me.pbBevel)
            Me.Controls.Add(Me.panel1)
            Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "AboutForm"
            Me.ShowInTaskbar = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "About dotConnect for SQLite"
            Me.panel1.ResumeLayout(False)
            Me.panel1.PerformLayout()
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pbBevel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

    ' Properties
    Friend Property ServiceProvider() As IServiceProvider
      Get
        Return Me.fieldServiceProvider
      End Get
      Set(ByVal value As IServiceProvider)
        Me.fieldServiceProvider = value
      End Set
    End Property

    ' Methods
    Private Sub lbMail_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lbMail.LinkClicked
      Process.Start(e.Link.LinkData.ToString)
    End Sub

    Private Sub lbWeb_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lbWeb.LinkClicked
      Process.Start(e.Link.LinkData.ToString)
    End Sub
  End Class
End Namespace
