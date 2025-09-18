using System;
using System.Collections.Generic;

namespace TokoOnlineApp
{
    // Composition: Keranjang punya banyak Produk
    class KeranjangBelanja
    {
        private List<Produk> daftarProduk = new List<Produk>();

        // Overloading
        public void TambahProduk(Produk p)
        {
            daftarProduk.Add(p);
            Console.WriteLine($"{p.Nama} berhasil ditambahkan ke keranjang.");
        }

        public void TambahProduk(string nama, double harga)
        {
            daftarProduk.Add(new Produk(nama, harga));
            Console.WriteLine($"{nama} berhasil ditambahkan ke keranjang.");
        }

        public void TampilkanKeranjang()
        {
            Console.WriteLine("\nIsi Keranjang:");
            foreach (var p in daftarProduk)
            {
                p.Info(); // Polymorphism
            }
        }
    }
}
