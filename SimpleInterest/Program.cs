using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInterest
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleInterest_Calc cal = new SimpleInterest_Calc();
            
            cal.SimpleInterestEvent += EndMessage;
            cal.CalcSimpleInterest(cal.Principle(), cal.Interest(), cal.TimeRange());

            Console.ReadLine();
        }

        public static void EndMessage(object sender, EventArgs e)
        {
            Console.WriteLine("Thank you for using this calculator!");
            Console.WriteLine("Goodbye!");
        }
        
    }
}
