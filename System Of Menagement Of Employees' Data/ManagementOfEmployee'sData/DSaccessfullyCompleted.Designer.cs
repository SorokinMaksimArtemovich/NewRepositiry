namespace ManagementOfEmployee_sData
{
    partial class DSaccessfullyCompleted
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
            this.SaccessfullyCompletedMessage = new System.Windows.Forms.Label();
            this.DeleteMore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SaccessfullyCompletedMessage
            // 
            this.SaccessfullyCompletedMessage.AutoSize = true;
            this.SaccessfullyCompletedMessage.Location = new System.Drawing.Point(325, 90);
            this.SaccessfullyCompletedMessage.Name = "SaccessfullyCompletedMessage";
            this.SaccessfullyCompletedMessage.Size = new System.Drawing.Size(150, 13);
            this.SaccessfullyCompletedMessage.TabIndex = 3;
            this.SaccessfullyCompletedMessage.Text = "Сотрудник успешно удалён!";
            // 
            // DeleteMore
            // 
            this.DeleteMore.Location = new System.Drawing.Point(404, 200);
            this.DeleteMore.Name = "DeleteMore";
            this.DeleteMore.Size = new System.Drawing.Size(180, 25);
            this.DeleteMore.TabIndex = 4;
            this.DeleteMore.Text = "Удалить ещё одного";
            this.DeleteMore.UseVisualStyleBackColor = true;
            this.DeleteMore.Click += new System.EventHandler(this.DeleteMore_Click);
            // 
            // DSaccessfullyCompleted
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DeleteMore);
            this.Controls.Add(this.SaccessfullyCompletedMessage);
            this.Name = "DSaccessfullyCompleted";
            this.Text = "Удаление данных сотрудника";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EmployeeDeletedClosed);
            this.Controls.SetChildIndex(this.SaccessfullyCompletedMessage, 0);
            this.Controls.SetChildIndex(this.DeleteMore, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SaccessfullyCompletedMessage;
        private System.Windows.Forms.Button DeleteMore;
    }
}