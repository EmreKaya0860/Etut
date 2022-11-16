using Microsoft.AspNetCore.Mvc;
using Odev2.Models;


namespace Odev2.Controllers
{
    public class IletisimController : Controller
    {
        [HttpPost]
        public IActionResult Index(Bilgiler[] bilgi)
        {

            //ViewBag.Name = collections["_name"];
            //ViewBag.Email = collections["email"];
            //ViewBag.Mesaj = collections["mesaj"];
            //ViewBag.Check = collections["kontrol"][0];

            if (ModelState.IsValid) // Eğer Model Nesnesi (uye) Validasyon Kuralları Geçerli ise
            {
                // Kurallara uyulmuşsa uye nesnesini veritabanına kaydet
            }

            if (!ModelState.IsValid) // Model Durumu Geçersiz ise
            {
                // Kullanıcıya hata mesajı göster
                ModelState.AddModelError("", "Lütfen Zorunlu Alanları Doldurunuz"); // Bu metotla ekrana kendi hata mesajlarımızı gönderebiliriz
            }

            return View(bilgi);

            
        }

        public IActionResult Index()
        {

            return View();
        }
    }
}
