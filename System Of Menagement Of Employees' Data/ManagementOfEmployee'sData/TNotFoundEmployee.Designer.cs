namespace ManagementOfEmployee_sData
{
    partial class TNotFoundEmployee
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
            this.AnotherTry = new System.Windows.Forms.Button();
            this.Message = new System.Windows.Forms.Label();
            this.NotFoundMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ReturnToMenu
            // 
            this.ReturnToMenu.Location = new System.Drawing.Point(238, 240);
            this.ReturnToMenu.Name = "ReturnToMenu";
            this.ReturnToMenu.Size = new System.Drawing.Size(160, 25);
            this.ReturnToMenu.TabIndex = 0;
            this.ReturnToMenu.Text = "Вернуться в главное меню";
            this.ReturnToMenu.UseVisualStyleBackColor = true;
            this.ReturnToMenu.Click += new System.EventHandler(this.ReturnToMenu_Click);
            // 
            // AnotherTry
            // 
            this.AnotherTry.Location = new System.Drawing.Point(402, 240);
            this.AnotherTry.Name = "AnotherTry";
            this.AnotherTry.Size = new System.Drawing.Size(160, 25);
            this.AnotherTry.TabIndex = 1;
            this.AnotherTry.Text = "Ввести данные заново";
            this.AnotherTry.UseVisualStyleBackColor = true;
            // 
            // Message
            // 
            this.Message.AutoSize = true;
            this.Message.Location = new System.Drawing.Point(312, 210);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(176, 13);
            this.Message.TabIndex = 2;
            this.Message.Text = "Выберите дальнейшее действие:";
            // 
            // NotFoundMessage
            // 
            this.NotFoundMessage.AutoSize = true;
            this.NotFoundMessage.Location = new System.Drawing.Point(205, 115);
            this.NotFoundMessage.Name = "NotFoundMessage";
            this.NotFoundMessage.Size = new System.Drawing.Size(392, 13);
            this.NotFoundMessage.TabIndex = 3;
            this.NotFoundMessage.Text = "По введенным вами даннымы, к сожалению, не найден ни один сотрудник!";
            // 
            // TNotFoundEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NotFoundMessage);
            this.Controls.Add(this.Message);
            this.Controls.Add(this.AnotherTry);
            this.Controls.Add(this.ReturnToMenu);
            this.Name = "TNotFoundEmployee";
            this.Text = "TNotFoundEmployee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ReturnToMenu;
        public System.Windows.Forms.Button AnotherTry;
        private System.Windows.Forms.Label Message;
        private System.Windows.Forms.Label NotFoundMessage;
    }
}