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
        public List<AgendaDiaria> agendas { get; set; }

        public EsquemaTrabajo(DateTime desde, DateTime hasta, Profesional profesional)
        {
            this.desde = desde;
            this.hasta = hasta;
            this.profesional = profesional;
            this.agendas = new List<AgendaDiaria>();
            this.cargarAgendas();
        }

        public EsquemaTrabajo(int id, DateTime desde, DateTime hasta)
        {
            this.id = id;
            this.desde = desde;
            this.hasta = hasta;
            this.profesional = null;
            this.agendas = new List<AgendaDiaria>();
            this.cargarAgendas();
        }

        private void cargarAgendas()
        {
            List<SqlParameter> ListaParametros = new List<SqlParameter>();
            ListaParametros.Add(new SqlParameter("@id", id));
            string query = "SELECT Dia, Desde, Hasta, Codigo, Descripcion "+
                           "FROM kernel_panic.Agenda_Diaria ad "+
                           "JOIN kernel_panic.Especialidades esp ON (esp.Codigo = ad.Especialidad) "+
                           "WHERE EsquemaTrabajo = @id";
            SpeakerDB speaker = ConexionDB.ObtenerDataReader(query, "T", ListaParametros);
            if (speaker.reader.HasRows)
            {
                while (speaker.reader.Read())
                {
                    int diaId = (int)speaker.reader["Dia"];
                    Dia dia = new Dia(diaId);
                    dia.horaDesde = (TimeSpan)speaker.reader["Desde"];
                    dia.horaHasta = (TimeSpan)speaker.reader["Hasta"];
                    string especialidadString = (String)speaker.reader["Descripcion"];
                    decimal codigo = (Decimal)speaker.reader["Codigo"];
                    AgendaDiaria agenda = new AgendaDiaria(dia, especialidadString, codigo);
                    agendas.Add(agenda);
                }
            }
            speaker.close();
        }

        public static List<EsquemaTrabajo> darEsquemas(int idProfesional)
        {
            List<EsquemaTrabajo> esquemas = new List<EsquemaTrabajo>();
            List<SqlParameter> ListaParametros = new List<SqlParameter>();
            ListaParametros.Add(new SqlParameter("@id", idProfesional));
            string query = "SELECT Id, Desde, Hasta " +
                           "FROM kernel_panic.Esquema_Trabajo " +
                           "WHERE Profesional = @id";
            SpeakerDB speaker = ConexionDB.ObtenerDataReader(query, "T", ListaParametros);
            if (speaker.reader.HasRows)
            {
                while (speaker.reader.Read())
                {
                    int id = (int)speaker.reader["Id"];
                    DateTime desde = (DateTime)speaker.reader["Desde"];
                    DateTime hasta = (DateTime)speaker.reader["Hasta"];
                    EsquemaTrabajo esquema = new EsquemaTrabajo(id, desde, hasta);
                    esquemas.Add(esquema);
                }
            }
            speaker.close();
            return esquemas;
        }

        public List<Fecha> darFechas(decimal codigoEspecilidad)
        {
            List<AgendaDiaria> agendasEspecialidad = new List<AgendaDiaria>();//agendas de la especialidad que nos interesa
            foreach (AgendaDiaria agenda in agendas)
            {
                if (agenda.especialidadCodigo == codigoEspecilidad)
                {
                    agendasEspecialidad.Add(agenda);
                }
            }

            List<Fecha> todasLasFechas = new List<Fecha>();//son todas las fechas comprendidas entre el desde y hasta del esquema
            Fecha fecha;
            if (desde.CompareTo(DateTime.Parse(ArchivoDeConfiguracion.Default.Fecha).Date) >= 0)
            {
                fecha = new Fecha(desde);
            }
            else
            {
                fecha = new Fecha(DateTime.Parse(ArchivoDeConfiguracion.Default.Fecha).Date);
            }
            while (fecha.CompareTo(hasta) <= 0)
            {
                todasLasFechas.Add(fecha);
                fecha = fecha.AddDays(1);
            }

            List<Fecha> fechas = new List<Fecha>();//ponemos solo las fechas que se corresponden en las agendas
            foreach (Fecha unaFecha in todasLasFechas)
            {
                foreach (AgendaDiaria agenda in agendasEspecialidad)
                {
                    if(agenda.fechaPertenece(unaFecha))
                    {
                        fechas.Add(unaFecha);
                        break;
                    }
                }
            }
            return fechas;
        }

        public Boolean persistirEsquema()
        {
            if(profesional == null) return false; //santi: ahora podriamos tener esquemas sin sus respectivos profesionales, me atajo con esto.
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

