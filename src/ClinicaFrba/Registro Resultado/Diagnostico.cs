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

namespace ClinicaFrba.Registro_Resultado
{
    partial class Diagnostico : Form
    {
        public Afiliado afiliado { get; set; }
        public Profesional profesional { get; set; }
        public Diagnostico(Afiliado afiliado, Profesional profesional)
        {
            InitializeComponent();
            this.afiliado = afiliado;
            this.profesional = profesional;
        }
    }
}
