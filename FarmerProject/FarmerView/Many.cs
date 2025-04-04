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
    // Класс формы Many, наследующий базовый функционал формы Windows Forms
    public partial class Many : Form
    {
        // Конструктор класса формы Many
        public Many()
        {
            // Инициализация компонентов формы, определенных в дизайнере
            InitializeComponent();
        }

        // Обработчик события клика по button1
        private void button1_Click(object sender, EventArgs e)
        {
            // Локальная функция Box для вычислений
            void Box()
            {
                // Получение значений из текстовых полей
                string p = textBox3.Text;  // Периметр
                string n = textBox15.Text;   // Количество сторон
                double x;  // Числовое значение периметра
                double y;  // Числовое значение количества сторон

                // Проверка на заполнение полей ввода
                if (((p.Length == 0) && (n.Length != 0)) || ((p.Length != 0) && (n.Length == 0)))
                {
                    if ((p.Length == 0) && (n.Length != 0))
                    {
                        // Вывод сообщения о необходимости ввести периметр
                        textBox12.Text = "Введите периметр!".ToString();
                        return;
                    }
                    else if ((p.Length != 0) && (n.Length == 0))
                    {
                        // Вывод сообщения о необходимости ввести количество сторон
                        textBox12.Text = "Введите количество сторон!".ToString();
                        return;
                    }
                }
                // Проверка на пустые поля
                else if ((p.Length == 0) && (n.Length == 0))
                {
                    textBox12.Text = "".ToString();
                    return;
                }
                else
                {
                    // Попытка преобразовать ввод периметра в число
                    try
                    {
                        x = Convert.ToDouble(p);
                    }
                    catch (Exception)
                    {
                        textBox12.Text = "Введите число!".ToString();
                        return;
                    }

                    // Попытка преобразовать ввод количества сторон в число
                    try
                    {
                        y = Convert.ToDouble(n);
                    }
                    catch (Exception)
                    {
                        textBox12.Text = "Введите число!".ToString();
                        return;
                    }

                    // Проверка минимального количества сторон
                    if (y <= 2)
                    {
                        textBox12.Text = "Неверное количество сторон!".ToString();
                        return;
                    }

                    // Проверка на отрицательные значения
                    if ((x < 0) || (y < 0))
                    {
                        if (x < 0)
                        {
                            textBox12.Text = "Периметр < 0!".ToString();
                            return;
                        }
                        else if (y < 0)
                        {
                            textBox12.Text = "Количество сторон < 0!".ToString();
                            return;
                        }
                    }
                    else
                    {
                        // Вычисление площади квадрата
                        textBox14.Text = (Math.Pow((x / 4), 2)).ToString();

                        // Вычисление площади прямоугольника
                        double shortSide = x / 6;
                        double longSide = 2 * shortSide;
                        textBox8.Text = (shortSide * longSide).ToString();

                        // Вычисление площади треугольника
                        double side = x / 3;
                        textBox9.Text = ((Math.Sqrt(3) / 4) * Math.Pow(side, 2)).ToString();

                        // Вычисление площади ромба
                        double side_1 = x / 4;
                        textBox17.Text = (2 * ((Math.Sqrt(3) / 4) * Math.Pow(side_1, 2))).ToString();

                        // Вычисление площади круга
                        double radius = x / (2 * Math.PI);
                        textBox10.Text = (Math.PI * Math.Pow(radius, 2)).ToString();

                        // Вычисление площади пятиугольника
                        double side_2 = x / 5;
                        textBox13.Text = ((5 * Math.Pow(side_2, 2)) / (4 * Math.Tan(Math.PI / 5))).ToString();

                        // Вычисление площади шестиугольника
                        double side_3 = x / 6;
                        textBox11.Text = ((3 * Math.Sqrt(3) / 2) * Math.Pow(side_3, 2)).ToString();

                        // Вычисление площади многоугольника с заданным количеством сторон
                        double a = x / y;
                        textBox12.Text = ((Math.Pow(x, 2) * (1 / Math.Tan(Math.PI / y))) / (4 * y)).ToString();
                    }
                }
            }

            // Вызов функции вычислений
            Box();
        }

        // Обработчик события клика по button3 (кнопка закрытия формы)
        private void button3_Click(object sender, EventArgs e)
        {
            // Закрытие текущей формы
            this.Close();
        }
    }
}
