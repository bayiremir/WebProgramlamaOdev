using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DKGamers.Models
{
    public class HaberListViewModel
    {
        public List<Haber> Haberler { get; set; }
        public List<Oyun> Oyunlar1 { get; set; }
        public List<Oyun> Oyunlar2 { get; set; }
    }
}