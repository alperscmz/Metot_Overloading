using System;
namespace Metot_Overloading
{
    class Program
    {
        static void Main(string[]args)
        {
          //out parametreler

          string sayi="777";
          int outSayi;

         bool sonuc= int.TryParse(sayi,out outSayi);
         if(sonuc)
         {
             Console.WriteLine("Başarılı.");
              Console.WriteLine(outSayi);
         }
         else
         {
             Console.WriteLine("Başarısız.");
         }

       
        Metotlar instance=new Metotlar();
        instance.Topla(4,5, out int toplamSonucu);
           Console.WriteLine(toplamSonucu);

           //Metot aşırı yükleme-overloading

           int ifade=999;
           instance.EkranaYazdir(Convert.ToString(ifade));
            instance.EkranaYazdir(ifade);
            instance.EkranaYazdir("alper ","saçmaözü");
    }
    }
    class Metotlar
    {
        public void Topla(int a,int b,out int toplam)
        {
           toplam=a+b;
        }
        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }
        public void EkranaYazdir(int veri)
        {
            Console.WriteLine(veri);
        }
         public void EkranaYazdir(string veri1,string veri2)
        {
            Console.WriteLine(veri1+veri2);
        }
    }
}
