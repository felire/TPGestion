using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.UtilConexion
{
    class Listado2
    {
        public int id { get; set; }

        public String nombre { get; set; }
        public String apellido { get; set; }
        public String tipoDocumento { get; set; }
        public decimal documento { get; set; }
        public int consultas { get; set; }

        public static List<Listado2> obtenerResultados(int anio, int semestre)
        {
            List<SqlParameter> ListaParametros = new List<SqlParameter>();
            ListaParametros.Add(new SqlParameter("@anio", anio));
            
            SpeakerDB speaker;
            if (semestre == 1)
            {

                speaker = ConexionDB.ObtenerDataReader("SELECT TOP 5 P.Id Id, P.Nombre nombre, P.Apellido apellido, P.Tipo_doc tipoDoc, P.Numero_doc numeroDoc, COUNT(DISTINCT T.Id) Consultas "+
                                                        "FROM kernel_panic.Profesionales P JOIN kernel_panic.Diagnosticos T ON(T.Profesional_id = P.Id) "+
								                                                          "JOIN kernel_panic.Afiliados A ON (T.Afiliado_id = A.Id) "+
								                                                          "JOIN kernel_panic.Grupos_Familiares GF ON (A.Numero_de_grupo = GF.Id) "+
								                                                          "JOIN kernel_panic.Turnos Tu ON (T.Id = Tu.Id) "+
                                                        "WHERE YEAR(T.Fecha)= @anio AND MONTH(T.Fecha)<7 "+
                                                        /*"AND Tu.Especialidad = @especialidad AND GF.Plan_grupo = @planGrupo "+*/
                                                        "GROUP BY P.Id, P.Nombre, P.Apellido, P.Tipo_doc, P.Numero_doc "+
                                                        "ORDER BY COUNT(DISTINCT T.Id) DESC", "T", ListaParametros);
                
            }
            else
            {
                speaker = ConexionDB.ObtenerDataReader("SELECT TOP 5 P.Id Id, P.Nombre nombre, P.Apellido apellido, P.Tipo_doc tipoDoc, P.Numero_doc numeroDoc, COUNT(DISTINCT T.Id) Consultas " +
                                                        "FROM kernel_panic.Profesionales P JOIN kernel_panic.Diagnosticos T ON(T.Profesional_id = P.Id) " +
                                                                                          "JOIN kernel_panic.Afiliados A ON (T.Afiliado_id = A.Id) " +
                                                                                          "JOIN kernel_panic.Grupos_Familiares GF ON (A.Numero_de_grupo = GF.Id) " +
                                                                                          "JOIN kernel_panic.Turnos Tu ON (T.Id = Tu.Id) " +
                                                        "WHERE YEAR(T.Fecha)= @anio AND MONTH(T.Fecha)>6 " +
                                                        /*"Tu.Especialidad = @especialidad AND GF.Plan_grupo = @planGrupo "+*/
                                                        "GROUP BY P.Id, P.Nombre, P.Apellido, P.Tipo_doc, P.Numero_doc " +
                                                        "ORDER BY COUNT(DISTINCT T.Id) DESC", "T", ListaParametros);       
            }

                           
            List<Listado2> lista= new List<Listado2>();
            if (speaker.reader.HasRows)
            {
                while (speaker.reader.Read())
                {
                    Listado2 listado = new Listado2();
                    listado.id = (int)speaker.reader["Id"];
                    listado.nombre = (string)speaker.reader["nombre"];
                    listado.apellido = (string)speaker.reader["apellido"];
                    listado.tipoDocumento = (string)speaker.reader["tipoDoc"];
                    listado.documento = (decimal)speaker.reader["numeroDoc"];
                    listado.consultas = (int)speaker.reader["Consultas"];
                    lista.Add(listado);                    
                }
            }
            speaker.close();
            return lista;
        }

    }
}
