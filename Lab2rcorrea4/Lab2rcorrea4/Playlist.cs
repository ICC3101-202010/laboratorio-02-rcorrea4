using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2rcorrea4
{
    class Playlist
    {
        private string nombrePlaylist;
        private List<Cancion> cancionesPlaylist;

        public string NombrePlaylist { get => nombrePlaylist; set => nombrePlaylist = value; }
        public List<Cancion> CancionesPlaylist { get => cancionesPlaylist; set => cancionesPlaylist = value; }

        public Playlist(string nombrePlaylist,List<Cancion> cancionePlaylist)
        {
            this.nombrePlaylist = nombrePlaylist;
            cancionesPlaylist = new List<Cancion>();

        }
        public void infoPlaylist()
        {
            Console.WriteLine("Nombre PLaylist: "+ nombrePlaylist);
            Console.WriteLine("Canciones Playlist:");
            int i = 0;
            while (i < cancionesPlaylist.Count)
            {
                Console.WriteLine("cancion"+(i+1)+":");
                Console.WriteLine(cancionesPlaylist[i].Infor());
                i++;
            }
        }
        public bool AgregarCancion1(Cancion cancion)
        {

            bool repetida = false;
            int i = 0;
            while (repetida = false && i < cancionesPlaylist.Count)
            {
                if (cancionesPlaylist[i] == cancion)
                {
                    repetida = true;
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
                cancionesPlaylist.Add(cancion);
                return true;
            }
        }
    }
}
