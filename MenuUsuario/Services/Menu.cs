using _19_05_2023.Clases;
using MenuUsuario.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _19_05_2023.Funciones
{
    public class Menu
    {
        public void Opciones()
        {
            #region Menu de opciones 
            int num1, num2, num3, num4, num5;
            double vdolar = 17.69;
            Console.WriteLine("Ingresa una de las opciones: ");
            Console.WriteLine("1: Suma");
            Console.WriteLine("2: Resta");
            Console.WriteLine("3: Multiplicacion");
            Console.WriteLine("4. De dolar a peso");
            int opcion = int.Parse(Console.ReadLine());
            Console.Clear();
            #endregion

            Operaciones operaciones = new Operaciones();
            double result = 0;

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Ingresa el primer valor");
                    num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingresa el segundo valor");
                    num2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingresa el tercer valor");
                    num3 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingresa el cuarto valor");
                    num4 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingresa el quinto valor");
                    num5 = int.Parse(Console.ReadLine());
                    result = operaciones.Suma(num1, num2, num3, num4, num5);
                    Console.WriteLine("El resultado es " + result);

                    break;
                case 2:
                    Console.WriteLine("Ingresa el primer valor");
                    num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingresa el segundo valor");
                    num2 = int.Parse(Console.ReadLine());
                    result = operaciones.Resta(num1, num2);
                    Console.WriteLine("El resultado es " + result);

                    break;
                case 3:
                    Console.WriteLine("Ingresa el primer valor");
                    num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingresa el segundo valor");
                    num2 = int.Parse(Console.ReadLine());
                    result = operaciones.Multi(num1, num2);
                    Console.WriteLine("El resultado es " + result);

                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("Cuantos dolares tienes?");
                    num1 = int.Parse(Console.ReadLine());
                    result = operaciones.PesoDolar(num1, vdolar);
                    Console.WriteLine("El valor en pesos mexicanos es: " + result);

                    break;
                case 5:

                    break;
                default:
                    Console.WriteLine("No existe esa opcion ");
                    break;
            }
        }
    }
}
