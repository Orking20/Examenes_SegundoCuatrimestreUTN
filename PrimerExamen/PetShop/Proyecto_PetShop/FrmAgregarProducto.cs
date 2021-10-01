using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace PetShop
{
    public partial class FrmAgregarProducto : Form
    {
        public FrmAgregarProducto()
        {
            InitializeComponent();
        }

        private void FrmAgregarProducto_Load(object sender, EventArgs e)
        {
            this.lstTipo.DataSource = Enum.GetValues(typeof(ETipo));

            if (FrmLogin.EsAdmin)
            {
                this.BackColor = Color.AntiqueWhite;
            }
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            string nombre;
            string marca;
            ETipo tipo;
            double precio;
            double peso;
            int stock;
            Producto productoNuevo;

            if (double.TryParse(nudPrecio.Text, out precio) &&
                Producto.ValidarPrecio(precio) &&
                double.TryParse(nudPeso.Text, out peso) &&
                Producto.ValidarPeso(peso) &&
                int.TryParse(nudStock.Text, out stock) &&
                Producto.ValidarStock(stock))
            {
                nombre = txtNombre.Text;
                marca = txtMarca.Text;
                tipo = (ETipo)lstTipo.SelectedItem;

                productoNuevo = Empleado.AltaProducto(nombre, marca, tipo, precio, peso, stock);
                FrmLogin.Productos.Add(productoNuevo);
                ReproducirSonidoExito();
            }
            else
            {
                MessageBox.Show("Uno o varios de los datos ingresados no son válidos\nRevise y corrija los datos por favor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = string.Empty;
            txtMarca.Text = string.Empty;
            nudPrecio.Value = 0;
            nudPeso.Value = 0;
            nudStock.Value = 0;
            ReproducirSonidoBoton();
        }

        private void ReproducirSonidoExito()
        {
            SoundPlayer sonidoExito = new SoundPlayer(@"D:\UTN\Segundo cuatrimestre\Programacion II\Examenes\PrimerExamen\Sonidos\Exito.wav");
            sonidoExito.Play();
        }

        private void ReproducirSonidoBoton()
        {
            SoundPlayer sonidoExito = new SoundPlayer(@"D:\UTN\Segundo cuatrimestre\Programacion II\Examenes\PrimerExamen\Sonidos\Boton.wav");
            sonidoExito.Play();
        }
    }
}
