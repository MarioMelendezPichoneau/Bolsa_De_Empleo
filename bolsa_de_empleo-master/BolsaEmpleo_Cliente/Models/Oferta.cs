using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BolsaEmpleo_Cliente.Models
{
    public class Oferta
    {
        public int Id { get; set; }
        public string Compania { get; set; }
        public string Tipo { get; set; }
        public string Logo { get; set; }
        public string Url { get; set; }
        public string Posicion { get; set; }
        public string Ubicacion { get; set; }
        public int? IdCategorias { get; set; }
        public string Email { get; set; }
        public DateTime? Fecha { get; set; }
    }
}
