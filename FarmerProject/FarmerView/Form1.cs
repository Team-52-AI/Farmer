using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmerView
{
    public partial class Form1 : Form
    {
        // Конструктор формы (вызывается при создании экземпляра Form1)
        public Form1()
        {
            InitializeComponent(); // Инициализация компонентов формы (кнопки, метки и т. д.)
        }

        // Обработчик нажатия на кнопку "button2" (например, "Справка" или "Помощь")
        private void button2_Click(object sender, EventArgs e)
        {
            // Создаем экземпляр формы "Reference" (справочная информация)
            Reference form = new Reference();

            // Открываем форму в модальном режиме (блокирует родительское окно)
            form.ShowDialog();
        }

        // Обработчик нажатия на кнопку "button1" (например, "Выбор" или "Начать")
        private void button1_Click(object sender, EventArgs e)
        {
            // Создаем экземпляр формы "Selection" (форма выбора)
            Selection form = new Selection();

            // Открываем форму в модальном режиме
            form.ShowDialog();
        }

        // Обработчик нажатия на кнопку "button3" (например, "Выход" или "Закрыть")
        private void button3_Click(object sender, EventArgs e)
        {
            // Завершаем работу приложения
            Application.Exit();
        }
    }
}
