using ConexcionBDpymeTransporte.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexcionBDpymeTransporte
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opciones;

            Console.WriteLine("INSERTAR VALORES EN TABLA TRANSPORTES");
            Console.WriteLine("1)Visualizar tabla");
            Console.WriteLine("2)Agregar nuevos valores");
            Console.WriteLine("3)Editar valores existentes");
            Console.WriteLine("4)Eliminar valores de la tabla");
            Console.WriteLine("Seleccione una opcion");
            opciones = int.Parse(Console.ReadLine());
            switch (opciones)
            {
                case 1:

                    Transporte transporteBD = new Transporte();

                    Console.WriteLine("Visualizar valores");
                    
                    var Vartransporte = transporteBD.Get();

                    foreach (var VerTransporte in Vartransporte)
                    {
                        Console.WriteLine(VerTransporte.IdTransporte + "              " + VerTransporte.Nombre);
                    }

                    break;

                case 2:
                    Console.WriteLine("Agreagar nuevos valores");
                    Insertar InsertarValor = new Insertar();
                    //Insertamos objetos nuevos
                    int cantidadInsertar;

                    Console.WriteLine("Ingrese la cantidad de transporte que desea ingresar: ");
                    cantidadInsertar = int.Parse(Console.ReadLine());

                    for (int i = 0; i < cantidadInsertar; i++)
                    {
                        Insertar insertarTransporte = new Insertar();
                        Console.WriteLine("Ingrese el id del transporte: ");
                        insertarTransporte.IdTransporte = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el Nombre del transporte: ");
                        insertarTransporte.Nombre = Console.ReadLine();

                        InsertarValor.Add(insertarTransporte);
                    }
                break;

                case 3:
                    Editar_valores EditarValores = new Editar_valores();
                    Console.WriteLine("Editar valores");
                    //Editar
                        Transporte insertarEditarTransporte = new Transporte();
                        Console.WriteLine("Ingrese el id del transporte: ");
                        insertarEditarTransporte.IdTransporte = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el Nombre del transporte: ");
                        insertarEditarTransporte.Nombre = Console.ReadLine();
                        EditarValores.Edit(insertarEditarTransporte);
                break;

                case 4:
                    Eliminar eliminarTransporte = new Eliminar();
                    // Solicitar el ID del transporte a eliminar
                    Console.WriteLine("Ingrese el código del transporte que desea eliminar: ");
                    int idTransporte = int.Parse(Console.ReadLine());
                    // Llamar al método Delete y pasar el ID del transporte
                    eliminarTransporte.Delete(idTransporte);
                break;





            }

            Console.ReadKey();
           

        }
    }
}
