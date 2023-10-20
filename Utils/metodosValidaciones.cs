using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;



namespace Utils
{
    public class metodosValidaciones
    {
        public static bool soloNumeros(char caracter)
        {

            /*
            try
            {
                if (char.IsControl(caracter) || char.IsDigit(caracter) || caracter == '\b')
                {
                    return true;
                }
                throw new Exception("El campo solamente acepta Numeros!");
               
            }
            catch (Exception ex)
            {

              throw MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
            

            return char.IsControl(caracter) || char.IsDigit(caracter) || caracter == '\b';
            /* Le paso el parametro char para realizar la validacion de los caracteres 
             * validando si es un caracter de control o numero 
             * con el IsControl se valida que los caracteres sean de tipo control 
             * con el IsDigit se validan que los caracteres sean numeros
             * con la comparación al carácter de retroceso, permitimos eliminar texto.
             * si es caracter es True / false  este es devuelto
             */
        }

        public static bool soloLetras(string texto)
        {
            // metodo para realizar la validacion de solamente texto 
            foreach (char caracter in texto)
            {
                // con este bucle realizo un recorrido por cada caracter del string 
                if (!char.IsLetter(caracter) && caracter != '\b')
                {
                    return false;
                    /*se valida cada caracter No es una letra y no sea el caracter de control de retroceso '\b'
                     *si el return es false indica que el caracter no es valido
                     */
                }
            }
            return true;


        }

        public static bool isEmail(string email)
        {
            // esta funcion valida que el email este en el formato valido
            if (string.IsNullOrWhiteSpace(email))
            {
                // valido que el string este en blanco o sea Null ... si es True significa que es una direccion No valida
                try
                {
                    email = Regex.Replace(email, @"(@)(.+)$", DomainMapper, RegexOptions.None, TimeSpan.FromMilliseconds(200));

                    /* se realizan varias operacions 
                     * busca el @ en el String email y reemplaza el dominio internacionalizado (idn)
                     * DomainMapper == modifica y mapealas partes del correo electronico
                     * IdnMapping == es una clase de espacios de nombre trabaja con los nombres de dominio internacionales (idn)
                     * IdnMapping reemplaza el dominio a la forma ASCII
                     */

                    string DomainMapper(Match match)
                    {
                        var idn = new IdnMapping();
                        string nombreDominio = idn.GetAscii(match.Groups[2].Value);
                        return match.Groups[1].Value + nombreDominio;
                    }
                    /* Regex.Replace  es el argumento para realizar la modificacion
                     * sirve para trabajar con idn internacionales que contienen caracteres no ASCII* y los convierte a una forma estandar
                     */
                }
                catch (RegexMatchTimeoutException)
                {
                    // esta excepcion indica que el string es invalido
                    return false;
                }
                catch (ArgumentException)
                {
                    return false;
                    // esta excepcion indica que el string es invalido
                }
                try
                {
                    return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$", RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
                    
                    /* se valida que el string tenga el formato valido " example@example.com "
                     */
                }
                catch (RegexMatchTimeoutException)
                {
                    return false;
                }
            }
            return true;
        }


    } // fin metodosValidaciones
}
