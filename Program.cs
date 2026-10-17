using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subtema5._1_y_5._2
{
    internal class Program
    {
        static string nombreArchivo = "Listaproductos. txt"; //variable de calse 
        static void Main(string[] args)
        {
            agregarNuevoProducto();
            GenerarReportes();
        }

        static void agregarNuevoProducto()
        {
            //StreamWriter
            //crear y abrir el documento de texto
            StreamWriter nuevoDocumento = new StreamWriter(nombreArchivo, true);
            //agregar un nuevo dato al documento de texto creado 
            Console.Write("ingrese el nombre del producto a registrar: ");
            string producto = Console.ReadLine();
            nuevoDocumento.WriteLine(producto);
            //IMPORTANTE !!! CERRAR para guardar los cambios en el documento
            nuevoDocumento.Close();
        }
        static void GenerarReportes()
        {
            StreamReader Leerdocumento = new StreamReader(nombreArchivo);

            //leerdocumento = coca cola 600 , galleta , agua 
            int contador = 0;
            string linea;
            string ultimoProducto = "";
            if (!File.Exists(nombreArchivo))//validar que el archivo.txt
            {
                Console.WriteLine("el archivo de texto NO EXISTE!");
                return;
            }

            while ((linea = Leerdocumento.ReadLine()) != null) //repartir y recorreresta lista de productos mientras aun exista un producto que leer 
            {
                ultimoProducto = linea;
                contador++;
                Console.WriteLine("producto: " + linea);
            }

            Console.WriteLine("el total de productos en el almacen son: " + contador);
            Leerdocumento.Close();// LIBERAR RECURSOS
            //COMPLETAR:   MOSTRAR EL ULTIMO PRODUCTO REGISTRADO 

            Console.WriteLine("El ultimo producto a registrar es: " + ultimoProducto);
        }
    }
}