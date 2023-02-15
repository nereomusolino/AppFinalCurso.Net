using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesDominio
{
    public class Articulos
    {

        [DisplayName("Codigo de Articulo")]
        public string CodigoArticulo { get; set; }
        public string Nombre { get; set; }

        [DisplayName("Descripción")]
        public string Descripcion { get; set; }

        [DisplayName("Marca")]
        public Marca MarcaArticulo { get; set; }

        [DisplayName("Categoría")]
        public Categoria CategoriaArticulo { get; set; }

        [DisplayName("Url de imagen")]
        public string UrlImagen { get; set; }
        public float Precio { get; set; }

    }
}
