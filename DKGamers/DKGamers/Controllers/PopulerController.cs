using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DKGamers.Models;
using Microsoft.EntityFrameworkCore;
using DKGamers.Data;
using Microsoft.AspNetCore.Identity;
using DKGamers.Identity;

namespace DKGamers.Controllers
{
    public class PopulerController : Controller
    {
        private Context context;

        private UserManager<Kullanici> kullaniciYoneticisi;
        public PopulerController(UserManager<Kullanici> _kullaniciYoneticisi, Context context)
        {
            kullaniciYoneticisi = _kullaniciYoneticisi;
            this.context = context;
        }
        public IActionResult Index()
        {
            var oyunlar = context.Oyun.Where(t => t.oyunGosterilsinmi == false).ToList(); ;
            oyunlar = oyunlar.OrderByDescending(x => x.GoruntulenmeSayisi).ToList();
            oyunlar = oyunlar.Take(10).ToList();

            return View(new OyunListViewModel()
            {
                Oyunlar = oyunlar,

            });
        }
        public IActionResult Detail(int id)
        {
            Oyun oyun = context.Oyun.Include(i => i.OyunKategorileri).ThenInclude(i => i.Kategori).FirstOrDefault(i => i.OyunID == id);
            var yorumlar = context.Yorum.Include(i => i.Oyun).Where(i => i.OyunID == id).ToList();
            var favorilerdemi = context.Favori.Any(i => i.Oyun.OyunID == id && i.KullaniciAdi == User.Identity.Name);
            oyun.GoruntulenmeSayisi++;
            context.Oyun.Update(oyun);
            context.SaveChanges();
            return View(new OyunDetailViewModel()
            {
                Oyun = oyun,
                Yorumlar = yorumlar,
                favorilerdemi = favorilerdemi
            });
        }

        [HttpPost]
        public IActionResult CreateComment(YorumModel model)
        {
            var user = kullaniciYoneticisi.FindByNameAsync(User.Identity.Name).Result;
            var Yorum = new Yorum()
            {
                OlusturulmaTarihi = DateTime.Now,
                KullaniciAdi = user.UserName,
                OyunID = model.OyunID,
                YapilanYorum = model.YapilanYorum
            };
            context.Yorum.Add(Yorum);
            context.SaveChanges();
            return Redirect("/Populer/Detail/" + model.OyunID);
        }

    }
}