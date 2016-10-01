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

namespace ClinicaFrba.Registrar_Agenta_Medico
{
    partial class RegAgendaMedico : Form
    {
        public Profesional profesional { get; set; }
        public List<AgendaDiaria> agendaDeTrabajo { get; set; }

        public RegAgendaMedico(Profesional profesional)
        {
            InitializeComponent();
            this.profesional = profesional;
            agendaDeTrabajo = new List<AgendaDiaria>();
            cargarPantalla();
        }

        private void cargarPantalla()
        {
            //Dias a mostrar
            rangoFechas.Visible = false;
            dias.DataSource = Dia.ObtenerTodosLosDias();
            dias.ValueMember = "id";
            dias.DisplayMember = "nombre";
            nombreProfesional.Text = profesional.apellido + ", " + profesional.nombre;

            //Horas por dia a mostrar
            horaDesde.DataSource = Hora.obtenerHorasDia((Dia) dias.SelectedItem);
            horaDesde.ValueMember = "LaHora";
            horaDesde.DisplayMember = "HoraAMostrar";
            horaDesde.SelectedIndex = 0;

            horaHasta.DataSource = Hora.obtenerHorasDia((Dia)dias.SelectedItem);
            horaHasta.ValueMember = "LaHora";
            horaHasta.DisplayMember = "HoraAMostrar";
            horaHasta.SelectedIndex = horaHasta.Items.Count - 1;

            //Especialidades a mostrar
            especialidades.DataSource = profesional.especialidades;
            especialidades.ValueMember = "codigo";
            especialidades.DisplayMember = "descripcion";

            //Generamos la lista de dias que se van a seleccionar
           
            horarios.AutoGenerateColumns = false;
            horarios.MultiSelect = false;
            generarGrid();
        }

        private void generarGrid()
        {
            DataGridViewTextBoxColumn ColDia = new DataGridViewTextBoxColumn();
            ColDia.DataPropertyName = "diaString";
            ColDia.HeaderText = "Día";
            ColDia.Width = 120;
            horarios.Columns.Add(ColDia);

            DataGridViewTextBoxColumn ColHoraDesde = new DataGridViewTextBoxColumn();
            ColHoraDesde.DataPropertyName = "horaDesde";
            ColHoraDesde.HeaderText = "Hora Desde";
            ColHoraDesde.Width = 120;
            horarios.Columns.Add(ColHoraDesde);

            DataGridViewTextBoxColumn ColHoraHasta = new DataGridViewTextBoxColumn();
            ColHoraHasta.DataPropertyName = "horaHasta";
            ColHoraHasta.HeaderText = "Hora Hasta";
            ColHoraHasta.Width = 120;
            horarios.Columns.Add(ColHoraHasta);

            DataGridViewTextBoxColumn ColEspecialidad = new DataGridViewTextBoxColumn();
            ColEspecialidad.DataPropertyName = "especialidadString";
            ColEspecialidad.HeaderText = "Especialidad";
            ColEspecialidad.Width = 120;
            horarios.Columns.Add(ColEspecialidad);
        }
        private void cambiarHorasDia(object sender, EventArgs e)
        {
            horaDesde.DataSource = Hora.obtenerHorasDia((Dia)dias.SelectedItem);
            horaDesde.ValueMember = "LaHora";
            horaDesde.DisplayMember = "HoraAMostrar";
            horaDesde.SelectedIndex = 0 ;

            horaHasta.DataSource = Hora.obtenerHorasDia((Dia)dias.SelectedItem);
            horaHasta.ValueMember = "LaHora";
            horaHasta.DisplayMember = "HoraAMostrar";
            horaHasta.SelectedIndex = horaHasta.Items.Count - 1;
        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            //AGARRO EL DIA
            Dia unDia = (Dia)dias.SelectedItem;
            //AGARR0 LAS HORAS
            Hora horaD = ((Hora)horaDesde.SelectedItem);
            Hora horaH = ((Hora)horaHasta.SelectedItem);
            TimeSpan horaDesdeT = horaD.LaHora;
            TimeSpan horaHastaT = horaH.LaHora;
            if (Hora.horasValidas(horaDesdeT, horaHastaT))
            {
                unDia.horaDesde = horaDesdeT;
                unDia.horaHasta = horaHastaT;
                Especialidad especialidad = (Especialidad)especialidades.SelectedItem;
                AgendaDiaria diaLaboral = new AgendaDiaria(unDia, especialidad.descripcion, especialidad.codigo);
                if (noEstaUsado(diaLaboral))
                {
                    agendaDeTrabajo.Add(diaLaboral);
                    actualizarLista();
                }
                else 
                {
                    MessageBox.Show("Los horarios seleccionados se sobreponen", "Error!", MessageBoxButtons.OK); 
                }
            }
            else 
            { 
                MessageBox.Show("Inserte correctamente las horas", "Error!", MessageBoxButtons.OK); 
            }
        }

