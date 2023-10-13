using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Direccion
    {
        private string provincia ;
        private string canton ;
        private string distrito ;
        private string otrasSenas;


        public string Provincia
        {
            get { return provincia; }
            set { provincia = value; }
        }
        public string Canton
        {
            get { return canton; }
            set { canton = value; }
        }
        public string Distrito
        {
            get { return distrito; }
            set { distrito = value; }
        }
        public string OtrasSenas
        {
            get { return otrasSenas;}
            set { otrasSenas = value;}
        }




    } // fin class Direccion
}
