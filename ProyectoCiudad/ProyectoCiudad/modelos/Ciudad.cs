using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCiudad.modelos
{
    public class Ciudad
    {
        private int id;
        private String nombre;
        private DateTime fechaFund;
        private int poblacion;

        public Ciudad() { }

        public Ciudad(int id, string nombre, DateTime fechaFund, int poblacion)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.FechaFund = fechaFund;
            this.Poblacion = poblacion;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public DateTime FechaFund { get => fechaFund; set => fechaFund = value; }
        public int Poblacion { get => poblacion; set => poblacion = value; }

        public int mostrarEdad()
        {
            return DateTime.Now.Year - FechaFund.Year;
        }

        public String mostrarNombreEnMayuscula()
        {
            return Nombre.ToUpper();
        }


    }
}
