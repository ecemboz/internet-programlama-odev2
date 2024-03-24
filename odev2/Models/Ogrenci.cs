namespace odev2.Models
{
    public class Ogrenci
    {
        public int OgrenciNo { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int Sinif { get; set; }
        public string DersTanimi { get; set; }
        public int Kredi { get; set; }
        public DateTime SinavTarihi { get; set; }
        public float VizeNotu { get; set; }
        public float FinalNotu { get; set;}
        public double Ortalama => (VizeNotu * 0.4 + FinalNotu * 0.6);
        public string HarfKarsiligi 
        { get 
            {
                double ortalama = Ortalama;
                if (ortalama >= 90)
                    return "AA";
                else if (ortalama >= 80)
                    return "BA";
                else if (ortalama >= 70)
                    return "BB";
                else if (ortalama >= 65)
                    return "CB";
                else if (ortalama >= 60)
                    return "CC";
                else if (ortalama >= 55)
                    return "DC";
                else if (ortalama >= 50)
                    return "DD";
                else
                    return "FF";
            }
        }
        public bool GecmeDurumu => Ortalama >= 60;
    }
}
