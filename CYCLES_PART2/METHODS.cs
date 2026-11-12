using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CYCLES_PART2
{
    internal class METHODS
    {
        public static int RandomNumberGenerator()
        {
            int a = 1;
            int b = 10;
            Random r = new Random();
            int secretNumber = r.Next(a, b);
            return secretNumber;
        }

        public static bool Guess(int SecretNumber)
        {
            int guess = int.Parse(Console.ReadLine());
            if (guess == SecretNumber)
            {
                return true;
            }
            else
            {
                return false;
            }
            //return guess = SecretNumber; предложили написать по-другому но я не шарю, так что не.
        }
            //задание 2.
           public static int Numberss()
            {
            Console.WriteLine("GIMME YOUR  NUMBERRR!!");
            int c = int.Parse(Console.ReadLine());
            return c;
            }
    }
}

