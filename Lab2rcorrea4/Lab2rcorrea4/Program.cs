using System;

namespace Lab2rcorrea4
{
    class Program
    {
        static void Main(string[] args)
        {
            Cancion cancion1 = new Cancion("layla","Unplugged","Eric Clapton","Rock");
            Cancion cancion2 = new Cancion("bichiyal", "YHLQMDLG", "Bad Bunny", "Reggaeton");
            Cancion cancion3 = new Cancion("Is this love", "Exodus", "Bob Marley", "Reggae");
            Espotifai espotifai = new Espotifai();
            espotifai.AgregarCancion(cancion1);

            //Flujo del programa
            Console.WriteLine("Bienvenido a Espotifai");
            Console.WriteLine("Ingrese opción: " +
                "1-Ver todas las canciones " +
                "2-Agregar cancion " +
                "3-Ver canciones por criterio " +
                "4-Salir del programa ");
            string opt = null;
            opt = Console.ReadLine();

            switch (opt)
            {
                case "1":
                    Console.WriteLine("Ver Canciones");
                    espotifai.verCanciones();
                    break;
                case "2":
                    Console.WriteLine("Agregar Cancion");
                    Console.WriteLine("Ingrese Nombre");
                    string n = Console.ReadLine();
                    Console.WriteLine("Ingrese Album");
                    string a = Console.ReadLine();
                    Console.WriteLine("Ingrese Artista");
                    string ar = Console.ReadLine();
                    Console.WriteLine("Ingrese Genero");
                    string g = Console.ReadLine();
                    Cancion nuevacancion = new Cancion(n,a,ar,g);
                    espotifai.AgregarCancion(nuevacancion);
                    break;
                case "3":
                    Console.WriteLine("Ingrese Criterio");
                    string criterio = Console.ReadLine();
                    Console.WriteLine("Ingrese Valor");
                    string valor = Console.ReadLine();
                    espotifai.CancionesPorCriterio(criterio, valor);
                    break;
                case "4":
                    Console.WriteLine( "Salir del programa" );
                    break;
                default:
                    Console.WriteLine("Opcion Invalida");
                    break;
            }
            

            

            
            //espotifai.AgregarCancion(cancion2);
            espotifai.verCanciones();
            
            
            Console.ReadLine();
        }
    }
}
