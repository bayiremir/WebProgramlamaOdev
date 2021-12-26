using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DKGamers.Models
{
    public class Oyun
    {
        [Key]
        public int OyunID { get; set; }
        [Required]
        public string Resim { get; set; }
        [Required]
        public string OyunAdi { get; set; }
        [Required]
        public DateTime PiyasayaSurulmeTarihi { get; set; }
        [Required]
        public string Yayinci { get; set; }
        [Required]
        public string Gelistirici { get; set; }
        [Required]
        public string Aciklama { get; set; }
        public int GoruntulenmeSayisi { get; set; }
        public IList<OyunKategorisi> OyunKategorileri { get; set; }

        public List<Yorum> Yorumlar { get; set; }
        public bool oyunGosterilsinmi { get; set; }
    }
}