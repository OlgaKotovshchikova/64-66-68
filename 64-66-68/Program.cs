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
                case 66:
                    TaskSixtysix();
                    break;
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
            Console.WriteLine("Введите N: ");
            int N = Convert.ToInt32(Console.ReadLine());
             
            void PrintNumbersFromNtoOne(int N, int n = 1)
            {
                if (n > N) return;
                PrintNumbersFromNtoOne(N, n++);
                Console.Write(n + " ");
            }
            PrintNumbersFromNtoOne(N);
        }

        #endregion

        #region Задача 66
        static void TaskSixtysix()
        {

        }

        #endregion

        #region Задача 68
        static void TaskSixtyeight()
        {

        }

        #endregion

    }

}
