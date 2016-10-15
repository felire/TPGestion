﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicaFrba.UtilConexion;

namespace ClinicaFrba.Abm_Afiliado
{
    partial class AfiliadoAltaConyuge : Form
    {
        public Afiliado afiliado { get; set; }
        public AfiliadoAlta formu { get; set; }

        public AfiliadoAltaConyuge(AfiliadoAlta formulario)
        {
            this.afiliado = new Afiliado();
            this.formu = formulario;
            InitializeComponent();
            this.cargarDatos();
        }

        private void cargarDatos()
        {

            comboBoxSexo.Items.Add("M");
            comboBoxSexo.Items.Add("F");
            comboBoxSexo.SelectedIndex = 0;

            comboBoxTDNI.Items.Add("");
            comboBoxTDNI.Items.Add("DNI");
            comboBoxTDNI.Items.Add("LD");
            comboBoxTDNI.Items.Add("LC");
            comboBoxTDNI.Items.Add("CI");
            comboBoxTDNI.SelectedIndex = 0;


        }
        private Boolean formularioValido()
        {
            uint i;
            string mensajeError = "";

            if (textBoxNom.Text == "")
            {
                mensajeError = "Complete el campo Nombre";
            }
            if (textBoxAp.Text == "")
            {
                mensajeError = mensajeError + "\r\n" + "Complete el campo Apellido";
            }
            if (!uint.TryParse(textBoxIDdni.Text, out i))
            {
                mensajeError = mensajeError + "\r\n" + "Ingrese un dni válido";
            }
            if (comboBoxTDNI.Text == "")
            {
                mensajeError = mensajeError + "\r\n" + "Seleccione el tipo de Dni";
            }
            if (textBoxIDdni.Text == "")
            {
                mensajeError = mensajeError + "\r\n" + "Complete la fecha de nacimiento";
            }
            if (textBoxMail.Text == "")
            {
                mensajeError = mensajeError + "\r\n" + "Complete el campo Mail";
            }
            if (!uint.TryParse(textBoxTel.Text, out i))
            {
                mensajeError = mensajeError + "\r\n" + "Ingrese un Telefono válido";
            }
            if (textBoxDire.Text == "")
            {
                mensajeError = mensajeError + "\r\n" + "Complete el domicilio";
            }

            if (mensajeError.Equals(""))
            {
                afiliado.apellido = textBoxAp.Text;
                afiliado.nombre = textBoxNom.Text;
                afiliado.documento = Decimal.Parse(textBoxIDdni.Text);
                afiliado.tipoDoc = comboBoxTDNI.Text;
                afiliado.estadoCivil = formu.afiliado.estadoCivil;
                afiliado.familiaresACargo = formu.afiliado.familiaresACargo;
                afiliado.fechaNac = fechaNac.Value;
                afiliado.mail = textBoxMail.Text;
                afiliado.telefono = Decimal.Parse(textBoxTel.Text);
                afiliado.domicilio = textBoxDire.Text;
                afiliado.sexo = comboBoxSexo.Text;
                return true;
            }
            else
            {
                MessageBox.Show(mensajeError, "Información");
                return false;
            }
        }

        private void buttonRegistrar_Click_1(object sender, EventArgs e)
        {
            if (formularioValido())
            {
                afiliado.registrarAltaConyuge(formu.afiliado);
                if (afiliado.id < 0)
                {
                    //existe
                }
                else
                {
                    MessageBox.Show("Conyuge registrado/a con exito", "Exito", MessageBoxButtons.OK);
                    this.Hide();
                    formu.preguntarHijos();
                }
            }
        }
    }
}
