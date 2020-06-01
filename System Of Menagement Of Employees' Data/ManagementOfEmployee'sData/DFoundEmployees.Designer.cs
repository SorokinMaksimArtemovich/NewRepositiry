namespace ManagementOfEmployee_sData
{
    partial class DFoundEmployees
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
            this.ChooseRequest = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ReturnToMenu
            // 
            this.ReturnToMenu.Location = new System.Drawing.Point(367, 382);
            // 
            // Message
            // 
            this.Message.Location = new System.Drawing.Point(260, 25);
            // 
            // OneMore
            // 
            this.OneMore.Location = new System.Drawing.Point(528, 382);
            this.OneMore.Name = "OneMore";
            this.OneMore.Size = new System.Drawing.Size(135, 25);
            this.OneMore.TabIndex = 6;
            this.OneMore.Text = "Ввести данные заново";
            this.OneMore.UseVisualStyleBackColor = true;
            // 
            // Coose
            // 
            this.Coose.Location = new System.Drawing.Point(669, 382);
            this.Coose.Name = "Coose";
            this.Coose.Size = new System.Drawing.Size(119, 25);
            this.Coose.TabIndex = 7;
            this.Coose.Text = "Удалить сотрудника";
            this.Coose.UseVisualStyleBackColor = true;
            this.Coose.Click += new System.EventHandler(this.Coose_Click);
            // 
            // ChooseRequest
            // 
            this.ChooseRequest.AutoSize = true;
            this.ChooseRequest.Location = new System.Drawing.Point(335, 50);
            this.ChooseRequest.Name = "ChooseRequest";
            this.ChooseRequest.Size = new System.Drawing.Size(130, 13);
            this.ChooseRequest.TabIndex = 8;
            this.ChooseRequest.Text = "Выберите одного из них";
            // 
            // DFoundEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ChooseRequest);
            this.Controls.Add(this.Coose);
            this.Controls.Add(this.OneMore);
            this.Name = "DFoundEmployees";
            this.Text = "Удаление данных сотрудника";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DFoundEmployeesClosed);
            this.Controls.SetChildIndex(this.Message, 0);
            this.Controls.SetChildIndex(this.OneMore, 0);
            this.Controls.SetChildIndex(this.Coose, 0);
            this.Controls.SetChildIndex(this.ChooseRequest, 0);
            this.Controls.SetChildIndex(this.ReturnToMenu, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OneMore;
        private System.Windows.Forms.Button Coose;
        private System.Windows.Forms.Label ChooseRequest;
    }
}