        private Boolean noEstaUsado(AgendaDiaria diaLaboral)
        {
            foreach (AgendaDiaria diaTrabajo in agendaDeTrabajo)
            {//los new TimeSpan(0, 1, 0) son para adelantar un minuto y poder verificar si se pisa o no en casos de que la hora sea la misma
                if (((diaTrabajo.horaDesde <= diaLaboral.horaDesde && diaLaboral.horaDesde.Add(new TimeSpan(0, 1, 0)) <= diaTrabajo.horaHasta) || diaTrabajo.horaDesde <= diaLaboral.horaHasta.Add(new TimeSpan(0, -1, 0)) && diaLaboral.horaHasta <= diaTrabajo.horaHasta) && diaLaboral.dia.id == diaTrabajo.dia.id)
                {
                    return false;
                }
            }
            return true;
        }

        private void actualizarLista()
        {
            horarios.DataSource = null;
            horarios.DataSource = agendaDeTrabajo;
        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            AgendaDiaria dia = (AgendaDiaria)horarios.CurrentRow.DataBoundItem;
            agendaDeTrabajo.Remove(dia);
            actualizarLista();
        }

        private void confirmar_Click(object sender, EventArgs e)
        {
            if (AgendaDiaria.agendaTotalLegal(agendaDeTrabajo))
            {
                confirmar.Visible = false;
                eliminar.Visible = false;
                aceptar.Visible = false;
                rangoFechas.Visible = true;
            }
            else
            {
                MessageBox.Show("La carga horaria supera las 48 horas", "Error!", MessageBoxButtons.OK); 
            }
        }

        private void confirmarRango_Click(object sender, EventArgs e)
        {
            DateTime fechaDesdeDT = fechaDesde.Value;
            DateTime fechaHastaDT = fechaHasta.Value;
            if (fechasValidas(fechaDesdeDT, fechaHastaDT))
            {
                EsquemaTrabajo esquema = new EsquemaTrabajo(fechaDesdeDT, fechaHastaDT, profesional);
                //Persistimos el esquema antes para tener el id que se autogenera y ademas necesito el dia.
                if (esquema.persistirEsquema())
                {
                    foreach (AgendaDiaria dia in agendaDeTrabajo)
                    {
                        dia.esquema = esquema; //Aca asignamos el esquema correspondiente  a cada dia.
                        dia.persistirDiaAgenda();
                    }
                    MessageBox.Show("Agenda guardada con exito!", "Exito!", MessageBoxButtons.OK);
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Las fechas de la agenda no son validas. Se superponen con otra agenda ya existente.", "Error!", MessageBoxButtons.OK);
                }

            }
            else
            {
                MessageBox.Show("Fechas no validas!", "Error!", MessageBoxButtons.OK); 
            }

        }

        private Boolean fechasValidas(DateTime desde, DateTime hasta)
        {
            if (desde >= hasta)
            {
                return false;
            } 
            return true;
        }
    }
}
