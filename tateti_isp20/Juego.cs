using System;
using System.Collections;

namespace tateti_isp20
{
	public class Juego
	{
		private Tablero tablero;
		private Jugador jugador1;
		private Jugador jugador2;

		public Juego ()
		{
			tablero = new Tablero ();
			jugador1 = new Jugador ("X");
			jugador2 = new Jugador ("O");
		}
		public void PintarTablero()
		{
			tablero.Limpiar();
			foreach (DictionaryEntry ficha in jugador1.fichas) 
			{
				tablero.posiciones[ficha.Value]=jugador1.tipo_ficha+ficha.Key.ToString();
			}
			foreach (DictionaryEntry ficha in jugador2.fichas) 
			{
				tablero.posiciones[ficha.Value]=jugador2.tipo_ficha+ficha.Key.ToString();
			}
			tablero.Pintar();
		}
		public int SeleccionarFicha (int jugador_actual)
		{
			int ficha_a_mover=0;
			Console.Write("Jugador {0}: ingrese el nro de ficha a mover:",jugador_actual);
			try
			{
				ficha_a_mover=Convert.ToInt32(Console.ReadLine());
			}
			catch
			{
				Console.WriteLine("Error, valor incorrecto presione una tecla para continuar");
				Console.ReadKey();
				SeleccionarFicha(jugador_actual);
			}
			return ficha_a_mover;
		}
		public void Jugar (int jugador, int nroficha, int pos_elegida)
		{
			if (jugador == 1)
				jugador1.fichas[nroficha] = pos_elegida;
			else
				jugador2.fichas[nroficha] = pos_elegida;

		}

	}
}

