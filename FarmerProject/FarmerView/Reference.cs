using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Пространство имен FarmerView, содержащее все формы приложения
namespace FarmerView
{
    // Класс формы Reference, наследующий базовый функционал формы Windows Forms
    public partial class Reference : Form
    {
        // Конструктор класса формы Reference
        public Reference()
        {
            // Инициализация компонентов формы, определенных в дизайнере
            InitializeComponent();
        }

        // Обработчик события клика по button1
        private void button1_Click(object sender, EventArgs e)
        {
            // Закрытие текущей формы Reference
            this.Close();
        }
    }
}
