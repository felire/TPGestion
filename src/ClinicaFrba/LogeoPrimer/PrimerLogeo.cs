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
using System.Security.Cryptography;

namespace ClinicaFrba.LogeoPrimer
{
    partial class PrimerLogeo : Form
    {
        private Usuario usuario;
        private Logeo log;

        public PrimerLogeo(Usuario usuario, Logeo log)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.log = log;
            nombreUsuario.Text = usuario.usuario;
        }

        private void Entrar_Click(object sender, EventArgs e)
        {
            if (passNuevaT.Text == passRepeT.Text)
            {
                UTF8Encoding encoderHash = new UTF8Encoding();
                SHA256Managed hasher = new SHA256Managed();
                string passConSalt = passNuevaT.Text + "MeRluSsA";
                byte[] bytesDeHasheo = hasher.ComputeHash(encoderHash.GetBytes(passConSalt));
                string pass = bytesDeHasheoToString(bytesDeHasheo).ToLower();
                usuario.actualizarPass(pass);
                this.Hide();
                log.logeoExitoso(usuario);
            }
            else
            {
                MessageBox.Show("Las contraseñas ingresadas no coinciden", "Error!", MessageBoxButtons.OK);
            }
        }

        private string bytesDeHasheoToString(byte[] array)
        {
            StringBuilder salida = new StringBuilder("");
            for (int i = 0; i < array.Length; i++)
            {
                salida.Append(array[i].ToString("X2"));
            }
            return salida.ToString();
        }

    }
}
