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
namespace ClinicaFrba
{
    public partial class Logeo : Form
    {
        public Logeo()
        {
            InitializeComponent();
        }

        private void logeoAccion(object sender, EventArgs e)
        {
            UTF8Encoding encoderHash = new UTF8Encoding();
            SHA256Managed hasher = new SHA256Managed();
            byte[] bytesDeHasheo = hasher.ComputeHash(encoderHash.GetBytes(password.Text));
            string pass = bytesDeHasheoToString(bytesDeHasheo).ToLower();
            string user = userName.Text;
            //MessageBox.Show("Usuario inactivo para acceder al sistema", "Error!", MessageBoxButtons.OK);
            Usuario usuario = new Usuario(user, pass, this);
            //UtilConexion.Prueba.Agregar("Pepe");
        }

        public void noContrasena()
        {
            MessageBox.Show("Usuario o contraseña incorrectos", "Error!", MessageBoxButtons.OK);
        }

        public void noHabilitado()
        {
            MessageBox.Show("Usuario no habilitado", "Error!", MessageBoxButtons.OK);
        }

        public void logeoExitoso()
        {
            MenuClinica menu = new MenuClinica();
            menu.Show();
            this.Hide();
        }

        private void Logeo_Load(object sender, EventArgs e)
        {

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
