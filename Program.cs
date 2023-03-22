using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Mobil mobil1 = new Mobil();

            mobil1.Warna = "Hitam";
            mobil1.JumlahPintu = 2;
            mobil1.Merek = "Toyota";
            mobil1.Model = "Supra";
            mobil1.TahunKeluaran = 2023;

            mobil1.Gas(100);
            mobil1.Klakson("Tin Tin");
            mobil1.TampilkanInfo();
        }
    }
}