using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiplication
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int Num;
            int res;
            for (int j = 1; j <= 10; j++)
            {
                Console.WriteLine("Kindly Enter Num");
                Num = Convert.ToInt32(Console.ReadLine());

                System.Threading.Thread.Sleep(10);
                Console.WriteLine();
                Console.WriteLine("Multiplication Table Of " + Num);


                Console.WriteLine("------------");

                for (int i = 1; i <= 10; i++)
                {
                    res = i * Num;
                    // Console.WriteLine(res);
                    Console.WriteLine($"{Num} x {i} = {res}");
                }
                Console.WriteLine("------------");
                Console.WriteLine();
                System.Threading.Thread.Sleep(10);
            }
        }
    }
}
