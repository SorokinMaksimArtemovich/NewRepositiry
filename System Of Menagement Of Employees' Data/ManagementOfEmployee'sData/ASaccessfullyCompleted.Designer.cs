namespace ManagementOfEmployee_sData
{
    partial class ASaccessfullyCompleted
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
            this.AddMore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SaccessfullyCompletedMessage
            // 
            this.SaccessfullyCompletedMessage.AutoSize = true;
            this.SaccessfullyCompletedMessage.Location = new System.Drawing.Point(320, 100);
            this.SaccessfullyCompletedMessage.Name = "SaccessfullyCompletedMessage";
            this.SaccessfullyCompletedMessage.Size = new System.Drawing.Size(160, 13);
            this.SaccessfullyCompletedMessage.TabIndex = 3;
            this.SaccessfullyCompletedMessage.Text = "Сотрудник успешно добавлен!";
            // 
            // AddMore
            // 
            this.AddMore.Location = new System.Drawing.Point(404, 200);
            this.AddMore.Name = "AddMore";
            this.AddMore.Size = new System.Drawing.Size(180, 25);
            this.AddMore.TabIndex = 4;
            this.AddMore.Text = "Добавить ещё одного";
            this.AddMore.UseVisualStyleBackColor = true;
            this.AddMore.Click += new System.EventHandler(this.AddMore_Click);
            // 
            // ASaccessfullyCompleted
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddMore);
            this.Controls.Add(this.SaccessfullyCompletedMessage);
            this.Name = "ASaccessfullyCompleted";
            this.Text = "Добавление сотрудника";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ASaccessfullyCompletedClosed);
            this.Controls.SetChildIndex(this.SaccessfullyCompletedMessage, 0);
            this.Controls.SetChildIndex(this.AddMore, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SaccessfullyCompletedMessage;
        private System.Windows.Forms.Button AddMore;
    }
}