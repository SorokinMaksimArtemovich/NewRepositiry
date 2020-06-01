// Главная форма приложения
// С данной формы можно перейти на следующие формы: добавления сотрудника, просмотра сотрудников,
// поиска сотрудника, изменения данных сотрудника и удаления сотрудника


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
    public partial class MainPage : Form
    {
        // Вызов данной формы
        public MainPage()
        {
            InitializeComponent();

        }

        // Обработка события "Нажатие на кнопку "Добавить сотрудника""
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            // Закрытие данной формы, создание нового экземполяра формы "Добавление сотрудника" и открытие данного экземпляра
            this.Hide();
            var AddForm = new AddingEmployee();
            AddForm.Show();
        }

        // Обработка события "Нажатие на кнопку "Поиск сотрудника""
        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            // Закрытие данной формы, создание нового экземполяра формы "Поиск сотрудника" и открытие данного экземпляра
            this.Hide();
            var SearchForm = new SearchingEmployee();
            SearchForm.Show();
        }

        // Обработка события "Нажатие на кнопку "Изменить данные сотрудника""
        private void ButtonChenge_Click(object sender, EventArgs e)
        {
            // Закрытие данной формы, создание нового экземполяра формы "Изменение данных сотрудника" и открытие данного экземпляра
            this.Hide();
            var ChangeForm = new ChangeEmployee_sData();
            ChangeForm.Show();
        }

        // Обработка события "Нажатие на кнопку "Удалить сотрудника сотрудника""
        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            // Закрытие данной формы, создание нового экземполяра формы "Удаление сотрудника" и открытие данного экземпляра
            this.Hide();
            var DeleteForm = new DeletingEmployee();
            DeleteForm.Show();
        }

        // Закрытие прогораммы при закрытии формы
        private void MainPageClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        // Обработка события "Нажатие на кнопку "Вывести данные всех сотрудников""
        private void ShowAllData_Click(object sender, EventArgs e)
        {
            // Закрытие данной формы, создание нового экземполяра формы "Удаление сотрудника" и открытие данного экземпляра
            this.Hide();
            var ShowAllForm = new ShowAllData();
            ShowAllForm.Show();
        }
    }
}
