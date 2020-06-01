// Форма появляющаяся в случае корректного добавления данных 
// Данная форма принадлежит ыетке добавления сотрудника
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
    // Форма реализованна с использованием шаблона "TSaccessfullyCompleted"
    public partial class ASaccessfullyCompleted : TSaccessfullyCompleted
    {

        // Вызов данной формы
        public ASaccessfullyCompleted()
        {
            InitializeComponent();
        }

        // Обработка события "нажатие на кнопку "Добавить ещё одного""
        private void AddMore_Click(object sender, EventArgs e)
        {
            // Закрытие формы, создание нового экземпляра формы "Добавление сотрудника" и её вывод
            this.Hide();
            var AddMoreForm = new AddingEmployee();
            AddMoreForm.Show();
        }

        // Закрытие прогораммы при закрытии формы
        private void ASaccessfullyCompletedClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
