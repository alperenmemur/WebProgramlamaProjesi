using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebProjesi.Models
{
    public class Kitap { 
    
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        [MinLength(3)]
        [Required]
        public string KitapAdi { get; set; }
        [MaxLength(300)]
        [MinLength(10)]
        [Required]
        public string KitapKonusu { get; set; }
        [MaxLength(50)]
        [MinLength(3)]
        [Required]
        public string KitapYazari { get; set; }
        [MaxLength(50)]
        [MinLength(3)]
        [Required]
        public string KitapTürü { get; set; }
           
    }
}
