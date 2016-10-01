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
            
            this.nombreAfiliado.Text = afiliado.apellido + ", " + afiliado.nombre;
            turnos.AutoGenerateColumns = false;
            turnos.MultiSelect = false;
            generarGrid();
            this.turnos.DataSource = listaTurnos;
        }

        private void generarGrid()
        {
            DataGridViewTextBoxColumn ColDia = new DataGridViewTextBoxColumn();
            ColDia.DataPropertyName = "fecha";
            ColDia.HeaderText = "Día";
            ColDia.Width = 120;
            turnos.Columns.Add(ColDia);


            DataGridViewTextBoxColumn ColEspecialidad = new DataGridViewTextBoxColumn();
            ColEspecialidad.DataPropertyName = "especialidadNombre";
            ColEspecialidad.HeaderText = "Especialidad";
            ColEspecialidad.Width = 120;
            turnos.Columns.Add(ColEspecialidad);


            DataGridViewTextBoxColumn ColProfesional = new DataGridViewTextBoxColumn();
            ColProfesional.DataPropertyName = "profesionalNombre";
            ColProfesional.HeaderText = "Profesional";
            ColProfesional.Width = 120;
            turnos.Columns.Add(ColProfesional);
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            if (seleccionValida())
            {
                if (motivoCancelacion.Text == "")
                {
                    MessageBox.Show("Debe especificar el motivo de la cancelacion", "Error!", MessageBoxButtons.OK);
                }
                else
                {
                    if (motivoCancelacion.Text.Length <= 400)
                    {
                        Turno turno = (Turno)turnos.CurrentRow.DataBoundItem;

                        if ((turno.fecha.Date - DateTime.Now.Date).Days >= 1)
                        {
                            turno.cancelar(motivoCancelacion.Text, "Afiliado");
                            MessageBox.Show("Turno cancelado con exito!", "Exito!", MessageBoxButtons.OK);
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("No puede cancelar un turno el dia que lo tiene.", "Error!", MessageBoxButtons.OK);
                        }
                    }
                    else
                    {
                        MessageBox.Show("El mensaje no debe superar los 400 caracteres", "Error!", MessageBoxButtons.OK);
                    }
                }
                
            }
        }


        private Boolean seleccionValida()
        {
            if (turnos.SelectedRows.Count == 1)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Debe seleccionar un turno", "Error!", MessageBoxButtons.OK);
                return false;
            }
        }

    }
}