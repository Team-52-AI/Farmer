using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmerView
{
    public partial class Many : Form
    {
        public Many()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            void Box()
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
                        textBox14.Text = (Math.Pow((x / 4), 2)).ToString();

                        double shortSide = x / 6;
                        double longSide = 2 * shortSide;
                        textBox8.Text = (shortSide * longSide).ToString();

                        double side = x / 3;
                        textBox9.Text = ((Math.Sqrt(3) / 4) * Math.Pow(side, 2)).ToString();

                        double side_1 = x / 4;
                        textBox17.Text = (2 * ((Math.Sqrt(3) / 4) * Math.Pow(side_1, 2))).ToString();

                        double radius = x / (2 * Math.PI);
                        textBox10.Text = (Math.PI * Math.Pow(radius, 2)).ToString();

                        double side_2 = x / 5;
                        textBox13.Text = ((5 * Math.Pow(side_2, 2)) / (4 * Math.Tan(Math.PI / 5))).ToString();

                        double side_3 = x / 6;
                        textBox11.Text = ((3 * Math.Sqrt(3) / 2) * Math.Pow(side_3, 2)).ToString();

                        double a = x / y;
                        textBox12.Text = ((Math.Pow(x, 2) * (1 / Math.Tan(Math.PI / y))) / (4 * y)).ToString();
                    }
                }
            }

            Box();
        }
    }
}
