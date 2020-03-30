using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2rcorrea4
{
    class Espotifai
    {
        public List<Cancion> canciones;

        
        public Espotifai()
        {
            canciones = new List<Cancion>();
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
    }
}
