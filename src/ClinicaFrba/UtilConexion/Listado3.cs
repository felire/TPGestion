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
            ListaParametros.Add(new SqlParameter("@anio", anio.ToString()));
            ListaParametros.Add(new SqlParameter("@especialidad", especialidad));
            
            SpeakerDB speaker;
                     

           



            if (semestre == 1)
            {

                speaker = ConexionDB.ObtenerDataReader("SELECT TOP 5 P.Id Id, P.Nombre nombre, P.Apellido apellido, P.Tipo_doc tipoDoc, P.Numero_doc numeroDoc, E.Desde desde,E.Hasta hasta,CASE WHEN (E.Desde<='01-01-'+@anio AND E.Hasta>='30-06-'+@anio) " + //,SUM(DATEDIFF(hour,AD.Desde, AD.Hasta))*DATEDIFF(week, E.Desde, E.Hasta) HorasTrabajadasEnFranja " +
                                                                                                                                                                                                    "THEN SUM(DATEDIFF(hour,AD.Desde, AD.Hasta))*DATEDIFF(week, '01-01-'+@anio, '30-06-'+@anio) " +
                                                                                                                                                                                                 "WHEN (E.Hasta>='01-01-'+@anio AND E.Hasta<='30-06-'+@anio) " +
                                                                                                                                                                                                    "THEN SUM(DATEDIFF(hour,AD.Desde, AD.Hasta))*DATEDIFF(week, '01-01-'+@anio, E.Hasta) "+
                                                                                                                                                                                                 "WHEN (E.Desde>='01-01-'+@anio AND E.Desde<='30-06-'+@anio) " +
                                                                                                                                                                                                    "THEN SUM(DATEDIFF(hour,AD.Desde, AD.Hasta))*DATEDIFF(week, E.Desde, '30-06-'+@anio) "+
                                                                                                                                                                                            "END HorasTrabajadasEnFranja " +

                                                   "FROM kernel_panic.Profesionales P JOIN kernel_panic.Esquema_Trabajo E ON (E.Profesional = P.Id) " +
                                                                                       "JOIN kernel_panic.Agenda_Diaria AD ON (AD.EsquemaTrabajo = E.Id) " +
                                                   "WHERE (E.Desde<='01-01-'+@anio AND E.Hasta>='30-06-'+@anio) OR " +
                                                          "(E.Hasta>='01-01-'+@anio AND E.Hasta<='30-06-'+@anio) OR " +
                                                          "(E.Desde>='01-01-'+@anio AND E.Desde<='30-06-'+@anio) " +
                                                   "AND AD.Especialidad = @especialidad " +
                                                   "GROUP BY  P.Id, P.Nombre, P.Apellido, P.Tipo_doc, P.Numero_doc,E.Desde,E.Hasta " +
                                                   "ORDER BY HorasTrabajadasEnFranja ASC", "T", ListaParametros);

            }
            else
            {
                speaker = ConexionDB.ObtenerDataReader("SELECT TOP 5 P.Id Id, P.Nombre nombre, P.Apellido apellido, P.Tipo_doc tipoDoc, P.Numero_doc numeroDoc, E.Desde desde,E.Hasta hasta,CASE WHEN (E.Desde<='01-07-'+@anio AND E.Hasta>='31-12-'+@anio) " + 
                                                                                                                                                                                                           "THEN SUM(DATEDIFF(hour,AD.Desde, AD.Hasta))*DATEDIFF(week, '01-07-'+@anio, '31-12-'+@anio) " +
                                                                                                                                                                                                        "WHEN (E.Hasta>='01-07-'+@anio AND E.Hasta<='30-06-'+@anio) " +
                                                                                                                                                                                                           "THEN SUM(DATEDIFF(hour,AD.Desde, AD.Hasta))*DATEDIFF(week, '01-07-'+@anio, E.Hasta) " +
                                                                                                                                                                                                        "WHEN (E.Desde>='01-07-'+@anio AND E.Desde<='31-12-'+@anio) " +
                                                                                                                                                                                                           "THEN SUM(DATEDIFF(hour,AD.Desde, AD.Hasta))*DATEDIFF(week, E.Desde, '31-12-'+@anio) " +
                                                                                                                                                                                                   "END HorasTrabajadasEnFranja " +

                                                          "FROM kernel_panic.Profesionales P JOIN kernel_panic.Esquema_Trabajo E ON (E.Profesional = P.Id) " +
                                                                                              "JOIN kernel_panic.Agenda_Diaria AD ON (AD.EsquemaTrabajo = E.Id) " +
                                                          "WHERE (E.Desde<='01-07-'+@anio AND E.Hasta>='31-12-'+@anio) OR " +
                                                                 "(E.Hasta>='01-07-'+@anio AND E.Hasta<='31-12-'+@anio) OR " +
                                                                 "(E.Desde>='01-07-'+@anio AND E.Desde<='31-12-'+@anio) " +
                                                          "AND AD.Especialidad = @especialidad " +
                                                          "GROUP BY  P.Id, P.Nombre, P.Apellido, P.Tipo_doc, P.Numero_doc,E.Desde,E.Hasta " +
                                                          "ORDER BY HorasTrabajadasEnFranja ASC", "T", ListaParametros);
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
