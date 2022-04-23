using Pais_Api_Proyect.Models;
using System.Collections.Generic;

namespace Pais_Api_Proyect.Services
{
    public interface IDataService
    {
        List<Pais> Get();
        Pais Get(string Nombre);

    }
}
