using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int count = 0;
            for (int i = 0; i < 10; i++)
            {
                int temp = rnd.Next(0, 100);
                count += temp;
                Console.WriteLine(temp);
                Thread.Sleep(3000);
            }
            Console.WriteLine("Введите число ");
            int inputValue= int.Parse(Console.ReadLine());
            if (inputValue == count)
            {
                Console.WriteLine("Ура!Ты молодец!");
            }
            else
            {
                Console.WriteLine("Поробуй ещё");
            }
        }
    }
}
