using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class DetalleVenta
    {
        public int id_detalle { get; set; }
        public int cantidad { get; set; }
        public float precio_unitario { get; set; }
        public Producto id_producto { get; set; }
        public Venta id_venta { get; set; }
    }
}
