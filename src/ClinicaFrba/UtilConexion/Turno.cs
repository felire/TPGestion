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
    class Turno
    {
        public int id { get; set; }
        public DateTime fecha { get; set; }
        public Especialidad especialidad { get; set; }
        public string especialidadNombre { get; set; }
        public Profesional profesional { get; set; }
        public string profesionalNombre { get; set; }
        public Afiliado afiliado { get; set; }

        public Turno(int id)
        {
            this.id = id;
            cargarTurno();
        }

        public Turno() {}

        public void cargarTurno()
        {
            List<SqlParameter> ListaParametros = new List<SqlParameter>();
            ListaParametros.Add(new SqlParameter("@turnoId", this.id));
            SpeakerDB speaker = ConexionDB.ObtenerDataReader("SELECT Fecha, Especialidad FROM kernel_panic.Turnos WHERE Id = @turnoId", "T", ListaParametros);
            if (speaker.reader.HasRows)
            {
                speaker.reader.Read();
                this.fecha = (DateTime)speaker.reader["Fecha"];
                this.especialidad = new Especialidad((decimal)speaker.reader["Especialidad"]);               
            }
            speaker.close();
        
        }
        public static List<Turno> darTodosLosTurnosDe(Afiliado afiliado)
        {
            List<SqlParameter> ListaParametros = new List<SqlParameter>();
            ListaParametros.Add(new SqlParameter("@afiliadoId", afiliado.id));
            List<Turno> turnos = new List<Turno>();
            SpeakerDB speaker = ConexionDB.ObtenerDataReader("SELECT Id, Fecha, Especialidad, Profesional_id FROM kernel_panic.Turnos WHERE Afiliado_id = @afiliadoId AND Fecha >= CONVERT(DATE,GETDATE()) AND Fecha_llegada IS NULL AND Cancelacion IS NULL ORDER BY Fecha ASC", "T", ListaParametros);
            if (speaker.reader.HasRows)
            {
                while (speaker.reader.Read())
                {
                    Turno turno = new Turno();
                    turno.id = (int)speaker.reader["Id"];
                    turno.fecha = (DateTime)speaker.reader["Fecha"];
                    turno.especialidad = new Especialidad((decimal) speaker.reader["Especialidad"]);
                    turno.profesional = new Profesional((int)speaker.reader["Profesional_id"]);
                    turno.especialidadNombre = turno.especialidad.descripcion;
                    turno.profesionalNombre = turno.profesional.apellido + ", " + turno.profesional.nombre; 
                    turnos.Add(turno);
                }
            }
            speaker.close();
            return turnos;
        }

        public void cancelar(string motivoCancelacion, string tipo)
        {
            List<SqlParameter> ListaParametros = new List<SqlParameter>();
            ListaParametros.Add(new SqlParameter("@idTurno", this.id));
            ListaParametros.Add(new SqlParameter("@detalle", motivoCancelacion));
            ListaParametros.Add(new SqlParameter("@tipo", tipo));
            SpeakerDB speaker = ConexionDB.ExecuteNoQuery("kernel_panic.cancelarTurnoAfi", "SP", ListaParametros);
            speaker.close();
        }

        public static List<Turno> darTurnos(Afiliado afiliado, Profesional profesional)
        {
            List<SqlParameter> ListaParametros = new List<SqlParameter>();
            ListaParametros.Add(new SqlParameter("@idAfiliado", afiliado.id));
            ListaParametros.Add(new SqlParameter("@idProfesional", profesional.id));
            SpeakerDB speaker = ConexionDB.ObtenerDataReader("SELECT Id, Fecha, Especialidad FROM kernel_panic.Turnos WHERE Afiliado_id = @idAfiliado AND Profesional_id = @idProfesional AND CONVERT(DATE,Fecha) = CONVERT(DATE,GETDATE()) AND Fecha_llegada IS NULL AND Cancelacion IS NULL ORDER BY Fecha ASC", "T", ListaParametros);
            List<Turno> turnos = new List<Turno>();
            if (speaker.reader.HasRows)
            {
                while (speaker.reader.Read())
                {
                    Turno turno = new Turno();
                    turno.id = (int)speaker.reader["Id"];
                    turno.fecha = (DateTime)speaker.reader["Fecha"];
                    turno.especialidad = new Especialidad((decimal)speaker.reader["Especialidad"]);
                    turno.afiliado = afiliado;
                    turno.profesional = profesional;
                    turno.especialidadNombre = turno.especialidad.descripcion;
                    turno.profesionalNombre = turno.profesional.apellido + ", " + turno.profesional.nombre;
                    turnos.Add(turno);
                }
            }
            speaker.close();
            return turnos;
        }

        public void registrarLlegada(int bonoAusar)
        {
            this.actualizarBono(bonoAusar);

            List<SqlParameter> ListaParametros = new List<SqlParameter>();
            ListaParametros.Add(new SqlParameter("@idTurno", this.id));
            SpeakerDB speaker = ConexionDB.ExecuteNoQuery("UPDATE kernel_panic.Turnos SET Fecha_llegada = GETDATE() WHERE Id = @idTurno", "T", ListaParametros);
            speaker.close();

            ListaParametros.Clear();
            ListaParametros.Add(new SqlParameter("@idTurno", this.id));
            ListaParametros.Add(new SqlParameter("@idAfiliado", afiliado.id));
            ListaParametros.Add(new SqlParameter("@idProfesional", profesional.id));
            speaker = ConexionDB.ExecuteNoQuery("INSERT INTO kernel_panic.Diagnosticos (Afiliado_id, Profesional_id, Turno_id) VALUES (@idAfiliado, @idProfesional, @idTurno)", "T", ListaParametros);
            speaker.close();
        }

        private void actualizarBono(int bonoAUsar)
        {
            int numeroConsulta = afiliado.proximoNumeroDeConsulta();
            List<SqlParameter> ListaParametros = new List<SqlParameter>();
            ListaParametros.Add(new SqlParameter("@numConsulta", numeroConsulta));
            ListaParametros.Add(new SqlParameter("@idAfiliado", afiliado.id));
            ListaParametros.Add(new SqlParameter("@hoy", DateTime.Today));
            ListaParametros.Add(new SqlParameter("@idTurno", this.id));
            ListaParametros.Add(new SqlParameter("@idBono", bonoAUsar));
            string query = "UPDATE kernel_panic.Bonos_Consultas " +
                           "SET Nro_consulta = @numConsulta, " +
                           "Afiliado_Uso = @idAfiliado, " +
                           "Fecha_Impresion = @hoy, " +
                           "Turno = @idBono " +
                           "WHERE Id = @idBono";
            SpeakerDB speaker = ConexionDB.ExecuteNoQuery(query, "T", ListaParametros);
            speaker.close();
        }
    }
}
