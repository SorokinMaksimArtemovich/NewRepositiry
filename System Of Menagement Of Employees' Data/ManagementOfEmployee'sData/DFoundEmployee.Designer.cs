﻿namespace ManagementOfEmployee_sData
{
    partial class DFoundEmployee
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
            this.Coose = new System.Windows.Forms.Button();
            this.Panel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // ReturnToMenu
            // 
            this.ReturnToMenu.Location = new System.Drawing.Point(335, 275);
            // 
            // OneMore
            // 
            this.OneMore.Location = new System.Drawing.Point(500, 275);
            this.OneMore.Name = "OneMore";
            this.OneMore.Size = new System.Drawing.Size(125, 25);
            this.OneMore.TabIndex = 6;
            this.OneMore.Text = "Вести данные заново";
            this.OneMore.UseVisualStyleBackColor = true;
            this.OneMore.Click += new System.EventHandler(this.OneMore_Click);
            // 
            // Coose
            // 
            this.Coose.Location = new System.Drawing.Point(630, 275);
            this.Coose.Name = "Coose";
            this.Coose.Size = new System.Drawing.Size(120, 25);
            this.Coose.TabIndex = 8;
            this.Coose.Text = "Удалить сотрудника";
            this.Coose.UseVisualStyleBackColor = true;
            this.Coose.Click += new System.EventHandler(this.Coose_Click);
            // 
            // Panel
            // 
            this.Panel.Location = new System.Drawing.Point(50, 115);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(700, 25);
            this.Panel.TabIndex = 5;
            // 
            // DFoundEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Coose);
            this.Controls.Add(this.OneMore);
            this.Controls.Add(this.Panel);
            this.Name = "DFoundEmployee";
            this.Text = "Удаление данных сотрудника";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DFoundEmployeeClosed);
            this.Controls.SetChildIndex(this.Panel, 0);
            this.Controls.SetChildIndex(this.ReturnToMenu, 0);
            this.Controls.SetChildIndex(this.OneMore, 0);
            this.Controls.SetChildIndex(this.Coose, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OneMore;
        private System.Windows.Forms.Button Coose;
        private System.Windows.Forms.Panel Panel;
    }
}