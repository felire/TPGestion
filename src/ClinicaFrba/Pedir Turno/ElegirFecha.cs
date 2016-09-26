using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicaFrba.UtilConexion;
using System.Data.SqlTypes;
using System.Data.Sql;
using System.Data.SqlClient;

namespace ClinicaFrba.Pedir_Turno
{
    partial class ElegirFecha : Form
    {
        public Turno turno;
        public List<Fecha> fechas;

        public ElegirFecha(Turno turno)
        {
            InitializeComponent();
            nombreProfesional.Text = "DR. " + turno.profesional.nombre + " " + turno.profesional.apellido;
            fechas = new List<Fecha>();
            this.turno = turno;
            this.cargarFechas();
            this.cargarCancelaciones();
            this.mostrarFechas();
        }

        private void cargarFechas()
        {
            List<Dia> dias = new List<Dia>();
            List<SqlParameter> ListaParametros = new List<SqlParameter>();
            ListaParametros.Add(new SqlParameter("@idProfesional", turno.profesional.id));
            ListaParametros.Add(new SqlParameter("@especialidad", turno.especialidad.codigo));
            SpeakerDB speaker = ConexionDB.ObtenerDataReader("SELECT ad.Dia AS dia, ad.Desde AS fechaDesde, ad.Hasta AS fechaHasta, et.Desde AS horaDesde, et.Hasta AS horaHasta FROM kernel_panic.Esquema_Trabajo et JOIN kernel_panic.Agenda_Diaria ad ON (et.Id = ad.EsquemaTrabajo) WHERE  et.Profesional = @idProfesional AND ad.Especialidad = @especialidad ", "T", ListaParametros);
            if (speaker.reader.HasRows)
            {
                while (speaker.reader.Read())
                {
                    int id = (int)speaker.reader["dia"];
                    Dia dia = new Dia(id);
                    dia.horaDesde = (TimeSpan)speaker.reader["fechaDesde"];
                    dia.horaHasta = (TimeSpan)speaker.reader["fechaHasta"];
                    dia.fechaDesde = (DateTime)speaker.reader["horaDesde"];
                    dia.fechaHasta = (DateTime)speaker.reader["horaHasta"];
                    dias.Add(dia);
                }
            }
            speaker.close();
            this.obtenerFechas(dias);
        }

        private void obtenerFechas(List<Dia> dias)
        {
            foreach (Dia dia in dias)
            {
                foreach (DateTime fecha in dia.darFechasConcretas())
                {
                    Fecha fechita = new Fecha(fecha, dia.horaDesde, dia.horaHasta);
                    this.fechas.Add(fechita);
                }
            }
        }

        private void cargarCancelaciones()
        {
            List<SqlParameter> ListaParametros = new List<SqlParameter>();
            ListaParametros.Add(new SqlParameter("@profesional", turno.profesional.id));
            SpeakerDB speaker = ConexionDB.ObtenerDataReader("SELECT c.Desde AS fechaDesde, c.Hasta AS fechaHasta FROM kernel_panic.Franjas_Canceladas c JOIN kernel_panic.Esquema_Trabajo et ON(c.EsquemaTrabajo = et.Id) WHERE et.Profesional = @profesional ", "T", ListaParametros);
            if (speaker.reader.HasRows)
            {
                while (speaker.reader.Read())
                {
                    DateTime fechaDesde = (DateTime)speaker.reader["fechaDesde"];
                    DateTime fechaHasta = (DateTime)speaker.reader["fechaHasta"];
                    this.borrarFechas(fechaDesde, fechaHasta);
                }
            }
            speaker.close();
        }

        private void borrarFechas(DateTime desde, DateTime hasta)
        {
            List<Fecha> fechasClonadas = new List<Fecha>();

            foreach (Fecha fecha in fechas)
            {

                fechasClonadas.Add(fecha);
            }

            foreach (Fecha fecha in fechasClonadas)
            {
                if (fecha.CompareTo(desde) >= 0 && fecha.CompareTo(hasta) <= 0)
                {
                    fechas.Remove(fecha);
                }
            }
        }

        private void mostrarFechas()
        {
            comboFecha.DataSource = fechas;
            comboFecha.DisplayMember = "dia";
        }

        private void elegirDia_Click(object sender, EventArgs e)
        {

            Fecha fecha = (Fecha)comboFecha.SelectedItem;
            turno.fecha = fecha.dia;
            Dia dia = new Dia(1);
            dia.horaDesde = fecha.horaDesde;
            dia.horaHasta = fecha.horaHasta;
            comboHorario.DataSource = Hora.obtenerHorasDia(dia);
            comboHorario.ValueMember = "LaHora";
            comboHorario.DisplayMember = "HoraAMostrar";
           
        }

        private void elegir_Click(object sender, EventArgs e)
        {
            Hora hora = (Hora)comboHorario.SelectedItem;
            turno.fecha = new DateTime(turno.fecha.Year, turno.fecha.Month, turno.fecha.Day, hora.LaHora.Hours, hora.LaHora.Minutes, 0);
            List<SqlParameter> ListaParametros = new List<SqlParameter>();
            ListaParametros.Add(new SqlParameter("@afiliadoId", turno.afiliado.id));
            ListaParametros.Add(new SqlParameter("@profesionalId", turno.profesional.id));
            ListaParametros.Add(new SqlParameter("@fecha", turno.fecha));
            ListaParametros.Add(new SqlParameter("@especialidad", turno.especialidad.codigo));
            SpeakerDB speaker = ConexionDB.ExecuteNoQuery("INSERT INTO kernel_panic.Turnos (Afiliado_id, Profesional_id, Fecha, Especialidad) VALUES (@afiliadoId, @profesionalId, @fecha, @especialidad) ", "T", ListaParametros);
            speaker.close();
            MessageBox.Show("Turno creado con exito", "Info", MessageBoxButtons.OK);
        }
    }
}
