using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebProjesi.Models
{
    public class DetayveYorum
    {
        public IEnumerable<FilmYorumlar> FilmYorumlar { get; set; }
        public Film film { get; set; }
        public FilmYorumlar yorum { get; set; }
        public IEnumerable<Film> Filmler { get; set; }
    }
}
