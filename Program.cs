using System;

class Program
{
    static void Main()
    {
        int angka1 = 23;
        int angka2 = 11;
        int angka3 = 04;

        int hasil = Penjumlahan.JumlahTigaAngka(angka1, angka2, angka3);
        Console.WriteLine($"Hasil Penjumlahan: {hasil}");

        SimpleDataBase<int> database = new SimpleDataBase<int>();

        database.AddNewData(angka1);
        database.AddNewData(angka2);
        database.AddNewData(angka3);

        database.PrintAllData();
    }
}
