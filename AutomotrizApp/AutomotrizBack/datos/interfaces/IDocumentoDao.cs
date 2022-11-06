using AutomotrizApp.dominio;
using AutomotrizBack.datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizApp.datos.interfaces
{
    interface IDocumentoDao
    {
        bool Create(Documento oPedido);

        bool Update(Documento oPedido);

        bool Delete(int id);

        List<Documento> GetDocumentosPorFiltro(List<Parametro> filtros);
        
        Documento GetDocumentoPorId(int id);

    }
}
