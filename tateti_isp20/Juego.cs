using System;
using System.Collections;

namespace tateti_isp20
{
	public class Juego
	{
		private Tablero tablero;
		private Jugador jugador1;
		private Jugador jugador2;
		int[,] movimientos_validos;
		int[,] jugadas_ganadoras;



		public Juego ()
		{
			tablero = new Tablero ();
			jugador1 = new Jugador ("X");
			jugador2 = new Jugador ("O");
			movimientos_validos= new int[10,9];
			jugadas_ganadoras= new int[8,3];
			//movim_validos[posicion_ficha,nro_movimiento]=posicion_valida
			movimientos_validos[1,1]=2;
			movimientos_validos[1,2]=5;
			movimientos_validos[1,3]=4;
			movimientos_validos[2,1]=1;
			movimientos_validos[2,2]=5;
			movimientos_validos[2,3]=3;
			movimientos_validos[3,1]=2;
			movimientos_validos[3,2]=5;
			movimientos_validos[3,3]=6;
			movimientos_validos[4,1]=1;
			movimientos_validos[4,2]=5;
			movimientos_validos[4,3]=7;
			movimientos_validos[5,1]=1;
			movimientos_validos[5,2]=2;
			movimientos_validos[5,3]=3;
			movimientos_validos[5,4]=4;
			movimientos_validos[5,5]=6;
			movimientos_validos[5,6]=7;
			movimientos_validos[5,7]=8;
			movimientos_validos[5,8]=9;
			movimientos_validos[6,1]=3;
			movimientos_validos[6,2]=5;
			movimientos_validos[6,3]=9;
			movimientos_validos[7,1]=4;
			movimientos_validos[7,2]=5;
			movimientos_validos[7,3]=8;
			movimientos_validos[8,1]=7;
			movimientos_validos[8,2]=5;
			movimientos_validos[8,3]=9;
			movimientos_validos[9,1]=8;
			movimientos_validos[9,2]=5;
			movimientos_validos[9,3]=6;
			jugadas_ganadoras[0,0]=1;
			jugadas_ganadoras[0,1]=2;
			jugadas_ganadoras[0,2]=3;
			jugadas_ganadoras[1,0]=3;
			jugadas_ganadoras[1,1]=6;
			jugadas_ganadoras[1,2]=9;
			jugadas_ganadoras[2,0]=7;
			jugadas_ganadoras[2,1]=8;
			jugadas_ganadoras[2,2]=9;
			jugadas_ganadoras[3,0]=1;
			jugadas_ganadoras[3,1]=4;
			jugadas_ganadoras[3,2]=7;
			jugadas_ganadoras[4,0]=1;
			jugadas_ganadoras[4,1]=5;
			jugadas_ganadoras[4,2]=9;
			jugadas_ganadoras[5,0]=2;
			jugadas_ganadoras[5,1]=5;
			jugadas_ganadoras[5,2]=8;
			jugadas_ganadoras[6,0]=3;
			jugadas_ganadoras[6,1]=5;
			jugadas_ganadoras[6,2]=7;
			jugadas_ganadoras[7,0]=4;
			jugadas_ganadoras[7,1]=5;
			jugadas_ganadoras[7,2]=6;

		}
		public bool ComprobarGanador ()
		{
			int acierto1=0;
			int acierto2=0;
			//comprobamos si gano el jugador 1
			for (int jugada=0; jugada<8; jugada++)
			{
				for(int ficha=0; ficha<3; ficha++)
				{
					if(jugadas_ganadoras[jugada,ficha]==(int)jugador1.fichas[1])
						acierto1++;	
					if(jugadas_ganadoras[jugada,ficha]==(int)jugador1.fichas[2])
						acierto1++;
					if(jugadas_ganadoras[jugada,ficha]==(int)jugador1.fichas[3])
						acierto1++;
					if(jugadas_ganadoras[jugada,ficha]==(int)jugador2.fichas[1])
						acierto2++;	
					if(jugadas_ganadoras[jugada,ficha]==(int)jugador2.fichas[2])
						acierto2++;
					if(jugadas_ganadoras[jugada,ficha]==(int)jugador2.fichas[3])
						acierto2++;
				}
				if (acierto1==3||acierto2==3)
					return true;
				else
				{
					//no hay un ganador que coincida con esta jugada
					acierto1=0;
					acierto2=0;
				}
			}
			return false;


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
			ComprobarGanador(); 
			/*
				Console.WriteLine("Existe un ganador");
				Console.ReadLine();
			}*/
		}
		public void SeleccionarPosicion (int jugador, int ficha, ref int posicion_elegida)
		{
			Console.Write ("Jugador {0}: ingrese la posicion de la ficha {1}:", jugador, ficha);
			try {
				posicion_elegida = Convert.ToInt32 (Console.ReadLine ());
			} catch {
				Console.WriteLine ("Error, valor incorrecto presione una tecla para continuar");
				Console.ReadKey ();
				SeleccionarPosicion (jugador, ficha, ref posicion_elegida);
			}
			if (posicion_elegida > 9 || posicion_elegida < 1) {
				Console.WriteLine ("Error, valor incorrecto presione una tecla para continuar");
				Console.ReadKey ();
				SeleccionarPosicion (jugador, ficha, ref posicion_elegida);
			}
			if (!ComprobarPosicionVacia (posicion_elegida)) 
			{
				Console.WriteLine ("Error, posicion elegida ya está en uso");
				Console.ReadKey ();
				SeleccionarPosicion (jugador, ficha, ref posicion_elegida);
			}
			if (!ComprobarMovimientoValido (posicion_elegida, jugador, ficha)) 
			{
				Console.WriteLine ("Error, movimiento no válido");
				Console.ReadKey ();
				SeleccionarPosicion (jugador, ficha, ref posicion_elegida);
			}

		}
		public bool ComprobarMovimientoValido (int posicion_elegida, int jugador, int ficha)
		{
			int posicion_previa=0;
			if (jugador == 1) {
				posicion_previa = (int)jugador1.fichas [ficha];
			} else {
				posicion_previa = (int)jugador2.fichas [ficha];
			}
			//si la ficha ya está colocada en el tablero
			//comprueba si se puede realizar el movimiento
			if (posicion_previa > 0) 
			{
				for (int i=1;i<9;i++)
				{
					if (movimientos_validos[posicion_previa,i]==posicion_elegida)
						return true;
				}
				return false;
			}
			//algo
			return true;
		}
		public bool ComprobarPosicionVacia (int posicion)
		{
			foreach (DictionaryEntry ficha in jugador1.fichas) 
			{
				if ((int)ficha.Value==posicion)
					return false;
			}
			foreach (DictionaryEntry ficha in jugador2.fichas) 
			{
				if ((int)ficha.Value==posicion)
					return false;			
			}

			return true;
		}
		public void SeleccionarFicha (int jugador_actual, ref int ficha_a_mover)
		{

			Console.Write ("Jugador {0}: ingrese el nro de ficha a mover:", jugador_actual);
			try {
				ficha_a_mover = Convert.ToInt32 (Console.ReadLine ());
			} catch {
				Console.WriteLine ("Error, valor incorrecto presione una tecla para continuar");
				Console.ReadKey ();
				SeleccionarFicha (jugador_actual, ref ficha_a_mover);
			}
			if (ficha_a_mover > 3 || ficha_a_mover < 1) 
			{
				Console.WriteLine ("Error, valor incorrecto presione una tecla para continuar");
				Console.ReadKey ();
				SeleccionarFicha (jugador_actual, ref ficha_a_mover);
			}

		}
		public void Jugar (int jugador, int nroficha, int pos_elegida)
		{
			if (jugador == 1)
				jugador1.fichas [nroficha] = pos_elegida;
			else {
				jugador2.fichas [nroficha] = pos_elegida;
			}



		}

	}
}

