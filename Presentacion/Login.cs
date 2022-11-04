using Presentacion.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.TxUsuario.Clear();
            this.TxContraseña.Clear();

        }

        private void BtnSesion_Click(object sender, EventArgs e)
        {
            if (TxUsuario.Text == "")
            {
                MessageBox.Show("El campo de usuario está vacio.", "Mensaje del sistema");
                TxUsuario.Focus();
            }
            else if (TxContraseña.Text == "")
            {
                MessageBox.Show("El campo de contraseña está vacio.", "Mensaje del sistema");
                TxContraseña.Focus();
            }
            else if (BoxUsuario.SelectedIndex < 0)
            {
                MessageBox.Show("El campo de rol está vacio.", "Mensaje del sistema");
                BoxUsuario.Focus();
            }
            else
            {
                //Pendiente de validación de rol
                if ((TxUsuario.Text == "Anibal") && (TxContraseña.Text == "Fuentes") && (BoxUsuario.Text == "Administrador"))
                {
                    FrmGanado frmGanado = new FrmGanado();
                    this.Hide();
                    frmGanado.Show();
                }
                else if ((TxUsuario.Text != "") && (TxContraseña.Text != "") && (BoxUsuario.Text == "Cliente"))
                {
                    MenuPrincipal menuPrincipal = new MenuPrincipal();
                    this.Hide();
                    menuPrincipal.Show();
                }
                else
                {
                    MessageBox.Show("Las credenciales no son correctas.");
                }
            }
        }

    }
}
