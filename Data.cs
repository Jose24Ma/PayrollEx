using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollEx
{
    internal class Data
    {
        private string FirstName;
        private string LastName;
        private double Document;
        private double MinSalary;
        private double WorkedDays;
        private double Accrued;
        private double AuxTranspor;
        private double Health;
        private double Pension;

        public string FirstName1 { get => FirstName; set => FirstName = value; }
        public string LastName1 { get => LastName; set => LastName = value; }
        public double Document1 { get => Document; set => Document = value; }
        public double MinSalary1 { get => MinSalary; set => MinSalary = value; }
        public double WorkedDays1 { get => WorkedDays; set => WorkedDays = value; }
        public double Accrued1 { get => Accrued; set => Accrued = value; }
        public double AuxTranspor1 { get => AuxTranspor; set => AuxTranspor = value; }
        public double Health1 { get => Health; set => Health = value; }
        public double Pension1 { get => Pension; set => Pension = value; }
    }
}
