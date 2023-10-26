using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
	public class Hijo : Padre // herencia
	{
		public Hijo()
		{
			this.fechaNaciemiento = fechaNaciemiento;
			// constructor que recibe la fecha de nacimiento al  crear el objeto
		}

		public DateTime fechaNaciemiento { get; set; }

		public void setFechaNacimiento(DateTime fecha) {
			fechaNaciemiento = fecha;
		}
		public int edadAnio /*metodo para calcular la edad por medio del get*/
		{
			get
			{
				DateTime fechaActual = DateTime.Now; /*obtenemos la fecha actual*/
				int anios = fechaActual.Year - fechaNaciemiento.Year; /*se calcula la diferencia en anios entre la fecha actual y la dfecha de nacimiento*/
				if (fechaActual.Month < fechaNaciemiento.Month || (fechaActual.Month == fechaNaciemiento.Month && fechaActual.Day < fechaNaciemiento.Day)) 
					/*se verifica si ya paso el cumpleanos en el anio actual. si no ha pasado se resta 1 el valor de anios*/
				{
					anios--;
				}
				return anios;
			}
		}
		public int edadMeses /*metodo para calcular la edad en meses*/
		{
			get
			{
				DateTime fechaActual = DateTime.Now; /*obtengo la fecha actual*/
				int meses = fechaActual.Month - fechaNaciemiento.Month;/*calculo la diferencia en meses entre la fecha actual y la fecha de nacimiento*/
				if (fechaActual.Day < fechaNaciemiento.Day)
				/*se verifica el dia actual es anterior a la fecha de nacimiento, si es true se resta 1 a meses*/
				{
					meses--;
					if (meses < 0)
					{
						meses = 11;
						/*si el valor es negativo se ajusta a 11 para obtener el valor correcto*/
					}
				}
				return meses;

			}
		}


	} // fin class Hijo
}
