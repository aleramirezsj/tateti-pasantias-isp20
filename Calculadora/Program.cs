using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            /*String nombre, apellido = "";
            Console.WriteLine("Ingrese su nombre:");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su apellido:");
            apellido = Console.ReadLine();
            Console.WriteLine("Bienvenido a C# {0} {1}", nombre,apellido);
           */
            //creamos el objeto mi calcu

            
            Calculadora micalcu = new Calculadora();

            //pedimos el ingreso del primer numero
            Console.WriteLine("Ingrese un número:");
            float nro1 = Convert.ToSingle(Console.ReadLine());
            
            //grabamos el nro en la calculadora
            micalcu.IngresarValor(nro1);

            //pedimos el ingreso de la operación
            Console.WriteLine("Ingrese la operación:");
            string operacion = Console.ReadLine();
            
            
            //pedimos el ingreso del segundo numero
            Console.WriteLine("Ingrese otro número:");
            float nro2 = Convert.ToSingle(Console.ReadLine());
            
            //grabamos el 2do nro en la calculadora
            micalcu.IngresarValor(nro2);
            
                      
            //mostramos el resultado enviando por parametros la operación
            //ingresado por el usuario
            Console.WriteLine("El resultado es:{0}",micalcu.MostrarResultado(operacion));
            Console.ReadKey();


        }
    }
}
