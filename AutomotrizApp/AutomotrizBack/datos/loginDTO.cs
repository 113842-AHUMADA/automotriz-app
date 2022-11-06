using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizBack.datos
{
    public class LoginDTO
    {
        public string privilegio { get; set; }
        public string nombreApellido { get; set; }
        public int id_credencial { get; set; }
    }
}
