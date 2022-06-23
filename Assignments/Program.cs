using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Program
    {
        
        public class Calculation
        {
            public static void Main(string[] args)
            {
                Console.WriteLine("Press 1 for Addition");
                Console.WriteLine("Press 2 for Substraction");
                Console.WriteLine("Press 3 for Multiplication");
                Console.WriteLine("Press 4 for Division");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter 1st Number");
                int n1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter 2nd Number");
                int n2 = Convert.ToInt32(Console.ReadLine());
                int result= 0;

                switch (a)
                {
                    case 1:
                        {
                            result = Addition(n1, n2);
                            break;
                        }

                    case 2:
                        {
                            result = Substraction(n1, n2);
                            break;
                        }
                    case 3:
                        {
                            result = Multiplication(n1, n2);
                            break;
                        }
                    case 4:
                        {
                            result = Division(n1, n2);
                            break;
                        }
                    default:
                        Console.WriteLine(" invalid input");
                        break;
                }
                Console.WriteLine("Wrong action performed");
                Console.ReadLine();

            }
            static int Addition(int n1, int n2)
            {
                int result = n1+n2;
                return result;
            }
            static int Substraction(int n1, int n2)
            {
                int result = n1 - n2;
                return result;
            }
            static int Multiplication(int n1, int n2)
            {
                int result = n1 * n2;
                return result;
            }
           static int Division(int n1, int n2)
            {
                int result = n1 / n2;
                return result;
            }



        }

    }
}

