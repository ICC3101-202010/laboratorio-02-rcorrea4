using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2rcorrea4
{
    class Cancion
    {
        private string nombre;
        private string album;
        private string artista;
        private string genero;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Album { get => album; set => album = value; }
        public string Artista { get => artista; set => artista = value; }
        public string Genero { get => genero; set => genero = value; }

        public Cancion(string nombre, string album,string artista, string genero)
        {
            this.nombre = nombre;
            this.album = album;
            this.artista = artista;
            this.genero = genero;
        }
        public string Infor()
        {
            string info = "genero: " + genero + " artista: " + artista + " album: " + album + " nombre: " + nombre;
            return info;
        }

        
    }
}
