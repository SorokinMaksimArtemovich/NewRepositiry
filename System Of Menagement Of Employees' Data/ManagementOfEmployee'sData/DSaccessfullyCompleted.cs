// Форма появляется в случае успешного изменения сотрудника
// Форма используется возврата в меню или повторного введения данных для поиска сотрудника для изменения
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
    // Форма реализованна с использованием шаблона "TSaccessfullyCompleted"
    public partial class DSaccessfullyCompleted : TSaccessfullyCompleted
    {
        // Вызов данной формы
        public DSaccessfullyCompleted()
        {
            InitializeComponent();
        }

        // Закрытие прогораммы при закрытии формы
        private void EmployeeDeletedClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        // Обработка события "нажатие на кнопку "Удалить ещё""
        private void DeleteMore_Click(object sender, EventArgs e)
        {
            // Закрытие данной формы, а также сиздание и вызов формы "Удаление сотрудника" 
            this.Hide();
            var DeletingForm = new DeletingEmployee();
            DeletingForm.Show();
        }
    }
}
