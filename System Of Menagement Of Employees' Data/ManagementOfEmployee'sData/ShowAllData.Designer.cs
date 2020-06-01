namespace ManagementOfEmployee_sData
{
    partial class ShowAllData
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
            this.Message = new System.Windows.Forms.Label();
            this.Panel = new System.Windows.Forms.FlowLayoutPanel();
            this.ReturnToMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Message
            // 
            this.Message.AutoSize = true;
            this.Message.Location = new System.Drawing.Point(244, 9);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(270, 13);
            this.Message.TabIndex = 0;
            this.Message.Text = "В базе данных содержатся следующие сотрудники:";
            // 
            // Panel
            // 
            this.Panel.Location = new System.Drawing.Point(12, 34);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(776, 336);
            this.Panel.TabIndex = 1;
            // 
            // ReturnToMenu
            // 
            this.ReturnToMenu.Location = new System.Drawing.Point(627, 376);
            this.ReturnToMenu.Name = "ReturnToMenu";
            this.ReturnToMenu.Size = new System.Drawing.Size(161, 23);
            this.ReturnToMenu.TabIndex = 2;
            this.ReturnToMenu.Text = "Вернуться в главное меню";
            this.ReturnToMenu.UseVisualStyleBackColor = true;
            this.ReturnToMenu.Click += new System.EventHandler(this.ReturnToMenu_Click);
            // 
            // ShowAllData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ReturnToMenu);
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.Message);
            this.Name = "ShowAllData";
            this.Text = "Ввывод всех сотрудников";
            this.ResumeLayout(false);
            this.PerformLayout();
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ShowAllDataClosed);

        }

        #endregion

        private System.Windows.Forms.Label Message;
        private System.Windows.Forms.FlowLayoutPanel Panel;
        private System.Windows.Forms.Button ReturnToMenu;
    }
}