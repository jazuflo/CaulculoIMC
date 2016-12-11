using System;
using System.Windows.Forms;

namespace SoftwareIMC
{
    public partial class frmIMC : Form
    {
        public frmIMC()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            nudIMC.Value = nudPeso.Value / (nudAltura.Value * nudAltura.Value);
            if (nudIMC.Value >= 40)
                txtCondición.Text = "Muy Severo";
            else if (nudIMC.Value >= 35)
                txtCondición.Text = "Severo";
            else if (nudIMC.Value >= 30)
                txtCondición.Text = "Moderado";
            else if (nudIMC.Value >= 25)
                txtCondición.Text = "Aumentado";
            else if (nudIMC.Value >= (decimal)18.5)
                txtCondición.Text = "Promedio";
        }
    }
}
