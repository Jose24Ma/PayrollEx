using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace PayrollEx
{
    internal class Payroll
    {
        public static void Main(string[] args)
        {

            StreamWriter fichero;
            fichero = File.CreateText("prueba.txt")


                Menu menu = new Menu();
                fichero.WriteLine("Welcome the program the payroll");
                fichero.WriteLine("1. Si desea agregar otro empleado");
                fichero.WriteLine("2. Si desea salir del programa");

                int Opcion = int.Parse(Console.ReadLine());

                int Opc1 = 1;
                switch (Opcion)
                {
                    case 1:
                        do
                        {
                            menu.CalculatePayroll();
                            menu.Print();
                            fichero.WriteLine("1. Si desea agregar otro empleado");
                            fichero.WriteLine("2. Si desea salir del programa");
                            Opc1 = int.Parse(Console.ReadLine());
                            fichero.WriteLine("Dato Invalido");
                            Console.Clear();

                        } while (Opc1 != 2);
                        break;

                    case 2:
                        fichero.WriteLine("Saliendo del programa");
                        break;

                    default:
                        fichero.WriteLine("Opcion no valida / Ingrese una correcta");
                        break;
                }
            fichero.Close();
            
            
        }
    }
}
