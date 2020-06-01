// Форма появляется в случае нахождения более чем одного сотрудника, при поиске сотрудника на предыдушей форме
// Форма используется для выбора одного из найденных сотрудников
// Данная форма принадлежит ветке удаления сотрудника
// Все формы имеющие префикс "D" пинадлежат ветке удаления сотрудника


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
    public partial class DFoundEmployees : TManyCoincidences
    {
        // Буфер для хранения данных сотрудника, выбранного для изменения
        Employee EmployeeData;
        // Вызов данной формы, с передачей в качестве аргумента писка специальных классов с данными сотрудников, найденных на предыдущей форме
        public DFoundEmployees(List<Employee> EmployeesData)
        {
            int width = 0;
            foreach (var EmployeeData in EmployeesData)
            {
                // создание и динамический вывод на экран блока "EmployeePanel" и переключателя "ChooseEmployeeButton" в нутри блока "Panel"
                InitializeComponent();
                var EmployeePanel = new Panel
                {
                    Location = new System.Drawing.Point(0, width),
                    Size = new System.Drawing.Size(775, 25)
                };
                var ChooseEmployeeButton = new RadioButton
                {
                    Location = new System.Drawing.Point(0, 0),
                    Size = new System.Drawing.Size(15, 19),
                    Text = "",
                    // Сохранение ID сотрудника для передачи его в обработчик события "Изменение нажатости переключателя "ChooseEmployeeButton""
                    TabIndex = (int)EmployeeData.ID
                };
                width += 80;
                Panel.Controls.Add(ChooseEmployeeButton);
                // Вызлв события "Изменение нажатости переключателя "ChooseEmployeeButton""
                ChooseEmployeeButton.CheckedChanged += new System.EventHandler(this.ChooseEmployeeButton_CheckedChanged);
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
                    Size = new System.Drawing.Size(200, 25)
                };
                EmployeePanel.Controls.Add(EmployeeDescription);
                // Добавление сотрудника
                Panel.Controls.Add(EmployeePanel);
            }
        }

        // Закрытие прогораммы при закрытии формы
        private void DFoundEmployeesClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        // Обработка события "Изменение нажатости переключателя "ChooseEmployeeButton""
        private void ChooseEmployeeButton_CheckedChanged(object sender, EventArgs e)
        {
            var sRB = (RadioButton)sender;
            // Обработка происходит только при изменении статуса на "Нажато"
            if (sRB.Checked)
            {
                // Соханение в буфер данных сотрудника связанных с нажатой кнопкой
                EmployeeData = Service.GetEmployee((uint)sRB.TabIndex);
            }
        }

        // Обработка события "нажатие на кнопку "Найти другого сотрудника""
        private void Coose_Click(object sender, EventArgs e)
        {
            // Вывод сообщения о том, что не выбран ни один сотрудник
            if (EmployeeData == null)
            {
                MessageBox.Show(
        "Не выбран ни один сотрудник!",
        "Выберите сотрудника",
        MessageBoxButtons.OK,
        MessageBoxIcon.Information,
        MessageBoxDefaultButton.Button1,
        MessageBoxOptions.DefaultDesktopOnly);
            }
            else
            {
                // Вызов функции "Удаление сотрудника"
                Service.DeleteEmployee(EmployeeData.ID);
                // Закрытие данной формы, создание нового экземполяра формы "Сотрудник успешно удален" и открытие данного экземпляра
                this.Hide();
                var DeletingForm = new DSaccessfullyCompleted();
                DeletingForm.Show();
            }
        }

        private void Message_Click(object sender, EventArgs e)
        {

        }
    }
}
