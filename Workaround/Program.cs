using Business.Concrete;
using Entities.Concrete;
using System;
namespace Workaround
{
    class Program
    {
        private static object person1;

        static void Main(string[] args)
        {
            //string mesaj = "Selam"; // Metinsel Değişken
            //Console.WriteLine(mesaj);
            //double tutar = 10000;
            //Console.WriteLine(tutar*1.18);  
            //int sayi=100;
            //bool girisYapmisMi = false;//True ya da False ,uygulamayı dallandırmak için kullanırız.
            //string ad = "Eylem";
            //string soyad = "Önderci";
            //int dogumYili = 2003;
            //long tcNo = 22705656788;  // Bunları mantıksal gruplara ayırdığımızda Nesne olurlar. Nesne tabanlı bu mantıktan gelir. Yani class.
            //Vatandas vatandas = new Vatandas();


            //SelamVer(isim:"Engin");
            //SelamVer(isim:"Eylem");
            //SelamVer(isim:"Kerem");
            //SelamVer();



            //Diziler/ Arrays

            //string ogrenci1 = "Eylem";
            //string ogrenci2 = "Kerem";
            //string ogrenci3 = "Engin";

            //Console.WriteLine(ogrenci1);
            //Console.WriteLine(ogrenci2);    
            //Console.WriteLine(ogrenci3);    

            //string[] ogrenciler = new string[3];
            //ogrenciler[0] = "Eylem";
            //ogrenciler[1] = "Kerem";
            //ogrenciler[2] = "Engin";
            //ogrenciler=new string[4];
            //ogrenciler[3] = "İlker";     // Referans tipleri: Stack ve Heap Eşittirin sol tarafı stack . Referans tiplerini kullanabilmek için heapte bellek açmak gerek.

            //for(int i = 0; i<ogrenciler.Length; i++)   // Array, Class, Abstract, referans
            //{
            //    Console.WriteLine(ogrenciler[i]);

            //}

            //string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" };
            //string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır" };

            //sehirler2 = sehirler1;
            //sehirler1[0] = "Adana";
            //Console.WriteLine(sehirler2[0]);


            //int sayi2 = 20;
            //int sayi1 = 10;
            //sayi2 = sayi1;
            //sayi1 = 30;
            ////sayi2 = 10;


            //foreach(string sehir in sehirler1)  //Dizi formatındaki yapılar.
            //{
            //    Console.WriteLine(sehir);
            //}
            ////MyList şeklinde bir koleksiyon kurma.
            //List<string> Yenisehirler1 = new List<string> {"Ankara1","İstanbul1","İzmir1"};  //List bir sınıftır. Yeni listeye yeni eleman ekledik.
            //Yenisehirler1.Add(item: "Adana");
            //foreach (var  sehir in Yenisehirler1)
            //{

            //}
            Person person1 = new Person();
            person1.FirstName = "Eylem";
            person1.LastName = "Önderci";
            person1.DateOfBirthYear = 2003;
            person1.NationalIdentity = 123;

            Person person2 = new Person();
            person2.FirstName = "Kerem";


            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);


            Person person = new Person();



            Console.ReadLine();  // Proje Çalıştığı zaman tuşa basmamızı bekleyen imleç.
        }



        //static void SelamVer(string isim = "isimsiz")
        //{
        //    Console.WriteLine("Merhaba" + isim);
        //}

        //static int Topla(int sayi1,int sayi2, int sonuc)
        //{
        //    Console.WriteLine("Toplam: "+ sonuc.ToString());
        //    int sonuc = sayi1 + sayi2;
        //    return sonuc;
        //}

    }
}


    // public class Vatandas // Bir class'ın içinde değişken tanımlarsak sadece o class'ın içinde değişkenleri kullanabiliriz.
    // {
    //    //string ad = "Eylem";   // Eğer başına public koyarsak dışardan da kullanılabilsin anlamına gelir.
    //    //string soyad = "Önderci";
    //    //int dogumYili = 2003;
    //    //long tcNo = 22705656788;

    //    //Pascal Casing=Kelimelerin ilk harfi büyük
    //    public string Ad { get; set; }
    //    public string Soyad { get; set; }

    //    public int dogumYili { get; set; }

    //    public long tcNo{ get; set; }


    //}
