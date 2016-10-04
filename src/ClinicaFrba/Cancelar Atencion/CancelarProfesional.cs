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

namespace ClinicaFrba.Cancelar_Atencion
{
    partial class CancelarProfesional : Form
    {
        private Profesional profesional;

        public CancelarProfesional(Profesional profesional)
        {
            InitializeComponent();
            this.profesional = profesional;
            this.nombre.Text = profesional.apellido + ", " + profesional.nombre;
            this.desde.Value = DateTime.Now;
            this.hasta.Value = DateTime.Now;
            this.dia.Value = DateTime.Now;
            this.desde.MinDate = DateTime.Now.AddDays(1);
            this.hasta.MinDate = DateTime.Now.AddDays(1);
            this.dia.MinDate = DateTime.Now.AddDays(1);
        }

        private void cancelarFranja_Click(object sender, EventArgs e)
        {
            if (desde.Value >= hasta.Value)
            {
                MessageBox.Show("Ingrese fechas correctas", "Error!", MessageBoxButtons.OK);
                return;
            }
            if (motivoCancelacion.Text.Length >= 400)
            {
                MessageBox.Show("El motivo de cancelacion tiene que tener menos de 400 caracteres", "Exito!", MessageBoxButtons.OK);
                return;
            }
            if (motivoCancelacion.Text.Equals(""))
            {
                MessageBox.Show("Debe ingresar un motivo de cancelacion", "Exito!", MessageBoxButtons.OK);
                return;
            }
            int resultado = profesional.cancelarFranja(desde.Value, hasta.Value, motivoCancelacion.Text, "Profesional");
            if (resultado == 1)
            {
                MessageBox.Show("Franja cancelada con exito", "Exito!", MessageBoxButtons.OK);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Los dias que selecciono no pertenecen a ninguna franja!", "Error!", MessageBoxButtons.OK);
            }
        }

        private void cancelarDia_Click(object sender, EventArgs e)
        {
            string mensajeDeError = "";
            if (motivoCancelacion.Text.Length >= 400)
            {
                mensajeDeError = "El motivo de cancelacion tiene que tener menos de 400 caracteres";
            }
            if (motivoCancelacion.Text.Equals(""))
            {
                mensajeDeError = mensajeDeError + "\r\n" + "Debe ingresar un motivo de cancelacion";
            }
            if (!mensajeDeError.Equals(""))
            {
                MessageBox.Show(mensajeDeError, "Error!", MessageBoxButtons.OK);
                return;
            }
            int resultado = profesional.cancelarDia(dia.Value, motivoCancelacion.Text, "Profesional");
            if (resultado == 1)
            {
                MessageBox.Show("Dia cancelado con exito", "Éxito!", MessageBoxButtons.OK);
                this.Hide();
            }
            else
            {
                MessageBox.Show("El dia seleccionado no pertenece a ninguna franja!", "Error!", MessageBoxButtons.OK);
            }
        }
    }
}
