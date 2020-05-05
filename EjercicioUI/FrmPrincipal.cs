using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioUI
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }
        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGestionLiquidacion frmGestionLiquidacion = new FrmGestionLiquidacion();
            frmGestionLiquidacion.Show();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultar frmConsultar = new FrmConsultar();
            frmConsultar.Show();
        }
    }
}
