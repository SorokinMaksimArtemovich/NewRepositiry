// Форма появляется в случае нахождения одного сотрудника при поиске сотрудника на предыдушей форме
// Форма используется для вывода данных найденного сотрудника
// Данная форма принадлежит ветке поиска сотрудника
// Все формы имеющие префикс "S" пинадлежат ветке поиска сотрудника


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementOfEmployee_sData
{
    // Форма реализованна с использованием шаблона "TOneCoincidence"
    public partial class SFoundEmployee : TOneCoincidence
    {
        // Вызов данной формы, с передачей в качестве аргумента специального класса с данными сотрудника, найденного на предыдущей форме
        public SFoundEmployee(Employee FoundEmployee)
        {
            InitializeComponent();
            // создание и динамический вывод на экран блока с именем сотрудника в нутри блока "Panel"
            var EmployeeName = new TextBox
            {
                Text = FoundEmployee.Name,
                ReadOnly = true,
                ScrollBars = ScrollBars.Horizontal,
                Location = new System.Drawing.Point(0, 0),
                Size = new System.Drawing.Size(80, 25)
            };
            Panel.Controls.Add(EmployeeName);
            // создание и динамический вывод на экран блока с отчеством сотрудника в нутри блока "Panel"
            var EmployeeMiddleName = new TextBox
            {
                Text = FoundEmployee.MiddleName,
                ReadOnly = true,
                ScrollBars = ScrollBars.Horizontal,
                Location = new System.Drawing.Point(80, 0),
                Size = new System.Drawing.Size(80, 25)
            };
            Panel.Controls.Add(EmployeeMiddleName);
            // создание и динамический вывод на экран блока с фамилией сотрудника в нутри блока "Panel"
            var EmployeeLastName = new TextBox
            {
                Text = FoundEmployee.LastName,
                ReadOnly = true,
                ScrollBars = ScrollBars.Horizontal,
                Location = new System.Drawing.Point(160, 0),
                Size = new System.Drawing.Size(80, 25)
            };
            Panel.Controls.Add(EmployeeLastName);
            // создание и динамический вывод на экран блока с датой рождения сотрудника в нутри блока "Panel"
            var EmployeeBirthDate = new TextBox
            {
                Text = FoundEmployee.BirthDate.ToString(),
                ReadOnly = true,
                ScrollBars = ScrollBars.Horizontal,
                Location = new System.Drawing.Point(240, 0),
                Size = new System.Drawing.Size(80, 25)
            };
            Panel.Controls.Add(EmployeeBirthDate);
            // создание и динамический вывод на экран блока с адресом сотрудника в нутри блока "Panel"
            var EmployeeAddress = new TextBox
            {
                Text = FoundEmployee.Address,
                ReadOnly = true,
                ScrollBars = ScrollBars.Horizontal,
                Location = new System.Drawing.Point(320, 0),
                Size = new System.Drawing.Size(80, 25)
            };
            Panel.Controls.Add(EmployeeAddress);
            // создание и динамический вывод на экран блока с отделом сотрудника в нутри блока "Panel"
            var EmployeeDepartment = new TextBox
            {
                Text = FoundEmployee.Department,
                ReadOnly = true,
                ScrollBars = ScrollBars.Horizontal,
                Location = new System.Drawing.Point(400, 0),
                Size = new System.Drawing.Size(80, 25)
            };
            Panel.Controls.Add(EmployeeDepartment);
            // создание и динамический вывод на экран блока с данными сотрудника из поля "о себе" в нутри блока "Panel"
            var EmployeeDescription = new TextBox
            {
                Text = FoundEmployee.DescriptionOfYourself,
                ReadOnly = true,
                ScrollBars = ScrollBars.Both,
                Location = new System.Drawing.Point(480, 0),
                Size = new System.Drawing.Size(220, 25)
            };
            Panel.Controls.Add(EmployeeDescription);
        }

        // Обработка события "нажатие на кнопку "Ввести данные заново""
        private void OneMore_Click(object sender, EventArgs e)
        {
            // Закрытие данной формы, создание нового экземполяра формы "Поиск сотрудника" и открытие данного экземпляра
            this.Hide();
            var SearchingForm = new SearchingEmployee();
            SearchingForm.Show();
        }

        // Закрытие прогораммы при закрытии формы
        private void SFoundEmployeeClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
