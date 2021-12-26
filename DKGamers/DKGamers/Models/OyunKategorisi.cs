using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DKGamers.Models
{
    public class OyunKategorisi
    {
        [Key]
        public int OyunID { get; set; }
        public Oyun Oyun { get; set; }
        public int KategoriID { get; set; }
        public Kategori Kategori { get; set; }
    }
}
