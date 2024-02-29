using System;

public class Empleado
{
    //miembro de datos 
    private string nombre;
    private int numeroEmpleado;

    //funciones miembro 
    public void leerDatos()
    {
        Console.Write("introduzca el nombre del empleado: ");
        nombre = Console.ReadLine();

        Console.Write("introduzca rl numero de empleado: ");
        numeroEmpleado = int.Parse(Console.ReadLine());
    }

    public void VerDatos()
    {
        Console.WriteLine("nombre: {0}", nombre);
        Console.WriteLine("numero de empleado: {0}", numeroEmpleado);
    }
}

class Program
{
    static void Main(string[] args)
    {
        //Crea un array de 50 empleados 
        Empleado[] empleados = new Empleado[50];

        //llenar un array con datos 
        for (int i = 0; i < empleados.Length; i++) // este bucle recorre cada elemento del array "empleados" comenzando desde el primer elemento "i = 0 y terminando en el ultimo elemento i=empleados.Length
        {
            empleados[i] = new Empleado();
            empleados[i].leerDatos(); // aqui tenia el error ya que lo tenia puesto de forma directa y daba resultado cero porque no habian ingresado datos que se leyeran
        }
        //mostrar los datos de los empleados 
        Console.WriteLine("**datos de los empelados:**");
        for (int i = 0; i < empleados.Length; i++)
            {
            empleados[i].VerDatos();
            Console.WriteLine();
        }
    }
}