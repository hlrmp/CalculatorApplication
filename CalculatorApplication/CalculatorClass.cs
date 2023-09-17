using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApplication
{
    public delegate T Formula<T>(T arg1, T arg2);
    internal class CalculatorClass
    {
        
        public Formula <double> Answer;

        public double GetDifference(double num1 , double num2)
        {
            return num1 - num2;
        }   

        public double GetSum(double num1, double num2)
        {
            return num1 + num2;
        }

        public double GetProduct(double num1, double num2)    // Challenge Exercise:
        {
            return num1 * num2;
        }

        public double GetQuotient(double num1, double num2)    // Challenge Exercise:
        {
            return num1 / num2;
        }

        public event Formula<double> CalculateEvent
        {
            add 
            {
                Console.WriteLine("Added the Delegate");
                Answer += value;
            }
            remove 
            {
                Console.WriteLine("The Delegate was Removed");
                Answer -= value;
            }
        }
    }
 }





