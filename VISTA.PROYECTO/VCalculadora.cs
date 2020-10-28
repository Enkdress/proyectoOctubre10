using System;
using System.Windows.Forms;
using CONTROL.PROYECTO;

namespace VISTA.PROYECTO
{
    public partial class VCalculadora : Form
    {
        VMenu vMenu;
        CMenu cMenu;
        public VCalculadora(VMenu menu)
        {
            InitializeComponent();
            this.vMenu = menu;
            this.cMenu = new CMenu();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            vMenu.Show();
        }
    }
}
