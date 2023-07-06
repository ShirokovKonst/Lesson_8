using System;

namespace Lesson_8_HomeWork_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int rw = Prompt("Введите кол-во стобцов: ");
            int cl = Prompt("Введите кол-во строк: ");
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

            int[,] CalcArray(int[,] arr, int r, int c)
            {
                int[,] result = new int[r,c];
                for (int i = 0; i < r; i++)
                {
                   result[i,0] = arr[i,0];
                   for (int j = 0; j < c; j++)
                   {
                        for (int x = 0; x < c; x++)
                        {
                            if(j > 0)
                            {
                                if(result[i,j] < arr[i,x] && result[i,j-1] > arr[i,x])
                                {
                                    result[i,j] = arr[i,x];
                                }
                            }
                            else
                            {
                                if(result[i,j] < arr[i,x])
                                {
                                    result[i,j] = arr[i,x];
                                }
                            }
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
