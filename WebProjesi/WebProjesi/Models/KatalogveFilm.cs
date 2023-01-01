using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebProjesi.Models
{
    public class KatalogveFilm
    {
        public IEnumerable<WebProjesi.Models.Film> filmler {get;set;}
        public IEnumerable<WebProjesi.Models.Kataloglar> kataloglar {get;set;}
    }
}
