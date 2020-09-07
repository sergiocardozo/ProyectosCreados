using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormDelegado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public delegate void fillTextBox(int x);
        string textValue = "";

        public void FillMathNote(int ExamNote)
        {
            textValue += "Tu nota de Matematica es: " + ExamNote + Environment.NewLine;
        }
        public void FillQuemistryNote(int ExamNote)
        {
            textValue += "Tu nota de Quimica es: " + ExamNote + Environment.NewLine;

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void ShowInTextBox()
        {
            txtValue.Text = textValue;
        }
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            fillTextBox fillTextBox = new fillTextBox(FillMathNote);
            fillTextBox += FillQuemistryNote;
            fillTextBox(81);
            fillTextBox -= FillMathNote;
            fillTextBox(60);
           
            ShowInTextBox();
        }
    }
}
