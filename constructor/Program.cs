using System;

public class Bebek
{
    // Property'ler
    public DateTime DogumTarihi { get; set; }
    public string Ad { get; set; }
    public string Soyad { get; set; }

    // Default constructor (parametresiz)
    public Bebek()
    {
        // Default constructor içinde herhangi bir işlem yapılabilir.
        Console.WriteLine("Bebek nesnesi oluşturuluyor...");
    }

    // Parametreli constructor (Ad ve Soyad parametreleri ile)
    public Bebek(string ad, string soyad)
    {
        // Parametreli constructor içinde "Ingaaaa" yazısını ekrana yazdırma
        Console.WriteLine("Ingaaaa");

        // Doğum tarihi o an olarak atanıyor
        this.DogumTarihi = DateTime.Now;

        // Ad ve Soyad'ı atama
        this.Ad = ad;
        this.Soyad = soyad;
    }
}

class Program
{
    static void Main()
    {
        // Default constructor ile bebek nesnesi oluşturuluyor
        Bebek bebek1 = new Bebek();

        // Parametreli constructor ile bebek nesnesi oluşturuluyor
        Bebek bebek2 = new Bebek("Ali", "Kara");

        // Bebek2'nin özelliklerini konsola yazdırıyoruz
        Console.WriteLine("Bebek Adı: " + bebek2.Ad);
        Console.WriteLine("Bebek Soyadı: " + bebek2.Soyad);
        Console.WriteLine("Bebek Doğum Tarihi: " + bebek2.DogumTarihi);
    }
}
