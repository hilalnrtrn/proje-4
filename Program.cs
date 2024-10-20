using System;

class proje4
{
    static void Main(string[] args)
    {
        Console.WriteLine("e degerini formul kullanarak tahmin et ve Math.e ile karsılastır.");


        int terimSayisi = 20;
        double tahminiE = EDegeriniTahminEt(terimSayisi);


        Console.WriteLine($"Tahmini e degeri: {tahminiE}");
        Console.WriteLine($"Math.E sabiti: {Math.E}");

    }

    // e değerini tahmin eden metod
    static double EDegeriniTahminEt(int terimSayisi)
    {
        double e = 1.0;

        for (int n = 1; n <= terimSayisi; n++)
        {
            e += 1.0 / Faktoriyel(n);
        }

        return e;
    }

    // Faktöriyel hesaplayan metod
    static double Faktoriyel(int n)
    {
        if (n == 0 || n == 1)

            return 1;

        double sonuc = 1;

        for (int i = 2; i <= n; i++)
        {
            sonuc *= i;
        }

        return sonuc;
    }
}