using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebProjesi.Models
{
    public class Kullanicilar
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Bu alan zorunludur.")]
        public string kullaniciAdi { get; set; }

        [Required(ErrorMessage = "Bu alan zorunludur.")]
        [DataType(DataType.Password)]
        public string sifre { get; set; }

        public string rol { get; set; }

    }
}
