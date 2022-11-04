// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

using System;

namespace task2
{
    class Program
    {
        public static int num=0;
        
        static void Main(string[] args)
        {
            int sum = Enter_number_and_sum();
            Console.WriteLine("Сумма равна " + Convert.ToString(sum));
        }

        static int Enter_number_and_sum(){
            Console.WriteLine("Введите целое число");
            num=Convert.ToInt32(Console.ReadLine());
            int sum_f=0;
            while(num>0){
                sum_f+=num%10;
                num/=10;
            }
            return sum_f;
        }
    }
}
