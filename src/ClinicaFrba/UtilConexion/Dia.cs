using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.UtilConexion
{
    class Dia
    {
        public string nombre { get; set; }
        public int id { get; set; }
        public TimeSpan horaDesde { get; set; }
        public TimeSpan horaHasta { get; set; }

        public Dia(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
            setFranja();
        }

        public Dia(int id)
        {
            this.id =id;
            switch (this.id)
            {
                case (int)DayOfWeek.Monday:
                    nombre = "Lunes";
                    break;
                case (int)DayOfWeek.Tuesday:
                    nombre = "Martes";
                    break;
                case (int)DayOfWeek.Wednesday:
                    nombre = "Miercoles";
                    break;
                case (int)DayOfWeek.Thursday:
                    nombre = "Jueves";
                    break;
                case (int)DayOfWeek.Friday:
                    nombre = "Viernes";
                    break;
                case (int)DayOfWeek.Saturday:
                    nombre = "Sábado";
                    break;
                case (int)DayOfWeek.Sunday:
                    nombre = "Domingo";
                    break;
            }
            setFranja();
        }

        public void setFranja()
        {
            //if (id >= 1 && id <= 6)
            if (id != (int)DayOfWeek.Saturday && id != (int)DayOfWeek.Sunday )
            {
                this.horaDesde = new TimeSpan(7, 00, 0);
                this.horaHasta = new TimeSpan(20, 00, 0);
            }
            if (id == (int)DayOfWeek.Saturday)
            {
                this.horaDesde = new TimeSpan(10, 00, 0);
                this.horaHasta = new TimeSpan(15, 00, 0);
            }
        }

        public static List<Dia> ObtenerTodosLosDias()
        {
            List<Dia> lista = new List<Dia>();
            lista.Add(new Dia((int)DayOfWeek.Monday, "Lunes"));
            lista.Add(new Dia((int)DayOfWeek.Tuesday, "Martes"));
            lista.Add(new Dia((int)DayOfWeek.Wednesday, "Miercoles"));
            lista.Add(new Dia((int)DayOfWeek.Thursday, "Jueves"));
            lista.Add(new Dia((int)DayOfWeek.Friday, "Viernes"));
            lista.Add(new Dia((int)DayOfWeek.Saturday, "Sábado"));
            return lista;
        }
    }
}
