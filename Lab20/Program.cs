using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab20
{
    internal class Program
    {
            delegate double DoubleDelegate(double r);
            static void Main(string[] args)
            {
                
                Console.WriteLine("Введите радиус");
                double r = Convert.ToDouble(Console.ReadLine());
                DoubleDelegate doubleDelegate = circumference;                       
                Console.WriteLine($"Длина окружности равна {doubleDelegate(r)}");
                doubleDelegate = Square;
                Console.WriteLine($"Площадь круга равна {doubleDelegate(r)}");
                doubleDelegate = Volume;
                Console.WriteLine($"Объем сферы равен {doubleDelegate(r)}");
                Console.ReadKey();


            }
            static double circumference(double r)
            {
                return 2 * Math.PI * r;
            }

            static double Square(double r)
            {
                return Math.PI * Math.Pow(r,2);
            }
            static double Volume(double r)
            {
                return Math.PI * Math.Pow(r, 3) * 4 / 3;
            }
        
    }
}