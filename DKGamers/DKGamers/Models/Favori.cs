using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DKGamers.Models
{
    public class Favori
    {
        [Key]
        public int FavoriID { get; set; }
        public string KullaniciAdi { get; set; }
        public int OyunID { get; set; }
        public Oyun Oyun { get; set; }
    }
}
