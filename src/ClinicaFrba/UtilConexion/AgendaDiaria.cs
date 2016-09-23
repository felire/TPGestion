using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlTypes;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

namespace ClinicaFrba.UtilConexion
{
    class AgendaDiaria
    {
        public Dia dia { get; set; }
        public string diaString { get; set; }
        public TimeSpan horaDesde { get; set; }
        public TimeSpan horaHasta { get; set; }
        public Especialidad especialidad { get; set; }
        public EsquemaTrabajo esquema { get; set;}
        public string especialidadString { get; set; }

        public AgendaDiaria(Dia dia, TimeSpan horaDesde, TimeSpan horaHasta, Especialidad especialidad)
        {
            this.dia = dia;
            this.horaDesde = horaDesde;
            this.horaHasta = horaHasta;
            this.especialidad = especialidad;
            this.diaString = dia.nombre;
            this.especialidadString = especialidad.descripcion;
        }

        public void persistirDiaAgenda()
        {
            List<SqlParameter> ListaParametros = new List<SqlParameter>();
            ListaParametros.Add(new SqlParameter("@esquema", this.esquema.id));
            ListaParametros.Add(new SqlParameter("@dia", this.dia.id));
            ListaParametros.Add(new SqlParameter("@horaDesde", this.horaDesde));
            ListaParametros.Add(new SqlParameter("@horaHasta", this.horaHasta));
            ListaParametros.Add(new SqlParameter("@especialidad", this.especialidad.codigo));
            SpeakerDB speaker = ConexionDB.ExecuteNoQuery("kernel_panic.agregarDiaAgenda", "SP", ListaParametros);
            speaker.close();
        }

        public static Boolean agendaTotalLegal(List<AgendaDiaria> lista) //Se fija que no supere las 48 horas de trabajo en una semana
        {
            int cont = 0;
            foreach (AgendaDiaria r in lista)
            {
                cont = cont + (int)(r.horaHasta.TotalMinutes - r.horaDesde.TotalMinutes);
            }
            if (cont <= (48 * 60))
            {
                return true;
            }
            else
            {
                return false;
            } 
        }
    }
}

