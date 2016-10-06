using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaFrba.UtilConexion
{
    class Fecha
    {
        public DateTime dia;
        public TimeSpan horaDesde;
        public TimeSpan horaHasta;
        public List<TimeSpan> horasOcupadas;

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

        public DayOfWeek dayOfWeek()
        {
            return dia.DayOfWeek;
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
