// Форма появляется в случае успешного изменения сотрудника
// Форма используется возврата в меню или повторного введения данных для поиска сотрудника для изменения
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
    // Форма реализованна с использованием шаблона "TSaccessfullyCompleted"
    public partial class CSaccessfullyCompleted : TSaccessfullyCompleted
    {
        // Вызов данной формы
        public CSaccessfullyCompleted()
        {
            InitializeComponent();
        }

        // Обработка события "нажатие на кнопку "Изменить ещё""
        private void ChangeMore_Click(object sender, EventArgs e)
        {
            // Закрытие данной формы, а также сиздание и вызов формы "Изменение данных сотрудника" 
            this.Hide();
            var ChangeMoreForm = new ChangeEmployee_sData();
            ChangeMoreForm.Show();
        }

        // Закрытие прогораммы при закрытии формы
        private void CSaccessfullyCompletedClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
