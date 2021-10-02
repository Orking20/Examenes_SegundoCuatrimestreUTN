using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Factura
    {
        private Cliente cliente;
        private Producto producto;
        private int stockComprado;

        #region Constructor
        /// <summary>
        /// Inicializa los datos de una factura
        /// </summary>
        /// <param name="cliente">Cliente asociado a la factura</param>
        /// <param name="producto">Producto asociado a la factura</param>
        /// <param name="stockComprado">Cantidad de productos comprados por el cliente</param>
        public Factura(Cliente cliente, Producto producto, int stockComprado)
        {
            this.cliente = cliente;
            this.producto = producto;
            this.stockComprado = stockComprado;
        }
        #endregion

        #region Getters
        /// <summary>
        /// Devuelve el valor de cliente
        /// </summary>
        public Cliente Cliente
        {
            get
            {
                return cliente;
            }
        }

        /// <summary>
        /// Devuelve el valor de producto
        /// </summary>
        public Producto Producto
        {
            get
            {
                return producto;
            }
        }

        /// <summary>
        /// Devuelve el valor de stockComprado
        /// </summary>
        public int StockComprado
        {
            get
            {
                return stockComprado;
            }
        }
        #endregion
    }
}
