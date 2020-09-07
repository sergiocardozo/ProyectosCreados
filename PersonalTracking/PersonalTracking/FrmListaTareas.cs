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
    public partial class FrmListaTareas : Form
    {
        public FrmListaTareas()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = General.isNumber(e);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmListaTareas_Load(object sender, EventArgs e)
        {
            panelAdmin.Hide();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmTareas frm = new FrmTareas();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            FrmTareas frm = new FrmTareas();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }
    }
}
