using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int edad;
            string nombre;
            string cedula;
            string tipoEmpleado = "";
            int cantidadhoraslabordas;
            int precioporhora;

            Console.WriteLine("Digite su numero de Cedula:");
         cedula = Console.ReadLine();                                 
         Console.WriteLine();

         Console.WriteLine("Digite su nombre completo:");
         nombre = Console.ReadLine();
         Console.WriteLine();

         Console.WriteLine("Digite su edad:");                                         
         edad = int.Parse(Console.ReadLine());

         Console.WriteLine("Seleccione el tipo de empleado: 1-Operario 2-Tecnico 3- Profesional");
         int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
            case 1:
                    tipoEmpleado = "Operario";
                    break;

            case 2:
                    tipoEmpleado = "Tecnico";
                    break;

            case 3:
                    tipoEmpleado = "Profesional";
                    break;

            }



            if (tipoEmpleado !="")
            {

        Console.WriteLine("Digite la cantidad de horas laboradas:");
                cantidadhoraslabordas = int.Parse(Console.ReadLine());



        Console.WriteLine("Digite el precio por horas laboradas:");
                precioporhora = int.Parse(Console.ReadLine());



                int salarioordinario = cantidadhoraslabordas * precioporhora;


                double aumento = 0;
                switch (tipoEmpleado)
                {
                    case "operario":
                        aumento = 0.15;
                        break;

                    case "Tecnico":
                        aumento = 0.10;
                        break;

                    case "Profesional":
                        aumento = 0.10;
                        break;


                }
                double salarioConAumento = salarioordinario * (1 + aumento);
                double salarioBruto = salarioordinario + salarioConAumento;

                double deduccionesCCSS = salarioBruto * 0.0917;

                double salarioNeto = salarioBruto - deduccionesCCSS;





                Console.WriteLine("mi cedula es: " + cedula);
                Console.WriteLine("mi nombre es: " + nombre);
                Console.WriteLine("mi edad es: " + edad);
                Console.WriteLine("Tipo de empleado: " + tipoEmpleado);
                Console.WriteLine("Cantidad de horas laboradas: " + cantidadhoraslabordas);
                Console.WriteLine("Precio por hora: " + precioporhora);
                Console.WriteLine("Salario ordinario: " + salarioordinario);
                Console.WriteLine("Salario con aumento: " + salarioConAumento);
                Console.WriteLine("Salario bruto: " + salarioBruto);
                Console.WriteLine("Deducciones CCSS: " + deduccionesCCSS);
                Console.WriteLine("Salario neto: " + salarioNeto);
            }









            Console.ReadLine();
        }
    }
}
