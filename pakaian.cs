using System;

namespace TokoOnlineApp
{
    // Inheritance dari Produk
    class Pakaian : Produk
    {
        public string Ukuran { get; set; }

        public Pakaian(string nama, double harga, string ukuran)
            : base(nama, harga)
        {
            Ukuran = ukuran;
        }

        // Overriding
        public override void Info()
        {
            Console.WriteLine($"Pakaian: {Nama}, Harga: Rp{Harga}, Ukuran: {Ukuran}");
        }
    }
}
