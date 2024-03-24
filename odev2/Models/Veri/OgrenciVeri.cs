namespace odev2.Models.Veri
{
    public class OgrenciVeri
    {
        public static List<Models.Ogrenci> kOgrenci = new List<Models.Ogrenci>
        {
            new Models.Ogrenci
            {
                OgrenciNo   = 20155030,
                Ad          = "Ecem",
                Soyad       = "Boz",
                Sinif       = 4,
                DersTanimi  = "İnternet Programlama",
                Kredi       = 4,
                SinavTarihi = new DateTime(2024, 4, 15),
                VizeNotu    = 90,
                FinalNotu   = 90,
            },

            new Models.Ogrenci
            {
                OgrenciNo   = 20155090,
                Ad          = "Berfin",
                Soyad       = "Özenir",
                Sinif       = 1,
                DersTanimi  = "Matematik-1",
                Kredi       = 4,
                SinavTarihi = new DateTime(2024, 4, 17),
                VizeNotu    = 85,
                FinalNotu   = 70,
            },

            new Models.Ogrenci
            {
                OgrenciNo   = 20155076,
                Ad          = "Merve",
                Soyad       = "Koçak",
                Sinif       = 2,
                DersTanimi  = "Bilgisayar mimarisi",
                Kredi       = 4,
                SinavTarihi = new DateTime(2024, 4, 19),
                VizeNotu    = 75,
                FinalNotu   = 40,
            },

            new Models.Ogrenci
            {
                OgrenciNo   = 20155088,
                Ad          = "Kübra",
                Soyad       = "Yüksel",
                Sinif       = 3,
                DersTanimi  = "Microprocessors",
                Kredi       = 4,
                SinavTarihi = new DateTime(2024, 4, 13),
                VizeNotu    = 58,
                FinalNotu   = 66,
            },

            new Models.Ogrenci
            {
                OgrenciNo   = 20155065,
                Ad          = "İlayda",
                Soyad       = "Doğan",
                Sinif       = 4,
                DersTanimi  = "E-commerce",
                Kredi       = 4,
                SinavTarihi = new DateTime(2024, 4, 16),
                VizeNotu    = 35,
                FinalNotu   = 72,
            },
        };
    }
}
