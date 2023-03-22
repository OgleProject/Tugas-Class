namespace TugasClass
{
    public class Mobil
    {
        public string Warna { get; set; }
        public int JumlahPintu { get; set; }
        public string Merek { get; set; }
        public string Model { get; set; }
        public int TahunKeluaran { get; set; }

        public void Gas(int kecepatan)
        {
            Console.WriteLine("Mobil Model " + Model + ", berjalan denga kecepatan " + kecepatan + " km/jam.");
        }

        public void Klakson(string suara)
        {
            Console.WriteLine("Mobil " + Merek + " " + Model + " berbunyi klakson dengan suara " + suara + ".");
        }

        public void TampilkanInfo()
        {
            Console.WriteLine("Mobil Saya berwarna " + Warna + ", Merek " + Merek + ", Model " + Model + ", Keluaran Tahun " + TahunKeluaran + ", dengan Jumlah Pintu sebanyak " + JumlahPintu);
        }
    }
}