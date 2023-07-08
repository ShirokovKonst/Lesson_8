using System;

namespace Lesson_8_HomeWork_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int rw = Prompt("Введите кол-во строк: ");
            int cl = Prompt("Введите кол-во столбцов: ");
            int[,] ar1 = GetArray(rw, cl);
            int[,] ar2 = GetArray(rw, cl);
            PrintArray(ar1, rw, cl);
            Console.Write("\n\n");
            PrintArray(ar2, rw, cl);
            int[,] prod = ProductArray(ar1, ar2, rw, cl);
            Console.Write("\n\n");
            PrintArray(prod, rw, cl);

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
                        result[i,j] = rnd.Next(1, 12);
                    }
                }
                return result;
            }

            int[,] ProductArray(int[,] arr1, int[,] arr2, int r, int c)
            {
                int[,] result = new int[r,c];
                for (int i = 0; i < r; ++i)
                {
                    for (int j = 0; j < c; ++j) 
                    {
                        for (int k = 0; k < c; ++k)
                        {
                            result[i,j] += arr1[i,k] * arr2[k,j];
                        }
                    }
                }
                return result;
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
