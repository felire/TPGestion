using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicaFrba.LogeoPrimer;
using ClinicaFrba.UtilConexion;

namespace ClinicaFrba.Menu
{
    partial class MenuClinica : Form
    {
        public Usuario usuario { get; set; }
        
        public MenuClinica(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
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
            labelFuncionalidades.Visible = true;
            List<Rol> roles = usuario.getRoles();
            comboElegirRol.DataSource = roles;
            comboElegirRol.DisplayMember = "nombreRol";
            comboElegirRol.ValueMember = "rol_id";
            comboElegirRol.SelectedIndex = 0;
        }

        private void mostrarMenuRol(Rol rol)
        {
            menuStrip1.Visible = true;
            List<Funcionalidad> funcionalidades = rol.getFuncionalidades();
            List<int> idFun = new List<int>();
            foreach (Funcionalidad funcionalidad in funcionalidades)
            {
                idFun.Add(funcionalidad.funcionalidad_id);
            }
            rolesToolStripMenuItem.Visible = idFun.Contains(1);
            afiliadoToolStripMenuItem.Visible = idFun.Contains(2);
            bonoToolStripMenuItem.Visible = idFun.Contains(4);
            pedirTurnoToolStripMenuItem.Visible = idFun.Contains(5);
            diagnosticoToolStripMenuItem.Visible = idFun.Contains(7);
            registrarLlegadaToolStripMenuItem.Visible = idFun.Contains(6);
            primerLogueoToolStripMenuItem.Visible = rol.nombreRol.Equals("Administrativo");
            if (idFun.Contains(8))
            {
                mostrarCancelacion(rol);
            }
            else
            {
                cancelarToolStripMenuItem.Visible = false;
                cancelarDiaOFranjaToolStripMenuItem.Visible = false;
            }
            listadoEstadisticoToolStripMenuItem.Visible = idFun.Contains(9);
            compraBono(rol);
            agendaProfesional.Visible = idFun.Contains(3);
        }

        private void mostrarCancelacion(Rol rol)
        {
            if (rol.nombreRol.Equals("Afiliado"))
            {
                cancelarToolStripMenuItem.Visible = true;
                cancelarDiaOFranjaToolStripMenuItem.Visible = false;
            }
            else
            {
                cancelarToolStripMenuItem.Visible = false;
                cancelarDiaOFranjaToolStripMenuItem.Visible = true;
            }
        }

        private void compraBono(Rol rol)
        {
            if (rol.nombreRol.Equals("Afiliado"))
            {
                comprarToolStripMenuItem.Visible = true;
                seleccionarAfiliado.Visible = false;
            }
            else
            {
                comprarToolStripMenuItem.Visible = false;
                seleccionarAfiliado.Visible = true;
            }
        }

        private void ocultarComboBox()
        {
            listaFunciones.Visible = false;
            textElegirRol.Visible = false;
            comboElegirRol.Visible = false;
            botonElegirRol.Visible = false;
            labelFuncionalidades.Visible = false;
        }

        private void listarFuncionalidades(List<Funcionalidad> funcionalidades)
        {
            foreach (Funcionalidad fun in funcionalidades)
            {
                listaFunciones.Items.Add(fun.descripcion);
            }
        }

        //Esto es un evento de cambio de elemento del combo box, cada vez que elige uno, se dispara
        private void cambioRolEvento(object sender, EventArgs e)
        {
            listaFunciones.Items.Clear();
            Rol rol = (Rol)comboElegirRol.SelectedItem;
            listarFuncionalidades(rol.getFuncionalidades());
        }

        private void rolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
 
        }

        private void altaToolStripMenuAF_Click(object sender, EventArgs e)
        {
            Abm_Afiliado.AfiliadoAlta formAf = new Abm_Afiliado.AfiliadoAlta();
            formAf.ShowDialog();
        }

        private void bajaToolStripMenuAF_Click(object sender, EventArgs e)
        {
            Abm_Afiliado.AfiliadoBajaPosta formAf = new Abm_Afiliado.AfiliadoBajaPosta();
            formAf.ShowDialog();
        }

