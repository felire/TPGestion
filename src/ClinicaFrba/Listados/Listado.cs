using ClinicaFrba.UtilConexion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.Listados
{
    partial class Listado : Form
    {
        public int semestre;
        private List<int> anios;
        public const int numeritoMagico = 44;
        private List<Especialidad> especialidades;
        public List<Plan> planes;
        public Listado()
        {
            InitializeComponent();
            this.cargarDatos();
            grilla4.Enabled = false;
            filtroEspecialidad.Visible=false;
            filtrarEspYPlan.Visible = false;
            grilla1.AutoGenerateColumns = false;
            grilla2.AutoGenerateColumns = false;
            grilla3.AutoGenerateColumns = false;
            grilla4.AutoGenerateColumns = false;
            grilla5.AutoGenerateColumns = false;
            this.generarGrillaListado1();
            this.generarGrillaListado2();
            this.generarGrillaListado3();
            this.generarGrillaListado4();
            this.generarGrillaListado5();
        }

        private void comboAnio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listar_Click(object sender, EventArgs e)
        {
            
            if (tabControl.SelectedTab.Name.Equals("tabPage1"))
            {
                this.cargarEspecialidadesCanceladas();
            }
            if (tabControl.SelectedTab.Name.Equals("tabPage2"))
            {
                this.cargarProfesionalesMasConsultados();
            }
            if (tabControl.SelectedTab.Name.Equals("tabPage3"))
            {
                this.cargarProfesionalesMenosHoras();
            }
            if (tabControl.SelectedTab.Name.Equals("tabPage4"))
            {
                this.cargarAfiliadosBonos();
            }
            if (tabControl.SelectedTab.Name.Equals("tabPage5"))
            {
                this.cargarEspecialidadesRequeridas();
            }
        }

        private void cargarDatos()
        {
            anios= new List<int>();
            for (int i = 2015; i <= DateTime.Now.Year; i++) anios.Add(i);
            anioElegido.DataSource = anios;
            semestreUno.Checked=true;
            especialidades = Especialidad.darTodasEspecialidades();
            this.planes = Plan.darTodosLosPlanes();

            comboBoxEspecialidades.DataSource = especialidades;
            comboBoxEspecialidades.DisplayMember = "descripcion";
            comboBoxEspecialidades.ValueMember = "codigo";
            comboBoxPlan.DataSource = this.planes;
            comboBoxPlan.DisplayMember = "descripcion";
            comboBoxPlan.ValueMember = "codigo";
            comboBoxEspecialidad2.DataSource = especialidades;
            comboBoxEspecialidad2.DisplayMember = "descripcion";
            comboBoxEspecialidad2.ValueMember = "codigo";
        }
        private void cargarEspecialidadesCanceladas()
        {
            List<Listado1> lista1 = Listado1.obtenerResultados((int)anioElegido.SelectedItem, semestre);
            grilla1.DataSource = lista1;
        }
        private void cargarProfesionalesMasConsultados()
        {
            List<Listado2> lista2 = Listado2.obtenerResultados((int)anioElegido.SelectedItem, semestre, ((Especialidad)comboBoxEspecialidad2.SelectedItem).codigo, ((Plan)comboBoxPlan.SelectedItem).codigo);
            grilla2.DataSource = lista2;
        }
        private void cargarProfesionalesMenosHoras()
        {
            List<Listado3> lista = Listado3.obtenerResultados((int)anioElegido.SelectedItem, semestre, ((Especialidad)comboBoxEspecialidades.SelectedItem).codigo);
            grilla3.DataSource = lista;
        }
        private void cargarAfiliadosBonos()
        {
            List<Listado4> lista = Listado4.obtenerResultados((int)anioElegido.SelectedItem, semestre);
            grilla4.DataSource = lista;
        }
        private void cargarEspecialidadesRequeridas()
        {
            List<Listado5> lista = Listado5.obtenerResultados((int)anioElegido.SelectedItem, semestre);
            grilla5.DataSource = lista;
        
        }

        private void semestreUno_CheckedChanged(object sender, EventArgs e)
        {
            semestre = 1;
        }

        private void Listado_Load(object sender, EventArgs e)
        {
            
        }

        private void semestre2_CheckedChanged(object sender, EventArgs e)
        {
            semestre = 2;
        }

        private void cambiaTab(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab.Name.Equals("tabPage1"))
            {
                filtroEspecialidad.Visible = false;
                filtrarEspYPlan.Visible = false;
            }
            if (tabControl.SelectedTab.Name.Equals("tabPage2"))
            {
                filtroEspecialidad.Visible = false;
                filtrarEspYPlan.Visible = true;
            }
            if (tabControl.SelectedTab.Name.Equals("tabPage3"))
            {
                filtroEspecialidad.Visible = true;
                filtrarEspYPlan.Visible = false;
            }
            if (tabControl.SelectedTab.Name.Equals("tabPage4"))
            {
                filtroEspecialidad.Visible = false;
                filtrarEspYPlan.Visible = false;
            }
            if (tabControl.SelectedTab.Name.Equals("tabPage5"))
            {
                filtroEspecialidad.Visible = false;
                filtrarEspYPlan.Visible = false;
            }
        }


        private decimal darCodigoEspecialidad()
        {
            foreach (Especialidad esp in especialidades)
            {
                if (esp.descripcion == comboBoxEspecialidades.SelectedItem) return esp.codigo;
            }
            return 0;
        }

        private void generarGrillaListado1()
        {

            DataGridViewTextBoxColumn ColNombre = new DataGridViewTextBoxColumn();
            ColNombre.DataPropertyName = "especialidad";
            ColNombre.HeaderText = "Especialidad Médica";

            ColNombre.Width = grilla1.Width/3;
            grilla1.Columns.Add(ColNombre);

            DataGridViewTextBoxColumn ColTipo = new DataGridViewTextBoxColumn();
            ColTipo.DataPropertyName = "tipoEspecialidad";
            ColTipo.HeaderText = "Tipo Especialidad Médica";
            ColTipo.Width = grilla1.Width / 3;
            grilla1.Columns.Add(ColTipo);

            DataGridViewTextBoxColumn ColCant = new DataGridViewTextBoxColumn();
            ColCant.DataPropertyName = "cantidadCancelaciones";
            ColCant.HeaderText = "Total Cancelaciones del semestre";
            ColCant.Width = grilla1.Width /3 -numeritoMagico;
            grilla1.Columns.Add(ColCant);
        }

        private void generarGrillaListado2()
        {

            DataGridViewTextBoxColumn ColId = new DataGridViewTextBoxColumn();
            ColId.DataPropertyName = "Id";
            ColId.HeaderText = "Id";
            ColId.Width = grilla1.Width / 6;
            grilla2.Columns.Add(ColId);

            DataGridViewTextBoxColumn ColNombre = new DataGridViewTextBoxColumn();
            ColNombre.DataPropertyName = "nombre";
            ColNombre.HeaderText = "Nombre Profesional";
            ColNombre.Width = grilla1.Width / 6;
            grilla2.Columns.Add(ColNombre);

            DataGridViewTextBoxColumn ColApellido = new DataGridViewTextBoxColumn();
            ColApellido.DataPropertyName = "apellido";
            ColApellido.HeaderText = "Apellido Profesional";
            ColApellido.Width = grilla1.Width / 6;
            grilla2.Columns.Add(ColApellido);

            DataGridViewTextBoxColumn ColTipoDoc = new DataGridViewTextBoxColumn();
            ColTipoDoc.DataPropertyName = "tipoDocumento";
            ColTipoDoc.HeaderText = "Tipo Documento";
            ColTipoDoc.Width = grilla1.Width / 6;
            grilla2.Columns.Add(ColTipoDoc);

            DataGridViewTextBoxColumn ColDocumento = new DataGridViewTextBoxColumn();
            ColDocumento.DataPropertyName = "documento";
            ColDocumento.HeaderText = "Documento";
            ColDocumento.Width = grilla1.Width / 6;
            grilla2.Columns.Add(ColDocumento);

            DataGridViewTextBoxColumn ColConsultas = new DataGridViewTextBoxColumn();
            ColConsultas.DataPropertyName = "consultas";
            ColConsultas.HeaderText = "Cantidad Consultas";
            ColConsultas.Width = grilla1.Width / 6 - 30;
            grilla2.Columns.Add(ColConsultas);
        }

        private void generarGrillaListado3()
        {

           DataGridViewTextBoxColumn ColId = new DataGridViewTextBoxColumn();
            ColId.DataPropertyName = "id";
            ColId.HeaderText = "Id";
            ColId.Width = grilla1.Width / 8;
            grilla3.Columns.Add(ColId);

            DataGridViewTextBoxColumn ColNombre = new DataGridViewTextBoxColumn();
            ColNombre.DataPropertyName = "nombre";
            ColNombre.HeaderText = "Nombre Profesional";
            ColNombre.Width = grilla3.Width / 8;
            grilla3.Columns.Add(ColNombre);

            DataGridViewTextBoxColumn ColApellido = new DataGridViewTextBoxColumn();
            ColApellido.DataPropertyName = "apellido";
            ColApellido.HeaderText = "Apellido Profesional";
            ColApellido.Width = grilla3.Width / 8;
            grilla3.Columns.Add(ColApellido);

            DataGridViewTextBoxColumn ColTipoDoc = new DataGridViewTextBoxColumn();
            ColTipoDoc.DataPropertyName = "tipoDocumento";
            ColTipoDoc.HeaderText = "Tipo Documento";
            ColTipoDoc.Width = grilla3.Width / 8;
            grilla3.Columns.Add(ColTipoDoc);

            DataGridViewTextBoxColumn ColDocumento = new DataGridViewTextBoxColumn();
            ColDocumento.DataPropertyName = "documento";
            ColDocumento.HeaderText = "Documento";
            ColDocumento.Width = grilla3.Width / 8;
            grilla3.Columns.Add(ColDocumento);

            DataGridViewTextBoxColumn ColDesde = new DataGridViewTextBoxColumn();
            ColDesde.DataPropertyName = "desde";
            ColDesde.HeaderText = "Desde";
            ColDesde.Width = grilla3.Width / 8;
            grilla3.Columns.Add(ColDesde);

            DataGridViewTextBoxColumn ColHasta = new DataGridViewTextBoxColumn();
            ColHasta.DataPropertyName = "hasta";
            ColHasta.HeaderText = "Hasta";
            ColHasta.Width = grilla3.Width / 8;
            grilla3.Columns.Add(ColHasta);

            DataGridViewTextBoxColumn ColHorasTrabajadas = new DataGridViewTextBoxColumn();
            ColHorasTrabajadas.DataPropertyName = "horasTrabajadas";
            ColHorasTrabajadas.HeaderText = "Horas Trabajadas";
            ColHorasTrabajadas.Width = grilla3.Width / 8 - numeritoMagico;
            grilla3.Columns.Add(ColHorasTrabajadas);


        }
        private void generarGrillaListado4()
        {

            DataGridViewTextBoxColumn ColNombre = new DataGridViewTextBoxColumn();
            ColNombre.DataPropertyName = "nombre";
            ColNombre.HeaderText = "Nombre";
            ColNombre.Width = grilla4.Width / 4;
            grilla4.Columns.Add(ColNombre);

            DataGridViewTextBoxColumn ColTipo = new DataGridViewTextBoxColumn();
            ColTipo.DataPropertyName = "apellido";
            ColTipo.HeaderText = "Apellido";
            ColTipo.Width = grilla4.Width / 4;
            grilla4.Columns.Add(ColTipo);

            DataGridViewTextBoxColumn ColCant = new DataGridViewTextBoxColumn();
            ColCant.DataPropertyName = "bonosComprados";
            ColCant.HeaderText = "Total de bonos comprados";
            ColCant.Width = grilla4.Width / 4;
            grilla4.Columns.Add(ColCant);

            DataGridViewTextBoxColumn ColParientes = new DataGridViewTextBoxColumn();
            ColParientes.DataPropertyName = "tieneParientes";
            ColParientes.HeaderText = "Tiene Parientes";
            ColParientes.Width = grilla4.Width / 4 - numeritoMagico;
            grilla4.Columns.Add(ColParientes);
        }
        private void generarGrillaListado5()
        {

            DataGridViewTextBoxColumn ColNombre = new DataGridViewTextBoxColumn();
            ColNombre.DataPropertyName = "Especialidad";
            ColNombre.HeaderText = "Especialidad Médica";
            ColNombre.Width = grilla5.Width / 3;
            grilla5.Columns.Add(ColNombre);

            DataGridViewTextBoxColumn ColTipo = new DataGridViewTextBoxColumn();
            ColTipo.DataPropertyName = "tipoEspecialidad";
            ColTipo.HeaderText = "Tipo Especialidad Médica";
            ColTipo.Width = grilla5.Width / 3;
            grilla5.Columns.Add(ColTipo);

            DataGridViewTextBoxColumn ColCant = new DataGridViewTextBoxColumn();
            ColCant.DataPropertyName = "bonosUtilizados";
            ColCant.HeaderText = "Bonos utilizados";
            ColCant.Width = grilla5.Width / 3 - numeritoMagico;
            grilla5.Columns.Add(ColCant);
        }


    }
}
