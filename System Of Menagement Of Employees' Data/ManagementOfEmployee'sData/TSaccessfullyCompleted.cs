// Шаблон формы успешного выполнения команды
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
    public partial class TSaccessfullyCompleted : Form
    {
        // Создание экземпляра по-умолчанию
        public TSaccessfullyCompleted()
        {
            InitializeComponent();
        }

        // Обработка события "Нажатие кнопки "Возврат на главную страницу""
        private void ReturnToMenu_Click(object sender, EventArgs e)
        {
            // Закрытие данной формы, а ьакже создание экземпляра формы "Гладная страница" и его открытие
            this.Hide();
            var ReturnToMenuForm = new MainPage();
            ReturnToMenuForm.Show();
        }
    }
}
