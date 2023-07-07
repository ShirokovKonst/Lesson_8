using System;

namespace Lesson_8_HomeWork_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int rw = Prompt("Введите кол-во строк: ");
            int cl = Prompt("Введите кол-во столбцов: ");
            int[,] ar = GetArray(rw, cl);
            PrintArray(ar, rw, cl);
            Console.Write("\n\n");
            int str = CalcArray(ar, rw, cl);
            Console.WriteLine("Строка номер " + str);

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

            int CalcArray(int[,] arr, int r, int c)
            {
                int[] summs = new int[r];
                for (int i = 0; i < r; i++)
                {
                    summs[i] = 0;
                    for (int j = 0; j < c; j++)
                    {
                        summs[i] = summs[i] + arr[i,j];
                    }
                }
                int result = 0;
                int sum = summs[0];
                for (int i = 0; i < r; i++)
                {
                    if(sum > summs[i])
                    {
                        result = i;
                        sum = summs[i];
                    }   
                }
                return result+1;
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
