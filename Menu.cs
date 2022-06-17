using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PayrollEx
{
    internal class Menu
    {
        Data data = new Data();
        Calculations calculations = new Calculations();
        public void CalculatePayroll()
        {
            try
            {
                Console.WriteLine("Enter the name of the employee :");
                data.FirstName1 = Console.ReadLine();
                Console.WriteLine("Enter the last name of the employee :");
                data.LastName1 = Console.ReadLine();
                Console.WriteLine("Enter the employee document :" );
                data.Document1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the employee's minumun salary :");
                data.MinSalary1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the days worked by the employee :");
                data.WorkedDays1 = double.Parse(Console.ReadLine());

                string OpcionHour = null;
                Console.WriteLine("¿The employee worked overtime? yes/no");
                OpcionHour = Console.ReadLine();
                if ((OpcionHour == "YES") || (OpcionHour == "yes"))
                {
                    Console.WriteLine("Enter the number of hours completed");
                    data.Overtime1 = int.Parse(Console.ReadLine());
                    data.OrdinaryHour1 = 12_500;
                    data.Overtime1 = data.Overtime1 * data.OrdinaryHour1;
                    Console.WriteLine("");
                    Console.WriteLine("The record has been saved to the file Payroll.txt");
                    Console.WriteLine("");
                }
                else if ((OpcionHour == "NO") || (OpcionHour == "no"))
                {
                    Console.WriteLine("");
                    Console.WriteLine("The record has been saved to the file Payroll.txt");
                    Console.WriteLine("");
                }

            }
            catch (FormatException ex)
            {
                Console.WriteLine("Wrong enter valid data");
                Console.ReadKey();
            }

            data.Accrued1 = (data.MinSalary1 * data.WorkedDays1) / 30;

            if (data.WorkedDays1 < 30)
            {
                data.AuxTranspor1 = 117172;
                data.AuxTranspor1 = (data.AuxTranspor1 * data.WorkedDays1) / 30;
            }
            else
            {
                data.AuxTranspor1 = 117172;
            }

            data.Health1 = data.Accrued1 * 0.04;
            data.Pension1 = data.Accrued1 * 0.04;

            if (data.MinSalary1 < 2000000)
            {
                data.Accrued1 = (data.Accrued1 + data.AuxTranspor1 + data.Overtime1) - data.Health1 + data.Pension1;

            }
            else
            {
                data.Accrued1 = data.MinSalary1 + data.Overtime1;
            }
        }
        public void Print()
        {
            StreamWriter Write = File.AppendText("Payroll.txt");
            Write.WriteLine("Name Employee: "+data.FirstName1 +" "+ data.LastName1);
            Write.WriteLine("Document: "+"C.C "+ data.Document1);
            Write.WriteLine("Salary Base: "+"$"+data.MinSalary1);
            Write.WriteLine("Worked Days/Month: " +data.WorkedDays1);
            Write.WriteLine("Overtime: " + data.Overtime1 + " Hours");
            Write.WriteLine("The total earned by the employee is: " + "$" + data.Accrued1);
            Write.WriteLine("");
            Write.WriteLine("--------------------New Employee------------------------");
            Write.WriteLine("");
            Write.Close();
        }
     
    }
}
