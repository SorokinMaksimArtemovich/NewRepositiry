// Шаблон формы ввода данных сотрудника, необходимых для поиска
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
    public partial class TSearchEmployee : Form
    {
        // Создание экземпляра по-умолчанию
        public TSearchEmployee()
        {
            InitializeComponent();
        }

        // Обработка события "Нажатие кнопки "Отмена""
        private void Cancel_Click(object sender, EventArgs e)
        {
            // Закрытие данной формы, а ьакже создание экземпляра формы "Гладная страница" и его открытие
            this.Hide();
            var CancelForm = new MainPage();
            CancelForm.Show();
        }
    }
}
