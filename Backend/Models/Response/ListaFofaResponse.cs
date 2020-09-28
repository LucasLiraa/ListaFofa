using System;

namespace Backend.Models.Response
{
    public class ListaFofaResponse
    {
        public int Id {get; set;}
        public string Fofura {get; set;}
        public string Porque {get; set;}
        public bool ColocariaPotinho {get; set;}
        public DateTime Niver {get; set;}
    }
}