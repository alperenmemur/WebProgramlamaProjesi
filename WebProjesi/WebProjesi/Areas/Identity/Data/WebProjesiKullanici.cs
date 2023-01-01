using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace WebProjesi.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the WebProjesiKullanici class
    public class WebProjesiKullanici : IdentityUser
    {
        [Required]
        [Column(TypeName ="nvarchar(30)")]
        [PersonalData]
        [MinLength(5)]
        [MaxLength(30)]
        [DataType(DataType.Text)]
        public string kullaniciAdi { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(30)")]
        [PersonalData]
        [MinLength(5)]
        [MaxLength(30)]
        [DataType(DataType.Password)]
        public string sifre { get; set; }

    }
}
