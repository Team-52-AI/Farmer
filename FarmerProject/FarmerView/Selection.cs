using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Пространство имен приложения FarmerView
namespace FarmerView
{
    // Класс формы Selection, наследующий от базового класса Form
    public partial class Selection : Form
    {
        // Конструктор класса Selection
        public Selection()
        {
            // Инициализация компонентов формы, созданных в дизайнере
            InitializeComponent();
        }

        // Обработчик события нажатия на button3
        private void button3_Click(object sender, EventArgs e)
        {
            // Закрытие текущей формы
            this.Close();
        }

        // Обработчик события нажатия на button1
        private void button1_Click(object sender, EventArgs e)
        {
            // Создание экземпляра формы Single
            Single form = new Single();
            // Открытие формы Single в модальном режиме
            form.ShowDialog();
        }

        // Обработчик события нажатия на button2
        private void button2_Click(object sender, EventArgs e)
        {
            // Создание экземпляра формы Many
            Many form = new Many();
            // Открытие формы Many в модальном режиме
            form.ShowDialog();
        }

        // Обработчик события нажатия на button4
        private void button4_Click(object sender, EventArgs e)
        {
            // Создание экземпляра формы Form1
            Form1 form = new Form1();
            // Открытие формы Form1 в модальном режиме
            form.ShowDialog();
        }
    }
}
