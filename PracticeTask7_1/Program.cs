using System;

namespace PracticeTask7_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            if ((((Math.Pow(x, 2) + Math.Pow(y, 2)) > 4) && ((x < -2) && (x > 2) && (y > 2) && (y < 0))) || (((x < -2) || (x > 2)) && ((y < -1) || (y > 0))))
            {
                Console.WriteLine("Да!");
            } 
            else if (((y == Math.Sqrt(4 - Math.Pow(x,2))) && ((x >= -2) || (x <= 2) && (y >= 2) || (y <= 0))) || (( y == -1) && ((x > -2) || (x < 2))))
            {
                Console.WriteLine("На границе!");
            }
            else
            {
                Console.WriteLine("Нет!");
            }

        }
    }
}
