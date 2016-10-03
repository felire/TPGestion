using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaFrba.UtilConexion
{
    class Listado4
    {
        public String nombre { get; set; }
        public String apellido  { get; set; }
        public int bonosComprados { get; set; }
        public Boolean tieneParientes { get; set; }

        public static List<Listado4> obtenerResultados(int anio, int semestre)
        {
            List<SqlParameter> ListaParametros = new List<SqlParameter>();
            ListaParametros.Add(new SqlParameter("@anio", anio));

            SpeakerDB speaker;
            if (semestre == 1)
            {

                speaker = ConexionDB.ObtenerDataReader("SELECT TOP 5 A.Nombre AS Nombre, A.Apellido AS Apellido, SUM(T.Cantidad) AS Cantidad_Comprados, A.Numero_de_grupo,(SELECT CAST( "+
                                                            "CASE WHEN (SELECT COUNT(A2.Numero_de_grupo) FROM kernel_panic.Afiliados A2 WHERE A2.Numero_de_grupo = A.Numero_de_grupo) > 1 THEN 1 "+
                                                                   "ELSE 0 "+ 
                                                                   "END "+ 
                                                            "AS BIT)) AS 'pertenece_a_grupo' "+                                                            
                                                            "FROM kernel_panic.Afiliados A JOIN kernel_panic.Transacciones T ON (T.Afiliado = A.Id) "+
                                                            "WHERE YEAR(T.Fecha)=@anio AND MONTH(T.Fecha)<7 "+
                                                            "GROUP BY A.Nombre, A.Apellido, A.Numero_de_grupo "+
                                                            "ORDER BY Cantidad_Comprados DESC, A.Numero_de_grupo ASC", "T", ListaParametros);

            }
            else
            {
                speaker = ConexionDB.ObtenerDataReader("SELECT TOP 5 A.Nombre AS Nombre, A.Apellido AS Apellido, SUM(T.Cantidad) AS Cantidad_Comprados, A.Numero_de_grupo,(SELECT CAST( " +
                                                             "CASE WHEN (SELECT COUNT(A2.Numero_de_grupo) FROM kernel_panic.Afiliados A2 WHERE A2.Numero_de_grupo = A.Numero_de_grupo) > 1 THEN 1 " +
                                                                    "ELSE 0 " +
                                                                    "END " +
                                                             "AS BIT)) AS 'pertenece_a_grupo' " +
                                                             "FROM kernel_panic.Afiliados A JOIN kernel_panic.Transacciones T ON (T.Afiliado = A.Id) " +
                                                             "WHERE YEAR(T.Fecha)=@anio AND MONTH(T.Fecha)>6 " +
                                                             "GROUP BY A.Nombre, A.Apellido, A.Numero_de_grupo " +
                                                             "ORDER BY Cantidad_Comprados DESC, A.Numero_de_grupo ASC", "T", ListaParametros);
            }


            List<Listado4> lista = new List<Listado4>();
            if (speaker.reader.HasRows)
            {
                while (speaker.reader.Read())
                {
                    Listado4 listado = new Listado4();
                    listado.nombre = (string)speaker.reader["Nombre"];
                    listado.apellido = (string)speaker.reader["Apellido"];
                    listado.bonosComprados = (int)speaker.reader["Cantidad_Comprados"];
                    listado.tieneParientes = (Boolean)speaker.reader["pertenece_a_grupo"];
                    lista.Add(listado);
                }
            }
            speaker.close();
            return lista;
        }
    }
}
