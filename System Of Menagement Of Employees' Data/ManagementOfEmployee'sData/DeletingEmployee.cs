// Форма отвечающая за главную страницу удаления сотрудника
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
    // Форма реализованна с использованием шаблона "TSearchEmployee"
    public partial class DeletingEmployee : TSearchEmployee
    {
        // Вызов данной формы
        public DeletingEmployee()
        {
            InitializeComponent();
        }

        // Обработка события "нажатие на кнопку "Найти сотрудника""
        private void Search_Click(object sender, EventArgs e)
        {
            // Заполнение переменных введенными пользователем данными
            string Name = NameBox.Text;
            string LastName = LastNameBox.Text;
            string MiddleName = MiddleNameBox.Text;
            string Department = DepartmentBox.Text;
            // Вызов сообщения с предупреждением при отсутствии заполнения объязательных ячеек
            if (Name == "" || LastName == "" || Department == "")
            {
                // Вывод сообщения с предупреждением
                MessageBox.Show(
        "Поля \"имя\", \"фамилия\" и \"отдел\" должны быть заплнены",
        "Добавление сотрудника",
        MessageBoxButtons.OK,
        MessageBoxIcon.Information,
        MessageBoxDefaultButton.Button1,
        MessageBoxOptions.DefaultDesktopOnly);
            }
            else
            {
                // В случае, если объязательные формы заполнены, вызывается функция поиска сотрудника 
                //(с отчеством или без него в зависимости от введеных данных)
                if (MiddleName == "")
                {
                    MiddleName = "NULL";
                }
                // ID полученные из функции помещаются в специальный список
                List<uint> IDs = Service.GetEmployeeID(Name, LastName, MiddleName, Department);
                // Если список не содержит элементов открывается форма "Не найдено ни одного сотрудника"
                if (IDs.Count() == 0)
                {
                    // Закрытие данной формы, создание нового экземполяра формы "Не найдено ни одного сотрудника" и открытие данного экземпляра
                    this.Hide();
                    var NotFound = new DNotFoundEmployee();
                    NotFound.Show();
                }
                // Если список содержит один элемент открывается форма "найден один сотрудник"
                else if (IDs.Count() == 1)
                {
                    // Закрытие данной формы, создание нового экземполяра формы "найден один сотрудник" с передачей в неё этого сотрудника и открытие данного экземпляра
                    this.Hide();
                    var OneFound = new DFoundEmployee(Service.GetEmployee(IDs[0]));
                    OneFound.Show();
                }
                // Если список содержит более одного элемента открывается форма "найдено много сотрудников"
                else
                {
                    // Создание и заполнение списка подходящих сотрудников для передачи их на следующую форму
                    var EmployeesData = new List<Employee>();
                    foreach (var i in IDs)
                    {
                        EmployeesData.Add(Service.GetEmployee(i));
                    }
                    // Закрытие данной формы, создание нового экземполяра формы "найдено много сотрудников" с передачей списка этих сотрудников и открытие данного экземпляра
                    this.Hide();
                    var ManyFound = new DFoundEmployees(EmployeesData);
                    ManyFound.Show();
                }
            }
        }

        // Закрытие прогораммы при закрытии формы
        private void DeletingEmployeeClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
