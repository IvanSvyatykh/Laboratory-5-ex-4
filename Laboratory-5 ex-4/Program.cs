using System;
using System.Diagnostics.CodeAnalysis;
using System.Xml.Linq;

namespace Laboratory
{
    public static class Programm
    {
        static string[] numbers;
        static public void InputNumbers()
        {
            // Метод принимает данные и переводит их в массив строк
            string str = Console.ReadLine();
            str = str.Trim();
            numbers = str.Split('/');
        }
        static public void CorrectArray()
        {
            // Метод убирает пробелы
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = numbers[i].Trim();
            }
        }
        static public void WriteArray()
        {
            // Метод выводит первый вариант массива
            Console.Write("First array : ");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i]);
                Console.Write(" / ");
            }
        }
        static public int Factorial(int elementInt)
        {
            // Метод выполняет операцию факториал
            int sum = 1;
            for (int j = 1; j < elementInt + 1; j++)
            {
                sum *= j;
            }
            return sum;
        }
        static public int RoundingNumber(decimal elementDouble)
        {
            // Метод выполняет операцию округления числа и отброс целой части
            decimal result = decimal.Round(elementDouble, 2, MidpointRounding.AwayFromZero);
            result -= (int)(decimal.Round(elementDouble, 2, MidpointRounding.AwayFromZero));
            result *= 100;
            return (int)result;
        }
        static public void ChangeElementsInArrayAndWrite()
        {
            //Метод производит математические операции по правилу из задания и выводит масив
            Console.Write("Second array : ");
            for (int i = 0; i < numbers.Length; i++)
            {
                int elementInt;
                decimal elementDouble;
                if (int.TryParse(numbers[i], out elementInt))//Проверяем тип элемента
                {
                    elementInt = int.Parse(numbers[i]);
                    if (elementInt > -1) Console.Write(Factorial(elementInt));
                    else Console.Write(elementInt);
                    Console.Write(" / ");
                }
                else if (decimal.TryParse(numbers[i], out elementDouble))//Проверяем тип элемента
                {
                    elementDouble = decimal.Parse(numbers[i]);
                    elementDouble = Math.Abs(elementDouble);
                    Console.Write(RoundingNumber(elementDouble));
                    Console.Write(" / ");
                }
            }
        }
        static void Main()
        {
            Console.WriteLine("Put your numbers and use split points " + "/" + " between each number");
            InputNumbers();
            CorrectArray();
            Console.Clear();
            WriteArray();
            Console.WriteLine();
            Console.WriteLine();
            ChangeElementsInArrayAndWrite();
        }

    }
}