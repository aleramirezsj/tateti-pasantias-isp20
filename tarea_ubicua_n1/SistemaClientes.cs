using System;
using System.Collections;

namespace tarea_ubicua_n1
{
	public class SistemaClientes
	{
		ArrayList clientes = new ArrayList ();

		public SistemaClientes ()
		{
			Console.WriteLine("Cargando el Sistema de clientes");
		}
		public void Iniciar ()
		{
			Menu();
		}
		private void ListarClientes()
		{
			foreach(Cliente cli in clientes){
					cli.Listar();
			}
		}
		private void BorrarCliente (int id_borrar)
		{
			foreach(Cliente cli in clientes){
					if (cli.codigo==id_borrar)
					{
						clientes.Remove(cli);
						break;
					}
			}
		}
		private void Menu ()
		{
			int opcion = 0;

			while (true)
			{
				Console.Clear();
				Console.WriteLine("CARGA DE CLIENTES");
				Console.WriteLine("1- Cargar un nuevo cliente");
				Console.WriteLine("2- Listar los clientes cargados");
				Console.WriteLine("3- Borrar un cliente");
				Console.WriteLine("4- Salir");
				Console.WriteLine("Ingrese el número de la opción:");
				try{
					opcion=Convert.ToInt32(Console.ReadLine());
				}catch{
					Console.WriteLine("Error en la opción ingresada");
				}

				switch (opcion)
				{
				case 1:
					Cliente cliente = new Cliente ();
					cliente.CapturarDatos ();
					clientes.Add (cliente);
					break;
				case 2:
					ListarClientes();
					Console.ReadLine();
					break;
				case 3:
					ListarClientes();
					Console.Write("Ingrese el número de cliente a eliminar:");
					int eliminar_cliente=Convert.ToInt32(Console.ReadLine());
					BorrarCliente(eliminar_cliente);
					ListarClientes();
					Console.ReadLine();
					break;
				case 4:
					return;

				
				}

			}
		}
	}
}

