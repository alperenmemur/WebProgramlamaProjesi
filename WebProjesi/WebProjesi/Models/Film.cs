using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebProjesi.Models
{
    public class Film
    {
        [Key]
        
        public int Id {get;set;}
        [Required(ErrorMessage = "Boş Olamaz!")]
        [MaxLength(50,ErrorMessage ="Film Adı 50 Karakterden Uzun Olamaz.")]
        public string filmIsmi { get; set; }

        [Required(ErrorMessage = "Boş Olamaz!")]
        [MaxLength(20,ErrorMessage ="Film Kategorisi 20 Karakterden Uzun Olamaz.")]
        public string filmTuru { get; set; }
      
        [Required(ErrorMessage ="Boş Olamaz!")]
        [MaxLength(400,ErrorMessage ="Film Açıklaması 200 Karakterden Uzun Olamaz.")]
        public string filmAciklamasi { get; set; }

        [Required(ErrorMessage = "Boş Olamaz!")]
        public string filmResimURL { get; set; }
    }
}
