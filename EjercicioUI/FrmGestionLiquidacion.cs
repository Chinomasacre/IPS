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
    public partial class FrmGestionLiquidacion : Form
    {
        LiquidacionService liquidacionService = new LiquidacionService();
        public FrmGestionLiquidacion()
        {
            InitializeComponent();
            lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblsalarioD.Visible = false;
            txtSalarioDevengado.Visible = false;
        }


        private void cmbtipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbtipo.Text == "SUBSIDIADO")
            {
                lblsalarioD.Visible = false;
                txtSalarioDevengado.Visible = false;
            }
            else
            {
                lblsalarioD.Visible = true;
                txtSalarioDevengado.Visible = true;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Liquidacion liquidacion;
            if (cmbtipo.Text == "SUBSIDIADO")
            {
                liquidacion = new RegimenSubsidiado();
            }
            else
            {
                liquidacion = new RegimenContributivo();
                liquidacion.SalarioDevengado = Convert.ToDecimal(txtSalarioDevengado.Text);
            }
            liquidacion.Fecha = DateTime.Now;
            liquidacion.Numero = txtNumero.Text;
            liquidacion.Identificacion = txtIdentificacion.Text;
            liquidacion.Nombre = txtNombre.Text;
            liquidacion.Tipo = cmbtipo.Text;
            liquidacion.ValorServicio = Convert.ToDecimal(txtValorServicio.Text);
            liquidacion.calcularCuotaModerada();

            string Mensaje = liquidacionService.Guardar(liquidacion);
            MessageBox.Show(Mensaje, "Mensaje de Guardado", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            Limpiar();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            RespuestaBusqueda respuestaBusqueda;
            respuestaBusqueda = liquidacionService.Buscar(txtNumero.Text);
            if (respuestaBusqueda.liquidacion == null)
            {
                btnEditar.Enabled = false;
                btnEliminar.Enabled = false;
            }
            else
            {
                btnEditar.Enabled = true;
                btnEliminar.Enabled = true;
                lblsalarioD.Visible = true;
                txtSalarioDevengado.Visible = true;

                lblFecha.Text = respuestaBusqueda.liquidacion.Fecha.ToString("dd/MM/yyyy");
                txtNumero.Text = respuestaBusqueda.liquidacion.Numero;
                txtIdentificacion.Text = respuestaBusqueda.liquidacion.Identificacion;
                txtNombre.Text = respuestaBusqueda.liquidacion.Nombre;
                cmbtipo.Text = respuestaBusqueda.liquidacion.Tipo;
                txtValorServicio.Text = Convert.ToString(respuestaBusqueda.liquidacion.ValorServicio);
                txtSalarioDevengado.Text = Convert.ToString(respuestaBusqueda.liquidacion.SalarioDevengado);
             
                btnRegistrar.Enabled = false;
            }
            MessageBox.Show(respuestaBusqueda.Mensaje, "Mensaje de Busqueda", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
           
        }
        public void Limpiar()
        {
            lblFecha.Text = DateTime.Now.ToLongDateString();
            txtNumero.Text="";
            txtIdentificacion.Text = "";
            txtNombre.Text = "";
            cmbtipo.Text = "";
            txtValorServicio.Text = "";
            lblsalarioD.Visible = false;
            txtSalarioDevengado.Visible = false;
            btnRegistrar.Enabled = true;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Liquidacion liquidacion;
            RespuestaBusqueda respuestaBusqueda ;
            respuestaBusqueda = liquidacionService.Buscar(txtNumero.Text);
            if (cmbtipo.Text == "SUBSIDIADO")
            {
                liquidacion = new RegimenSubsidiado();
            }
            else
            {
                liquidacion = new RegimenContributivo();
                liquidacion.SalarioDevengado = Convert.ToDecimal(txtSalarioDevengado.Text);
            }
            liquidacion.Fecha = respuestaBusqueda.liquidacion.Fecha;
            liquidacion.Numero = respuestaBusqueda.liquidacion.Numero;
            liquidacion.Identificacion = respuestaBusqueda.liquidacion.Identificacion;
            liquidacion.Nombre = respuestaBusqueda.liquidacion.Nombre;
            liquidacion.Tipo = cmbtipo.Text;
            liquidacion.ValorServicio = respuestaBusqueda.liquidacion.ValorServicio;
            liquidacion.calcularCuotaModerada();

            string Mensaje = liquidacionService.Editar(liquidacion);
            MessageBox.Show(Mensaje, "Mensaje de Editar", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            Limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string Mensaje = liquidacionService.Eliminar(txtNumero.Text);
            MessageBox.Show(Mensaje, "Mensaje de Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            Limpiar();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }
    }
}
