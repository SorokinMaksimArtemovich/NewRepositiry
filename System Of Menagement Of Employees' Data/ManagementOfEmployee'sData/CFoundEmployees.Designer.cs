namespace ManagementOfEmployee_sData
{
    partial class CFoundEmployees
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Coose = new System.Windows.Forms.Button();
            this.OneMore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ReturnToMenu
            // 
            this.ReturnToMenu.Location = new System.Drawing.Point(355, 380);
            // 
            // Coose
            // 
            this.Coose.Location = new System.Drawing.Point(670, 380);
            this.Coose.Name = "Coose";
            this.Coose.Size = new System.Drawing.Size(120, 25);
            this.Coose.TabIndex = 9;
            this.Coose.Text = "Удалить сотрудника";
            this.Coose.UseVisualStyleBackColor = true;
            this.Coose.Click += new System.EventHandler(this.Coose_Click);
            // 
            // OneMore
            // 
            this.OneMore.Location = new System.Drawing.Point(515, 380);
            this.OneMore.Name = "OneMore";
            this.OneMore.Size = new System.Drawing.Size(150, 25);
            this.OneMore.TabIndex = 10;
            this.OneMore.Text = "Найти другого сотрудника";
            this.OneMore.UseVisualStyleBackColor = true;
            this.OneMore.Click += new System.EventHandler(this.OneMore_Click);
            // 
            // CFoundEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OneMore);
            this.Controls.Add(this.Coose);
            this.Name = "CFoundEmployees";
            this.Text = "Изменение данных сотрудника";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CFoundEmployeesClosed);
            this.Controls.SetChildIndex(this.ReturnToMenu, 0);
            this.Controls.SetChildIndex(this.Coose, 0);
            this.Controls.SetChildIndex(this.OneMore, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Coose;
        private System.Windows.Forms.Button OneMore;
    }
}