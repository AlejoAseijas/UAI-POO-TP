using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1.models
{
    public abstract class Producto
    {

        #region Propiedades

        public string Categoria { get; set; }
        public string SubCategoria { get; set; }
        public string Nombre { get; set; }
        //Agregacion
        public Proveedor Provedor { get; set; }

        #endregion

        #region constructores

        public Producto() { }

        public Producto(string categoria, string subcategoria, string nombre) { 
            this.Categoria = categoria;
            this.SubCategoria = subcategoria;
            this.Nombre = nombre;
        }

        #endregion

        #region metodos

        public override string ToString()
        {
            return this.Categoria + "-" + this.SubCategoria + "-" + this.Nombre + "-" + "-" + this.Provedor.ToString();
        }

        public abstract String GenerarCodigo();

        public override bool Equals(object obj)
        {
            bool status = false;

            if (obj is Producto)
            {
                Producto o = (Producto)obj;

                status = this.Categoria == o.Categoria && this.SubCategoria == o.SubCategoria &&
                    this.Nombre == o.Nombre && this.Provedor.Equals(o.Provedor);
            }

            return status;
        }
        #endregion

    }
}
