﻿namespace ManagementOfEmployee_sData
{
    partial class TSaccessfullyCompleted
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
            this.ReturnToMenu = new System.Windows.Forms.Button();
            this.Message = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ReturnToMenu
            // 
            this.ReturnToMenu.Location = new System.Drawing.Point(218, 200);
            this.ReturnToMenu.Name = "ReturnToMenu";
            this.ReturnToMenu.Size = new System.Drawing.Size(180, 25);
            this.ReturnToMenu.TabIndex = 0;
            this.ReturnToMenu.Text = "Вернуться в главное меню";
            this.ReturnToMenu.UseVisualStyleBackColor = true;
            this.ReturnToMenu.Click += new System.EventHandler(this.ReturnToMenu_Click);
            // 
            // Message
            // 
            this.Message.AutoSize = true;
            this.Message.Location = new System.Drawing.Point(315, 165);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(170, 15);
            this.Message.TabIndex = 2;
            this.Message.Text = "Выберите дальнейшее действие:";
            // 
            // TSaccessfullyCompleted
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Message);
            this.Controls.Add(this.ReturnToMenu);
            this.Name = "TSaccessfullyCompleted";
            this.Text = "TSaccessfullyCompleted";
            this.Text = "TSaccessfullyCompleted";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ReturnToMenu;
        private System.Windows.Forms.Label Message;
    }
}