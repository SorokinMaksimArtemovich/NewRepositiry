namespace ManagementOfEmployee_sData
{
    partial class AddingEmployee
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
            this.Message = new System.Windows.Forms.Label();
            this.AddEmployee = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Message
            // 
            this.Message.AutoSize = true;
            this.Message.Location = new System.Drawing.Point(325, 50);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(148, 13);
            this.Message.TabIndex = 21;
            this.Message.Text = "Ведите данные сотрудника:";
            // 
            // AddEmployee
            // 
            this.AddEmployee.Location = new System.Drawing.Point(600, 330);
            this.AddEmployee.Name = "AddEmployee";
            this.AddEmployee.Size = new System.Drawing.Size(140, 25);
            this.AddEmployee.TabIndex = 22;
            this.AddEmployee.Text = "Добавить сотрудника";
            this.AddEmployee.UseVisualStyleBackColor = true;
            this.AddEmployee.Click += new System.EventHandler(this.AddEmployee_Click);
            // 
            // AddingEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddEmployee);
            this.Controls.Add(this.Message);
            this.Name = "AddingEmployee";
            this.Text = "Добавление сотрудника";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddingEmployeeClosed);
            this.Controls.SetChildIndex(this.Cancel, 0);
            this.Controls.SetChildIndex(this.EmployeeName, 0);
            this.Controls.SetChildIndex(this.MiddleName, 0);
            this.Controls.SetChildIndex(this.LastName, 0);
            this.Controls.SetChildIndex(this.BirthDate, 0);
            this.Controls.SetChildIndex(this.Address, 0);
            this.Controls.SetChildIndex(this.Department, 0);
            this.Controls.SetChildIndex(this.DescriptionOfYourself, 0);
            this.Controls.SetChildIndex(this.Day, 0);
            this.Controls.SetChildIndex(this.Year, 0);
            this.Controls.SetChildIndex(this.Mounth, 0);
            this.Controls.SetChildIndex(this.Message, 0);
            this.Controls.SetChildIndex(this.AddEmployee, 0);
            this.Controls.SetChildIndex(this.YearBox, 0);
            this.Controls.SetChildIndex(this.MounthBox, 0);
            this.Controls.SetChildIndex(this.DayBox, 0);
            this.Controls.SetChildIndex(this.DescriptionBox, 0);
            this.Controls.SetChildIndex(this.DepartmentBox, 0);
            this.Controls.SetChildIndex(this.AddressBox, 0);
            this.Controls.SetChildIndex(this.LastNameBox, 0);
            this.Controls.SetChildIndex(this.MiddleNameBox, 0);
            this.Controls.SetChildIndex(this.NameBox, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Message;
        private System.Windows.Forms.Button AddEmployee;
    }
}