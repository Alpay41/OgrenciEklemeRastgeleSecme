namespace OgrenciEklemeRastgeleSecme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kaç Öğrenci Eklenecek ?");
            int eklenecekOgrenciSayisi = int.Parse(Console.ReadLine());

            string[] ogrenciAdi = new string[eklenecekOgrenciSayisi];
            string[] ogrenciSoyadi = new string[eklenecekOgrenciSayisi];

            for (int i = 0; i < eklenecekOgrenciSayisi; i++)//Diziye eleman eklemek
            {
                Console.WriteLine("{0}. Öğrenci Adını Giriniz",i+1);
                ogrenciAdi[i] += Console.ReadLine();
                Console.WriteLine("{0}. Öğrenci Soyadını Giriniz", i+1);
                ogrenciSoyadi[i] += Console.ReadLine();
            }
            Random rnd = new Random();
            int secilen = rnd.Next(0,eklenecekOgrenciSayisi);
            Console.WriteLine("Rastgele SEçim Yapmak İçin Entere Basınız");
            Console.ReadLine();
            Console.WriteLine("Rastgele Seçilen Öğrenci :{0} {1}", ogrenciAdi[secilen], ogrenciSoyadi[secilen]);



        }
    }
}