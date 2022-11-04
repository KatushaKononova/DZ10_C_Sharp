// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random_array();
        }

        static void Random_array(){
            int[] array = new int[8];
            for(int i=0;i<8;i++){
                array[i]=new Random().Next(0,10);
                Console.Write($"{array[i]} ");
            }
        }
    }
}
