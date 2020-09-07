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
    public partial class FrmListaSalario : Form
    {
        public FrmListaSalario()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmSalario frm = new FrmSalario();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            FrmSalario frm = new FrmSalario();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }
    }
}
