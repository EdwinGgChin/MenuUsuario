using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_05_2023.Funciones
{
    public class Operaciones            //es la clase de las operaciones 
    {
        #region Otra forma de hacer
        //public int num1, num2;
        /*public void Suma()
        {
            Console.WriteLine("Ingresa un numero:");
            num1= int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa un numero:");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"El resultado es {num1 + num2}");


            //int resultado = num1 + num2;      es otra forma de dar el resultado
            //return num1 + num2;                  retorna el resultado de la operacion
        }*/
        #endregion
        public int Suma(int num1, int num2, int num3, int num4, int num5)      //debes devolver un entero y declarar los parametros
        {
            int resultado = num1 + num2 + num3 + num4 + num5;
            return resultado;
        }

        public int Resta(int num1, int num2)
        {

            int resultado = num1 - num2;
            return resultado;
        }
        public int Multi(int num1, int num2)
        {

            int resultado = num1 * num2;
            return resultado;
        }
        public double PesoDolar(int num1, double vdolar)
        {
            vdolar = 17.69;
            double result = num1 * vdolar;
            return result;

        }

    }
}
