using System;
using System.Collections.Generic;
using Negocios.Entidades;
using Negocios.Actividades;

namespace EmpresasCorporativas
{
    class Program
    {
        static void Main(string[] args)
        {
            Actividades_Clientes actividades_cliente = new Actividades_Clientes();

            Cliente cliente = new Cliente();
            Console.WriteLine("Ingrese el cliente a eliminar");
            cliente.DNI = Console.ReadLine();

            bool estado = actividades_cliente.Delete(cliente);
            if(estado)
            {
                Console.WriteLine("Cliente eliminado");
            }
            else
            {
                Console.WriteLine("El cliente no pudo ser eliminado");
            }


            List<Cliente> clientes = actividades_cliente.ReadAll();

            foreach (var c in clientes)
            {
                Console.WriteLine("==============================");
                Console.WriteLine("DNI: " + c.DNI);
                Console.WriteLine("DNI:" + c.Nombre);
                Console.WriteLine("DNI: " + c.Apellido);
                Console.WriteLine("==============================");
            }

            //Console.WriteLine("===== Ingrese el DNI del cliente:");
            //string buscarDNI = Console.ReadLine();

            //Cliente clientePorDNI = actividades_cliente.Read(buscarDNI);

            //Console.WriteLine("==============================");
            //Console.WriteLine("DNI: " + clientePorDNI.DNI);
            //Console.WriteLine("DNI:" + clientePorDNI.Nombre);
            //Console.WriteLine("DNI: " + clientePorDNI.Apellido);
            //Console.WriteLine("==============================");

            //Cliente cliente = new Cliente();

            //Console.WriteLine();
            //Console.WriteLine("Ingrese el DNI");
            //cliente.DNI = Console.ReadLine();
            //Console.WriteLine("Ingrese el NOMBRE");
            //cliente.Nombre = Console.ReadLine();
            //Console.WriteLine("Ingrese el APELLIDO");
            //cliente.Apellido = Console.ReadLine();

            //bool estado = actividades_cliente.Create(cliente);

            //if (estado)
            //{
            //    Console.WriteLine("El cliente fue guardado correctamente");
            //}
            //else
            //{
            //    Console.WriteLine("El cliente no fue guardado correctamente");
            //}

            //Console.WriteLine("===========================================");

            //Console.WriteLine("===== Ingrese el DNI del cliente:");
            //string buscarDNIParaModificar = Console.ReadLine();

            //Cliente clienteAModificar = actividades_cliente.Read(buscarDNIParaModificar);

            //Console.WriteLine("==============================");
            //Console.WriteLine("DNI: " + clienteAModificar.DNI);
            //Console.WriteLine("DNI:" + clienteAModificar.Nombre);
            //Console.WriteLine("DNI: " + clienteAModificar.Apellido);
            //Console.WriteLine("==============================");

            //Console.WriteLine("Ingrese el NOMBRE");
            //clienteAModificar.Nombre = Console.ReadLine();
            //Console.WriteLine("Ingrese el APELLIDO");
            //clienteAModificar.Apellido = Console.ReadLine();

            //estado = actividades_cliente.Update(clienteAModificar);
            //if(estado)
            //{
            //    Console.WriteLine("El cliente fue modificado correctamente");
            //}
            //else
            //{
            //    Console.WriteLine("El cliente no fue modificado correctamente");
            //}



        }
    }
}

