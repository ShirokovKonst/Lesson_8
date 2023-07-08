using System;

namespace Lesson_8_HomeWork_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 5;
            int[,] snake = FillArray(size);
            PrintArray(snake, size); 
            void PrintArray(int[,] arr, int s)
            {
                for(int i = 0; i < s; i++)
                {
                    for(int j = 0; j < s; j++)
                    {
                        Console.Write(arr[i,j] + " ");
                    }
                    Console.Write('\n');
                }
            }
            int[,] FillArray(int s)
            {
                int[,] result = new int[s,s];
                int value = 1;
                int i = 0;
                int j = 0;
                while(value <= s*s)
                {
                    result[i,j] = value;
                    if (i <= j+1 && i + j < s - 1)
                    j++;
                    else if (i < j && i + j >= s - 1)
                    i++;
                    else if (i >= j && i + j > s - 1)
                    j--;
                    else 
                    i--;
                    value ++;
                }
                return result;
            }
        }
    }
}
