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
    public partial class FrmListaPermisos : Form
    {
        public FrmListaPermisos()
        {
            InitializeComponent();
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = General.isNumber(e);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = General.isNumber(e);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmPermisos frm = new FrmPermisos();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            FrmPermisos frm = new FrmPermisos();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }
    }
}
