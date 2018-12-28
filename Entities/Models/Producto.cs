using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
    public class Producto
    {
        public int ID { get; set; }
        public string Nombre { get; set; }

        public double Precio { get; set; }

        public string Descripcion { get; set; }

        public int Marca_Id { get; set; }
        public virtual Marca Marca { get; set; }
    }
}
