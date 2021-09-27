using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInterest
{
    public delegate void SimpleInterestEventHandler(object sender, EventArgs e);
    class SimpleInterest_Calc
    {
        public event SimpleInterestEventHandler SimpleInterestEvent;
        int principle;
        float interest;
        int timerange;

        public int Principle()
        {
            try
            {
                Console.WriteLine("What is the Principle amount? ");
                Console.Write("Enter here: ");
                principle = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Error! Only numbers allowed!");
                Console.WriteLine();
            }
            catch(ArgumentNullException)
            {
                Console.WriteLine("Error! No input has been detected!");
                Console.WriteLine();
            }

            if(principle == 0)
            {
                Console.WriteLine("Error! 0 is not allowed for this input!");
                Environment.Exit(0);
                Console.WriteLine("Goodbye!");
                Console.ReadLine();
            }

            return principle;
        }

        public float Interest()
        {
            try
            {
                Console.WriteLine("What is the Interest Rate? ");
                Console.Write("Enter here: ");
                interest = float.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Error! Only numbers allowed!");
                Console.WriteLine();
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Error! No input has been detected!");
                Console.WriteLine();
            }


            if (interest == 0)
            {
                Console.WriteLine("Error! 0 is not allowed for this input!");
                Environment.Exit(0);
                Console.WriteLine("Goodbye!");
                Console.ReadLine();
            }

            return interest;
        }

        public int TimeRange()
        {
            try
            {
                Console.WriteLine("What is the timerange?(in months)");
                Console.Write("Enter here: ");
                timerange = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Error! Only numbers allowed!");
                Console.WriteLine();
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Error! No input has been detected!");
                Console.WriteLine();
            }

            if (principle == 0)
            {
                Console.WriteLine("Error! 0 is not allowed for this input!");
                Environment.Exit(0);
                Console.WriteLine("Goodbye!");
                Console.ReadLine();
            }

            return timerange;
        }

        public void CalcSimpleInterest(int principle, float interest, int timerange)
        {
            Console.WriteLine("The principle amount is: " + principle);
            Console.WriteLine("The interest rate is: " + interest);
            Console.WriteLine("The timerange is: " +  timerange + " months.");
            Console.WriteLine();
            Console.WriteLine("Calculating simple interest now....");
            Console.WriteLine();

            try
            {
                float result = principle * interest * timerange / 100;

                Console.WriteLine("The total interest is: " + result);
                Console.WriteLine();
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error! Attempted to divide by value 0!");
                Console.WriteLine();
            }
            finally
            {
                SimpleInterestEventSender(EventArgs.Empty);
            }
        }

        protected virtual void SimpleInterestEventSender(EventArgs e)
        {
            SimpleInterestEvent?.Invoke(this, e);
        }
    }

}
