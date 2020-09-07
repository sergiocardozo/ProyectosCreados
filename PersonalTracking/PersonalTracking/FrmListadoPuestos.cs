using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalTracking
{
    public partial class FrmListadoPuestos : Form
    {
        public FrmListadoPuestos()
        {
            InitializeComponent();
        }

        
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmPuesto frm = new FrmPuesto();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            FrmPuesto frm = new FrmPuesto();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }
    }
}
