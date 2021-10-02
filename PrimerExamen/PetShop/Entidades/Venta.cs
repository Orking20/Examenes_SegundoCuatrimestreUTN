using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public sealed class Venta
    {
        #region Metodos
        /// <summary>
        /// Calcula el precio a pagar, lo resta del saldo al cliente y resta el stock del producto
        /// </summary>
        /// <param name="producto">Producto que se está vendiendo</param>
        /// <param name="cliente">Cliente que está comprando</param>
        /// <param name="stock">Cantidad de productos vendidos</param>
        /// <returns>Retorna un mensaje indicando si se pudo vender correctamente o si hubo algun error</returns>
        public static string VenderProducto(Producto producto, Cliente cliente, int stock)
        {
            double precio = producto.Precio;
            double saldo = cliente.Saldo;
            double precioTotal;
            string retorno;

            if (stock == 0)
            {
                retorno = "Seleccione una cantidad para vender";
            }
            else
            {
                if (producto.Stock > 0)
                {
                    precioTotal = PrecioTotal(precio, stock);

                    if (precioTotal <= saldo)
                    {
                        saldo -= precioTotal;

                        producto.Stock -= stock;
                        cliente.Saldo = saldo;

                        retorno = "¡Vendido!";
                    }
                    else
                    {
                        retorno = "El cliente no tiene suficiente dinero";
                    }
                }
                else
                {
                    retorno = "¡No hay suficiente stock!";
                }
            }

            return retorno;
        }

        /// <summary>
        /// Calcula el precio total a pagar multiplicando el precio de un determinado producto por la cantidad de productos
        /// </summary>
        /// <param name="precio">Precio individual de un progucto</param>
        /// <param name="stock">Cantidad de productos</param>
        /// <returns>Retorna el precio total de la compra</returns>
        public static double PrecioTotal(double precio, int stock)
        {
            double precioTotal;

            precioTotal = precio * stock;

            return precioTotal;
        }
        #endregion
    }
}
