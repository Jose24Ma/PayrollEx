using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollEx
{
    internal class Menu
    {
        Data data = new Data();
        public void CalculatePayroll()
        {
            
            try
            {
                Console.WriteLine("Enter the name of the employee :");
                data.FirstName1 = Console.ReadLine();
                Console.WriteLine("Enter the last name of the employee :");
                data.LastName1 = Console.ReadLine();
                Console.WriteLine("Enter the employee document :" + "\nC.C");
                data.Document1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the employee's minumun salary :");
                data.MinSalary1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the days worked by the employee :");
                data.WorkedDays1 = double.Parse(Console.ReadLine());
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Wrong enter valid data");
                Console.ReadKey();
            }

            data.Accrued1 = (data.MinSalary1 * data.WorkedDays1) / 30;

            data.AuxTranspor1 = 117172 / 30;
            data.AuxTranspor1 = data.AuxTranspor1 * data.WorkedDays1;

            data.Health1 = data.Accrued1 * 0.04;
            data.Pension1 = data.Accrued1 * 0.04;

            if (data.MinSalary1 <= 2000000)
            {
                data.Accrued1 = data.Accrued1 + data.AuxTranspor1 + data.Health1 + data.Pension1;

            }
            else
            {
                data.MinSalary1 = data.MinSalary1;
            }
        }
        public void Print()
        {
            Console.WriteLine(data.FirstName1 +""+ data.LastName1);
            Console.WriteLine(data.Document1);
            Console.WriteLine(data.MinSalary1);
            Console.WriteLine(data.WorkedDays1);
            Console.WriteLine(data.Accrued1);
            Console.WriteLine("The total earned by the employee is:" + data.Accrued1);
        }
    }
}
