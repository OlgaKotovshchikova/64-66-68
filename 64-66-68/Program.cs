using System;
using System.Numerics;

namespace _64_66_68
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите номер задачи 64, 66, 68: ");
            int taskNumber = Convert.ToInt32(Console.ReadLine());
            switch (taskNumber)
            {
                case 64:
                    TaskSixtyfour();
                    break;
                case 66:
                    TaskSixtysix();
                    break;
                case 68:
                    TaskSixtyeight();
                    break;
                default:
                    Console.WriteLine("Такой задачи не существует");
                    break;
            }
        }

        #region Задача 64
        /*Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
        N = 5 -> "5, 4, 3, 2, 1"
        N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/
        static void TaskSixtyfour()
        {
            Console.WriteLine("Введите N: ");
            int N = Convert.ToInt32(Console.ReadLine());
            PrintNumbersFromNtoOne(N);
        }
        static void PrintNumbersFromNtoOne(int N, int n = 1)
        {
            if (n > N) return;
            PrintNumbersFromNtoOne(N, n+1);
            Console.Write(n + " ");
        }
        #endregion

        #region Задача 66
        /*Задайте значения M и N.
        Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.*/
        /*M = 1; N = 15 -> 120
        M = 4; N = 8. -> 30*/
        static void TaskSixtysix()
        {
            Console.WriteLine("Введите M: ");
            int M = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите N: ");
            int N = Convert.ToInt32(Console.ReadLine());
            if (M < N) PrintNumbersFromMtoN(N, M);
            else  Console.WriteLine("M должно быть меньше N");
            int result = SumNumbersFromMtoN(N, M);
            Console.WriteLine();
            Console.WriteLine(result);

            static void PrintNumbersFromMtoN(int N, int M)
            {
                if (N < M) return;
                PrintNumbersFromMtoN(N - 1, M);
                Console.Write(N + " ");
            }

            int SumNumbersFromMtoN(int N, int M)
            {
                if (N < M) return 0;
                return N + SumNumbersFromMtoN(N - 1, M);
            }

        }



        #endregion

        #region Задача 68
        /*Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
        m = 2, n = 3->A(m, n) = 9*/

        static void TaskSixtyeight()
        {
            Console.WriteLine("Введите неотрицательное число m: ");
            ulong m = ulong.Parse(Console.ReadLine());
            Console.WriteLine("Введите неотрицательное число n: ");
            ulong n = ulong.Parse(Console.ReadLine());
            if (m >= 0 || n >= 0) AckermanFunction(m, n);
            else Console.WriteLine("Числа должны быть неотрицательными");
            ulong result = AckermanFunction(m, n);
            Console.WriteLine();
            Console.WriteLine(result);

            ulong AckermanFunction(ulong m, ulong n)
            {
                if (m == 0) return (n + 1);
                if ((m > 0) && (n == 0)) return AckermanFunction(m - 1, 1);
                else return AckermanFunction(m - 1, AckermanFunction(m, n - 1));
            }
        }
        #endregion

    }

}
