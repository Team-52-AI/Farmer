using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;  // Для работы с политиками безопасности (возможно не используется)
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Пространство имен приложения FarmerView
namespace FarmerView
{
    // Класс формы Single, наследующий базовый функционал формы Windows Forms
    public partial class Single : Form
    {
        // Конструктор класса формы Single
        public Single()
        {
            // Инициализация компонентов формы, определенных в дизайнере
            InitializeComponent();
        }

        // Метод для вычисления площади круга по периметру
        void Circle_Box()
        {
            string p = textBox5.Text;  // Получение значения периметра из текстового поля
            double x;  // Числовое значение периметра

            // Проверка на пустое поле ввода
            if (p.Length == 0)
            {
                textBox10.Text = "".ToString();  // Очистка поля результата
                return;
            }
            else
            {
                // Попытка преобразовать ввод в число
                try
                {
                    x = Convert.ToDouble(p);
                }
                catch (Exception)
                {
                    textBox10.Text = "Введите периметр!".ToString();  // Сообщение об ошибке
                    return;
                }

                // Проверка на отрицательное значение
                if (x < 0)
                {
                    textBox10.Text = "".ToString();
                    return;
                }
                else
                {
                    // Вычисление радиуса и площади круга
                    double radius = x / (2 * Math.PI);
                    textBox10.Text = (Math.PI * Math.Pow(radius, 2)).ToString();
                }
            }
        }

        // Метод для вычисления площади равностороннего треугольника по периметру
        void Triangle_Box()
        {
            string p = textBox6.Text;
            double x;

            if (p.Length == 0)
            {
                textBox9.Text = "".ToString();
                return;
            }
            else
            {
                try
                {
                    x = Convert.ToDouble(p);
                }
                catch (Exception)
                {
                    textBox9.Text = "Введите периметр!".ToString();
                    return;
                }

                if (x < 0)
                {
                    textBox9.Text = "Периметр < 0!".ToString();
                    return;
                }
                else
                {
                    // Вычисление стороны и площади треугольника
                    double side = x / 3;
                    textBox9.Text = ((Math.Sqrt(3) / 4) * Math.Pow(side, 2)).ToString();
                }
            }
        }

        // Метод для вычисления площади квадрата по периметру
        void Square_Box()
        {
            string p = textBox1.Text;
            double x;

            if (p.Length == 0)
            {
                textBox14.Text = "".ToString();
                return;
            }
            else
            {
                try
                {
                    x = Convert.ToDouble(p);
                }
                catch (Exception)
                {
                    textBox14.Text = "Введите периметр!".ToString();
                    return;
                }

                if (x < 0)
                {
                    textBox14.Text = "Периметр < 0!".ToString();
                    return;
                }
                else
                {
                    // Вычисление площади квадрата
                    textBox14.Text = (Math.Pow((x / 4), 2)).ToString();
                }
            }
        }

        // Метод для вычисления площади ромба по периметру
        void Rhomb_Box()
        {
            string p = textBox16.Text;
            double x;

            if (p.Length == 0)
            {
                textBox17.Text = "".ToString();
                return;
            }
            else
            {
                try
                {
                    x = Convert.ToDouble(p);
                }
                catch (Exception)
                {
                    textBox17.Text = "Введите периметр!".ToString();
                    return;
                }

                if (x < 0)
                {
                    textBox17.Text = "Периметр < 0!".ToString();
                    return;
                }
                else
                {
                    // Вычисление площади ромба (как двух равносторонних треугольников)
                    double side = x / 4;
                    textBox17.Text = (2 * ((Math.Sqrt(3) / 4) * Math.Pow(side, 2))).ToString();
                }
            }
        }

