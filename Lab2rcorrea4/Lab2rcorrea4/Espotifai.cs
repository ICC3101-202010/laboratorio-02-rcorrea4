using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2rcorrea4
{
    class Espotifai
    {
        public List<Cancion> canciones;
        public List<Playlist> playlists;

        
        public Espotifai()
        {
            canciones = new List<Cancion>();
            playlists = new List<Playlist>();
            
        }
        public bool AgregarCancion(Cancion cancion)
        {
            
            bool repetida= false;
            int i = 0;
            while (repetida=false && i<canciones.Count)
            {
                if (canciones[i] == cancion)
                {
                    repetida= true;
                }
                else
                {
                    i++;
                }
               
            }
            if (repetida == true)
            {
                return false;
            }
            else
            {
                canciones.Add(cancion);
                return true;
            }
        }
        public void verCanciones()
        {
            int i = 0;
            while (i<canciones.Count)
            {
                Console.WriteLine("cancion" + i + ":");
                Console.WriteLine(canciones[i].Infor()  ); 
                i++;

            }
        }
        public List<Cancion> CancionesPorCriterio(string criterio,string valor)
        {
            List<Cancion> cpc = new List<Cancion>();
            int i = 0;
            while (i < canciones.Count)
            {
                if (criterio == "nombre")
                {
                    if (canciones[i].Nombre == valor)
                    {
                        cpc.Add(canciones[i]);
                    }
                }
                else if (criterio == "album")
                {
                    if (canciones[i].Album == valor)
                    {
                        cpc.Add(canciones[i]);
                    }
                }
                else if (criterio == "artista")
                {
                    if (canciones[i].Artista == valor)
                    {
                        cpc.Add(canciones[i]);
                    }
                }
                else if (criterio == "genero")
                {
                    if (canciones[i].Genero == valor)
                    {
                        cpc.Add(canciones[i]);
                    }
                }
                i++;

            }
            return cpc;
        }
        public Playlist generarPlaylist(string criterio, string valorCriterio, string nombrePlaylist)
        {
            List<Cancion> cpc = new List<Cancion>();
            int i = 0;
            while (i < canciones.Count)
            {
                if (criterio == "nombre")
                {
                    if (canciones[i].Nombre == valorCriterio)
                    {
                        cpc.Add(canciones[i]);
                    }
                }
                else if (criterio == "album")
                {
                    if (canciones[i].Album == valorCriterio)
                    {
                        cpc.Add(canciones[i]);
                    }
                }
                else if (criterio == "artista")
                {
                    if (canciones[i].Artista == valorCriterio)
                    {
                        cpc.Add(canciones[i]);
                    }
                }
                else if (criterio == "genero")
                {
                    if (canciones[i].Genero == valorCriterio)
                    {
                        cpc.Add(canciones[i]);
                    }
                }
                i++;

            }
            Playlist playlist1 = new Playlist("nombre",cpc);
            return playlist1;
        }
        public void verMisPlaylists()
        {
            int i = 0;
            while (i < playlists.Count)
            {
                Console.WriteLine(playlists[i]);
                
                i++;
            }
        }
    }
}
