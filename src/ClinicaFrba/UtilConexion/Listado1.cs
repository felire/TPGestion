using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaFrba.UtilConexion
{
    class Listado1
    {
        public String especialidad { get; set; }
        public String tipoEspecialidad { get; set; }
        public int cantidadCancelaciones { get; set; }

        public static List<Listado1> obtenerResultados(int anio, int semestre)
        {
            List<SqlParameter> ListaParametros = new List<SqlParameter>();
            ListaParametros.Add(new SqlParameter("@anio", anio));
            
            SpeakerDB speaker;
            if (semestre == 1)
            {

                speaker = ConexionDB.ObtenerDataReader("SELECT TOP 5 E.Descripcion AS Especialidad, T.Descripcion AS Tipo, COUNT(Tu.Id) AS Cantidad_cancelaciones " +
                            "FROM kernel_panic.Especialidades E JOIN kernel_panic.Tipo_Especialidad T ON (T.Codigo = E.Tipo) " +
                                            "JOIN kernel_panic.Turnos Tu ON (Tu.Especialidad = E.Codigo) " +
                            "WHERE Tu.Cancelacion IS NOT NULL AND MONTH(Tu.Fecha)<7 AND YEAR(Tu.Fecha)=@anio " +
                            "GROUP BY E.Descripcion, T.Descripcion " +
                            "ORDER BY cantidad_cancelaciones DESC", "T", ListaParametros);
                
            }
            else
            {
                speaker = ConexionDB.ObtenerDataReader("SELECT TOP 5 E.Descripcion AS Especialidad, T.Descripcion AS Tipo, COUNT(Tu.Id) AS Cantidad_cancelaciones " +
                            "FROM kernel_panic.Especialidades E JOIN kernel_panic.Tipo_Especialidad T ON (T.Codigo = E.Tipo) " +
                                            "JOIN kernel_panic.Turnos Tu ON (Tu.Especialidad = E.Codigo) " +
                            "WHERE Tu.Cancelacion IS NOT NULL AND MONTH(Tu.Fecha)>6 AND YEAR(Tu.Fecha)=@anio " +
                            "GROUP BY E.Descripcion, T.Descripcion " +
                            "ORDER BY cantidad_cancelaciones DESC", "T", ListaParametros);                
            }

                           
            List<Listado1> lista= new List<Listado1>();
            if (speaker.reader.HasRows)
            {
                while (speaker.reader.Read())
                {
                    Listado1 listado = new Listado1();
                    listado.especialidad = (string)speaker.reader["Especialidad"];
                    listado.tipoEspecialidad = (string)speaker.reader["Tipo"];
                    listado.cantidadCancelaciones = (int)speaker.reader["Cantidad_cancelaciones"];
                    lista.Add(listado);                    
                }
            }
            speaker.close();
            return lista;
        }

    }
}
