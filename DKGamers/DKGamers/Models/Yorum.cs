using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using DKGamers.Identity;

namespace DKGamers.Models
{
    public class Yorum
    {
        [Key]
        public int YorumID { get; set; }
        public string YapilanYorum { get; set; }
        public DateTime OlusturulmaTarihi { get; set; }
        public int OyunID { get; set; }
        public Oyun Oyun { get; set; }
        public string KullaniciAdi { get; set; }
    }
}