using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmerView
{
    public partial class Single : Form
    {
        public Single()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void Circle_Box()
        {
            string p = textBox5.Text;
            double x;

            if (p.Length == 0)
            {
                textBox10.Text = "".ToString();
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
                    textBox10.Text = "Введите периметр!".ToString();
                    return;
                }

                if (x < 0)
                {
                    textBox10.Text = "".ToString();
                    return;
                }

                else
                {
                    double radius = x / (2 * Math.PI);
                    textBox10.Text = (Math.PI * Math.Pow(radius, 2)).ToString();
                }
            }
        }

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
                    double side = x / 3;
                    textBox9.Text = ((Math.Sqrt(3) / 4) * Math.Pow(side, 2)).ToString();
                }
            }
        }

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
                    textBox14.Text = (Math.Pow((x / 4), 2)).ToString();
                }
            }
        }

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
                    double side = x / 4;
                    textBox17.Text = (2 * ((Math.Sqrt(3) / 4) * Math.Pow(side, 2))).ToString();
                }
            }
        }

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
                    double side = x / 5;
                    textBox13.Text = ((5 * Math.Pow(side, 2)) / (4 * Math.Tan(Math.PI / 5))).ToString();
                }
            }
        }

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
                    double shortSide = x / 6;
                    double longSide = 2 * shortSide;
                    textBox8.Text = (shortSide * longSide).ToString();
                }
            }
        }

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
                    double side = x / 6;
                    textBox11.Text = ((3 * Math.Sqrt(3) / 2) * Math.Pow(side, 2)).ToString();
                }
            }
        }

        void Polygon_Box()
        {
            string p = textBox3.Text;
            string n = textBox15.Text;
            double x;
            double y;


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

            else if ((p.Length == 0) && (n.Length == 0))
            {
                textBox12.Text = "".ToString();
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
                    textBox12.Text = "Введите число!".ToString();
                    return;
                }

                try
                {
                    y = Convert.ToDouble(n);
                }
                catch (Exception)
                {
                    textBox12.Text = "Введите число!".ToString();
                    return;
                }

                if (y <= 2)
                {
                    textBox12.Text = "Неверное количество сторон!".ToString();
                    return;
                }

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
                    double a = x / y;
                    textBox12.Text = ((Math.Pow(x, 2) * (1 / Math.Tan(Math.PI / y))) / (4 * y)).ToString();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Square_Box();
            Rectangle_Box();
            Triangle_Box();
            Rhomb_Box();
            Circle_Box();
            Pentagon_Box();
            Hexagon_Box();
            Polygon_Box();
        }
    }
}
