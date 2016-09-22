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

namespace ClinicaFrba.AbmRol
{
    partial class ModificarFuncionalidadesRol : Form
    {
        public Rol rol { get; set; }
        public List<Funcionalidad> funcionalidadesDelRol { get; set;}
        public List<Funcionalidad> funcionalidades { get; set; }
        public ModificarFuncionalidadesRol(Rol rol)
        {
            InitializeComponent();
            this.rol = rol;
            this.funcionalidades = Funcionalidad.darTodasLasFuncionalidades();
            this.funcionalidadesDelRol = rol.funcionalidades;
            cargarPantalla();
        }


        private void cargarPantalla()
        {
            nombreDeRol.Text = rol.nombreRol;
            List<Funcionalidad> restoFuncionalidades = restoDeLasFuncionalidades();
            foreach(Funcionalidad funcionalidad in restoFuncionalidades)
            {
                funcionalidadesAgregables.Items.Add(funcionalidad.descripcion);
            }
            foreach (Funcionalidad funcionalidad in funcionalidadesDelRol)
            {
                funcionalidadesAgregadas.Items.Add(funcionalidad.descripcion);
            }
            
        }

        private void ModificarFuncionalidadesRol_Load(object sender, EventArgs e)
        {
            
        }


        private List<Funcionalidad> restoDeLasFuncionalidades()
        {
            List<int> idFunDelRol = new List<int>();
            foreach (Funcionalidad funcionalidadDelRol in funcionalidadesDelRol)
            {
                idFunDelRol.Add(funcionalidadDelRol.funcionalidad_id);
            }
            List<Funcionalidad> funci = new List<Funcionalidad>();
            foreach (Funcionalidad funcionalidad in funcionalidades)
            {
                if (!idFunDelRol.Contains(funcionalidad.funcionalidad_id))
                {
                    funci.Add(funcionalidad);
                }
            }
            return funci;
        }

        private void agregarFun_Click(object sender, EventArgs e)
        {
            int cantidadSeleccionadas = funcionalidadesAgregables.SelectedItems.Count;
            if (cantidadSeleccionadas > 0)
            {
                for (int i = 0; i < cantidadSeleccionadas; i++)
                {
                    ListViewItem descripcion = funcionalidadesAgregables.SelectedItems[0];
                    funcionalidadesAgregadas.Items.Add(descripcion.Text);
                    funcionalidadesAgregables.Items.Remove(descripcion);
                }

            }
        }

        private void quitarFun_Click(object sender, EventArgs e)
        {
            int cantidadSeleccionadas = funcionalidadesAgregadas.SelectedItems.Count;
            if (cantidadSeleccionadas > 0)
            {
                for (int i = 0; i < cantidadSeleccionadas; i++)
                {
                    ListViewItem descripcion = funcionalidadesAgregadas.SelectedItems[0];
                    funcionalidadesAgregables.Items.Add(descripcion.Text);
                    funcionalidadesAgregadas.Items.Remove(descripcion);
                }
            }
        }

        private void agregarRol_Click(object sender, EventArgs e)
        {
            if (formularioValido())
            {
                rol.actualizarFuncionalidades(funcionalidadesElegidas());
                MessageBox.Show("Funcionalidades modificadas con exito!", "Exito", MessageBoxButtons.OK);
                this.Hide();
            }
        }

        private List<Funcionalidad> funcionalidadesElegidas()
        {
            List<Funcionalidad> funcionalidadesAAgregar = new List<Funcionalidad>();
            foreach (Funcionalidad funci in funcionalidades)
            {
                foreach (ListViewItem item in funcionalidadesAgregadas.Items)
                {
                    if (funci.descripcion.Equals(item.Text))
                    {
                        funcionalidadesAAgregar.Add(funci);
                    }
                }
            }

            return funcionalidadesAAgregar;
        }

        private Boolean formularioValido()
        {
            if (funcionalidadesAgregadas.Items.Count == 0)
            {
                MessageBox.Show("No a asignado funcionalidades al rol", "Error!", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }


    }
}
