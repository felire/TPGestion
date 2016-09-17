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
namespace ClinicaFrba.Menu
{
    partial class MenuClinica : Form
    {
        public MenuClinica(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        public Usuario usuario { get; set; }
        private void rolesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void merlusaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MenuClinica_Load(object sender, EventArgs e)
        {
            comboElegirRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            mostrarInicio(this.usuario);
        }

        private void mostrarInicio(Usuario usuario)
        {
            if (usuario.masDeUnRol())
            {
                ocultarMenu();
                mostrarComboBox(usuario);
            }
            else
            {
                ocultarComboBox();
                mostrarMenuRol(usuario.getRoles()[0]);
            }
        }

        private void ocultarMenu()
        {
            menuStrip1.Visible = false;
        }
        private void mostrarComboBox(Usuario usuario)
        {
            listaFunciones.Visible = true;
            textElegirRol.Visible = true;
            comboElegirRol.Visible = true;
            botonElegirRol.Visible = true;
            List<Rol> roles = usuario.getRoles();
            comboElegirRol.DataSource = roles;
            comboElegirRol.DisplayMember = "nombreRol";
            comboElegirRol.ValueMember = "rol_id";
            comboElegirRol.SelectedIndex = 0;
        }

        private void mostrarMenuRol(Rol rol)
        {
            menuStrip1.Visible = true;
            List<Funcionalidad> func = rol.getFuncionalidades();
            List<int> idFun = new List<int>();
            foreach(Funcionalidad fun in func){
                idFun.Add(fun.funcionalidad_id);
            }
            rolesToolStripMenuItem.Visible = idFun.Contains(1);
            afiliadoToolStripMenuItem.Visible = idFun.Contains(2);
            bonoToolStripMenuItem.Visible = idFun.Contains(4);
            turnoToolStripMenuItem.Visible = idFun.Contains(5);
            diagnosticoToolStripMenuItem.Visible = idFun.Contains(7);
            cancelarToolStripMenuItem.Visible = idFun.Contains(8);
            listadoEstadisticoToolStripMenuItem.Visible = idFun.Contains(9);
        }
        private void ocultarComboBox()
        {
            listaFunciones.Visible = false;
            textElegirRol.Visible = false;
            comboElegirRol.Visible = false;
            botonElegirRol.Visible = false;
        }
        private void listarFuncionalidades(List<Funcionalidad> funciones)
        {
            foreach(Funcionalidad fun in funciones){
                listaFunciones.Items.Add(fun.descripcion);
            }
        }


        //Esto es un evento de cambio de elemento del combo box, cada vez que elige uno, se dispara
        private void cambioRolEvento(object sender, EventArgs e)
        {
            listaFunciones.Items.Clear();
            Rol rol = (Rol) comboElegirRol.SelectedItem;            
            listarFuncionalidades(rol.getFuncionalidades());           
        }


        private void botonElegirRol_Click(object sender, EventArgs e)
        {
            Rol rol = (Rol)comboElegirRol.SelectedItem;
            ocultarComboBox();
            mostrarMenuRol(rol);
        }

        
        /*private void comboElegirRol_SelectionChangeCommitted(object sender, EventArgs e)
        {

            ComboBox senderComboBox = (ComboBox)sender;

            // Change the length of the text box depending on what the user has 
            // selected and committed using the SelectionLength property.
            
        }*/


    }
}
