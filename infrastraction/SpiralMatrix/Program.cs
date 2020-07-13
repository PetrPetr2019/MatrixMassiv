using System;

namespace SpiralMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 5;
            PrintSpiral(n);
            Console.ReadLine();
            ReversMatrix(n);
            Console.ReadLine();
        }
        private static void PrintSpiral(int n)
        {
            for (var i = 0; i < n; i++)
            {
                for (var j = 0; j < n; j++)
                {
                    var x = Math.Min(Math.Min(i, j), Math.Min(n - 1 - i, n - 1 - j));
                    if (i <= j) Console.Write((n - 2 * x) * (n - 2 * x) - (i - x) - (j - x) + "\t");
                    else Console.Write((n - 2 * x - 2) * (n - 2 * x - 2) + (i - x) + (j - x) + "\t");
                }

                Console.WriteLine();
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Данная матрица выводит результат по часовой стрелки начиная с цифры " +
                              "25, 24,23, 22, 21\n" + "20,19,18,17\n" + "16,15,14,13\n" + "12,11\n" + "10,9,8,7\n" +
                              "6,5,4,3,2,1");
            Console.WriteLine("Для продолжения нажмите ENTER");
            Console.ReadLine();
            Console.WriteLine("Для вывода следующего столбца массива, нажмите еще раз клавишу ENTER\n");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(new string('-', 68));
        }

        private static void ReversMatrix(int n)
        {
            for (var i = 0; i < n; i++)
            {
                for (var j = 0; j < n; j++)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    var x = Math.Min(Math.Min(i, j), Math.Min(n - 1 - i, n - 1 - j));
                    if (i >= j) Console.Write((n - 2 * x) * (n - 2 * x) - (i - x) - (j - x) + "\t");
                    else Console.Write((n - 2 * x - 2) * (n - 2 * x - 2) + (i - x) + (j - x) + "\t");
                }

                Console.WriteLine();
            }

            Console.WriteLine(
                "Данная матрица, выводит результат в обратном порядке движения. начиная с цифры 25 и двигаясь в нз по спирали до 1");
        }
    }
}
    