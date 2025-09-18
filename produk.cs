using System;

namespace TokoOnlineApp
{
    // Class (Encapsulation + Constructor)
    class Produk
    {
        private string nama;
        private double harga;

        public Produk(string nama, double harga)
        {
            this.nama = nama;
            this.harga = harga;
        }

        public string Nama => nama;
        public double Harga => harga;

        public virtual void Info()
        {
            Console.WriteLine($"Produk: {nama}, Harga: Rp{harga}");
        }
    }
}

