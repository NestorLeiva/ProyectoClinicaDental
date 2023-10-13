namespace BLL
{
    public class Persona
    {
        private string nombre;
        private string apellido;
        private int identificacion;
        private DateOnly fecha = new DateOnly(); // ???
        private int edad;
        private string sexo;
        private int telefono;
        private string email;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public int Identificacion
        {
            get { return identificacion; }
            set { identificacion = value; }
        }
        public DateOnly Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        public int Edad
        {
            get { return edad; }
                set { edad = value; }
        }
        public string Sexo
        {
            get { return sexo; }
                set { sexo = value; }
        }
        public int Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }



    } // fin class Persona


    //public int calcularEdad() { }


}