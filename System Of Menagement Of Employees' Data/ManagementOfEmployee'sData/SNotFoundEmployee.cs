// Форма появляется в случае не нахождения ни одного подходящего сотрудника, при поиске сотрудника на предыдушей форме
// Форма используется возврата в меню или повторного введения данных для поиска
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
    // Форма реализованна с использованием шаблона "TNotFoundEmployee"
    public partial class SNotFoundEmployee : TNotFoundEmployee
    {
        // Вызов данной формы
        public SNotFoundEmployee()
        {
            InitializeComponent();
        }

        // Закрытие прогораммы при закрытии формы
        private void SNotFoundEmployeeClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        // Обработка события "нажатие на кнопку "Ввести данные заново""
        private void AnotherTry_Click(object sender, EventArgs e)
        {
            // Закрытие данной формы, а также сиздание и вызов формы "Поиск сотрудника" 
            this.Hide();
            var ReturnToMenuForm = new SearchingEmployee();
            ReturnToMenuForm.Show();
        }
    }
}
