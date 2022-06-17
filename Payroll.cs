using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using DocumentFormat.OpenXml.Vml;

namespace PayrollEx
{
    internal class Payroll
    {
        public static void Main(string[] args)
        {

            

            Menu menu = new Menu();
  
                Console.WriteLine("Welcome the program the payroll");
                Console.WriteLine("1. If you want to add another employee");
                Console.WriteLine("2. If you want to exit the program");

                int Opcion = int.Parse(Console.ReadLine());

                int Opc1 = 1;
                switch (Opcion)
                {
                    case 1:
                        do
                        {
                            menu.CalculatePayroll();
                            menu.Print();
                            Console.WriteLine("1. If you want to add another employee");
                            Console.WriteLine("2. If you want to exit the program");
                            Opc1 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Invalid Data");
                            Console.Clear();

                        } while (Opc1 != 2);
                        break;

                    case 2:
                        Console.WriteLine("Exit the program");
                        break;

                    default:
                        Console.WriteLine("Invalid Opcion/ Enter a Correct");
                        break;

                    
                }
            
        }
    }
}
