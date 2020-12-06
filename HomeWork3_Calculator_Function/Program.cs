using System;

namespace HomeWork3_Calculator_Function
{
    class Program
    {
        static double FirstNum()
        {
            double firstNum;
            Console.WriteLine("Введите первое число:");
            firstNum = Double.Parse(Console.ReadLine());
            return firstNum;
        }
        static double SecondNum()
        {
            double secondNum;
            Console.WriteLine("Введите второе число:");
            secondNum = Double.Parse(Console.ReadLine());
            return secondNum;
        }

        static void CountSum(double firstNum, double secondNum)
        {
            double result;
            result = firstNum + secondNum;
            Console.WriteLine("Сумма равна = " + result);
        }

        static void CountDif(double firstNum, double secondNum)
        {
            double result;
            result = firstNum - secondNum;
            Console.WriteLine("Разница равна = " + result);
        }

        static void CountMultip(double firstNum, double secondNum)
        {
            double result;
            result = firstNum * secondNum;
            Console.WriteLine("Умножение равно = " + result);
        }

        static void CountDiv(double firstNum, double secondNum)
        {
            double result;
            if (secondNum == 0)
                Console.WriteLine(0);
            else
            {
                result = firstNum / secondNum;
                Console.WriteLine("Деление равно = " + result);
            }
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();

                Console.WriteLine("Введите арифметическое действие:");
                string arithOperation = Console.ReadLine();

                switch (arithOperation)
                {
                    case "+":
                        CountSum(FirstNum(), SecondNum());
                        break;
                    case "-":
                        CountDif(FirstNum(), SecondNum());
                        break;
                    case "*":
                        CountMultip(FirstNum(), SecondNum());
                        break;
                    case "/":
                        CountDiv(FirstNum(), SecondNum());
                        break;

                    default:
                        Console.WriteLine("Вы ввели неверное арифметическое действие");
                        break;
                }
                Console.ReadLine();
            }
        }
    }
}
