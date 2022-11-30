using Entidad.Login;
using Negocio;
using Presentacion.Formularios;
using System;
using System.Data;
using System.Linq;
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
            ValidarCredenciales();
            //if (TxUsuario.Text == "")
            //{
            //    MessageBox.Show("El campo de usuario está vacio.", "Mensaje del sistema");
            //    TxUsuario.Focus();
            //}
            //else if (TxContraseña.Text == "")
            //{
            //    MessageBox.Show("El campo de contraseña está vacio.", "Mensaje del sistema");
            //    TxContraseña.Focus();
            //}
            //else if (BoxUsuario.SelectedIndex < 0)
            //{
            //    MessageBox.Show("El campo de rol está vacio.", "Mensaje del sistema");
            //    BoxUsuario.Focus();
            //}
            //else
            //{
            //    //Pendiente de validación de rol
            //    if ((TxUsuario.Text == "Anibal") && (TxContraseña.Text == "Fuentes") && (BoxUsuario.Text == "Administrador"))
            //    {
            //        FrmGanado frmGanado = new FrmGanado();
            //        this.Hide();
            //        frmGanado.Show();
            //    }
            //    else if ((TxUsuario.Text != "") && (TxContraseña.Text != "") && (BoxUsuario.Text == "Cliente"))
            //    {
            //        MenuPrincipal menuPrincipal = new MenuPrincipal();
            //        this.Hide();
            //        menuPrincipal.Show();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Las credenciales no son correctas.");
            //    }
            //}
        }

        private void ValidarCredenciales()
        {
            try
            {
                Usuario usuario = new L_Usuario().Validar().Where(u => u.User == TxUsuario.Text && u.Contraseña == TxContraseña.Text).FirstOrDefault();

                if (TxUsuario.Text == "")
                {
                    MessageBox.Show("El campo del documento está vacío.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TxUsuario.Focus();
                }
                else if (TxContraseña.Text == "")
                {
                    MessageBox.Show("El campo de contraseña está vacío.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TxContraseña.Focus();
                }
                else
                {
                    if (usuario != null)
                    {
                        if (usuario.TipoUsuario == true)
                        {
                            FrmGanado frmGanado = new FrmGanado();
                            this.Hide();
                            frmGanado.Show();
                        }
                        else
                        {
                            Comprar comprar = new Comprar(usuario);
                            this.Hide();
                            comprar.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Credenciales incorrectas, verifique e intentelo nuevamente.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
