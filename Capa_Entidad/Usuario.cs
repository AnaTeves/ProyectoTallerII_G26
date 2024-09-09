using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class Usuario
    {
        public int id_usuario { get; set; }
        public string nomYape { get; set; }
        public string dni { get; set; }
        public string email { get; set; }
        public string contraseña { get; set; }
        public Rol rol { get; set; }
    }
}
