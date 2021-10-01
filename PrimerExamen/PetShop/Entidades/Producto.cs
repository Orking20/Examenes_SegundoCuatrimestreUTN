using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        private string nombre;
        private string marca;
        private ETipo tipo;
        private double precio;
        private double peso;
        private int stock;
        private int idProducto;

        #region Constructor
        /// <summary>
        /// Inicializa el producto
        /// </summary>
        /// <param name="nombre">Nombre del producto</param>
        /// <param name="marca">Marca del producto</param>
        /// <param name="precio">Precio del producto</param>
        /// <param name="peso">Peso del producto</param>
        /// <param name="stock">Stock del producto</param>
        /// <param name="idProducto">ID del producto</param>
        public Producto(string nombre, string marca, ETipo tipo, double precio, double peso, int stock, int idProducto)
        {
            this.Nombre = nombre;
            this.Marca = marca;
            this.Tipo = tipo;
            this.Precio = precio;
            this.Peso = peso;
            this.Stock = stock;
            this.IdProducto = idProducto;
        }
        #endregion

        /// <summary>
        /// Muestra los datos de un producto
        /// </summary>
        /// <returns></returns>
        public string Mostrar()
        {
            StringBuilder st = new StringBuilder();

            st.AppendLine($"Nombre: {Nombre}");
            st.AppendLine($"Marca: {Marca}");
            st.AppendLine($"Tipo: {Tipo}");
            st.AppendLine($"Precio: {Precio}");
            st.AppendLine($"Peso: {Peso}");
            st.AppendLine($"Stock: {Stock}");

            return st.ToString();
        }

        #region Getters/Setters
        /// <summary>
        /// Devuelve o establece el nombre
        /// </summary>
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }

        /// <summary>
        /// Devuelve o establece la marca
        /// </summary>
        public string Marca
        {
            get
            {
                return this.marca;
            }
            set
            {
                this.marca = value;
            }
        }

        /// <summary>
        /// Devuelve o establece el tipo
        /// </summary>
        public ETipo Tipo
        {
            get
            {
                return this.tipo;
            }
            set
            {
                this.tipo = value;
            }
        }

        /// <summary>
        /// Devuelve o establece el precio
        /// </summary>
        public double Precio
        {
            get
            {
                return this.precio;
            }
            set
            {
                if (ValidarPrecio(value))
                {
                    this.precio = value;
                }
            }
        }

        /// <summary>
        /// Devuelve o establece el peso
        /// </summary>
        public double Peso
        {
            get
            {
                return this.peso;
            }
            set
            {
                if (ValidarPeso(value))
                {
                    this.peso = value;
                }
            }
        }

        /// <summary>
        /// Devuelve o establece el stock
        /// </summary>
        public int Stock
        {
            get
            {
                return this.stock;
            }
            set
            {
                if (ValidarStock(value))
                {
                    this.stock = value;
                }
            }
        }

        /// <summary>
        /// Devuelve el id
        /// </summary>
        public int IdProducto
        {
            get
            {
                return this.idProducto;
            }
            set
            {
                this.idProducto = value;
            }
        }
        #endregion

        #region Validaciones
        /// <summary>
        /// Valida el precio del producto
        /// </summary>
        /// <param name="precio">Precio del producto</param>
        /// <returns></returns>
        public static bool ValidarPrecio(double precio)
        {
            bool retorno = false;

            if (precio > 0)
            {
                retorno = true;
            }

            return retorno;
        }

        /// <summary>
        /// Valida el peso del producto
        /// </summary>
        /// <param name="peso">Peso del producto</param>
        /// <returns></returns>
        public static bool ValidarPeso(double peso)
        {
            bool retorno = false;

            if (peso > 0)
            {
                retorno = true;
            }

            return retorno;
        }

        /// <summary>
        /// Valida el stock del producto
        /// </summary>
        /// <param name="peso">Peso del producto</param>
        /// <returns></returns>
        public static bool ValidarStock(int stock)
        {
            bool retorno = false;

            if (stock >= 0)
            {
                retorno = true;
            }

            return retorno;
        }
        #endregion
    }
}
