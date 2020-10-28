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
            this.cCalculadora = new CCalculadora();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            vMenu.Show();
        }

        private void VCalculadora_Load(object sender, EventArgs e)
        {

        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            
        }
    }
}
