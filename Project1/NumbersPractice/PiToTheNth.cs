using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.NumbersPractice
{
    /* This class takes in an integer from the user and computes pi to the input number decimal place. */
    class PiToTheNth
    {
        public static void Main(String[] args)
        {
            double pi;
            int userNum; 
            Console.WriteLine("How many decimals of Pi would you like to see?");
            userNum = Convert.ToInt32(Console.ReadLine());
            if (userNum > 0)
            {
                if (userNum < 162)
                {
                    pi = piCalc(userNum);
                    Console.WriteLine("Pi to the " + userNum + " decimal point: " + pi);
                    //Sleep for answer visability
                    System.Threading.Thread.Sleep(10000);
                }
                else
                {
                    Console.WriteLine("Please input a value less than 162.");
                    userNum = Convert.ToInt32(Console.ReadLine());
                }
            }
            else
            {
                Console.WriteLine("Please input a value greater than 0.");
                userNum = Convert.ToInt32(Console.ReadLine());
            }
        }
        /* The equation used to calculate pi is accurate up to 161 decimal places. */
        public static double piCalc(int roundInt)
        {
            double a = .5*(23+(4*(Math.Sqrt(34))));
            double b = .5*((19*Math.Sqrt(2)) + (7*Math.Sqrt(17)));
            double c = 429 + (304*Math.Sqrt(2));
            double d = .5*(627 + (442*Math.Sqrt(2)));
            double u = (Math.Pow(a + (Math.Sqrt(Math.Pow(a,2) - 1)),2)) * (Math.Pow(b + (Math.Sqrt(Math.Pow(b, 2) - 1)), 2)) * (c + (Math.Sqrt(Math.Pow(c, 2) - 1))) * (d + (Math.Sqrt(Math.Pow(d,2) - 1)));
            double pi = Math.Log((Math.Pow(2 * u, 6) + 24)) / Math.Sqrt(3502);
            return Math.Round(pi, roundInt);
             
        }
    }
}
