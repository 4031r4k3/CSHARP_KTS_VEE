using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace KT2IfAndElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
        private static void Ex4()
        {
            // imt = kg / (m * m)
            Console.WriteLine("WHAT IS UR IMT?");
            Console.WriteLine("Enter your weigth :");
            string weigth = Console.ReadLine();
            int wt = int.Parse(weigth);
            double WT = wt;
            Console.WriteLine("Enter your height :");
            string height = Console.ReadLine();
            int ht = int.Parse(height);
            double HT = ht;
            double htm = HT / 100;
            double imt = WT / (htm * htm);
            Console.WriteLine("UR IMT = " + imt);
            if (imt <= 16)
            {
                Console.WriteLine("You need to gain weight.");
            }
            else if (imt > 25)
            {
                Console.WriteLine("You need to lose weight.");
            }
            else
            {
                Console.WriteLine("You are great!");
            }
        }
        private static void Ex1()
        {
            // a, b, c, choose the smallest one from console.
            Console.WriteLine("YOUR SMALLEST NUMBER");
            Console.WriteLine("Enter first number:");
            string a = Console.ReadLine();
            int A = int.Parse(a);

            Console.WriteLine("Enter second number:");
            string b = Console.ReadLine();
            int B = int.Parse(b);

            Console.WriteLine("Enter third number:");
            string c = Console.ReadLine();
            int C = int.Parse(c);

            if (A < B || A < C)
            {
                Console.WriteLine("The smallest number: " + A);
            }
            else if (B < C || B < A)
            {
                Console.WriteLine("The smallest number: " + B);
            }
            else if (C < B || C < A)
            {
                Console.WriteLine("The smallest number: " + C);
            }
        }

        private static void Ex2()
        {
            Console.WriteLine("Enter ur number:");
            string number = Console.ReadLine();
            int nm = int.Parse(number);
            bool bnm = nm % 2 == 0;
            if (bnm)
            {
                return;
            }
            else
            {
                return;
            }
        }
        private static void Ex3()
        {
            // A = B*C if A>9000 HELL NAH!!! else well ok.
            Console.WriteLine("DEAL DAMAGE!");
            Console.WriteLine("Enter your first number:");
            string d = Console.ReadLine();
            int D = int.Parse(d);
            Console.WriteLine("Enter your second number:");
            string e = Console.ReadLine();
            int E = int.Parse(e);
            int Damage = D * E;

            if (Damage > 9000)
            {
                Console.WriteLine("THAT'S A LOT OF DAMAGE!");
            }
            else
            {
                Console.WriteLine("well");
            }
        }
        private static void Ex5()
        {
            Console.WriteLine("ENTER UR AGE:");
            string AGE = Console.ReadLine();
            int age = int.Parse(AGE);
            bool isAge = age >= 18;
            {
                if (isAge)
                {
                    return;
                }
                else
                {
                    return;
                }
            }
        }
        private static void Ex6()
        {

        }
    }
}
