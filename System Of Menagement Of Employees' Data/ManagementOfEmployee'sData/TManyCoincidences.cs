// Шаблон формы получения больше чем одного найденного сотрудника
// Формы с префиксом "T" являются шаблонами


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
    public partial class TManyCoincidences : Form
    {
        // Создание экземпляра по-умолчанию
        public TManyCoincidences()
        {
            InitializeComponent();
        }

        // Обработка события "Нажатие кнопки "Возврат на главную страницу""
        private void ReturnToMenu_Click(object sender, EventArgs e)
        {
            // Закрытие данной формы, а ьакже создание экземпляра формы "Гладная страница" и его открытие
            this.Hide();
            var CancelForm = new MainPage();
            CancelForm.Show();
        }
    }
}
