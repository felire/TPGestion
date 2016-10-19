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

        public PrimerLogeo(Usuario unUsuario)
        {
            InitializeComponent();
            this.usuario = unUsuario;
            nombreUsuario.Text = usuario.usuario;
        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            if (formularioValido())
            {
                if (passNuevaT.Text == passRepeT.Text)
                {
                    UTF8Encoding encoderHash = new UTF8Encoding();
                    SHA256Managed hasher = new SHA256Managed();
                    string passConSalt = passNuevaT.Text + "MeRluSsA";
                    byte[] bytesDeHasheo = hasher.ComputeHash(encoderHash.GetBytes(passConSalt));
                    string pass = bytesDeHasheoToString(bytesDeHasheo).ToLower();
                    usuario.actualizarPass(pass);
                    MessageBox.Show("El usuario ya puede loguearse normalmente", "Éxito", MessageBoxButtons.OK);
                    this.Close();
                }           
                else
                {
                    MessageBox.Show("Las contraseñas ingresadas no coinciden", "Error!", MessageBoxButtons.OK);
                    passNuevaT.Clear();
                    passRepeT.Clear();
                }
            }
        }

        private Boolean formularioValido()
        {
            string mensajeError = "";
            if (passNuevaT.Text.Length == 0)
            {
                mensajeError = "Ingrese su nueva contraseña";
            }
            if (passRepeT.Text.Length == 0)
            {
                mensajeError = mensajeError + "\r\n" + "repita su contraseña";
            }
            if (mensajeError.Equals(""))
            {
                return true;
            }
            else
            {
                MessageBox.Show(mensajeError, "Información");
                return false;
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
