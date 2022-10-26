using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trainee_Project
{
    internal class Debt
    {
        private double _Balance { get; set; }
        private double _InterestRate { get; set; }

        public Debt(double initialBalance, double initialInterestRate)
        {
            _Balance = initialBalance;
            _InterestRate = initialInterestRate;
        }

        public void HoldOnOneYear()
        {
            _Balance = _Balance * _InterestRate;
            
        }

        public void ShowBalance()
        {
            Console.WriteLine($"_Balance:{_Balance} InterestRate{_InterestRate}");
        }



    }
}
