using System;
using System.Collections.Generic;
using Trabajo3.Ventas;


namespace Trabajo3
{
    class Program
    {
        static void Main(string[] args)
        {

            Cliente cliente = new Cliente();
            Console.WriteLine("Ingrese los datos del cliente:");

            Console.WriteLine("Ingrese los apellidos del cliente");
            cliente.Apellidos = Console.ReadLine();

            Console.WriteLine("Ingrese los nombres del cliente");
            cliente.Nombres = Console.ReadLine();

            Console.WriteLine("Ingrese el número de cédula del cliente");
            cliente.Cédula = Console.ReadLine();

            Console.WriteLine("Ingrese la dirección del cliente");
            cliente.Dirección = Console.ReadLine();


            Console.WriteLine("Ingrese los datos de la gasolina:");
            Gasolina gasolina = new Gasolina();
            Console.WriteLine("Ingrese el tipo de gasolina");
            gasolina.Tipo = Console.ReadLine();
            Console.WriteLine("Ingrese la cantidad de gasolina");
            gasolina.Cantidad = Int32.Parse(Console.ReadLine());


            Console.WriteLine("Datos del cliente:");
            Console.WriteLine(cliente.Apellidos + "" + cliente.Nombres);
            Console.WriteLine(cliente.Cédula);
            Console.WriteLine(cliente.Dirección);


            Console.WriteLine("Factura:");
            Console.WriteLine("Subtotal:" +gasolina.Subtotal());
            Console.WriteLine("IVA:" +gasolina.Iva());
            Console.WriteLine("Total:" +gasolina.Total());


            Console.ReadKey();

        } 
    }
}
