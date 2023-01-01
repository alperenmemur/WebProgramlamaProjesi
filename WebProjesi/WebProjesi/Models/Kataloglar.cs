using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebProjesi.Models
{
    public class Kataloglar
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string kullaniciAdi { get; set; }
        [Required]
        public int filmNumara { get; set; }
    }
}
