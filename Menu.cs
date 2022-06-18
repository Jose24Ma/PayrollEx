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
        public void CalculatePayroll()
        {
            try
            {
                Console.WriteLine("Enter the name of the employee :");
                data.FirstName1 = Console.ReadLine();
                Console.WriteLine("Enter the last name of the employee :");
                data.LastName1 = Console.ReadLine();
                Console.WriteLine("Enter the employee document :");
                data.Document1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the employee's minumun salary :");
                data.MinSalary1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the days worked by the employee :");
                data.WorkedDays1 = double.Parse(Console.ReadLine());


                Console.WriteLine("¿The employee worked overtime? yes/no");
                data.OpcionHour1 = Console.ReadLine();
                if ((data.OpcionHour1 == "YES") || (data.OpcionHour1 == "yes"))
                {
                    Console.WriteLine("Enter the number of hours completed");
                    data.Hours1 = int.Parse(Console.ReadLine());
                    data.OrdinaryHour1 = 12500;
                    data.Overtime1 = (data.Hours1 * data.OrdinaryHour1) * 0_12;
                    Console.WriteLine("");
                    Console.WriteLine("The record has been saved to the file Payroll.txt");
                    Console.WriteLine("");
                }
                else if ((data.OpcionHour1 == "NO") || (data.OpcionHour1 == "no"))
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

            data.Health1 = data.Accrued1 * 0_04;
            data.Pension1 = data.Accrued1 * 0_04;

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
            var Date = DateTime.Now;
            StreamWriter Write = File.AppendText("Payroll.txt");
            Write.WriteLine("Name Employee: "+ data.FirstName1 +" "+ data.LastName1);
            Write.WriteLine("Document: "+"C.C "+ data.Document1);
            Write.WriteLine("Salary Base: "+"$"+data.MinSalary1);
            Write.WriteLine("Worked Days/Month: " +data.WorkedDays1);
            if ((data.OpcionHour1 == "NO") || (data.OpcionHour1 == "no"))
            {
                Write.WriteLine("Overtime: No worked overtime");
            }
            else if ((data.OpcionHour1 == "YES") || (data.OpcionHour1 == "yes"))
            {
                Write.WriteLine("Overtime: " + data.Hours1 + " Hours");
            }
            Write.WriteLine("The total earned by the employee is: " + "$" + data.Accrued1);
            Write.WriteLine("");
            Write.WriteLine("Record time: "+ Date);
            Write.WriteLine("--------------------New Employee------------------------");
            Write.WriteLine("");
            Write.Close();
        }
     
    }
}
