using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Padre : Persona
    {
        // esta clase Hereda todo lo de Persona por ese motivo no tiene nada


        public Padre() : base("", "", 0, new DateTime(), 0, "", 0, "")
        {
            /* constructor vacio
             * realizo la llamada al constructor de la clase persona 
             * el Base  nos asegura de que los campos esten inicializados correctamente
             * ("", "", 0, new DateOnly(), 0, "", 0, "") son los valores predeterminados  para los campos y propiedades de la clase  base 
            */
        }



        public List<Hijo> Hijo { get; set; } = new List<Hijo>();
        // lista para guardar los hijos


    } // fin class padre
}