        private void visualizacionAficlick(object sender, EventArgs e)
        {
            Abm_Afiliado.AfiliadoVisualiza formAf = new Abm_Afiliado.AfiliadoVisualiza();
            formAf.ShowDialog();
        }

        private void modificacionAficlick(object sender, EventArgs e)
        {
            Abm_Afiliado.ElegirAfiliado formAf = new Abm_Afiliado.ElegirAfiliado();
            formAf.ShowDialog();
        }

        private void logsAficlick(object sender, EventArgs e)
        {
            Abm_Afiliado.Logs formAf = new Abm_Afiliado.Logs();
            formAf.ShowDialog();
        }
        
        private void botonElegirRol_Click(object sender, EventArgs e)
        {
            Rol rol = (Rol)comboElegirRol.SelectedItem;
            ocultarComboBox();
            mostrarMenuRol(rol);
        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClinicaFrba.AbmRol.AltaRol rol = new ClinicaFrba.AbmRol.AltaRol();
            rol.Show();
        }

        private void modificaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClinicaFrba.AbmRol.ModificarRol rol = new ClinicaFrba.AbmRol.ModificarRol();
            rol.Show();
        }

        private void agendaProfesional_Click(object sender, EventArgs e)
        {
            ClinicaFrba.Registrar_Agenta_Medico.SeleccionarProfesional agenda = new ClinicaFrba.Registrar_Agenta_Medico.SeleccionarProfesional();
            agenda.Show();
        }

        private void bajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClinicaFrba.AbmRol.BajaRol rol = new ClinicaFrba.AbmRol.BajaRol();
            rol.Show();
        }

        private void seleccionarAfiliado_Click(object sender, EventArgs e)
        {
            ClinicaFrba.Compra_Bono.ElegirAfiliado form = new ClinicaFrba.Compra_Bono.ElegirAfiliado();
            form.Show();
        }

        private void comprarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Compra_Bono.CompraBono compraBono = new Compra_Bono.CompraBono(usuario.afiliado);
            compraBono.Show();
        }

        private void cancelarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cancelar_Atencion.CancelarAfiliado canc = new Cancelar_Atencion.CancelarAfiliado(usuario.afiliado);
            if (canc.listaTurnos.Count == 0)
            {
                MessageBox.Show("No tiene turnos disponibles para cancelar", "Error!", MessageBoxButtons.OK);
            }
            else
            {
                canc.Show();
            }          
        }

        private void cancelarDiaOFranjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClinicaFrba.Cancelar_Atencion.CancelarProfesional canc = new ClinicaFrba.Cancelar_Atencion.CancelarProfesional(usuario.profesional);
            canc.Show();
        }

        private void pedirTurnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Turno turno = new Turno();
            turno.afiliado = usuario.afiliado;
            Pedir_Turno.ElegirProfesional elegirProfesional = new Pedir_Turno.ElegirProfesional(turno);
            elegirProfesional.Show();
        }

        private void diagnosticoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClinicaFrba.Registro_Resultado.ElegirAfiliado elegir = new ClinicaFrba.Registro_Resultado.ElegirAfiliado(this.usuario.profesional);
            elegir.Show();
        }

        private void registrarLlegadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClinicaFrba.Registro_Llegada.RegLlegada regLlegada = new ClinicaFrba.Registro_Llegada.RegLlegada();
            regLlegada.Show();
        }

        private void listadoEstadisticoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClinicaFrba.Listados.Listado listado = new ClinicaFrba.Listados.Listado();
            listado.Show();
        }

        private void habilitarAfiliadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClinicaFrba.Abm_Afiliado.ElegirAfiliadoDeshabilitado desa = new ClinicaFrba.Abm_Afiliado.ElegirAfiliadoDeshabilitado();
            desa.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void primerLogueoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SeleccionUsuario sel = new SeleccionUsuario();
            sel.Show();
        }
    }
}
