using Entidad;
using Negocio.implementaciones;
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
    public partial class Comprar : Form
    {
        public Comprar()
        {
            InitializeComponent();
        }

        Ganado ganado = new Ganado();

        private void CalcularTotal()
        {
            decimal total = 0;

            if (DatosGanados.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in DatosCarrito.Rows)
                {
                    total += Convert.ToDecimal(row.Cells["PrecioVenta"].Value.ToString());
                }
                lblTotalPagar.Text = "$" + total.ToString("0.00");
            }
            else
            {
                lblTotalPagar.Text = "$0";
            }
        }

        private void AgregarGanado()
        {
                DatosCarrito.Rows.Add(new object[]
                {
                    txtIdProd.Text,
                    txtSexo.Text,
                    txtRaza.Text,
                    txtPeso.Text,
                    txtPrecioVenta.Text
                });
                CalcularTotal();
        }

        private void LLenarDatos()
        {
            GanadoImpl ganadoImpl = new GanadoImpl();
            List<Ganado> ganados = ganadoImpl.Listar();
            //Llenar tabla
            foreach (var item in ganados)
            {
                if (item.Estado == true)
                {
                    DatosGanados.Rows.Add(new object[] { item.IdGanado, item.Sexo, item.Raza, item.Peso, item.PrecioVenta });
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuPrincipal menuPrincipal = new MenuPrincipal();
            this.Hide();
            menuPrincipal.Show();
        }

        private void Comprar_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogo = MessageBox.Show("¿Desea cerrar el programa?",
           "Cerrar el programa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogo == DialogResult.No) { e.Cancel = true; }
            else
            {
                e.Cancel = false; Environment.Exit(1);
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        GanadoImpl ganadoImpl = new GanadoImpl();

        private void Comprar_Load(object sender, EventArgs e)
        {
            LLenarDatos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AgregarGanado();
            CalcularTotal(); 
        }

        private void DatosProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index_row = e.RowIndex;
            int index_colum = e.ColumnIndex;

            if (index_row >= 0 && index_colum >= 0)
            {
                ganado = new Ganado()
                {
                    IdGanado = Convert.ToInt32(DatosGanados.Rows[index_row].Cells["_id"].Value.ToString()),
                    Raza = DatosGanados.Rows[index_row].Cells["_Raza"].Value.ToString(),
                    Sexo = Convert.ToChar(DatosGanados.Rows[index_row].Cells["_Sexo"].Value.ToString()),
                    PesoVenta = Convert.ToDecimal(DatosGanados.Rows[index_row].Cells["_Peso"].Value.ToString()),
                    PrecioVenta = Convert.ToDecimal(DatosGanados.Rows[index_row].Cells["_PrecioVenta"].Value.ToString()),
                };

                txtIdProd.Text = ganado.IdGanado.ToString();
                txtRaza.Text = ganado.Raza.ToString();
                txtSexo.Text = ganado.Sexo.ToString();
                txtPeso.Text = ganado.PesoVenta.ToString();
                txtPrecioVenta.Text = ganado.PrecioVenta.ToString();
            }
        }
    }
}
