// Форма появляется при выборе сотрудника для изменения его данных и содержит ячейки для изменения этих данных
// Данная форма принадлежит ветке изменения данных сотрудника
// Все формы имеющие префикс "C" пинадлежат ветке изменения данных сотрудника


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
    public partial class CEnteringNewData : TEnterData
    {
        // Буфер для хранения данных сотрудника, выбранного на предыдущей форме
        Employee ChangedEmployee;
        // Вызов данной формы, с передачей в качестве аргумента специального класса с данными сотрудника, выбранного на предыдущей форме
        public CEnteringNewData(Employee ChosenEmployee)
        {
            // Сохранение данных выбранного на предыдущей форме струдника в буфер
            ChangedEmployee = ChosenEmployee;
            InitializeComponent();
            // Вывод данных выбранного на предыдущей форме струдника на экран в текстоые блоки, для их возможного измнения
            NameBox.Text = ChosenEmployee.Name;
            MiddleNameBox.Text = ChosenEmployee.MiddleName;
            LastNameBox.Text = ChosenEmployee.LastName;
            DayBox.Text = ChosenEmployee.BirthDate.Day.ToString();
            MounthBox.Text = ChosenEmployee.BirthDate.Month.ToString();
            YearBox.Text = ChosenEmployee.BirthDate.Year.ToString();
            AddressBox.Text = ChosenEmployee.Address;
            DepartmentBox.Text = ChosenEmployee.Department;
            DescriptionBox.Text = ChosenEmployee.DescriptionOfYourself;
        }

        // Обработка события "нажатие на кнопку "Изменить данные""
        private void ChangeData_Click(object sender, EventArgs e)
        {
            // Сохранние прежненго ID сотрудника
            uint ID = ChangedEmployee.ID;
            // Сохранние измененных данных сотрудника
            string Name = NameBox.Text;
            string MiddleName = MiddleNameBox.Text;
            string LastName = LastNameBox.Text;
            int Year, Mounth, Day;
            string Address = AddressBox.Text;
            string Department = DepartmentBox.Text;
            string Description = DescriptionBox.Text;
            // Вызов сообщения с предупреждением, при отсутствии заполнения объязательных ячеек
            if (Name == "" || LastName == "" || DayBox.Text == "" || MounthBox.Text == "" || YearBox.Text == "" || Address == "" || Department == "" || Description == "")
            {
                // Вывод сообщения с предупреждением
                MessageBox.Show(
        "Поля \"имя\", \"фамилия\", \"день\", \"месяц\", \"год\", \"адрес\", \"отдел\" и \"О себе\" должны быть заплнены",
        "Изменение данных сотрудника",
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
                    //(с отчеством или без него, в зависимости от введеных данных)
                    if (MiddleName == "")
                    {
                        ChangedEmployee = new Employee(ID, Name, LastName, BirthDate, Address, Department, Description);
                    }
                    else
                    {
                        ChangedEmployee = new Employee(ID, Name, LastName, MiddleName, BirthDate, Address, Department, Description);
                    }
                    Service.ChangeEmployeeData(ChangedEmployee);
                    this.Hide();
                    var AddForm = new CSaccessfullyCompleted();
                    AddForm.Show();
                }
                else
                {
                    //вывод сообщения о ненорректно введеноой дате
                    MessageBox.Show(
        "Некорректно введена дата!",
        "Изменение данных сотрудника",
        MessageBoxButtons.OK,
        MessageBoxIcon.Information,
        MessageBoxDefaultButton.Button1,
        MessageBoxOptions.DefaultDesktopOnly);
                }
            }
        }

        // Закрытие прогораммы при закрытии формы
        private void CEnteringNewDataClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
