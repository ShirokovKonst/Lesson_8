using System;

namespace Lesson_8_HomeWork_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = Prompt("Введите размер массива: ");
            int[,,] ar = new int[size,size,size];
            ar = GetArray(size);
            PrintArray(ar, size);
            
            int Prompt(string msg)
            {
                Console.WriteLine(msg);
                return int.Parse(Console.ReadLine());
            }
            void PrintArray(int[,,] arr, int s)
            {
                for(int i = 0; i < s; i++)
                {
                    for(int j = 0; j < s; j++)
                    {
                        for(int x = 0; x < s; x++)
                        {
                           Console.Write(arr[i,j,x] + " " + "(" + i + "," + j + "," + x + ")" + " ");
                        }
                        Console.Write('\n');
                    }
                }
            }
            int[,,] GetArray(int s)
            {
                int[,,] result = new int[s,s,s];
                int[] temp = new int[s*s*s];
                int tmp=0;
                bool flag=true;
                Random rnd = new Random();
                int rw = 0; 
                for(int i = 0; i < s; i++)
                {
                    for(int j = 0; j < s; j++)
                    {
                        for(int x = 0; x < s; x++)
                        {
                            flag = true;
                            while(flag == true)
                            {
                                flag = false;
                                tmp = rnd.Next(1,99);
                                for(int a = 0; a < s*s*s; a++)
                                {
                                    if (temp[a] == tmp)
                                    {
                                    flag = true;
                                    }
                                }
                            }
                            temp[rw] = tmp;
                            rw++;
                            result[i,j,x] = tmp;
                        }
                    }
                }
                return result;
            }
        }
    }
}
