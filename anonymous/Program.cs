using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anonymous
{
    public delegate void anony(int n );

    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            anony a1 = (n) =>
            {
                for (int i = 0; i <= n; i++)
                {
                    sum = sum + i;
                }
                Console.WriteLine("sum: " + sum);

            };
            Console.WriteLine("Enter the num: ");
            int a = Convert.ToInt32(Console.ReadLine());

            a1.Invoke(a);

            Console.WriteLine("");


        }
    }
}


