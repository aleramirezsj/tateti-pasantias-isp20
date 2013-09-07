using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculadoraVisual
{
    /// <summary>
    /// Primera clase de prueba de pasantias 2013
    /// </summary>
    public class Calculadora
    {
        //declaracion de las propiedades
        private float numero1;
        private float numero2;
        private float resultado;
        public Calculadora()
        {
            numero1 = 0;
            numero2 = 0;
        }
        public Calculadora(float nro1, float nro2)
        {
            numero1 = nro1;
            numero2 = nro2;
        }

        public float Sumar()
        {
            Console.WriteLine("ejecutando sumar sin parametros");
            return numero1 + numero2;
        }
        public float Sumar(float nro)
        {
            Console.WriteLine("ejecutando con parametros");
            return numero1 + numero2 + nro;
        }
        public void IngresarValor(float nro1,float nro2)
        {
            
            numero1 = nro1;
            numero2 = nro2;
            
        }
        public float MostrarResultado(string operacion)
        {
            if (operacion == "+")
            {
                return numero1 + numero2;
            }
            if (operacion == "-")
            {
                return numero1 - numero2;
            }
            if (operacion == "/")
            {
                return numero1 / numero2;
            }
            if (operacion == "*")
            {
                return numero1 * numero2;
            }
            else
            {
                return 0;
            }
        }

    }
}
