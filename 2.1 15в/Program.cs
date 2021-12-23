using System;

namespace _2._1_15в
{
    class Program
    {
        static void Main(string[] args)
        {
            //2.1 средний уровень 15в
            Console.WriteLine("Введите бал за физику:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите бал за математику:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите бал за информатику:");
            int c = int.Parse(Console.ReadLine());
            if( (a>=4)&& (b>=4)&&(c>=4))
            {
                Console.WriteLine("Студент получит стипендию:");
            }
            else
            {
                Console.WriteLine("Студент не получит стипендию:");
            }
        }
    }
}
