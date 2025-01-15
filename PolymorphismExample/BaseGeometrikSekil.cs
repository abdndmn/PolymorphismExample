
using System.Threading.Channels;

namespace PolymorphismExample
{
    public class BaseGeometrikSekil//BaseClass
    {
        public double Genislik { get; set; }//Propertiler
        public double Yukseklik { get; set; }

        public virtual double AlanHesapla()//virtual keywordü ile override aldıgında değiştirilebilecek
        {
            return Genislik * Yukseklik;
        }

    }

    internal class Kare : BaseGeometrikSekil//Türetilmiş class
    {
        public override double AlanHesapla()
        {
            return base.AlanHesapla();
        }


    }

    internal class Dikdortgen : BaseGeometrikSekil//Türetilmiş class
    {
        public override double AlanHesapla()
        {
            return base.AlanHesapla();
        }

    }

    internal class DikUcgen : BaseGeometrikSekil//Türetilmiş class
    {

        public override double AlanHesapla()
        {
            return Genislik*Yukseklik/2;//alan hesabı farkı, override keywordü ile değiştirilebildi.
        }

    }
}
