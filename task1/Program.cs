//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

using System;



namespace task1
{
    class Program
    {
        public static int numA=0;
        public static int numB=0;
        static void Main(string[] args)
        {
            Enter_Two_number();
            Console.WriteLine("A^B=" + Convert.ToString(Math.Pow(numA,numB)));
        }

        static void Enter_Two_number(){
            Console.WriteLine("Введите целые числа A и B");
            numA=Convert.ToInt32(Console.ReadLine());
            numB=Convert.ToInt32(Console.ReadLine());
            return;
        }
    }
}