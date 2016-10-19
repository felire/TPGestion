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
        private Turno turno;
        private List<Fecha> fechas;
        private ElegirEspecialidad elegirEsp;

        public ElegirFecha(Turno turno, ElegirEspecialidad elegirEsp)
        {
            InitializeComponent();
            this.elegirEsp = elegirEsp;
            nombreProfesional.Text = "DR. " + turno.profesional.nombre + " " + turno.profesional.apellido;
            fechas = new List<Fecha>();
            this.turno = turno;
            this.cargarFechas();
            this.borrarFechasCanceladas();
            this.borrarHorariosOcupados();
            this.mostrarFechas();
        }

        private void cargarFechas()
        {
            List<EsquemaTrabajo> esquemas = EsquemaTrabajo.darEsquemas(turno.profesional.id);
            foreach (EsquemaTrabajo esquema in esquemas)
            {
                List<Fecha> fechasEsquema = esquema.darFechas(turno.especialidad.codigo);
                foreach (Fecha fecha in fechasEsquema)
                {
                    fechas.Add(fecha);
                }
            }
        }

        private void borrarFechasCanceladas()
        {
            List<FranjaCancelada> franjasCanceladas = turno.profesional.darFranjasCanceladas();
            foreach (FranjaCancelada franja in franjasCanceladas)
            {
                fechas.RemoveAll(fecha => franja.fechaFueCancelada(fecha));
            }
        }

        private void borrarHorariosOcupados()
        {
            List<SqlParameter> ListaParametros = new List<SqlParameter>();
            ListaParametros.Add(new SqlParameter("@afiliado", turno.afiliado.id));
            ListaParametros.Add(new SqlParameter("@profesional", turno.profesional.id));
            string query = "SELECT Fecha "+
                           "FROM kernel_panic.Turnos "+
                           "WHERE ( Afiliado_id = @afiliado OR Profesional_id = @profesional ) AND Cancelacion IS NULL ";
            SpeakerDB speaker = ConexionDB.ObtenerDataReader(query, "T", ListaParametros);
            if (speaker.reader.HasRows)
            {
                while (speaker.reader.Read())
                {
                    agregarHorarioOcupado((DateTime)speaker.reader["Fecha"]);
                }
            }
            speaker.close();
        }

        private void agregarHorarioOcupado(DateTime date)
        {
            Fecha fechaOcupada = Fecha.parsearDateTime(date);
            foreach (Fecha unaFecha in fechas)
            {
                if (fechaOcupada.dia.Date == unaFecha.dia.Date)
                {
                    unaFecha.horasOcupadas.Add(fechaOcupada.horaDesde);
                }
            }
        }

        private void mostrarFechas()
        {
            int fechasMostradas = 0;
            List<Fecha> fechasConHorariosDisponibles = new List<Fecha>();
            foreach (Fecha fecha in fechas)
            {
                if (Hora.obtenerHorasFecha(fecha).Count() > 0)
                {
                    fechasConHorariosDisponibles.Add(fecha);
                    fechasMostradas++;
                }
            }
            if (fechasMostradas != 0)
            {
                comboFecha.DataSource = fechasConHorariosDisponibles;
                comboFecha.DisplayMember = "dia";
                elegirEsp.Close();
                this.Show();
            }
            else 
            {
                MessageBox.Show("No hay turnos disponibles para la especialidad elegida", "Error!", MessageBoxButtons.OK);
            }
        }

        private void eligioDia(object sender, EventArgs e)
        {
            Fecha fecha = (Fecha)comboFecha.SelectedItem;
            turno.fecha = fecha.dia;
            comboHorario.DataSource = Hora.obtenerHorasFecha(fecha);
            comboHorario.ValueMember = "LaHora";
            comboHorario.DisplayMember = "HoraAMostrar";
        }

        private void acepto(object sender, EventArgs e)
        {
            Hora hora = (Hora)comboHorario.SelectedItem;
            turno.fecha = new DateTime(turno.fecha.Year, turno.fecha.Month, turno.fecha.Day, hora.LaHora.Hours, hora.LaHora.Minutes, 0);
            turno.persistir();
            MessageBox.Show("Turno creado con exito", "Info", MessageBoxButtons.OK);
            this.Close();
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
