using System;
using System.Windows.Forms;
using CONTROL.PROYECTO;

namespace VISTA.PROYECTO
{
    public partial class VCalculadora : Form
    {
        VMenu vMenu;
        CCalculadora cCalculadora;
        public VCalculadora(VMenu menu)
        {
            InitializeComponent();
            this.vMenu = menu;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            vMenu.Show();
        }

        private void ejecutarAccion(String response)
        {
            try
            {
                lblResultado.Text = response;
            }
            catch ( FormatException error )
            {
                MessageBox.Show("Ingresa numeros por favor. \nError: " + error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            this.cCalculadora = new CCalculadora(Double.Parse(txtNumber1.Text), Double.Parse(txtNumber2.Text));
            ejecutarAccion(cCalculadora.sumarNumeros().ToString());
        }

        private void btnModulo_Click(object sender, EventArgs e)
        {
            this.cCalculadora = new CCalculadora(Double.Parse(txtNumber1.Text), Double.Parse(txtNumber2.Text));
            ejecutarAccion(cCalculadora.moduloNumeros().ToString());
        }

        private void btnPotencia_Click(object sender, EventArgs e)
        {
            this.cCalculadora = new CCalculadora(Double.Parse(txtNumber1.Text), Double.Parse(txtNumber2.Text));
            ejecutarAccion(cCalculadora.potenciaNumeros().ToString());
        }

        private void btnMayor_Click(object sender, EventArgs e)
        {
            this.cCalculadora = new CCalculadora(Double.Parse(txtNumber1.Text), Double.Parse(txtNumber2.Text));
            ejecutarAccion(cCalculadora.mayorNumeros().ToString());
        }

        private void btnSerie1_Click(object sender, EventArgs e)
        {
            this.cCalculadora = new CCalculadora(Double.Parse(txtNumber1.Text), Double.Parse(txtNumber2.Text));
            ejecutarAccion(cCalculadora.serieNumeros1());
        }

        private void btnSerie2_Click(object sender, EventArgs e)
        {
            this.cCalculadora = new CCalculadora(Double.Parse(txtNumber1.Text), Double.Parse(txtNumber2.Text));
            ejecutarAccion(cCalculadora.serieNumeros2());
        }

        private void btnFactorial_Click(object sender, EventArgs e)
        {
            this.cCalculadora = new CCalculadora(Double.Parse(txtNumber1.Text), Double.Parse(txtNumber2.Text));
            ejecutarAccion(cCalculadora.factorialNumeros().ToString());
        }

        private void btnAleatorio_Click(object sender, EventArgs e)
        {
            this.cCalculadora = new CCalculadora(Double.Parse(txtNumber1.Text), Double.Parse(txtNumber2.Text));
            try
            {
                ejecutarAccion(cCalculadora.aleatoriosNumeros().ToString());
            } catch (ArgumentOutOfRangeException err)
            {
                MessageBox.Show("Error: " + err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSumatoria_Click(object sender, EventArgs e)
        {
            this.cCalculadora = new CCalculadora(Double.Parse(txtNumber1.Text), Double.Parse(txtNumber2.Text));
            ejecutarAccion(cCalculadora.sumatoriaNumeros().ToString());
        }

        private void btnAbsoluto_Click(object sender, EventArgs e)
        {
            this.cCalculadora = new CCalculadora(Double.Parse(txtNumber1.Text), Double.Parse(txtNumber2.Text));
            ejecutarAccion(cCalculadora.absolutoNumeros().ToString());
        }
    }
}
