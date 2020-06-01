// Шаблон формы ввода полного списка данных сотрудника
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
    public partial class TEnterData : Form
    {
        // Создание экземпляра по-умолчанию
        public TEnterData()
        {
            InitializeComponent();
        }

        // Обработка события "Нажатие кнопки "Отмена""
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            // Закрытие данной формы, а ьакже создание экземпляра формы "Гладная страница" и его открытие
            this.Hide();
            var CancelForm = new MainPage();
            CancelForm.Show();
        }

        private void AddressBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
