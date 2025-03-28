using FarmerLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmerTest
{
    public class Program
    {
        public static void Test1() // Тест площади круга CircleArea
        {
            double p = 9.23;
            double s = Farmer.CircleArea(p);
            Console.WriteLine("Площадь круга: " + s);
        }

        static void Test2() // Тест площади равностороннего треугольника EquilateralTriangleArea
        {
            double p = -9.5;
            double s = Farmer.EquilateralTriangleArea(p);
            Console.WriteLine("Площадь равностороннего треугольника: " + s);    
        }

        static void Test3() // Тест площади квадрата SquareArea
        {
            double p = -36;
            double s = Farmer.SquareArea(p);
            Console.WriteLine("Площадь квадрата: " + s);
        }

        static void Test4() // Тест площади правильного ромба RhombusArea
        {
            double p = 315;
            double s = Farmer.RhombusArea(p);
            Console.WriteLine("Площадь правильного ромба: " + s);
        }
        
        static void Test5() // Тест площади правильного пятиугольника PentagonArea
        {
            double p = 55;
            double s = Farmer.PentagonArea(p);
            Console.WriteLine("Площадь правильного пятиугольника: " + s);
        }

        static void Test6() // Тест площади прмоугольника, у которого одна сторона вдвое больше другой RectangleArea
        {
            double p = 5.600;
            double s = Farmer.RectangleArea(p);
            Console.WriteLine("Площадь прямоугольника, у которого одна сторона вдвое больше другой: " + s);
        }

        static void Test7() // Тест площади правильного шестиугольника HexagonArea
        {
            double p = 0.26;
            double s = Farmer.HexagonArea(p);
            Console.WriteLine("Площадь правильного шестиугольника: " + s);
        }

        /// <summary>
        /// Тесты и вывод их результатов
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("try commit");
            Test1();
            Test2();
            Test3();
            Test4();
            Test5();
            Test6();
            Test7();
            Console.ReadKey();
        }
    }
}
