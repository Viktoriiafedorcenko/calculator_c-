using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число"); // Говорим пользователю ввести первое число

            int a = int.Parse(Console.ReadLine()); // Смотреть примечание 1"

            Console.WriteLine("Введите символ");

            string symbol = Console.ReadLine();

            Console.WriteLine("Введите второе число");

            int b = int.Parse(Console.ReadLine()); // Примечание 1*



            int result = 0; // Переменная для вывода



            if (symbol == "+")

            {

                result = a + b;

            }

            else if (symbol == "-")

            {

                result = a - b;

            }

            else if (symbol == "*")

            {

                result = a * b;

            }

            else if (symbol == "/")

            {

                result = a / b;

            }
            else if (symbol == "%")
            {
                result = a % b * b;
            }



            Console.WriteLine("Результат = " + result);

            Console.ReadKey();



        }
    }
}
    

