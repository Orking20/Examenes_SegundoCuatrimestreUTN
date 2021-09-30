using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public sealed class Venta
    {
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

        public static double PrecioTotal(double precio, int stock)
        {
            double precioTotal;

            precioTotal = precio * stock;

            return precioTotal;
        }
    }
}
