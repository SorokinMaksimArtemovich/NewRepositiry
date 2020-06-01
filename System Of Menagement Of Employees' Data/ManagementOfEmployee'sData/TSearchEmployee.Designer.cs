namespace ManagementOfEmployee_sData
{
    partial class TSearchEmployee
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
            this.EmployeeName = new System.Windows.Forms.Label();
            this.MiddleName = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.Label();
            this.Department = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.MiddleNameBox = new System.Windows.Forms.TextBox();
            this.LastNameBox = new System.Windows.Forms.TextBox();
            this.DepartmentBox = new System.Windows.Forms.TextBox();
            this.Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EmployeeName
            // 
            this.EmployeeName.AutoSize = true;
            this.EmployeeName.Location = new System.Drawing.Point(85, 168);
            this.EmployeeName.Name = "EmployeeName";
            this.EmployeeName.Size = new System.Drawing.Size(133, 13);
            this.EmployeeName.TabIndex = 1;
            this.EmployeeName.Text = "Введите имя сотрудника";
            // 
            // MiddleName
            // 
            this.MiddleName.AutoSize = true;
            this.MiddleName.Location = new System.Drawing.Point(85, 193);
            this.MiddleName.Name = "MiddleName";
            this.MiddleName.Size = new System.Drawing.Size(217, 13);
            this.MiddleName.TabIndex = 2;
            this.MiddleName.Text = "Введите отчество сотрудника (если есть)";
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Location = new System.Drawing.Point(85, 143);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(155, 13);
            this.LastName.TabIndex = 3;
            this.LastName.Text = "Ведите фамилию сотрудника";
            // 
            // Department
            // 
            this.Department.AutoSize = true;
            this.Department.Location = new System.Drawing.Point(85, 218);
            this.Department.Name = "Department";
            this.Department.Size = new System.Drawing.Size(240, 13);
            this.Department.TabIndex = 4;
            this.Department.Text = "Введите отдел в котором работает сотрудник";
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(365, 165);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(350, 20);
            this.NameBox.TabIndex = 5;
            // 
            // MiddleNameBox
            // 
            this.MiddleNameBox.Location = new System.Drawing.Point(365, 190);
            this.MiddleNameBox.Name = "MiddleNameBox";
            this.MiddleNameBox.Size = new System.Drawing.Size(350, 20);
            this.MiddleNameBox.TabIndex = 6;
            // 
            // LastNameBox
            // 
            this.LastNameBox.Location = new System.Drawing.Point(365, 140);
            this.LastNameBox.Name = "LastNameBox";
            this.LastNameBox.Size = new System.Drawing.Size(350, 20);
            this.LastNameBox.TabIndex = 7;
            // 
            // DepartmentBox
            // 
            this.DepartmentBox.Location = new System.Drawing.Point(365, 215);
            this.DepartmentBox.Name = "DepartmentBox";
            this.DepartmentBox.Size = new System.Drawing.Size(350, 20);
            this.DepartmentBox.TabIndex = 8;
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(490, 300);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(110, 25);
            this.Cancel.TabIndex = 9;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // TSearchEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.DepartmentBox);
            this.Controls.Add(this.LastNameBox);
            this.Controls.Add(this.MiddleNameBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.Department);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.MiddleName);
            this.Controls.Add(this.EmployeeName);
            this.Name = "TSearchEmployee";
            this.Text = "TSearchEmployee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label EmployeeName;
        private System.Windows.Forms.Label MiddleName;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.Label Department;
        public System.Windows.Forms.TextBox NameBox;
        public System.Windows.Forms.TextBox MiddleNameBox;
        public System.Windows.Forms.TextBox LastNameBox;
        public System.Windows.Forms.TextBox DepartmentBox;
        private System.Windows.Forms.Button Cancel;
    }
}