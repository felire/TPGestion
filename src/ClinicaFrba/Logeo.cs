using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using ClinicaFrba.UtilConexion;
using ClinicaFrba.Menu;
using ClinicaFrba.LogeoPrimer;

namespace ClinicaFrba
{
    partial class Logeo : Form
    {
        public Logeo()
        {
            InitializeComponent();
        }

        private void logeoAccion(object sender, EventArgs e)
        {
            UTF8Encoding encoderHash = new UTF8Encoding();
            SHA256Managed hasher = new SHA256Managed();
            string passConSalt = password.Text + "MeRluSsA";
            byte[] bytesDeHasheo = hasher.ComputeHash(encoderHash.GetBytes(passConSalt));
            string pass = bytesDeHasheoToString(bytesDeHasheo).ToLower();
            string user = userName.Text;
            Usuario usuario = new Usuario(user, pass, this);
        }

        public void sinRoles()
        {
            MessageBox.Show("El usuario elegido no tiene roles asignados", "Error!", MessageBoxButtons.OK);
        }
        public void noContrasena()
        {
            MessageBox.Show("Usuario o contraseña incorrectos", "Error!", MessageBoxButtons.OK);
        }

        public void noHabilitado()
        {
            MessageBox.Show("Usuario no habilitado", "Error!", MessageBoxButtons.OK);
        }

        public void logeoExitoso(Usuario usuario)
        {
            MenuClinica menu = new MenuClinica(usuario);
            menu.Show();
            this.Hide();
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
