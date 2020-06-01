// Форма появляется в случае нахождения более чем одного сотрудника, при поиске сотрудника на предыдушей форм
// Форма используется для вывода данных найденных сотрудников
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
    // Форма реализованна с использованием шаблона "TManyCoincidences"
    public partial class SFoundEmployees : TManyCoincidences
    {
        // Вызов данной формы, с передачей в качестве аргумента писка специальных классов с данными сотрудников, найденных на предыдущей форме
        public SFoundEmployees(List<Employee> EmployeesData)
        {
            int width = 0;
            foreach (var EmployeeData in EmployeesData)
            {
                // создание и динамический вывод на экран блока "EmployeePanel" в нутри блока "Panel"
                InitializeComponent();
                var EmployeePanel = new Panel
                {
                    Location = new System.Drawing.Point(width, 0),
                    Size = new System.Drawing.Size(800, 25)
                };
                // создание и динамический вывод на экран блока с именем сотрудника внутри динамического блока "EmployeePanel"
                var EmployeeName = new TextBox
                {
                    Text = EmployeeData.Name,
                    ReadOnly = true,
                    ScrollBars = ScrollBars.Horizontal,
                    Location = new System.Drawing.Point(0, 0),
                    Size = new System.Drawing.Size(80, 25)
                };
                EmployeePanel.Controls.Add(EmployeeName);
                // создание и динамический вывод на экран блока с отчеством сотрудника внутри динамического блока "EmployeePanel"
                var EmployeeMiddleName = new TextBox
                {
                    Text = EmployeeData.MiddleName,
                    ReadOnly = true,
                    ScrollBars = ScrollBars.Horizontal,
                    Location = new System.Drawing.Point(80, 0),
                    Size = new System.Drawing.Size(80, 25)
                };
                EmployeePanel.Controls.Add(EmployeeMiddleName);
                // создание и динамический вывод на экран блока с фамилией сотрудника внутри динамического блока "EmployeePanel"
                var EmployeeLastName = new TextBox
                {
                    Text = EmployeeData.LastName,
                    ReadOnly = true,
                    ScrollBars = ScrollBars.Horizontal,
                    Location = new System.Drawing.Point(160, 0),
                    Size = new System.Drawing.Size(80, 25)
                };
                EmployeePanel.Controls.Add(EmployeeLastName);
                // создание и динамический вывод на экран блока с датой рождения сотрудника внутри динамического блока "EmployeePanel"
                var EmployeeBirthDate = new TextBox
                {
                    Text = EmployeeData.BirthDate.ToString(),
                    ReadOnly = true,
                    ScrollBars = ScrollBars.Horizontal,
                    Location = new System.Drawing.Point(240, 0),
                    Size = new System.Drawing.Size(80, 25)
                };
                EmployeePanel.Controls.Add(EmployeeBirthDate);
                // создание и динамический вывод на экран блока с адресом сотрудника внутри динамического блока "EmployeePanel"
                var EmployeeAddress = new TextBox
                {
                    Text = EmployeeData.Address,
                    ReadOnly = true,
                    ScrollBars = ScrollBars.Horizontal,
                    Location = new System.Drawing.Point(320, 0),
                    Size = new System.Drawing.Size(80, 25)
                };
                EmployeePanel.Controls.Add(EmployeeAddress);
                // создание и динамический вывод на экран блока с отделом сотрудника внутри динамического блока "EmployeePanel"
                var EmployeeDepartment = new TextBox
                {
                    Text = EmployeeData.Department,
                    ReadOnly = true,
                    ScrollBars = ScrollBars.Horizontal,
                    Location = new System.Drawing.Point(400, 0),
                    Size = new System.Drawing.Size(80, 25)
                };
                EmployeePanel.Controls.Add(EmployeeDepartment);
                // создание и динамический вывод на экран блока с данными сотрудника из поля "о себе" внутри динамического блока "EmployeePanel"
                var EmployeeDescription = new TextBox
                {
                    Text = EmployeeData.DescriptionOfYourself,
                    ReadOnly = true,
                    ScrollBars = ScrollBars.Both,
                    Location = new System.Drawing.Point(480, 0),
                    Size = new System.Drawing.Size(220, 25)
                };
                EmployeePanel.Controls.Add(EmployeeDescription);
                // Добавление сотрудника
                Panel.Controls.Add(EmployeePanel);
            }
        }

        // Закрытие прогораммы при закрытии формы
        private void SFoundEmployeesClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        // Обработка события "нажатие на кнопку "Ввести данные заново""
        private void OneMore_Click(object sender, EventArgs e)
        {
            // Закрытие данной формы, создание нового экземполяра формы "Поиск сотрудника" и открытие данного экземпляра
            this.Hide();
            var SearchForm = new SearchingEmployee();
            SearchForm.Show();
        }
    }
}
