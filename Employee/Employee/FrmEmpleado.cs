using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Employee
{
    public partial class FrmEmpleado : Form
    {
        public FrmEmpleado()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            Empleado empleadoDetalles = new Empleado();
            empleadoDetalles.EmpleadoAños = Convert.ToInt32(txtAños.Text);
            empleadoDetalles.EmpleadoNombre = txtNombre.Text;
            empleadoDetalles.EmpleadoPosicion = txtPosicion.Text;
            FrmEmpleadoDetalles frmEmpleadoDetalles = new FrmEmpleadoDetalles();

            frmEmpleadoDetalles.lblAños.Text = empleadoDetalles.EmpleadoAños.ToString();
            frmEmpleadoDetalles.lblNombre.Text = empleadoDetalles.EmpleadoNombre;
            frmEmpleadoDetalles.lblPosicion.Text = empleadoDetalles.EmpleadoPosicion;
            frmEmpleadoDetalles.ShowDialog();
        }
    }
}
