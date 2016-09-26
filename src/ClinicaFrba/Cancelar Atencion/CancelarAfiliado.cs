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


namespace ClinicaFrba.Cancelar_Atencion
{
    partial class CancelarAfiliado : Form
    {
        public Afiliado afiliado { get; set; }
        public List<Turno> listaTurnos { get; set; }

        public CancelarAfiliado(Afiliado afiliado)
        {
            InitializeComponent();
            this.afiliado = afiliado;
            this.listaTurnos = Turno.darTodosLosTurnosDe(afiliado);
            cargarDatos();
        }

        public void cargarDatos()
        {
            this.turnos.DataSource = listaTurnos;
            this.nombreAfiliado.Text = afiliado.apellido + ", " + afiliado.nombre;
        }
    }
}
