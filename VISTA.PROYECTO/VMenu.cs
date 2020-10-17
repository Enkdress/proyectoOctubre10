using System.Windows.Forms;

namespace VISTA.PROYECTO
{
    public partial class VMenu : Form
    {
        public VMenu()
        {
            InitializeComponent();
        }

        private void btnCalculadora_Click(object sender, System.EventArgs e)
        {
            VCalculadora calculadora = new VCalculadora(this);
            calculadora.Show();
            this.Hide();
        }

        private void btnAcercade_Click(object sender, System.EventArgs e)
        {
            VAcercade acercade = new VAcercade();
            acercade.Show();
        }

        private void btnSalir_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
