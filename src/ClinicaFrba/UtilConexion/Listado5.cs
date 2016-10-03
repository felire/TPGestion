using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaFrba.UtilConexion
{
    class Listado5
    {

        public String Especialidad { get; set; }
        public String tipoEspecialidad { get; set; }
        public int bonosUtilizados { get; set; }
        
        public static List<Listado5> obtenerResultados(int anio, int semestre)
        {
            List<SqlParameter> ListaParametros = new List<SqlParameter>();
            ListaParametros.Add(new SqlParameter("@anio", anio));

            SpeakerDB speaker;
            if (semestre == 1)
            {

                speaker = ConexionDB.ObtenerDataReader("SELECT TOP 5 E.Descripcion AS Especialidad,Ti.Descripcion AS Tipo,COUNT(B.Id) AS Bonos_Utilizados "+
                                                       "FROM kernel_panic.Turnos T "+ 
		                                                        "JOIN kernel_panic.Bonos_Consultas B ON (T.Id=B.Turno) "+
		                                                        "JOIN kernel_panic.Especialidades E ON (T.Especialidad= E.Codigo) "+
		                                                        "JOIN kernel_panic.Tipo_Especialidad Ti ON (Ti.Codigo = E.Tipo) "+
                                                        "WHERE YEAR(T.Fecha)=@anio AND MONTH(T.Fecha)<7 "+    
                                                        "GROUP BY  Ti.Descripcion,E.Descripcion "+
                                                        "ORDER BY Bonos_Utilizados DESC", "T", ListaParametros);

            }
            else
            {
                speaker = ConexionDB.ObtenerDataReader("SELECT TOP 5 E.Descripcion AS Especialidad,Ti.Descripcion AS Tipo,COUNT(B.Id) AS Bonos_Utilizados " +
                                                      "FROM kernel_panic.Turnos T " +
                                                               "JOIN kernel_panic.Bonos_Consultas B ON (T.Id=B.Turno) " +
                                                               "JOIN kernel_panic.Especialidades E ON (T.Especialidad= E.Codigo) " +
                                                               "JOIN kernel_panic.Tipo_Especialidad Ti ON (Ti.Codigo = E.Tipo) " +
                                                       "WHERE YEAR(T.Fecha)=@anio AND MONTH(T.Fecha)>6 " +
                                                       "GROUP BY  Ti.Descripcion,E.Descripcion " +
                                                       "ORDER BY Bonos_Utilizados DESC", "T", ListaParametros);

            }


            List<Listado5> lista = new List<Listado5>();
            if (speaker.reader.HasRows)
            {
                while (speaker.reader.Read())
                {
                    Listado5 listado = new Listado5();
                    listado.Especialidad = (string)speaker.reader["Especialidad"];
                    listado.tipoEspecialidad = (string)speaker.reader["Tipo"];
                    listado.bonosUtilizados = (int)speaker.reader["Bonos_Utilizados"];
                    lista.Add(listado);
                }
            }
            speaker.close();
            return lista;
        }
    }
}
