// Форма появляется в случае не нахождения ни одного подходящего сотрудника, при поиске сотрудника на предыдушей форме
// Форма используется возврата в меню или повторного введения данных для поиска
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
    // Форма реализованна с использованием шаблона "TNotFoundEmployee"
    public partial class CNotFoundEmployee : TNotFoundEmployee
    {
        // Вызов данной формы
        public CNotFoundEmployee()
        {
            InitializeComponent();
        }
        
        // Закрытие прогораммы при закрытии формы
        private void CNotFoundEmployeeClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        // Обработка события "нажатие на кнопку "Ввести данные заново""
        private void AnotherTry_Click(object sender, EventArgs e)
        {
            // Закрытие данной формы, а также сиздание и вызов формы "Изменение данных сотрудника" 
            this.Hide();
            var ChangeEmployee_sDataForm = new ChangeEmployee_sData();
            ChangeEmployee_sDataForm.Show();
        }
    }
}
