using System;
using System.Windows.Forms;

namespace VISTA.PROYECTO
{
    public partial class VCalculadora : Form
    {
        VMenu menu;
        public VCalculadora(VMenu menu)
        {
            InitializeComponent();
            this.menu = menu;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu.Show();
        }
    }
}
