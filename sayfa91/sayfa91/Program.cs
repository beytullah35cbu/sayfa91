using System;

class Program
{
    static void Main()
    {
        string[] iller = { "Mus", "Agri", "Bolu", "Ankara", "Izmir", "Trabzon", "Antalya" };
        string[] isimler = { "Asuman", "Iclal", "Emin", "Bekir", "Ahmet", "Can", "Esma" };

        Random rastgele = new Random();

        int[] kullanilanIsimler = new int[isimler.Length];//isimleri kontrol et
        int[] kullanilanIller = new int[iller.Length]; //illeri kontrol et

        for (int a = 0; a < 7; a++) //7kez calıstır
        {
            int rastgeleIlIndex, rastgeleIsimIndex; //ısımler ıcın ayrı iller için ayrı index

            do
            {
                rastgeleIlIndex = rastgele.Next(0, iller.Length); 
            } while (kullanilanIller[rastgeleIlIndex] != 0);

            do
            {
                rastgeleIsimIndex = rastgele.Next(0, isimler.Length);
            } while (kullanilanIsimler[rastgeleIsimIndex] != 0);

            kullanilanIller[rastgeleIlIndex] = 1; // Seçilen il ve isim için indeksleri işaretle
            kullanilanIsimler[rastgeleIsimIndex] = 1;//tekrar aynı ısım ve il gelmeden 2 tarafı random eslestır

            Console.WriteLine(isimler[rastgeleIsimIndex] + "\t= " + iller[rastgeleIlIndex]);
        }

        Console.ReadKey(true);
    }
}
