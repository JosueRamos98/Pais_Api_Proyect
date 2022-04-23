using System.Collections.Generic;

namespace Pais_Api_Proyect.Models
{
    public class Pais
    {
        public Pais(string nombre, string capital, string poblacion)
        {
            Nombre = nombre;
            Capital = capital;
            Poblacion = poblacion;
        }

        public string Nombre { get; set; }
        public string Capital { get; set; }
        public string Poblacion { get; set; }
        
    }

    public class Paises
    {
        public List<Pais> data { get; set; }
    }
}
