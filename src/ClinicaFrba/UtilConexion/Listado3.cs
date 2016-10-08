using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.UtilConexion
{
    class Listado3
    {
        public int id { get; set; }
        public String nombre { get; set; }
        public String apellido { get; set; }
        public String tipoDocumento { get; set; }
        public decimal documento { get; set; }
        public DateTime desde { get; set; }
        public DateTime hasta { get; set; }
        public int horasTrabajadas { get; set; }

        public static List<Listado3> obtenerResultados(int anio, int semestre, decimal especialidad)
        {
            List<SqlParameter> ListaParametros = new List<SqlParameter>();
            ListaParametros.Add(new SqlParameter("@anio", anio));
            ListaParametros.Add(new SqlParameter("@especialidad", especialidad));
            //SELECT convert(date, '23/10/2016', 103)
            SpeakerDB speaker;
                     

           



            if (semestre == 1)
            {

                speaker = ConexionDB.ObtenerDataReader("SELECT TOP 5 P.Id Id, P.Nombre nombre, P.Apellido apellido, P.Tipo_doc tipoDoc, P.Numero_doc numeroDoc, E.Desde desde,E.Hasta hasta,SUM(DATEDIFF(hour,AD.Desde, AD.Hasta))*DATEDIFF(week, E.Desde, E.Hasta) HorasTrabajadasEnFranja " +
                                                   "FROM kernel_panic.Profesionales P JOIN kernel_panic.Esquema_Trabajo E ON (E.Profesional = P.Id) " +
                                                                                       "JOIN kernel_panic.Agenda_Diaria AD ON (AD.EsquemaTrabajo = E.Id) " +
                                                   "WHERE (YEAR(E.Desde)=@anio OR YEAR(E.Hasta)=@anio) AND MONTH(E.Desde)<7 " +
                                                   "AND AD.Especialidad = @especialidad " +
                                                   "GROUP BY  P.Id, P.Nombre, P.Apellido, P.Tipo_doc, P.Numero_doc,E.Desde,E.Hasta " +
                                                   "ORDER BY SUM(DATEDIFF(hour,AD.Desde, AD.Hasta))*DATEDIFF(week, E.Desde, E.Hasta) ASC", "T", ListaParametros);

            }
            else
            {
                speaker = ConexionDB.ObtenerDataReader("SELECT TOP 5 P.Id Id, P.Nombre nombre, P.Apellido apellido, P.Tipo_doc tipoDoc, P.Numero_doc numeroDoc, E.Desde desde,E.Hasta hasta,SUM(DATEDIFF(hour,AD.Desde, AD.Hasta))*DATEDIFF(week, CASE WHEN MONTH(E.Desde) > 6 THEN E.Desde ELSE convert(date, '01/07/@anio', 103) END, CASE WHEN MONTH(E.Hasta)>6 THEN E.Hasta ELSE convert(date, '31/12/@anio',103) END) HorasTrabajadasEnFranja " +
                                                   "FROM kernel_panic.Profesionales P JOIN kernel_panic.Esquema_Trabajo E ON (E.Profesional = P.Id) " +
                                                                                       "JOIN kernel_panic.Agenda_Diaria AD ON (AD.EsquemaTrabajo = E.Id) " +
                                                   "WHERE (YEAR(E.Desde)=@anio OR YEAR(E.Hasta)=@anio) " +
                                                   "AND AD.Especialidad = @especialidad " +
                                                   "GROUP BY  P.Id, P.Nombre, P.Apellido, P.Tipo_doc, P.Numero_doc,E.Desde,E.Hasta " +
                                                   "ORDER BY SUM(DATEDIFF(hour,AD.Desde, AD.Hasta))*DATEDIFF(week, CASE WHEN MONTH(E.Desde) > 6 THEN E.Desde ELSE convert(date, '01/07/@anio', 103) END, CASE WHEN MONTH(E.Hasta)>6 THEN E.Hasta ELSE convert(date, '31/12/@anio',103) END) ASC", "T", ListaParametros);
            }
            List<Listado3> lista = new List<Listado3>();
            if (speaker.reader.HasRows)
            {
                while (speaker.reader.Read())
                {
                    Listado3 listado = new Listado3();
                    listado.id = (int)speaker.reader["Id"];
                    listado.nombre = (string)speaker.reader["nombre"];
                    listado.apellido = (string)speaker.reader["apellido"];
                    listado.tipoDocumento = (string)speaker.reader["tipoDoc"];
                    listado.documento = (decimal)speaker.reader["numeroDoc"];
                    listado.desde = (DateTime)speaker.reader["desde"];
                    listado.hasta = (DateTime)speaker.reader["hasta"];
                    listado.horasTrabajadas = (int)speaker.reader["HorasTrabajadasEnFranja"];
                    lista.Add(listado);                    
                }
            }
            speaker.close();
            return lista;
        }

    }
}
