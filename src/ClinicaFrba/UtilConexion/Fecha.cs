using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaFrba.UtilConexion
{
    class Fecha
    {
        public DateTime dia { get; set; }
        public TimeSpan horaDesde { get; set; }
        public TimeSpan horaHasta { get; set; }
        public List<TimeSpan> horasOcupadas { get; set; }

        public Fecha(DateTime dia, TimeSpan horaDesde, TimeSpan horaHasta)
        {
            this.dia = dia;
            this.horaDesde = horaDesde;
            this.horaHasta = horaHasta;
            this.horasOcupadas = new List<TimeSpan>();
        }

        public Fecha(DateTime dia)
        {
            this.dia = dia;
            this.horasOcupadas = new List<TimeSpan>();
        }

        public int CompareTo(DateTime desde)
        {
            return dia.CompareTo(desde);
        }

        public Fecha AddDays(double n)
        {
            return new Fecha(dia.AddDays(n));
        }

        public static Fecha parsearDateTime(DateTime date)
        { 
            TimeSpan desde = new TimeSpan(date.Hour, date.Minute, 0);
            TimeSpan hasta = new TimeSpan(date.Hour, date.Minute + 30, 0);
            return new Fecha(date, desde, hasta);
        }
    }
}
