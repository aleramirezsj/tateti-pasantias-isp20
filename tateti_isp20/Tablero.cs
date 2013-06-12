using System;
using System.Collections;

namespace tateti_isp20
{
	public class Tablero
	{
		public Hashtable posiciones;

		//método constructor
		public Tablero ()
		{
			posiciones= new Hashtable();

			//inicializamos las 9 posiciones con el valor vacio
			for (int i=1; i<10; i++) 
				posiciones.Add(i,"  ");
		}
		public void Limpiar ()
		{
			for (int i=1; i<10; i++) 
				posiciones[i]="  ";
		}

		public void Pintar ()
		{
			//borro la consola
			Console.Clear();
			//imprimo el tablero y cada una de las posiciones
			//con su respectivo valor
			for (int i=1; i<10; i++) 
			{
				Console.Write("[{0}]",posiciones[i]);
				//utilizamos el módulo para detectar que ya se 
				//imprimieron 3 casilleros y generamos un salto de linea
				if (i%3==0)
				{
					Console.Write("\n");
				}
			}
		}

	}
}

