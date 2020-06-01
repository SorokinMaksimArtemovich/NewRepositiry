namespace ManagementOfEmployee_sData
{
    partial class SearchingEmployee
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
            this.Choose = new System.Windows.Forms.Button();
            this.Message = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Choose
            // 
            this.Choose.Location = new System.Drawing.Point(605, 300);
            this.Choose.Name = "Choose";
            this.Choose.Size = new System.Drawing.Size(110, 25);
            this.Choose.TabIndex = 10;
            this.Choose.Text = "Найти сотрудника";
            this.Choose.UseVisualStyleBackColor = true;
            this.Choose.Click += new System.EventHandler(this.Choose_Click);
            // 
            // Message
            // 
            this.Message.AutoSize = true;
            this.Message.Location = new System.Drawing.Point(325, 70);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(150, 13);
            this.Message.TabIndex = 11;
            this.Message.Text = "Введите данные сотрудника:";
            // 
            // SearchingEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Message);
            this.Controls.Add(this.Choose);
            this.Name = "SearchingEmployee";
            this.Text = "Поиск сотрудника";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SearchingEmployeeClosed);
            this.Controls.SetChildIndex(this.NameBox, 0);
            this.Controls.SetChildIndex(this.MiddleNameBox, 0);
            this.Controls.SetChildIndex(this.LastNameBox, 0);
            this.Controls.SetChildIndex(this.DepartmentBox, 0);
            this.Controls.SetChildIndex(this.Choose, 0);
            this.Controls.SetChildIndex(this.Message, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private System.Windows.Forms.Button Choose;
        private System.Windows.Forms.Label Message;
    }
}