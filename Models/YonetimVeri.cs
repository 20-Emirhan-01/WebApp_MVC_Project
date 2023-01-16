namespace WebApp_MVC_Project.Models
{
    public class YonetimVeri
    {
        public static List<Yonetim> Yöneticiler = new List<Yonetim>()
        {
            new Yonetim()
            {
                Id = 1,
                Ad = "Betul",
                Soyad = "SOLMAZ",
                Gorevi = "Ogretmen",
                YonetimTip11 ="None",
                YonetimTip12 ="Ogretmen",
                YonetimTip13 ="None",

            },
            new Yonetim()
            {
                Id = 2,
                Ad = "Pınar",
                Soyad = "DEMIR",
                Gorevi = "Calısan",
                YonetimTip11 ="None",
                YonetimTip12 ="None",
                YonetimTip13 ="Ogrenci isleri",
            },
            new Yonetim()
            {
                Id = 3,
                Ad = "Emrah",
                Soyad = "SARICICEK",
                 Gorevi = "Ogretmen",
                YonetimTip11 ="None",
                YonetimTip12 ="Ogretmen",
                YonetimTip13 ="None" ,
            },
            new Yonetim()
            {
                Id = 4,
                Ad = "Hanifi",
                Soyad = "ARSLAN",
                 Gorevi = "Calısan",
                YonetimTip11 ="İdare",
                YonetimTip12 ="None",
                YonetimTip13 ="None",
            },
        };
    }
}
