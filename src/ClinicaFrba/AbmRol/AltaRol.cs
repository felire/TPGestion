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

namespace ClinicaFrba.AbmRol
{
    partial class AltaRol : Form
    {
        private List<Funcionalidad> funcionalidades;
 
        public AltaRol()
        {
            InitializeComponent();
            funcionalidades = Funcionalidad.darTodasLasFuncionalidades();
            cargarOpciones();
        }

        private void cargarOpciones()
        {
            foreach (Funcionalidad funcionalidad in funcionalidades)
            {
                funcionalidadesAgregables.Items.Add(funcionalidad.descripcion);
            }
        }

        private void agregarFun_Click(object sender, EventArgs e)
        {
            int cantidadSeleccionadas = funcionalidadesAgregables.SelectedItems.Count;
            for (int i = 0; i < cantidadSeleccionadas; i++)
            {
                ListViewItem descripcion = funcionalidadesAgregables.SelectedItems[0];
                funcionalidadesAgregadas.Items.Add(descripcion.Text);
                funcionalidadesAgregables.Items.Remove(descripcion);  
            }
        }

        private void quitarFun_Click(object sender, EventArgs e)
        {
            int cantidadSeleccionadas = funcionalidadesAgregadas.SelectedItems.Count;
            for (int i = 0; i < cantidadSeleccionadas; i++)
            {
                ListViewItem descripcion = funcionalidadesAgregadas.SelectedItems[0];
                funcionalidadesAgregables.Items.Add(descripcion.Text);
                funcionalidadesAgregadas.Items.Remove(descripcion);
            }
        }

        private void agregarRol_Click(object sender, EventArgs e)
        {
            if (formularioValido())
            {
                ClinicaFrba.UtilConexion.Rol rol = new ClinicaFrba.UtilConexion.Rol();
                rol.nombreRol = nombreElegido.Text;
                rol.funcionalidades = funcionalidadesElegidas();
                if (rol.darAlta())
                {
                    MessageBox.Show("Rol agregado con exito!", "Exito", MessageBoxButtons.OK);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ya existe un Rol con ese nombre", "Error!", MessageBoxButtons.OK);
                }
            }
        }

        private Boolean formularioValido()
        {
            string mensajeDeError = "";
            if (nombreElegido.Text == "")
            {
                mensajeDeError = "No a asignado un nombre al rol";
            }
            if (funcionalidadesAgregadas.Items.Count == 0)
            {
                mensajeDeError = mensajeDeError + "\r\n" + "No a asignado funcionalidades al rol";
            }
            if (mensajeDeError.Equals(""))
            {
                return true;
            }
            else
            {
                MessageBox.Show(mensajeDeError, "Error!", MessageBoxButtons.OK);
                return false;
            }
        }

        private List<Funcionalidad> funcionalidadesElegidas()
        {
            List<Funcionalidad> funcionalidadesAAgregar = new List<Funcionalidad>();
            foreach (ListViewItem item in funcionalidadesAgregadas.Items)
            {
                foreach (Funcionalidad funcionalidad in funcionalidades)
                {
                    if (funcionalidad.descripcion.Equals(item.Text))
                    {
                        funcionalidadesAAgregar.Add(funcionalidad);
                        break;
                    }
                }
            }
            return funcionalidadesAAgregar;
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
