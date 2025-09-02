using System;

#region HomeWork
abstract class Tasit
{
    public string Marka { get; set; }
    public string Model { get; set; }
    public decimal TabanFiyat { get; set; }

    public abstract decimal Fiyat { get; }
}


class Araba : Tasit
{
    public string YakitTuru { get; set; } 
    public string VitesTuru { get; set; }

    public override decimal Fiyat
    {
        get
        {
            decimal fiyat = TabanFiyat;

            if (YakitTuru.ToLower() == "dizel")
                fiyat += 5000;

            if (VitesTuru.ToLower() == "otomatik")
                fiyat += 10000;

            return fiyat;
        }
    }
}

class Ucak : Tasit
{
    public int Kapasite { get; set; } 

    public override decimal Fiyat
    {
        get
        {
            return TabanFiyat + (Kapasite * 100);
        }
    }
}


class Tren : Tasit
{
    public int VagonSayisi { get; set; }
    public string Sinif { get; set; } 

    public override decimal Fiyat
    {
        get
        {
            decimal fiyat = TabanFiyat;

            if (Sinif.ToUpper() == "A")
                fiyat += 50000;
            else if (Sinif.ToUpper() == "B")
                fiyat += 10000;

            fiyat += VagonSayisi * 30000;

            return fiyat;
        }
    }
}


class Gemi : Tasit
{
    public int KamaraSayisi { get; set; }

    public override decimal Fiyat
    {
        get
        {
            return TabanFiyat + (KamaraSayisi * 40000);
        }
    }
}
#endregion

internal class Program
{
    static void Main(string[] args)
    {
        Araba araba = new Araba
        {
            Marka = "BMW",
            Model = "X5",
            TabanFiyat = 500000,
            YakitTuru = "Dizel",
            VitesTuru = "Otomatik"
        };
        Console.WriteLine($"Araba Fiyatı: {araba.Fiyat}");

        Ucak ucak = new Ucak
        {
            Marka = "Airbus",
            Model = "A320",
            TabanFiyat = 2000000,
            Kapasite = 180
        };
        Console.WriteLine($"Uçak Fiyatı: {ucak.Fiyat}");

        Tren tren = new Tren
        {
            Marka = "TCDD",
            Model = "Hızlı Tren",
            TabanFiyat = 1000000,
            VagonSayisi = 5,
            Sinif = "A"
        };
        Console.WriteLine($"Tren Fiyatı: {tren.Fiyat}");

        Gemi gemi = new Gemi
        {
            Marka = "MSC",
            Model = "Cruise",
            TabanFiyat = 5000000,
            KamaraSayisi = 50
        };
        Console.WriteLine($"Gemi Fiyatı: {gemi.Fiyat}");

        Console.ReadLine();
    }
}
