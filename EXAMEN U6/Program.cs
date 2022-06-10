using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace EXAMEN_U6
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables auxiliares
            string NombreProducto;
                string DescripcionProducto;
                int Stock;
                float Precio;
            int opcion;

            do
            {
                Console.Clear();
                Console.WriteLine("\nINVENTARIO");
                Console.WriteLine("1. Creación del inventario.");
                Console.WriteLine("2. Lectura del inventario.");
                Console.WriteLine("3. Salir del programa.");
                Console.Write("\nIntroduzca su opción a elegir: ");
                opcion = Int16.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        try
                        {
                            StreamWriter sw = new StreamWriter("Productos.txt", true);

                            Console.Write("Nombre del producto: ");
                            NombreProducto = Console.ReadLine();
                            Console.Write("Descripción del producto: ");
                            DescripcionProducto = Console.ReadLine();
                            Console.Write("Producto en stock: ");
                            Stock = Int32.Parse(Console.ReadLine());
                            Console.Write("Precio del producto: ");
                            Precio = float.Parse(Console.ReadLine());
                            Inventario inv = new Inventario(NombreProducto, DescripcionProducto, Stock, Precio);
                            sw.WriteLine(inv.NombreProducto + " " + inv.DescripcionProducto + " " + inv.Stock + " " + inv.Precio);
                            sw.Close();
                            Console.WriteLine("Archivando...");
                            Console.ReadKey();
                        }
                        catch (IOException e)
                        {
                            Console.WriteLine("\nError : " + e.Message);
                            Console.WriteLine("\nRuta : " + e.StackTrace);
                        }
                        break;

                    case 2:
                        //bloque de lectura
                        try
                        {
                            StreamReader sr = new StreamReader("Productos.txt");
                            //NO SÉ COMO USAR STREAMREADER :c
                        }
                        catch (IOException e)
                        {
                            Console.WriteLine("\nError : " + e.Message);
                            Console.WriteLine("\nRuta : " + e.StackTrace);
                        }
                        break;

                    case 3:
                        Console.Write("\nPresione <enter> para Salir del Programa.");
                        Console.ReadKey();
                        break;

                    default:
                        Console.Write("\nLa opción elegida no existe, Presione <enter> para Continuar...");
                        Console.ReadKey();
                        break;
                }
            }
            while (opcion != 3);
        } 
    }
}

