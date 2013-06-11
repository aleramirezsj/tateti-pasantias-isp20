using System;

namespace tarea_ubicua_n1
{
public class Cliente
{
    private string nombre, apellido, direccion, localidad, telefono;
    public int codigo;
    private DateTime FechaNac;

    private void CapturarNombre()
    {
        Console.Write("Ingrese su nombre: ");
        nombre = Console.ReadLine();
		if (nombre == "")
			{
				Console.WriteLine("Error, ingresa nuevamente el nombre");
				CapturarNombre();
			}
    }

    private void CapturarApellido()
    {
        Console.Write("Ingrese su apellido: ");
        apellido = Console.ReadLine();
		if (apellido == "")
		{
			Console.WriteLine("Error, ingresa nuevamente el apellido");
			CapturarApellido();
		}
    }

    private void CapturarDireccion()
    {
        Console.Write("Ingrese su dirección: ");
        direccion = Console.ReadLine();
		if (direccion == "")
		{
			Console.WriteLine("Error, ingresa nuevamente el dirección");
			CapturarDireccion();
		}
    }

    private void CapturarLocalidad()
    {
        Console.Write("Ingrese su localidad: ");
        localidad = Console.ReadLine();
		if (direccion == "")
		{
			Console.WriteLine("Error, ingresa nuevamente el dirección");
			CapturarDireccion();
		}
    }

    private void CapturarTelefono()
    {
        Console.Write("Ingrese su teléfono: ");
        telefono = Console.ReadLine();
		if (telefono == "")
		{
			Console.WriteLine("Error, ingresa nuevamente el Telefono");
			CapturarTelefono();
		}
    }
 
    private void CapturarCodigo ()
		{
			Console.Write ("Ingrese su Codigo: ");
			try {
				codigo = Convert.ToInt32 (Console.ReadLine ());
			} catch {
				CapturarCodigo ();
			} 

     }
    private void CapturarFechaNac ()
		{
			Console.Write ("Ingrese su Fecha de Nacimiento: ");
			//intenta convertir a datetime lo que escribe el usuario
			try {
				FechaNac = Convert.ToDateTime (Console.ReadLine ());
			} catch {
				//si la conversión fallo vuelve a llamar al método
				CapturarFechaNac ();
			}
    }
 
 
    public string ImprimirFicha() 
    {
        string ficha="FICHA PERSONAL CLIENTE";
		ficha+="\nCodigo: " + codigo;
        ficha+="\nNombre: " + nombre;
        ficha+="\nApellido: " + apellido; 
        ficha+="\nDireccion: " + direccion; 
        ficha+="\nLocalidad: " + localidad; 
        ficha+="\nTelefono: " + telefono; 
		ficha+="\nFecha de Nacimiento: "+FechaNac.ToShortDateString();
		return ficha;
    }

	public void CapturarDatos()
    	{
        	CapturarCodigo();
			CapturarNombre();
            CapturarApellido();
            CapturarDireccion();
            CapturarLocalidad();
            CapturarTelefono();
            CapturarFechaNac();
        }

	private string Presentarse()
    {
            string presentacion="Hola Soy: "+nombre+" "+apellido;
			return presentacion;
	}
	public void Listar()
    {
			//imprimimos en un renglon los datos de un cliente
			Console.WriteLine("|{0}|{1}|{2}|{3}|{4}",codigo,nombre,apellido,direccion,localidad);
	}

	private string AnunciarDomicilio()
    {
            return "Vivo en: " +direccion+ " - " +localidad;
    }
	public string AnunciarEdad()
    {
         //calculamos la edad y mostramos en un string 
		 int edad;
         DateTime hoy = DateTime.Now;
         edad = hoy.Year - FechaNac.Year;
         return "Nací en el año " + FechaNac.Year + " y tengo " + edad + " años de edad";
     }
	public void Hablar()
        {
        	Console.WriteLine(Presentarse());
            Console.WriteLine(AnunciarDomicilio());
            Console.WriteLine(AnunciarEdad());
        }
	}
}

