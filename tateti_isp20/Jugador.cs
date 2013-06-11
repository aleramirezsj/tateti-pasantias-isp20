using System;
using System.Collections;

namespace tateti_isp20
{
	public class Jugador
	{
		//declaración de las propiedades
		public Hashtable fichas;
		public string tipo_ficha;

		public Jugador (string tipoficha)
		{
			//inicializamos las fichas
			fichas = new Hashtable();
			fichas.Add(1,0);
			fichas.Add(2,0);
			fichas.Add(3,0);
			tipo_ficha=tipoficha;

		}
	}
}

