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
    public partial class FrmVenta : Form
    {
        #region Carga de datos
        /// <summary>
        /// Carga los componentes gráficos del formulario
        /// </summary>
        public FrmVenta()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Carga algunos datos antes de mostrar el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmVenta_Load(object sender, EventArgs e)
        {
            if (FrmLogin.EsAdmin)
            {
                this.BackColor = Color.AntiqueWhite;
            }
        }
        #endregion

        #region Botones
        /// <summary>
        /// Realiza la venta y añade la factura correspondiente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVender_Click(object sender, EventArgs e)
        {
            Cliente cliente;
            Producto producto;
            int stock = (int)nudStock.Value;
            string mensaje;

            cliente = BuscarCliente();
            producto = BuscarProducto();

            mensaje = Venta.VenderProducto(producto, cliente, stock);
            
            lblVendido.Visible = true;
            lblVendido.Text = mensaje;

            if (mensaje == "¡Vendido!")
            {
                Factura factura = new Factura(cliente, producto, stock);
                FrmLogin.Facturas.Add(factura);
                ReproducirSonidoExito();
            }
            else
            {
                ReproducirSonidoFallo();
            }
        }
        #endregion

        #region NumericUpDowns
        /// <summary>
        /// Va cambiando el precio a pagar según la cantidad de stock que se elija
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nudStock_ValueChanged(object sender, EventArgs e)
        {
            Producto producto = BuscarProducto();
            double precio = producto.Precio;
            int stock = (int)nudStock.Value;
            lblPrecioTotalProducto.Visible = true;

            lblPrecioTotalProducto.Text = Venta.PrecioTotal(precio, stock).ToString();
        }

        /// <summary>
        /// Va mostrando los datos de los clientes según el ID seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nudIdClientes_ValueChanged_1(object sender, EventArgs e)
        {
            Cliente cliente = BuscarCliente();

            if (cliente != null)
            {
                lblNombreCliente.Text = cliente.Nombre;
                lblApellidoCliente.Text = cliente.Apellido;
                lblDniCliente.Text = cliente.Dni.ToString();

                lblNombreCliente.Visible = true;
                lblApellidoCliente.Visible = true;
                lblDniCliente.Visible = true;
            }
        }

        /// <summary>
        /// Va mostrando los datos de los productos según el ID seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nudIdProducto_ValueChanged_1(object sender, EventArgs e)
        {
            Producto producto = BuscarProducto();

            if (producto != null)
            {
                double precio = producto.Precio;
                int stock = (int)nudStock.Value;

                lblNombreProducto.Text = producto.Nombre;
                lblMarcaProducto.Text = producto.Marca;
                lblPrecioProducto.Text = producto.Precio.ToString();
                lblStockProducto.Text = producto.Stock.ToString();

                lblNombreProducto.Visible = true;
                lblMarcaProducto.Visible = true;
                lblPrecioProducto.Visible = true;
                lblStockProducto.Visible = true;

                lblPrecioTotalProducto.Text = Venta.PrecioTotal(precio, stock).ToString();
            }
        }
        #endregion

        #region Sonido
        /// <summary>
        /// Reproduce un sonido indicando que todo salió correctamente
        /// </summary>
        private void ReproducirSonidoExito()
        {
            SoundPlayer sonidoExito = new SoundPlayer(@"D:\UTN\Segundo cuatrimestre\Programacion II\Examenes\PrimerExamen\Sonidos\Exito.wav");
            sonidoExito.Play();
        }

        /// <summary>
        /// Reproduce un sonido indicando que algo falló
        /// </summary>
        private void ReproducirSonidoFallo()
        {
            SoundPlayer sonidoFallo = new SoundPlayer(@"D:\UTN\Segundo cuatrimestre\Programacion II\Examenes\PrimerExamen\Sonidos\Fallo.wav");
            sonidoFallo.Play();
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Busca el cliente seleccionado según el ID
        /// </summary>
        /// <returns></returns>
        private Cliente BuscarCliente()
        {
            Cliente cliente = null;

            if (FrmMenu.Clientes.Count > 0)
            {
                for (int i = 0; i < FrmMenu.Clientes.Count; i++)
                {
                    cliente = FrmMenu.Clientes[i];

                    if (nudIdClientes.Value == cliente.IdCliente)
                    {
                        lblInfoCliente.Visible = false;
                        lblNombreCliente.Visible = true;
                        lblApellidoCliente.Visible = true;
                        lblDniCliente.Visible = true;
                        break;
                    }
                    else
                    {
                        lblInfoCliente.Visible = true;
                        lblNombreCliente.Visible = false;
                        lblApellidoCliente.Visible = false;
                        lblDniCliente.Visible = false;
                        cliente = null;
                    }
                }
            }
            else
            {
                lblInfoCliente.Visible = true;
                lblNombreCliente.Visible = false;
                lblApellidoCliente.Visible = false;
                lblDniCliente.Visible = false;
                ReproducirSonidoFallo();
            }

            return cliente;
        }

        /// <summary>
        /// Busca el producto seleccionado según el ID
        /// </summary>
        /// <returns></returns>
        private Producto BuscarProducto()
        {
            Producto producto = null;

            if (FrmLogin.Productos.Count > 0)
            {
                for (int j = 0; j < FrmLogin.Productos.Count; j++)
                {
                    producto = FrmLogin.Productos[j];

                    if (nudIdProducto.Value == producto.IdProducto)
                    {
                        lblInfoProducto.Visible = false;
                        lblNombreProducto.Visible = true;
                        lblMarcaProducto.Visible = true;
                        lblPrecioProducto.Visible = true;
                        lblStockProducto.Visible = true;
                        break;
                    }
                    else
                    {
                        lblInfoProducto.Visible = true;
                        lblNombreProducto.Visible = false;
                        lblMarcaProducto.Visible = false;
                        lblPrecioProducto.Visible = false;
                        lblStockProducto.Visible = false;
                        producto = null;
                    }
                }
            }
            else
            {
                lblInfoProducto.Visible = true;
                lblNombreProducto.Visible = false;
                lblMarcaProducto.Visible = false;
                lblPrecioProducto.Visible = false;
                lblStockProducto.Visible = false;
                ReproducirSonidoFallo();
            }

            return producto;
        }
        #endregion

    }
}
