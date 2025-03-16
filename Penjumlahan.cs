using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul5_2311104041
{
    class Penjumlahan
    {
        public static T JumlahTigaAngka<T>(T angka1, T angka2, T angka3)
        {
            dynamic a = angka1;
            dynamic b = angka2;
            dynamic c = angka3;
            return a + b + c;
        }

        static void Main()
        {
            string nim = "2311104041";
            char lastDigit = nim[nim.Length - 1]; 

            dynamic hasil;

            if (lastDigit == '1' || lastDigit == '2')
            {
                float angka1 = 12.1f, angka2 = 34.2f, angka3 = 56.3f;
                hasil = JumlahTigaAngka(angka1, angka2, angka3);
            }
            else if (lastDigit == '3' || lastDigit == '4' || lastDigit == '5')
            {
                double angka1 = 12.12, angka2 = 34.34, angka3 = 56.56;
                hasil = JumlahTigaAngka(angka1, angka2, angka3);
            }
            else if (lastDigit == '6' || lastDigit == '7' || lastDigit == '8')
            {
                int angka1 = 12, angka2 = 34, angka3 = 56;
                hasil = JumlahTigaAngka(angka1, angka2, angka3);
            }
            else 
            {
                long angka1 = 12L, angka2 = 34L, angka3 = 56L;
                hasil = JumlahTigaAngka(angka1, angka2, angka3);
            }

            Console.WriteLine($"Hasil penjumlahan untuk NIM {nim} adalah: {hasil}");
        }
    }
}
