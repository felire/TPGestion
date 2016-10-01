using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaFrba.UtilConexion
{
    class Dia
    {
        public string nombre { get; set; }
        public int id { get; set; }
        public TimeSpan horaDesde { get; set; }
        public TimeSpan horaHasta { get; set; }
        public DateTime fechaDesde { get; set; }
        public DateTime fechaHasta { get; set; }

        public Dia(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
            setFranja();
        }

        public Dia(int id)
        {
            this.id = id;
            switch (id)
            {
                case 1:
                    nombre = "Lunes";
                    break;
                case 2:
                    nombre = "Martes";
                    break;
                case 3:
                    nombre = "Miercoles";
                    break;
                case 4:
                    nombre = "Jueves";
                    break;
                case 5:
                    nombre = "Viernes";
                    break;
                case 6:
                    nombre = "Sábado";
                    break;
                case 7:
                    nombre = "Domingo";
                    break;
            }
            setFranja();
        }

        public void setFranja()
        {
            if (id >= 1 && id <= 6)
            {
                this.horaDesde = new TimeSpan(7, 00, 0);
                this.horaHasta = new TimeSpan(20, 00, 0);
            }
            if (id == 7)
            {
                this.horaDesde = new TimeSpan(10, 00, 0);
                this.horaHasta = new TimeSpan(15, 00, 0);
            }
        }

        public static List<Dia> ObtenerTodosLosDias()
        {
            List<Dia> lista = new List<Dia>();
            lista.Add(new Dia(1, "Lunes"));
            lista.Add(new Dia(2, "Martes"));
            lista.Add(new Dia(3, "Miercoles"));
            lista.Add(new Dia(4, "Jueves"));
            lista.Add(new Dia(5, "Viernes"));
            lista.Add(new Dia(6, "Sábado"));
            return lista;
        }

        public List<DateTime> darFechasConcretas()
        {
            List<DateTime> fechas = new List<DateTime>();
            DateTime fecha;
            fecha = fechaDesde;
            while (fecha.CompareTo(fechaHasta) <= 0)
            {
                fechas.Add(fecha);
                fecha = fecha.AddDays(1);
            }
            return fechas;
        }
    }
}

