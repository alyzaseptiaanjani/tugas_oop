using System;

namespace TokoOnlineApp
{
    class Program
    {
        static void Main(string[] args)
        {
            KeranjangBelanja keranjang = new KeranjangBelanja();

            // Membuat produk dengan constructor
            Produk p1 = new Elektronik("Laptop", 7500000, 24);
            Produk p2 = new Pakaian("Kaos Polos", 75000, "L");

            // Menambahkan ke keranjang (Overloading + Composition)
            keranjang.TambahProduk(p1);
            keranjang.TambahProduk(p2);
            keranjang.TambahProduk("Mouse", 120000); // versi overloading

            // Menampilkan isi keranjang
            keranjang.TampilkanKeranjang();
        }
    }
}
