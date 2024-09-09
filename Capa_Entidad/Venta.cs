using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class Venta
    {
        public int id_venta { get; set; }
        public string fecha_venta { get; set; }
        public float total_venta { get; set; }
        public Cliente id { get; set; }
        public Usuario usuario { get; set; }
    }
}
