// Форма отвечающая за главную страницу добавления пльзователя
// Все формы имеющие префикс "A" пинадлежат ветке добавления сотрудника


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
    // Форма реализованна с использованием шаблона "TEnterData"
    public partial class AddingEmployee : TEnterData
    {
        // Вызов данной формы
        public AddingEmployee()
        {
            InitializeComponent();
        }

        // Обработка события "нажатие на кнопку "Добавить сотрудника""
        private void AddEmployee_Click(object sender, EventArgs e)
        {
            // Заполнение переменных введенными пользователем данными
            string Name = NameBox.Text;
            string MiddleName = MiddleNameBox.Text;
            string LastName = LastNameBox.Text;
            int Year, Mounth, Day;
            string Address = AddressBox.Text;
            string Department = DepartmentBox.Text;
            string Description = DescriptionBox.Text;
            // Вызов сообщения с предупреждением при отсутствии заполнения объязательных ячеек
            if (Name == "" || LastName == "" || DayBox.Text == "" || MounthBox.Text == "" || YearBox.Text == "" || Address == "" || Department == "" || Description == "")
            {
                // Вывод сообщения с предупреждением
                MessageBox.Show(
        "Поля \"имя\", \"фамилия\", \"день\", \"месяц\", \"год\", \"адрес\", \"отдел\" и \"О себе\" должны быть заплнены",
        "Добавление сотрудника",
        MessageBoxButtons.OK,
        MessageBoxIcon.Information,
        MessageBoxDefaultButton.Button1,
        MessageBoxOptions.DefaultDesktopOnly);
            }
            else
            {
                // В случае, если объязательные формы заполнены, идет проверка корректрости введенной даты
                bool IsDateCorrect = Int32.TryParse(YearBox.Text, out Year);
                IsDateCorrect &= Int32.TryParse(MounthBox.Text, out Mounth);
                IsDateCorrect &= Int32.TryParse(DayBox.Text, out Day);
                if (IsDateCorrect)
                {
                    DateTime BirthDate = new DateTime(Year, Mounth, Day);
                    // Если дата введена корректно, вызывается функция добавления сотрудника 
                    //(с отчеством или без него в зависимости от введеных данных)
                    if (MiddleName == "")
                    {
                        Service.AddEmployee(Name, LastName, BirthDate, Address, Department, Description);
                    }
                    else
                    {
                        Service.AddEmployee(Name, MiddleName, LastName, BirthDate, Address, Department, Description);
                    }
                    this.Hide();
                    var AddForm = new ASaccessfullyCompleted();
                    AddForm.Show();
                }
                else
                {
                    //вывод сообщения о ненорректно введеноой дате
                    MessageBox.Show(
        "Некорректно введена дата!",
        "Добавление сотрудника",
        MessageBoxButtons.OK,
        MessageBoxIcon.Information,
        MessageBoxDefaultButton.Button1,
        MessageBoxOptions.DefaultDesktopOnly);
                }
            }
        }

        // Закрытие прогораммы при закрытии формы
        private void AddingEmployeeClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
