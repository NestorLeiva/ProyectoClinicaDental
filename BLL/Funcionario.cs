using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Funcionario
    {
        private string puesto ;
        private string usuario;
        private string contrasenia;

        public string Puesto
        {
            get { return puesto; }
            set { puesto = value; }
        }
        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }
        public string Contrasenia
        {
            get { return contrasenia;}
            set { contrasenia = value;}
        }








    } // fin class Funcionario
}
