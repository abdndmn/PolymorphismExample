using PolymorphismExample;

BaseGeometrikSekil kare = new Kare
{
    Genislik=10,
    Yukseklik=10,
};
Console.WriteLine("Karenin Alanı: "+kare.AlanHesapla());

BaseGeometrikSekil dikdortgen = new Dikdortgen
{
    Genislik = 10,
    Yukseklik = 25,
};

Console.WriteLine("Dikdörtgenin Alanı: " + dikdortgen.AlanHesapla());

BaseGeometrikSekil dikUcgen = new DikUcgen
{
    Genislik = 10,
    Yukseklik = 30,
};
Console.WriteLine("Dik Üçgenin Alanı: " + dikUcgen.AlanHesapla());