using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DKGamers.Models
{
    public class OyunDetailViewModel
    {
        public Oyun Oyun { get; set; }
        public List<Yorum> Yorumlar { get; set; }
        public bool favorilerdemi { get; set; }
    }
}
