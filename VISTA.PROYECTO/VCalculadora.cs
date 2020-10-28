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

        private void btnSuma_Click(object sender, EventArgs e)
        {
            try {
                this.cCalculadora = new CCalculadora(Double.Parse(txtNumber1.Text), Double.Parse(txtNumber2.Text));
                double response = cCalculadora.sumarNumeros();
                lblResultado.Text = response.ToString();
            }
            catch (FormatException error) {
                MessageBox.Show("Ingresa numeros por favor" + error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }

        private void btnModulo_Click(object sender, EventArgs e)
        {
            try
            {
                this.cCalculadora = new CCalculadora(Double.Parse(txtNumber1.Text), Double.Parse(txtNumber2.Text));
                double response = cCalculadora.moduloNumeros();
                lblResultado.Text = response.ToString();
            }
            catch (FormatException error)
            {
                MessageBox.Show("Ingresa numeros por favor" + error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPotencia_Click(object sender, EventArgs e)
        {
            try
            {
                this.cCalculadora = new CCalculadora(Double.Parse(txtNumber1.Text), Double.Parse(txtNumber2.Text));
                double response = cCalculadora.potenciaNumeros();
                lblResultado.Text = response.ToString();
            }
            catch (FormatException error)
            {
                MessageBox.Show("Ingresa numeros por favor" + error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMayor_Click(object sender, EventArgs e)
        {
            try
            {
                this.cCalculadora = new CCalculadora(Double.Parse(txtNumber1.Text), Double.Parse(txtNumber2.Text));
                double response = cCalculadora.mayorNumeros();
                lblResultado.Text = response.ToString();
            }
            catch (FormatException error)
            {
                MessageBox.Show("Ingresa numeros por favor" + error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSerie1_Click(object sender, EventArgs e)
        {
            try
            {
                this.cCalculadora = new CCalculadora(Double.Parse(txtNumber1.Text), Double.Parse(txtNumber2.Text));
                lblResultado.Text = cCalculadora.serieNumeros1();
            }
            catch (FormatException error)
            {
                MessageBox.Show("Ingresa numeros por favor" + error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSerie2_Click(object sender, EventArgs e)
        {
            try
            {
                this.cCalculadora = new CCalculadora(Double.Parse(txtNumber1.Text), Double.Parse(txtNumber2.Text));
                lblResultado.Text = cCalculadora.serieNumeros2();
            }
            catch (FormatException error)
            {
                MessageBox.Show("Ingresa numeros por favor" + error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFactorial_Click(object sender, EventArgs e)
        {
            try
            {
                this.cCalculadora = new CCalculadora(Double.Parse(txtNumber1.Text), Double.Parse(txtNumber2.Text));
                double response = cCalculadora.factorialNumeros();
                lblResultado.Text = response.ToString();
            }
            catch (FormatException error)
            {
                MessageBox.Show("Ingresa numeros por favor" + error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAleatorio_Click(object sender, EventArgs e)
        {
            try
            {
                this.cCalculadora = new CCalculadora(Double.Parse(txtNumber1.Text), Double.Parse(txtNumber2.Text));
                int response = cCalculadora.aleatoriosNumeros();
                lblResultado.Text = response.ToString();
            }
            catch (FormatException error)
            {
                MessageBox.Show("Ingresa numeros por favor" + error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSumatoria_Click(object sender, EventArgs e)
        {
            try
            {
                this.cCalculadora = new CCalculadora(Double.Parse(txtNumber1.Text), Double.Parse(txtNumber2.Text));
                double response = cCalculadora.sumatoriaNumeros();
                lblResultado.Text = response.ToString();
            }
            catch (FormatException error)
            {
                MessageBox.Show("Ingresa numeros por favor" + error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAbsoluto_Click(object sender, EventArgs e)
        {
            try{
                this.cCalculadora = new CCalculadora(Double.Parse(txtNumber1.Text), Double.Parse(txtNumber2.Text));
                double response = cCalculadora.absolutoNumeros();
                lblResultado.Text = response.ToString();
            }
            catch (FormatException error)
            {
                MessageBox.Show("Ingresa numeros por favor" + error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
