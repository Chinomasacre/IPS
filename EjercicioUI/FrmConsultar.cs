using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Entyti;
using static BLL.LiquidacionService;

namespace EjercicioUI
{
    public partial class FrmConsultar : Form
    {
        LiquidacionService liquidacionService = new LiquidacionService();

        public FrmConsultar()
        {
            InitializeComponent();
            cmbTipo.Enabled = false;
            DTPInicio.Enabled = false;
            DTPFinal.Enabled = false;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            RespuestaConsulta respuestaConsulta ;
            dataGridView1.DataSource = null;

            if (radioButton1.Checked == true)
            {
                string Tipo = cmbTipo.Text;
                if (Tipo == "SUBSIDIADO")
                {
                    respuestaConsulta = liquidacionService.ConsultarxTipo(Tipo);
                }
                else if (Tipo == "CONTRIBUTIVO")
                {
                    respuestaConsulta = liquidacionService.ConsultarxTipo(Tipo);
                }
                else
                {
                    respuestaConsulta = liquidacionService.Consultar();
                }
            }
            else
            {
                DateTime FechaInicio, FechaFinal;
                FechaInicio = DTPInicio.Value;
                FechaFinal= DTPFinal.Value;

                respuestaConsulta = liquidacionService.ConsultarxFecha(FechaInicio, FechaFinal);
                
            }

            dataGridView1.DataSource = respuestaConsulta.ListaLiquidaciones;

            txtCanTodos.Text = liquidacionService.TotalCantidad().ToString();
            txtCanRC.Text = liquidacionService.TotalCantidadTipo("CONTRIBUTIVO").ToString();
            txtCantRS.Text = liquidacionService.TotalCantidadTipo("SUBSIDIADO").ToString();

            txtTotalTodos.Text = liquidacionService.ValorTotal().ToString();
            txtTotalRC.Text = liquidacionService.ValorTotalTipo("CONTRIBUTIVO").ToString();
            txtTotalRS.Text = liquidacionService.ValorTotalTipo("SUBSIDIADO").ToString();
            
            MessageBox.Show(respuestaConsulta.Mensaje, "Mensaje de Consulta", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            cmbTipo.Enabled = true;
            DTPInicio.Enabled = false;
            DTPFinal.Enabled = false;
            btnConsultar.Enabled = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            cmbTipo.Enabled = false;
            DTPInicio.Enabled = true;
            DTPFinal.Enabled = true;
            btnConsultar.Enabled = true;
        }

        private void txtNombre_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtNombre.Text.Trim() != "")
            {
                dataGridView1.DataSource = liquidacionService.ConsultarNombre(txtNombre.Text);

                txtCanTodos.Text = liquidacionService.TotalCantidad().ToString();
                txtCanRC.Text = liquidacionService.TotalCantidadTipo("CONTRIBUTIVO").ToString();
                txtCantRS.Text = liquidacionService.TotalCantidadTipo("SUBSIDIADO").ToString();

                txtTotalTodos.Text = liquidacionService.ValorTotal().ToString();
                txtTotalRC.Text = liquidacionService.ValorTotalTipo("CONTRIBUTIVO").ToString();
                txtTotalRS.Text = liquidacionService.ValorTotalTipo("SUBSIDIADO").ToString();
            }
            else
            {
                int vacio = 0;
                dataGridView1.DataSource = null;
                txtCanTodos.Text = vacio.ToString();
                txtCanRC.Text = vacio.ToString();
                txtCantRS.Text = vacio.ToString();

                txtTotalTodos.Text = vacio.ToString();
                txtTotalRC.Text = vacio.ToString();
                txtTotalRS.Text = vacio.ToString();
            }
        }
    }
}
