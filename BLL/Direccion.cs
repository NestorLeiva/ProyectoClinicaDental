using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Direccion 
    {
        // Los campos están marcados con ?, lo que indica que son de tipo nullable, es decir, pueden ser nulos. Esto significa que pueden contener un valor o ser null.
        private string? provincia;
        private string? canton;
        private string? distrito;
        private string? otrasSenas;


        public Direccion(string provincia, string canton, string distrito, string otrasSenas)
        {
            // constructor con parametros
            Provincia = provincia;
            Canton = canton;
            Distrito = distrito;
            OtrasSenas = otrasSenas;
            Provincia = provincia;
            Canton = canton;
            Distrito = distrito;
            OtrasSenas = otrasSenas;
        }

        public string? Provincia
        {
            get { return provincia; }
            set { provincia = value; }
        } 
        public string? Canton
        {
            get { return canton; }
            set { canton = value; }
        }
        public string? Distrito
        {
            get { return distrito; }
            set { distrito = value; }
        }
        public string? OtrasSenas
        {
            get { return otrasSenas; }
            set { otrasSenas = value; }
        }




    } // fin class Direccion
}
