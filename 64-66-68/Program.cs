using System;

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
              /*  case 66:
                    TaskSixtysix();
                    break;*/
                case 58:
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
            try
            {
                Console.WriteLine("Введите N: ");
                int N = Convert.ToInt32(Console.ReadLine());
                PrintNumbersFromNtoOne(N);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
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
        Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
        M = 1; N = 15 -> 120
        M = 4; N = 8. -> 30*//*
        static void TaskSixtysix()
        {
            Console.WriteLine("Введите M: ");
            int M = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите N: ");
            int N = Convert.ToInt32(Console.ReadLine());
            *//*int sum = 0;*//*
            if (M < N)
            {
                void PrintSumNumbersFromMtoN(int N, int M)
                {
                    if (N < M) return;
                    PrintSumNumbersFromMtoN(N - 1, M);
                    Console.Write(N + " ");
                }
                PrintSumNumbersFromMtoN(N, M);
            }
            else Console.WriteLine("Первое число M должно быть меньше второго числа N. Введите заново.");
            
        }*/



        #endregion

        #region Задача 68
        static void TaskSixtyeight()
        {

        }

        #endregion

    }

}
