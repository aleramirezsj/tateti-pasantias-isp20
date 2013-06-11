using System;

namespace tateti_isp20
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Juego juego=new Juego();
			int jugador_actual=1;
			int ficha_actual=1;
			int ficha_a_mover=0;
			int posicion_elegida=0;
			while (true) 
			{
				juego.PintarTablero();
				//cuando ya se colocaron las 6 fichas
				//pide definir la ficha a mover
				if (ficha_actual==0)
				{
					ficha_a_mover=juego.SeleccionarFicha(jugador_actual);
					Console.Write("Jugador {0}: ingrese la posicion de la ficha {1}:",jugador_actual,ficha_a_mover);
					posicion_elegida=Convert.ToInt32(Console.ReadLine());
					juego.Jugar(jugador_actual,ficha_a_mover,posicion_elegida);
				}
				//en las primeras 6 fichas se ejecuta
				//esto
				else
				{
					//pide ingresar el movimiento
					Console.Write("Jugador {0}: ingrese la posicion de la ficha {1}:",jugador_actual,ficha_actual);
					try
					{
						posicion_elegida=Convert.ToInt32(Console.ReadLine());
					}
					catch
					{
						Console.WriteLine("Error, valor incorrecto presione una tecla para continuar");
						Console.ReadKey();
						continue;
					}
					//almacenar el movimiento en el tablero y en las fichas
					//del jugador
					juego.Jugar(jugador_actual,ficha_actual,posicion_elegida);
					//cambio de jugador
				}
				jugador_actual++;
				if (jugador_actual==3)
				{
					jugador_actual=1;
					if (ficha_actual>0)
					{
						ficha_actual++;
						if (ficha_actual==4)
							ficha_actual=0;
					}
				}
			}
		}
	}
}
