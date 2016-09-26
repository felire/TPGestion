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

        public Fecha(DateTime dia, TimeSpan horaDesde, TimeSpan horaHasta)
        {
            this.dia = dia;
            this.horaDesde = horaDesde;
            this.horaHasta = horaHasta;
        }
        public int CompareTo(DateTime desde)
        {
            return dia.CompareTo(desde);
        }
    }
}
