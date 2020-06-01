namespace ManagementOfEmployee_sData
{
    partial class TEnterData
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
            this.Cancel = new System.Windows.Forms.Button();
            this.EmployeeName = new System.Windows.Forms.Label();
            this.MiddleName = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.Label();
            this.BirthDate = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.Label();
            this.Department = new System.Windows.Forms.Label();
            this.DescriptionOfYourself = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.MiddleNameBox = new System.Windows.Forms.TextBox();
            this.LastNameBox = new System.Windows.Forms.TextBox();
            this.AddressBox = new System.Windows.Forms.TextBox();
            this.DepartmentBox = new System.Windows.Forms.TextBox();
            this.DescriptionBox = new System.Windows.Forms.TextBox();
            this.DayBox = new System.Windows.Forms.TextBox();
            this.Day = new System.Windows.Forms.Label();
            this.Mounth = new System.Windows.Forms.Label();
            this.MounthBox = new System.Windows.Forms.TextBox();
            this.Year = new System.Windows.Forms.Label();
            this.YearBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(520, 330);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 25);
            this.Cancel.TabIndex = 0;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // EmployeeName
            // 
            this.EmployeeName.AutoSize = true;
            this.EmployeeName.Location = new System.Drawing.Point(65, 135);
            this.EmployeeName.Name = "EmployeeName";
            this.EmployeeName.Size = new System.Drawing.Size(130, 13);
            this.EmployeeName.TabIndex = 3;
            this.EmployeeName.Text = "Ведитк имя сотрудника:";
            // 
            // MiddleName
            // 
            this.MiddleName.AutoSize = true;
            this.MiddleName.Location = new System.Drawing.Point(65, 160);
            this.MiddleName.Name = "MiddleName";
            this.MiddleName.Size = new System.Drawing.Size(220, 13);
            this.MiddleName.TabIndex = 4;
            this.MiddleName.Text = "Введите отчество сотрудника (если есть):";
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Location = new System.Drawing.Point(65, 110);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(167, 13);
            this.LastName.TabIndex = 2;
            this.LastName.Text = "Введите фамилию сотрудника: ";
            // 
            // BirthDate
            // 
            this.BirthDate.AutoSize = true;
            this.BirthDate.Location = new System.Drawing.Point(65, 185);
            this.BirthDate.Name = "BirthDate";
            this.BirthDate.Size = new System.Drawing.Size(191, 13);
            this.BirthDate.TabIndex = 5;
            this.BirthDate.Text = "Введите дату рождения сотрудника:";
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Location = new System.Drawing.Point(65, 210);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(214, 13);
            this.Address.TabIndex = 6;
            this.Address.Text = "Введите адресс проживания сотрудника";
            // 
            // Department
            // 
            this.Department.AutoSize = true;
            this.Department.Location = new System.Drawing.Point(65, 235);
            this.Department.Name = "Department";
            this.Department.Size = new System.Drawing.Size(263, 13);
            this.Department.TabIndex = 7;
            this.Department.Text = "Введите отдел, которому принадлежит сотрудник:";
            // 
            // DescriptionOfYourself
            // 
            this.DescriptionOfYourself.AutoSize = true;
            this.DescriptionOfYourself.Location = new System.Drawing.Point(66, 260);
            this.DescriptionOfYourself.Name = "DescriptionOfYourself";
            this.DescriptionOfYourself.Size = new System.Drawing.Size(168, 13);
            this.DescriptionOfYourself.TabIndex = 8;
            this.DescriptionOfYourself.Text = "Введите данные поля \"О себе\":";
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(375, 132);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(365, 20);
            this.NameBox.TabIndex = 10;
            // 
            // MiddleNameBox
            // 
            this.MiddleNameBox.Location = new System.Drawing.Point(375, 157);
            this.MiddleNameBox.Name = "MiddleNameBox";
            this.MiddleNameBox.Size = new System.Drawing.Size(365, 20);
            this.MiddleNameBox.TabIndex = 11;
            // 
            // LastNameBox
            // 
            this.LastNameBox.Location = new System.Drawing.Point(375, 107);
            this.LastNameBox.Name = "LastNameBox";
            this.LastNameBox.Size = new System.Drawing.Size(365, 20);
            this.LastNameBox.TabIndex = 9;
            // 
            // AddressBox
            // 
            this.AddressBox.Location = new System.Drawing.Point(375, 207);
            this.AddressBox.Name = "AddressBox";
            this.AddressBox.Size = new System.Drawing.Size(365, 20);
            this.AddressBox.TabIndex = 15;
            this.AddressBox.TextChanged += new System.EventHandler(this.AddressBox_TextChanged);
            // 
            // DepartmentBox
            // 
            this.DepartmentBox.Location = new System.Drawing.Point(375, 232);
            this.DepartmentBox.Name = "DepartmentBox";
            this.DepartmentBox.Size = new System.Drawing.Size(365, 20);
            this.DepartmentBox.TabIndex = 18;
            // 
            // DescriptionBox
            // 
            this.DescriptionBox.Location = new System.Drawing.Point(375, 257);
            this.DescriptionBox.Name = "DescriptionBox";
            this.DescriptionBox.Size = new System.Drawing.Size(365, 20);
            this.DescriptionBox.TabIndex = 20;
            // 
            // DayBox
            // 
            this.DayBox.Location = new System.Drawing.Point(418, 182);
            this.DayBox.Name = "DayBox";
            this.DayBox.Size = new System.Drawing.Size(60, 20);
            this.DayBox.TabIndex = 12;
            // 
            // Day
            // 
            this.Day.AutoSize = true;
            this.Day.Location = new System.Drawing.Point(378, 185);
            this.Day.Name = "Day";
            this.Day.Size = new System.Drawing.Size(37, 13);
            this.Day.TabIndex = 16;
            this.Day.Text = "День:";
            // 
            // Mounth
            // 
            this.Mounth.AutoSize = true;
            this.Mounth.Location = new System.Drawing.Point(481, 185);
            this.Mounth.Name = "Mounth";
            this.Mounth.Size = new System.Drawing.Size(43, 13);
            this.Mounth.TabIndex = 17;
            this.Mounth.Text = "Месяц:";
            // 
            // MounthBox
            // 
            this.MounthBox.Location = new System.Drawing.Point(527, 182);
            this.MounthBox.Name = "MounthBox";
            this.MounthBox.Size = new System.Drawing.Size(60, 20);
            this.MounthBox.TabIndex = 13;
            // 
            // Year
            // 
            this.Year.AutoSize = true;
            this.Year.Location = new System.Drawing.Point(590, 185);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(28, 13);
            this.Year.TabIndex = 19;
            this.Year.Text = "Год:";
            // 
            // YearBox
            // 
            this.YearBox.Location = new System.Drawing.Point(621, 183);
            this.YearBox.Name = "YearBox";
            this.YearBox.Size = new System.Drawing.Size(119, 20);
            this.YearBox.TabIndex = 14;
            // 
            // TEnterData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Mounth);
            this.Controls.Add(this.Year);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.MiddleNameBox);
            this.Controls.Add(this.LastNameBox);
            this.Controls.Add(this.AddressBox);
            this.Controls.Add(this.DepartmentBox);
            this.Controls.Add(this.DescriptionBox);
            this.Controls.Add(this.DayBox);
            this.Controls.Add(this.MounthBox);
            this.Controls.Add(this.YearBox);
            this.Controls.Add(this.Day);
            this.Controls.Add(this.DescriptionOfYourself);
            this.Controls.Add(this.Department);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.BirthDate);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.MiddleName);
            this.Controls.Add(this.EmployeeName);
            this.Controls.Add(this.Cancel);
            this.Name = "TEnterData";
            this.Text = "TEnterData";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button Cancel;
        public System.Windows.Forms.Label EmployeeName;
        public System.Windows.Forms.Label MiddleName;
        public System.Windows.Forms.Label LastName;
        public System.Windows.Forms.Label BirthDate;
        public System.Windows.Forms.Label Address;
        public System.Windows.Forms.Label Department;
        public System.Windows.Forms.Label DescriptionOfYourself;
        public System.Windows.Forms.Label Day;
        public System.Windows.Forms.Label Mounth;
        public System.Windows.Forms.Label Year;
        public System.Windows.Forms.TextBox NameBox;
        public System.Windows.Forms.TextBox MiddleNameBox;
        public System.Windows.Forms.TextBox LastNameBox;
        public System.Windows.Forms.TextBox AddressBox;
        public System.Windows.Forms.TextBox DepartmentBox;
        public System.Windows.Forms.TextBox DescriptionBox;
        public System.Windows.Forms.TextBox DayBox;
        public System.Windows.Forms.TextBox MounthBox;
        public System.Windows.Forms.TextBox YearBox;
    }
}