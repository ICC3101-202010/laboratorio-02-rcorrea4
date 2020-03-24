using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2rcorrea4
{
    class Espotifai
    {
        public Cancion[] canciones;

        public Espotifai()
        {

        }
        public bool AgregarCancion(Cancion cancion)
        {
            int i = canciones.Length;
            bool repetida= false;
            for (int o = 0; o <= canciones.Length; o++)
            {
                if (canciones[o] == cancion)
                {
                    repetida= true;
                }
               
            }
            if (repetida == true)
            {
                return false;
            }
            else
            {
                canciones[i + 1] = cancion;
                return true;

            }



        }
    }
}
