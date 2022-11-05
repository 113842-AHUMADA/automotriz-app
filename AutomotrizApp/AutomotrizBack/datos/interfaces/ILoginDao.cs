using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizBack.datos.interfaces
{
    interface ILoginDao
    {
        string Login(List<Parametro> credenciales);

    }
}
