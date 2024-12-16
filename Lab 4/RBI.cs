using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    internal class RBI
    {
        public virtual void CalculateInterest(double principal, double rate, int time)
        {
            double interest = (principal * rate * time) / 100;
            Console.WriteLine("Interest is " + interest);
        }
    }
    
    class HDFC : RBI
    {
        public override void CalculateInterest(double principal, double rate, int time)
        {
            double interest = (principal * rate * time) / 100;
            Console.WriteLine("Interest HDFC is " + interest);
        }
    }

    class SBI : RBI
    {
        public override void CalculateInterest(double principal, double rate, int time)
        {
            double interest = (principal * rate * time) / 100;
            Console.WriteLine("Interest SBI is " + interest);
        }
    }

    class ICICI : RBI
    {
        public override void CalculateInterest(double principal, double rate, int time)
        {
            double interest = (principal * rate * time) / 100;
            Console.WriteLine("Interest ICICI is " + interest);
        }
    }

}
