using System;
using System.Windows.Forms;

namespace Presentacion.Formularios
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            GanadosClientes ganadosCliente = new GanadosClientes();
            this.Hide();
            ganadosCliente.Show();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {

        }

        private void MenuPrincipal_Load(object sender, System.EventArgs e)
        {

        }

        private void MenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogo = MessageBox.Show("¿Desea cerrar el programa?",
            "Cerrar el programa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogo == DialogResult.No) { e.Cancel = true; }
            else
            {
                e.Cancel = false; Environment.Exit(1);
            }
        }
    }
}
