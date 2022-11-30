using Datos;
using Entidad;
using Negocio;
using Negocio.implementaciones;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Presentacion.Formularios
{
    public partial class FrmGanado : Form
    {
        public FrmGanado()
        {
            InitializeComponent();
        }
        
        Ganado ganado = new Ganado();
        #region LOAD
        int posicion = 0;

        GanadoImpl impl = new GanadoImpl();
        private void FrmGanado_Load(object sender, EventArgs e)
        {
            //Contador.Text = "Ganados registrados: " + impl.Listar().Count();
            //ListaGanado.DataSource = impl.Listar();
            LlenarDatos();
        }
     
        
        private void  LlenarDatos()

        {

            BoxEstado.Items.Add(new OpcionCombo() { valor = 1, texto = "Disponible" });
            BoxEstado.Items.Add(new OpcionCombo() { valor = 2, texto = "Vendido" });
            BoxEstado.DisplayMember = "Texto";
            BoxEstado.ValueMember = "valor";
            BoxEstado.SelectedIndex = 0;

            L_Ganado LogicaGanados = new L_Ganado();
            List<Ganado> Ganados = LogicaGanados.Listar();

            //Llenar tabla
            foreach (Ganado item in Ganados)
            {
                ListaGanado.Rows.Add(new object[] {"",item.IdGanado,item.Raza,item.Sexo,item.Peso,item.PesoVenta,item.MesesRecuperacion,item.PrecioCompra,item.PrecioVenta, item.FechaRegistro,item.Referencia,


                    item.Estado == true ? 1 : 0,
                    item.Estado == true ? "Activo" : "Inactivo" 
                });
            }



            
        }
      

        #endregion

        #region BOTONES CRUD
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            AgregarGanado();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            EliminarGanado();
        }
        #endregion

        #region FUNCIONES

        private void CrearGanado()
        {

            ganado.IdGanado = new Random().Next(0, 10000);
            ganado.Raza = BoxRaza.Text.ToString().ToUpperInvariant().ToString();
            ganado.Sexo = char.Parse(BoxSexo.Text.ToString().ToUpperInvariant());
            ganado.Peso = decimal.Parse(TxPeso.Text.ToUpperInvariant().ToString());
            ganado.MesesRecuperacion = int.Parse(BoxMeses.Text.ToString().ToUpperInvariant().ToString());
            ganado.PesoVenta = decimal.Parse(TxPesoVenta.Text.ToUpperInvariant().ToString());
            ganado.PrecioCompra = decimal.Parse(TxCompra.Text.ToUpperInvariant().ToString());
            ganado.PrecioVenta = decimal.Parse(TxCompra.Text.ToUpperInvariant().ToString());
            ganado.Estado = true;
            ganado.FechaRegistro = DateTime.Today.ToShortDateString().ToString();
            impl.Agregar(ganado);
            LlenarDatos();
            //ListaGanado.DataSource = null;
            //ListaGanado.DataSource = impl.Listar();
        }
        private bool ValidarCamposVacios()
        {
            if (TxPeso.Text == "")
            {
                MessageBox.Show("El campo de peso está vacio.", "Mensaje del sistema",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxPeso.Focus();
                return true;
            }
            else
            {
                //No hay campos vacíos
                return false;
            }
        }
        private void AgregarGanado()
        {
            if (BtnAgregar.Text == "Agregar")
            {
                try
                {
                    if (ValidarCamposVacios() == true)
                    {
                        //No agrega el producto y muestra las alertas correspondientes
                    }
                    else
                    {
                        DialogResult resultado = MessageBox.Show("Desea agregar este ganado al registro?", "ATENCIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (resultado == DialogResult.Yes)
                        {
                            //Creamos el ganado
                            CrearGanado();

                            //MessageBox.Show("Producto creada exitosamente.", "Mensaje del sistema",
                            //MessageBoxButtons.OK, MessageBoxIcon.Information);

                            Contador.Text = "Ganados registrados:: " + impl.Listar().Count;

                        }
                        else
                        {
                            MessageBox.Show("Proceso cancelado.", "Mensaje del sistema",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Mensaje del sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                //EditarGanado();
            }
        }
        private void FiltrarBusqueda()
        {
            if (TxConsultar.Text != "")
            {
                ListaGanado.CurrentCell = null;

                foreach (DataGridViewRow row in ListaGanado.Rows) { row.Visible = false; }

                foreach (DataGridViewRow row in ListaGanado.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if ((cell.Value.ToString().ToUpperInvariant().IndexOf(TxConsultar.Text.ToUpperInvariant()) == 0))
                        {
                            row.Visible = true;
                            break;
                        }
                    }
                }
            }
            else
            {
                LlenarDatos();
                //ListaGanado.DataSource = null;
                //ListaGanado.DataSource = impl.Listar();
            }
        }
        private void EliminarGanado()
        {
            try
            {
                if (impl.Listar().Count < 0)
                {
                    MessageBox.Show("No hay registros de ganados.", "Mensaje del sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DialogResult resultado = MessageBox.Show("Desea eliminar el ganado "
                + ListaGanado[1, posicion].Value + " del registro?", "Mensaje del sistema",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resultado == DialogResult.Yes)
                    {
                        impl.Eliminar(impl.Listar()[posicion]);

                        //MessageBox.Show("Producto eliminado correctamente.", "Mensaje del sistema",
                        //MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ListaGanado.DataSource = null;
                        ListaGanado.DataSource = impl.Listar();
                        ListaGanado.Text = "Ganados registrados: " + impl.Listar().Count;
                    }
                    else
                    {
                        MessageBox.Show("Proceso cancelado.", "Mensaje del sistema",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje del sistema",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region CONDICIONES
        private void TxConsultar_TextChanged(object sender, EventArgs e)
        {
            FiltrarBusqueda();
        }
        private void TxPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Este campo solo admite numeros.", "Mensaje del sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
            }
        }

        private void ListaGanado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            posicion = ListaGanado.CurrentRow.Index;
        }

        #endregion

        private void TxCompra_Click(object sender, EventArgs e)
        {
           
        }

        private void TxPeso_TextChanged(object sender, EventArgs e)
        {
            TxPesoVenta.Text = ganado.PesoVenta.ToString();
        }

        private void ListaGanado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.TxPeso.Clear();
           
        }

        private void TxPesoVenta_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void FrmGanado_FormClosing(object sender, FormClosingEventArgs e)
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
