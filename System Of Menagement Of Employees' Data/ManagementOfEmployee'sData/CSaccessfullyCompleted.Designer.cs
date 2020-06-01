namespace ManagementOfEmployee_sData
{
    partial class CSaccessfullyCompleted
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
            this.ChangeMore = new System.Windows.Forms.Button();
            this.SaccessfullyCompletedMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ChangeMore
            // 
            this.ChangeMore.Location = new System.Drawing.Point(402, 200);
            this.ChangeMore.Name = "ChangeMore";
            this.ChangeMore.Size = new System.Drawing.Size(180, 25);
            this.ChangeMore.TabIndex = 3;
            this.ChangeMore.Text = "Изменить ещё";
            this.ChangeMore.UseVisualStyleBackColor = true;
            this.ChangeMore.Click += new System.EventHandler(this.ChangeMore_Click);
            // 
            // SaccessfullyCompletedMessage
            // 
            this.SaccessfullyCompletedMessage.AutoSize = true;
            this.SaccessfullyCompletedMessage.Location = new System.Drawing.Point(325, 90);
            this.SaccessfullyCompletedMessage.Name = "SaccessfullyCompletedMessage";
            this.SaccessfullyCompletedMessage.Size = new System.Drawing.Size(150, 13);
            this.SaccessfullyCompletedMessage.TabIndex = 4;
            this.SaccessfullyCompletedMessage.Text = "Данные успешно изменены!";
            // 
            // CSaccessfullyCompleted
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SaccessfullyCompletedMessage);
            this.Controls.Add(this.ChangeMore);
            this.Name = "CSaccessfullyCompleted";
            this.Text = "Изменение данных сотрудника";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CSaccessfullyCompletedClosed);
            this.Controls.SetChildIndex(this.ChangeMore, 0);
            this.Controls.SetChildIndex(this.SaccessfullyCompletedMessage, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ChangeMore;
        private System.Windows.Forms.Label SaccessfullyCompletedMessage;
    }
}