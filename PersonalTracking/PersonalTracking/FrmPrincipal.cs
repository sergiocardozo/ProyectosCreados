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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            FrmListaEmpleados listaEmpleados = new FrmListaEmpleados();
            this.Hide();
            listaEmpleados.ShowDialog();
            this.Visible = true;
        }

        private void btnTareas_Click(object sender, EventArgs e)
        {
            FrmListaTareas listaTareas = new FrmListaTareas();
            this.Hide();
            listaTareas.ShowDialog();
            this.Visible = true;
        }

        private void btnSalarios_Click(object sender, EventArgs e)
        {
            FrmListaSalario frm = new FrmListaSalario();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void btnPermisos_Click(object sender, EventArgs e)
        {
            FrmListaPermisos frm = new FrmListaPermisos();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void btnDepartamento_Click(object sender, EventArgs e)
        {
            FrmListadoDepartamento frm = new FrmListadoDepartamento();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void btnPuesto_Click(object sender, EventArgs e)
        {
            FrmListadoPuestos frm = new FrmListadoPuestos();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            FrmLogin frm = new FrmLogin();
            this.Hide();
            frm.ShowDialog();
        }

        private void FrmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
