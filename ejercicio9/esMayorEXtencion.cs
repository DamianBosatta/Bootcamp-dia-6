using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio9
{
    public static class esMayorEXtencion
    {
        public static bool esMayor(this Persona abc)
        {

            if (abc.Edad > 18) return true;
            return false;
        }

    }
}


