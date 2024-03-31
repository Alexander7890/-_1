using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace наслідування_1
{
    public class Employee : Person
    {
        public string Workplace { get; set; }
        public double Salary { get; set; }

        // Розрахунок доходу
        public double CalculateIncome()
        {
            return Salary * 12;
        }
    }
}
