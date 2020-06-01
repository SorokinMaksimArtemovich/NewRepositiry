namespace ManagementOfEmployee_sData
{
    partial class SFoundEmployee
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
            this.OneMore = new System.Windows.Forms.Button();
            this.Panel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // ReturnToMenu
            // 
            this.ReturnToMenu.Location = new System.Drawing.Point(425, 275);
            // 
            // OneMore
            // 
            this.OneMore.Location = new System.Drawing.Point(590, 275);
            this.OneMore.Name = "OneMore";
            this.OneMore.Size = new System.Drawing.Size(160, 25);
            this.OneMore.TabIndex = 4;
            this.OneMore.Text = "Найти ещё одного";
            this.OneMore.UseVisualStyleBackColor = true;
            this.OneMore.Click += new System.EventHandler(this.OneMore_Click);
            // 
            // Panel
            // 
            this.Panel.Location = new System.Drawing.Point(50, 120);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(700, 25);
            this.Panel.TabIndex = 5;
            // 
            // SFoundEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.OneMore);
            this.Name = "SFoundEmployee";
            this.Text = "Поиск сотрудника";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SFoundEmployeeClosed);
            this.Controls.SetChildIndex(this.ReturnToMenu, 0);
            this.Controls.SetChildIndex(this.OneMore, 0);
            this.Controls.SetChildIndex(this.Panel, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OneMore;
        private System.Windows.Forms.Panel Panel;
    }
}