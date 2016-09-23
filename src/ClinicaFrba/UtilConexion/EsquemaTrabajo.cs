using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlTypes;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace ClinicaFrba.UtilConexion
{
    class EsquemaTrabajo
    {
        public int id { get; set; }
        public DateTime desde { get; set; }
        public DateTime hasta { get; set; }
        public Profesional profesional { get; set; }

        public EsquemaTrabajo(DateTime desde, DateTime hasta, Profesional profesional)
        {
            this.desde = desde;
            this.hasta = hasta;
            this.profesional = profesional;
        }

        public Boolean persistirEsquema()
        {
            List<SqlParameter> ListaParametros = new List<SqlParameter>();
            ListaParametros.Add(new SqlParameter("@profesional", this.profesional.id));
            ListaParametros.Add(new SqlParameter("@fechaDesde", this.desde.Date));
            ListaParametros.Add(new SqlParameter("@fechaHasta", this.hasta.Date));
            SqlParameter parametroSalida = new SqlParameter("@id", 0);
            parametroSalida.Direction = ParameterDirection.Output;
            ListaParametros.Add(parametroSalida);
            SpeakerDB speaker = ConexionDB.ExecuteNoQuery("kernel_panic.agregarEsquemaAgenda", "SP", ListaParametros);
            int resultado = Int32.Parse(speaker.comando.Parameters["@id"].Value.ToString());
            speaker.close();
            if (resultado == -1)
            {
                return false;
            }
            else
            {
                this.id = resultado;
                return true;
            }
        }
    }
}

