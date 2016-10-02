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
    class ConsultaMedica
    {
        public int id { get; set; }
        public Afiliado afiliado { get; set; }
        public Profesional profesional { get; set; }
        public DateTime fecha { get; set; }
        public string sintoma { get; set; }
        public string enfermedad { get; set; }
        public Turno turno { get; set; }

        public ConsultaMedica(Afiliado afiliado, Profesional profesional)
        {
            this.afiliado = afiliado;
            this.profesional = profesional;
            this.cargarConsulta();
        }

        public void cargarConsulta()
        {
            List<SqlParameter> ListaParametros = new List<SqlParameter>();
            ListaParametros.Add(new SqlParameter("@afiliado", this.afiliado.id));
            ListaParametros.Add(new SqlParameter("@profesional", this.profesional.id));
            SqlParameter parametroSalida = new SqlParameter("@idConsulta", 0);
            parametroSalida.Direction = ParameterDirection.Output;
            ListaParametros.Add(parametroSalida);
            SqlParameter parametroSalida2 = new SqlParameter("@idTurno", 0);
            parametroSalida2.Direction = ParameterDirection.Output;
            ListaParametros.Add(parametroSalida2);
            SpeakerDB speaker = ConexionDB.ExecuteNoQuery("kernel_panic.consultaNueva", "SP", ListaParametros);
            int resultado = Int32.Parse(speaker.comando.Parameters["@idConsulta"].Value.ToString());
            this.id = resultado;
            speaker.close();
            if (this.id != -1)
            {
                int turno = Int32.Parse(speaker.comando.Parameters["@idTurno"].Value.ToString());
                this.turno = new Turno(turno);
            }
        }

        public void actualizarConsulta()
        {
            List<SqlParameter> ListaParametros = new List<SqlParameter>();
            ListaParametros.Add(new SqlParameter("@id", this.id));
            ListaParametros.Add(new SqlParameter("@fecha", this.fecha));
            ListaParametros.Add(new SqlParameter("@enfermedad", this.enfermedad));
            ListaParametros.Add(new SqlParameter("@sintomas", this.sintoma));
            SpeakerDB speaker = ConexionDB.ExecuteNoQuery("UPDATE kernel_panic.Diagnosticos SET Fecha = @fecha, Sintoma = @sintomas, Enfermedad = @enfermedad WHERE Id = @id ", "T", ListaParametros);
            speaker.close();
        }
    }
}
