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

namespace ClinicaFrba.Registro_Llegada
{
    partial class ElegirProfesional : Form
    {
        private List<Especialidad> especialidades;
        private List<Profesional> profesionalesActuales;
        private Profesional profesionalElegido;
        private Afiliado afiliado;
        private int bonoAUsar;

        public ElegirProfesional(Afiliado afiliado, int bonoAUsar)
        {
            InitializeComponent();
            especialidades = Especialidad.darTodasEspecialidades();
            profesionalesActuales = new List<Profesional>();
            this.afiliado = afiliado;
            this.bonoAUsar = bonoAUsar;
            cargarFormulario();
        }

        private void cargarFormulario()
        {
            Especialidad noElige = new Especialidad();
            noElige.codigo = -1;
            noElige.descripcion = "";
            List<Especialidad> listaConNoElige = new List<Especialidad>();
            listaConNoElige.Add(noElige);
            foreach (Especialidad esp in this.especialidades)
            {
                listaConNoElige.Add(esp);
            }
            comboEspecialidades.DataSource = listaConNoElige;
            comboEspecialidades.DisplayMember = "descripcion";
            comboEspecialidades.ValueMember = "codigo";
            comboEspecialidades.SelectedItem = noElige;

            tipoDoc.Items.Add("");
            tipoDoc.Items.Add("DNI");
            tipoDoc.Items.Add("LD");
            tipoDoc.Items.Add("LC");
            tipoDoc.Items.Add("CI");
            tipoDoc.SelectedIndex = 0;
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            profesionalesActuales.Clear();
            profesionalesActuales = Profesional.buscar(nombre.Text, apellido.Text, ((Especialidad)comboEspecialidades.SelectedItem).descripcion, (string)tipoDoc.SelectedItem, numeroDoc.Text);
            listaProfesionales.DataSource = profesionalesActuales;
            listaProfesionales.ClearSelection();
        }

        private Boolean seleccionValida()
        {
            if (listaProfesionales.SelectedRows.Count == 1)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Debe seleccionar un profesional", "Error!", MessageBoxButtons.OK);
                return false;
            }
        }

        private void Elegir(object sender, EventArgs e)
        {
            if (seleccionValida())
            {
                profesionalElegido = (Profesional)listaProfesionales.CurrentRow.DataBoundItem;
                ListarTurnos listarTurnos = new ListarTurnos(profesionalElegido, this.afiliado, bonoAUsar, this);
            }
        }
    }
}
