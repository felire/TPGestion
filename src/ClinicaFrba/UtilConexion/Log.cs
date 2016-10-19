using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaFrba.UtilConexion
{
    class Log
    {
        public int idLog { get; set; }
        public string tipo { get; set; }
        public DateTime fecha { get; set; }
        public string descripcion { get; set; }
        public string valorAnterior { get; set; }
    }
}
