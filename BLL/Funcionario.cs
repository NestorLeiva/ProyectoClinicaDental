using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Funcionario : Persona  // herencia
    {
        // Los campos están marcados con ?, lo que indica que son de tipo nullable, es decir, pueden ser nulos. Esto significa que pueden contener un valor o ser null.

        private string? puesto;
        private string? usuario;
        private string? contrasenia;

        /* el : base realiza la llamada al constructor de la clase persona
         * el Base  nos asegura de que los campos esten inicializados correctamente
         * ("", "", 0, new DateOnly(), 0, "", 0, "") son los valores predeterminados  para los campos y propiedades de la clase  base 
        */
        public Funcionario(string puesto, string usuario, string contrasenia) :
            base("", "", 0, new DateOnly(), 0, "", 0, "")
        {
            // constuctor con parametros
            Puesto = puesto;
            Usuario = usuario;
            Contrasenia = contrasenia;
        }

        public string? Puesto
        {
            get { return puesto; }
            set { puesto = value; }
        }
        public string? Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }
        public string? Contrasenia
        {
            get { return contrasenia; }
            set { contrasenia = value; }
        }


    } // fin class Funcionario
}
