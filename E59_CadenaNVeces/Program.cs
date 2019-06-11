using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E59_CadenaNVeces
{
    class Program
    {
        static void Main(string[] args)
        {
            bool salir = false;
            string opcion, cadena;
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("Programa que dada una cadena s, y un número n. imprime la cadena n veces");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Ingrese la cadena");
                cadena = Console.ReadLine().Trim();

                if (cadena.Length > 0)
                {
                    Console.WriteLine("Ingrese número");
                    if (Int32.TryParse(Console.ReadLine(), out int numeroVeces))
                    {                        
                        if (numeroVeces > 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            for (int i = 1; i <= numeroVeces; i++)
                                Console.WriteLine("{0}: {1}", i, cadena);
                        }                            
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Error... el número debe ser mayor a cero");
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Error... al ingresar número");
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error... cadena vacía");
                }

                do
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("n : nuevo, s : salir");
                    opcion = Console.ReadLine();

                    if (opcion.Equals("s"))
                    {
                        salir = true;
                        break;
                    }
                    else if (!opcion.Equals("n"))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("No se reconoce opción...");
                    }
                    else
                        break;
                } while (true);
            } while (!salir);
        }
    }
}
