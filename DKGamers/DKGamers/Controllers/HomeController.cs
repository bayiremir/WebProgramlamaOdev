using DKGamers.Data;
using DKGamers.Models;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace DKGamers.Controllers
{
    public class HomeController : Controller
    {
        private Context context;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, Context context)
        {
            _logger = logger;
            this.context = context;
        }

        public IActionResult CultureManagement(string Culture, string returnUrl)
        {
            Response.Cookies.Append(CookieRequestCultureProvider.DefaultCookieName, CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(Culture)),
                new CookieOptions { Expires = DateTimeOffset.Now.AddDays(30) });
            return LocalRedirect(returnUrl);
        }

        public IActionResult Index()
        {
            var haberler = context.Haber.ToList();
            haberler = haberler.Where(t => t.haberGosterilsinmi == false).ToList();
            haberler.Reverse();

            var oyunlar1 = context.Oyun.ToList();
            oyunlar1 = oyunlar1.Where(t => t.oyunGosterilsinmi == false).OrderByDescending(x => x.PiyasayaSurulmeTarihi).ToList();
            oyunlar1 = oyunlar1.Take(5).ToList();

            var oyunlar2 = context.Oyun.ToList();
            oyunlar2 = oyunlar2.Where(t => t.oyunGosterilsinmi == false).OrderByDescending(x => x.GoruntulenmeSayisi).ToList();
            oyunlar2 = oyunlar2.Take(5).ToList();

            return View(new HaberListViewModel()
            {
                Haberler = haberler,
                Oyunlar1 = oyunlar1,
                Oyunlar2 = oyunlar2
            });
        }
        public IActionResult Detail(int id)
        {
            var haber = context.Haber.FirstOrDefault(i => i.HaberID == id);
            return View(haber);
        }
        public IActionResult Privacy()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}