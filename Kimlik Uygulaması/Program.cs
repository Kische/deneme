using System;


//TAMAMLANMADI
//Bir öğrencinin sahip olabileceği tüm bilgileri tutacak olan namespace
namespace Bilgiler
{
    //Öğrencinin kimlik bilgilerini tutan class
    class Kimlik 
    {
        private string anneAdı;
        private string babaAdı;
        private string adSoyad;
        private string doğumYeri;
        private string kimlikNumarası;
        private string doğumTarihi;

        //Öğrencinin kimlik bilgilerini kullanıcıdan alacak fonksiyon
        private void gets()
        {

            Console.WriteLine("Anne adınızı girin:");
            anneAdı=  Console.ReadLine();
            Console.WriteLine("Baba adını girin");
            babaAdı = Console.ReadLine();
            Console.WriteLine("Adınızı girin");
            adSoyad=  Console.ReadLine();
            Console.WriteLine("Doğum Tarihinizi 1.1.2000 şeklinde girin");
            doğumTarihi= Console.ReadLine();
            Console.WriteLine("Doğum yerinizi girin");
            doğumYeri = Console.ReadLine();
            Console.WriteLine("Kimlik numaranızı girin");
            kimlikNumarası = Console.ReadLine();


        }
        //Öğrencilerin kimlik bilgilerini ekrana basan fonksiyon
        private void print()
        {
            Console.WriteLine("Anne Adı:");
            Console.WriteLine(anneAdı);
            Console.WriteLine("Baba Adı:");
            Console.WriteLine(babaAdı);
            Console.WriteLine("Adınız:");
            Console.WriteLine(adSoyad);
            Console.WriteLine("Doğum Tarihi:");
            Console.WriteLine(doğumTarihi);
            Console.WriteLine("Doğum Yeri:");
            Console.WriteLine(doğumYeri);
            Console.WriteLine("Kimlik Numarası:");
            Console.WriteLine(kimlikNumarası);
        
        
        }


static void Main(string[] args)
        {
            Kimlik Ayşe = new Kimlik();
            Ayşe.gets();
            Ayşe.print();

        }
    }
}











