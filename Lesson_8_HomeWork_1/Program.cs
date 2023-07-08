using System;

namespace Lesson_8_HomeWork_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int rw = Prompt("Введите кол-во строк: ");
            int cl = Prompt("Введите кол-во столбцов: ");
            int[,] ar = GetArray(rw, cl);
            PrintArray(ar, rw, cl);
            int[,] arCalc = CalcArray(ar, rw, cl);
            Console.Write("\n\n\n\n");
            PrintArray(arCalc, rw, cl);
            
            int Prompt(string msg)
            {
                Console.WriteLine(msg);
                return int.Parse(Console.ReadLine());
            }

            int[,] GetArray(int r, int c)
            {
                int[,] result = new int[r,c];
                Random rnd = new Random();
                for (int i = 0; i < r; i++)
                {
                    for (int j = 0; j < c; j++)
                    {
                        result[i,j] = rnd.Next(1, 100);
                    }
                }
                return result;
            }

            int[,] CalcArray(int[,] arr, int c, int r)
            {
                int b;
                for (int i = 0; i < c; i++)
                {
                    for (int j = 0; j < r; j++)
                    {
                        for (int x = 0; x < r - 1; x++)
                        {
                            if (arr[i, x] < arr[i,x + 1])
                            {
                                b = arr[i,x];
                                arr[i,x] = arr[i,x + 1];
                                arr[i,x + 1] = b;
                            }
                        }
                    }
                }
                return arr;
            }
            void PrintArray(int[,] arr, int r, int c)
            {
                for (int i = 0; i < r; i++)
                {
                    for (int j = 0; j < c; j++)
                    {
                        Console.Write(arr[i,j]+" ");
                    }
                    Console.Write('\n');
                }
            }


        }
    }
}
