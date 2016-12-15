using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class Program
    {
        static void Main(string[] args)
        {
        
            Program p1 = new ConsoleApplication2.Program(); // deneme 
            String yourname = "Mr. Nice";                       // deneme 2
            Console.WriteLine("Hello {0}", yourname);       //deneme 3
            String x = "welcome to calculator";             // deneme4
            Console.WriteLine("Hello {0}", x);              //deneme5
            Console.WriteLine("ASD");
            /////
            double result;
            //////////////
            Console.WriteLine("Enter your choice(addition: 1),(subtraction:  2), (division:  3)");
            int choice = Convert.ToInt32(Console.ReadLine());
            
            if (choice == 1)
            {
                Console.WriteLine("Enter first number: ");
                double a = Convert.ToDouble(Console.ReadLine());//hello my name is hakank
                Console.WriteLine("Enter second number: ");
                double b = Convert.ToDouble(Console.ReadLine());
                result = p1.addition(a,b);
            }
            else if (choice == 2)
            {
                Console.WriteLine("Enter first number: ");
                double a = Double.Parse(Console.ReadLine());
                Console.WriteLine("Enter second number: ");
                double b = Double.Parse(Console.ReadLine());
                result = p1.subtraction(a, b);
            }
            else if(choice == 3)
            {
                Console.WriteLine("Enter first number: ");
                double a = Double.Parse(Console.ReadLine());
                Console.WriteLine("Enter second number: ");
                double b = Double.Parse(Console.ReadLine());
                result = p1.division(a, b);
            }

        }
        public double addition(double a, double b)
        {
            double result;
           
            result = a + b;
            Console.WriteLine("Result is  " + result);
            return result;
           
        }
        public double subtraction(double a, double b)
        {
            double result;

            result = a - b;
            Console.WriteLine("Result is  " + result);
            return result;

        }
        public double division(double a, double b)
        {
            double result;
            
            result =a / b;
            Console.WriteLine("Result is  " + result);
            return result;           
        }
    }
}
