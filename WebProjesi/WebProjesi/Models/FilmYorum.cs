using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebProjesi.Models
{
    public class FilmYorum
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string Kullanici { get; set; }
        [Required]
        [MaxLength(200)]
        public string Yorum { get; set; }
        [Required]
        public int FilmNumara { get; set; }
       
    }
}
