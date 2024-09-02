using Abstraction.Abstraction;
using Abstraction.Constructor;

class Program
{
    static void Main(string[] args)
    {
        Calisan yazilimci = new YazilimGeliştiricisi();
        yazilimci.Ad = "Hasan";
        yazilimci.Soyad = "Çalışkan";
        yazilimci.Departman = "Yazılım";
            
        Calisan yonetici = new ProjeYoneticisi();
        yonetici.Ad = "Kamil";
        yonetici.Soyad = "Yıldız";
        yonetici.Departman = "Yönetim";

        Calisan satici = new SatısTemsilcisi();

        satici.Ad = "Hamdi";
        satici.Soyad = "Altay";
        satici.Departman = "Satış";



        yazilimci.Gorev();
        yonetici.Gorev();
        satici.Gorev();
    }
}