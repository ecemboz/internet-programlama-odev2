using Microsoft.AspNetCore.Mvc;
using odev2.Models;
using odev2.Models.Veri;
using System;
using System.Collections.Generic;
using System.Linq;

namespace odev2.Controllers
{
    public class OgrenciController:Controller
    {
        //LİSTELEME
        public IActionResult Listele()
        {
            ViewData["Baslik"] = "ÖĞRENCİ LİSTELEME";
            return View(OgrenciVeri.kOgrenci);

        }

        //YENİ KAYIT
        public IActionResult YeniKayit() 
        {
            return View();
        }

        [HttpPost]
        public IActionResult YeniKayit(Models.Ogrenci yOgrenci)
        {
            if (ModelState.IsValid)
            {
                OgrenciVeri.kOgrenci.Add(yOgrenci);
                return RedirectToAction("Listele");
            }
            return View(yOgrenci);
        }

        //DETAY
        public IActionResult Detay(int id)
        {
            var ogrenci = OgrenciVeri.kOgrenci.FirstOrDefault(o => o.OgrenciNo == id);
            if (ogrenci != null)
                return View(ogrenci);
            return NotFound();
        }

        //GÜNCELLEME
        public IActionResult Guncelle(int id)
        {
            var gOgrenci = OgrenciVeri.kOgrenci.FirstOrDefault(o => o.OgrenciNo == id);
            return View(gOgrenci);
        }

        [HttpPost]
        public IActionResult Guncelle(Ogrenci ogrenci)
        {
            if (ModelState.IsValid)
            {
                var gOgrenci = OgrenciVeri.kOgrenci.FirstOrDefault(o => o.OgrenciNo == ogrenci.OgrenciNo);
                if (gOgrenci != null)
                {
                    gOgrenci.Ad = ogrenci.Ad;
                    gOgrenci.Soyad = ogrenci.Soyad;
                    gOgrenci.Sinif = ogrenci.Sinif;
                    gOgrenci.DersTanimi = ogrenci.DersTanimi;
                    gOgrenci.Kredi = ogrenci.Kredi;
                    gOgrenci.SinavTarihi = ogrenci.SinavTarihi;
                    gOgrenci.VizeNotu = ogrenci.VizeNotu;
                    gOgrenci.FinalNotu = ogrenci.FinalNotu;

                    return RedirectToAction("Listele");
                }
                else
                    return NotFound();
            }
            return View(ogrenci);
        }

        //SİLME
        public IActionResult Sil(int id)
        {
            var sOgrenci = OgrenciVeri.kOgrenci.FirstOrDefault(o => o.OgrenciNo == id);
            if (sOgrenci != null)
                return View(sOgrenci);
            return NotFound();
        }

        [HttpPost, ActionName("Sil")]
        public IActionResult Sil(Ogrenci ogrenci)
        {
            var sOgrenci = OgrenciVeri.kOgrenci.FirstOrDefault(o => o.OgrenciNo == ogrenci.OgrenciNo);
            if (sOgrenci != null)
            {
                OgrenciVeri.kOgrenci.Remove(sOgrenci);
                return RedirectToAction("Listele");
            }
            return NotFound();
        }
    }
}
