using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapInteger
{
    class Program
    {
        public static void Main(string[] args)
        {
            int num1, num2, temp;
            Console.Write("\nInput the First Number : ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("\nInput the Second Number : ");
            num2 = int.Parse(Console.ReadLine());
            temp = num1;
            num1 = num2;
            num2 = temp;
            Console.Write("\nAfter Swapping : ");
            Console.Write("\nFirst Number : " + num1);
            Console.Write("\nSecond Number : " + num2);
            Console.Read();
        }
    }
}