        // Метод для вычисления площади правильного пятиугольника по периметру
        void Pentagon_Box()
        {
            string p = textBox2.Text;
            double x;

            if (p.Length == 0)
            {
                textBox13.Text = "".ToString();
                return;
            }
            else
            {
                try
                {
                    x = Convert.ToDouble(p);
                }
                catch (Exception)
                {
                    textBox13.Text = "Введите число!".ToString();
                    return;
                }

                if (x < 0)
                {
                    textBox13.Text = "Периметр < 0!".ToString();
                    return;
                }
                else
                {
                    // Вычисление площади пятиугольника
                    double side = x / 5;
                    textBox13.Text = ((5 * Math.Pow(side, 2)) / (4 * Math.Tan(Math.PI / 5))).ToString();
                }
            }
        }

        // Метод для вычисления площади прямоугольника по периметру
        void Rectangle_Box()
        {
            string p = textBox7.Text;
            double x;

            if (p.Length == 0)
            {
                textBox8.Text = "".ToString();
                return;
            }
            else
            {
                try
                {
                    x = Convert.ToDouble(p);
                }
                catch (Exception)
                {
                    textBox8.Text = "Введите число!".ToString();
                    return;
                }

                if (x < 0)
                {
                    textBox8.Text = "Периметр < 0!".ToString();
                    return;
                }
                else
                {
                    // Вычисление сторон и площади прямоугольника (соотношение 1:2)
                    double shortSide = x / 6;
                    double longSide = 2 * shortSide;
                    textBox8.Text = (shortSide * longSide).ToString();
                }
            }
        }

        // Метод для вычисления площади правильного шестиугольника по периметру
        void Hexagon_Box()
        {
            string p = textBox4.Text;
            double x;

            if (p.Length == 0)
            {
                textBox11.Text = "".ToString();
                return;
            }
            else
            {
                try
                {
                    x = Convert.ToDouble(p);
                }
                catch (Exception)
                {
                    textBox11.Text = "Введите число!".ToString();
                    return;
                }

                if (x < 0)
                {
                    textBox11.Text = "Периметр < 0!".ToString();
                    return;
                }
                else
                {
                    // Вычисление площади шестиугольника
                    double side = x / 6;
                    textBox11.Text = ((3 * Math.Sqrt(3) / 2) * Math.Pow(side, 2)).ToString();
                }
            }
        }

        // Метод для вычисления площади правильного многоугольника по периметру и количеству сторон
        void Polygon_Box()
        {
            string p = textBox3.Text;  // Периметр
            string n = textBox15.Text; // Количество сторон
            double x;  // Числовое значение периметра
            double y;  // Числовое значение количества сторон

            // Проверка на частичное заполнение полей
            if (((p.Length == 0) && (n.Length != 0)) || ((p.Length != 0) && (n.Length == 0)))
            {
                if ((p.Length == 0) && (n.Length != 0))
                {
                    textBox12.Text = "Введите периметр!".ToString();
                    return;
                }
                else if ((p.Length != 0) && (n.Length == 0))
                {
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
                // Проверка корректности ввода периметра
                try
                {
                    x = Convert.ToDouble(p);
                }
                catch (Exception)
                {
                    textBox12.Text = "Введите число!".ToString();
                    return;
                }

                // Проверка корректности ввода количества сторон
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
                    // Вычисление площади правильного многоугольника
                    double a = x / y;
                    textBox12.Text = ((Math.Pow(x, 2) * (1 / Math.Tan(Math.PI / y))) / (4 * y)).ToString();
                }
            }
        }

        // Обработчик события клика по button1 (кнопка вычисления)
        private void button1_Click(object sender, EventArgs e)
        {
            // Последовательный вызов всех методов вычисления площадей
            Square_Box();
            Rectangle_Box();
            Triangle_Box();
            Rhomb_Box();
            Circle_Box();
            Pentagon_Box();
            Hexagon_Box();
            Polygon_Box();
        }

        // Обработчик события клика по button3 (кнопка закрытия формы)
        private void button3_Click(object sender, EventArgs e)
        {
            // Закрытие текущей формы
            this.Close();
        }
    }
}
