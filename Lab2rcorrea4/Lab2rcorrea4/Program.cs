using System;

namespace Lab2rcorrea4
{
    class Program
    {
        static void Main(string[] args)
        {
            Cancion cancion1 = new Cancion("layla","Unplugged","Eric Clapton","Rock");
            Cancion cancion2 = new Cancion("bichiyal", "1", "Bad Bunny", "Reggaeton");
            Cancion cancion3 = new Cancion("Is this love", "Exodus", "Bob Marley", "Reggae");
            Cancion cancion4 = new Cancion("q", "1", "este", "ese");
            Espotifai espotifai = new Espotifai();

            espotifai.AgregarCancion(cancion4);
            espotifai.AgregarCancion(cancion2);
            espotifai.AgregarCancion(cancion1);
            espotifai.AgregarCancion(cancion3);

            
            

            
            string opt = null;
            while (opt != "6")
            {
                Console.WriteLine("Bienvenido a Espotifai");
                Console.WriteLine("Ingrese opción: " +
                    "1-Ver todas las canciones " +
                    "2-Agregar cancion " +
                    "3-Ver canciones por criterio " +
                    "4-Generar Playlist" +
                    "5-Ver Playlists" +
                    "6-Salir del programa ");


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
                        Cancion nuevacancion = new Cancion(n, a, ar, g);
                        espotifai.AgregarCancion(nuevacancion);
                        break;
                    case "3":
                        Console.WriteLine("Ingrese Criterio");
                        string criterio = Console.ReadLine();
                        Console.WriteLine("Ingrese Valor");
                        string valor = Console.ReadLine();
                        espotifai.CancionesPorCriterio(criterio, valor);
                        int i = 0;
                        while (i < espotifai.CancionesPorCriterio(criterio, valor).Count)
                        {
                            Console.WriteLine("cancion" + (i + 1));
                            Console.WriteLine(espotifai.CancionesPorCriterio(criterio, valor)[i].Album);
                            Console.WriteLine(espotifai.CancionesPorCriterio(criterio, valor)[i].Artista);
                            Console.WriteLine(espotifai.CancionesPorCriterio(criterio, valor)[i].Genero);
                            Console.WriteLine(espotifai.CancionesPorCriterio(criterio, valor)[i].Nombre);
                            i++;
                        }
                        break;
                    case "4":
                        Console.WriteLine("Ingresar criterio");
                        string c = Console.ReadLine();
                        Console.WriteLine("Ingresar Valor");
                        string v = Console.ReadLine();
                        Console.WriteLine("Ingrese nombre lista");
                        string no = Console.ReadLine();
                        espotifai.generarPlaylist(c, v, no);
                        int s = 0;
                        while (s < espotifai.generarPlaylist(c, v, no).CancionesPlaylist.Count)
                        {
                            Console.WriteLine("cancion" + (s + 1));
                            Console.WriteLine(espotifai.generarPlaylist(c, v, no).CancionesPlaylist[s].Album);
                            Console.WriteLine(espotifai.generarPlaylist(c, v, no).CancionesPlaylist[s].Artista);
                            Console.WriteLine(espotifai.generarPlaylist(c, v, no).CancionesPlaylist[s].Genero);
                            Console.WriteLine(espotifai.generarPlaylist(c, v, no).CancionesPlaylist[s].Nombre);
                        }
                        break;
                    case "5":
                        espotifai.verMisPlaylists();
                        break;
                    case "6":
                        Console.WriteLine("Salir del programa");
                        break;
                    default:
                        Console.WriteLine("Opcion Invalida");
                        break;
                }








                Console.ReadLine();
            }
        }
    }
}
