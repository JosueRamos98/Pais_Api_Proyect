using Newtonsoft.Json;
using Pais_Api_Proyect.Models;
using RestSharp;
using System.Collections.Generic;
using System.IO;

namespace Pais_Api_Proyect.Services
{
    public class DataService : IDataService

    {
        private readonly List<Pais> lstPais = new List<Pais>();

       
        
        public DataService()
        {

            //Extrae el nombre desde una url

            var url = "https://restcountries.com/v3.1/all";
            var json = new System.Net.WebClient().DownloadString(url);

            dynamic pais = Newtonsoft.Json.JsonConvert.DeserializeObject(json);
           

            foreach (var pa in pais)
            {
                string nombre = "";
                string capital = "";
                string poblacion = "";
                
                if (pa.name.common.Value.ToString() != null) nombre = pa.name.common.Value.ToString();

                if (pa.capital != null) capital = pa.capital[0].Value.ToString();

                if (pa.population.Value.ToString() != null) poblacion = pa.population.Value.ToString();

                lstPais.Add(new Pais(nombre, capital, poblacion));


            };
            


        }
        public List<Pais> Get()
        {

            if (lstPais.Count > 0) return lstPais;
            return null;
            
        }

        public Pais Get(string Nombre)
        {
            foreach (var item in lstPais)
            {
                if (item.Nombre == Nombre)
                {
                    return item;
                }
            }
            return null;

        }
    }


}
