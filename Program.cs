using System;
using System.Collections.Generic;
using System.Linq;

namespace AplikasiPenjualanSederhana
{
    // Class untuk merepresentasikan barang
    public class Barang
    {
        public int Id { get; set; }
        public string Nama { get; set; }
        public decimal Harga { get; set; }
    }

    // Class untuk item di keranjang
    public class ItemKeranjang
    {
        public Barang Barang { get; set; }
        public int Jumlah { get; set; }
        public decimal Subtotal => Barang.Harga * Jumlah;
    }

    class Program
    {
        static List<Barang> daftarBarang = new List<Barang>();
        static List<ItemKeranjang> keranjang = new List<ItemKeranjang>();

        static void Main(string[] args)
        {
            InitializeDaftarBarang();
            
            while (true)
            {
                TampilkanMenuUtama();
                string pilihan = Console.ReadLine();
                
                switch (pilihan)
                {
                    case "1":
                        TampilkanDaftarBarang();
                        break;
                    case "2":
                        TambahBarangKeKeranjang();
                        break;
                    case "3":
                        TampilkanKeranjang();
                        break;
                    case "4":
                        Pembayaran();
                        break;
                    case "5":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Pilihan tidak valid!");
                        break;
                }
                
                Console.WriteLine("\nTekan Enter untuk melanjutkan...");
                Console.ReadLine();
                Console.Clear();
            }
        }

        static void InitializeDaftarBarang()
        {
            daftarBarang.AddRange(new List<Barang>
            {
                new Barang { Id = 1, Nama = "Skintific 5X Ceramide Barrier Repair Moisturizer", Harga = 89000 },
                new Barang { Id = 2, Nama = "Skintific 2% Salicylic Acid Anti Acne Serum", Harga = 75000 },
                new Barang { Id = 3, Nama = "Skintific Hyaluronic Acid Deep Hydrating Toner", Harga = 65000 },
                new Barang { Id = 4, Nama = "Skintific 10% Niacinamide Brightening Serum", Harga = 79000 },
                new Barang { Id = 5, Nama = "Skintific Gentle Face Wash Oily Skin", Harga = 45000 },
                new Barang { Id = 6, Nama = "Skintific Sunscreen SPF 50 PA++++", Harga = 55000 },
                new Barang { Id = 7, Nama = "Skintific Vitamin C + E Serum", Harga = 85000 },
                new Barang { Id = 8, Nama = "Skintific AHA BHA PHA Triple Care Serum", Harga = 89000 },
                new Barang { Id = 9, Nama = "Skintific Low pH Good Morning Gel Cleanser", Harga = 49000 },
                new Barang { Id = 10, Nama = "Skintific Centella Asiatica Calming Toner", Harga = 59000 },
                new Barang { Id = 11, Nama = "Skintific Retinol Anti Aging Serum", Harga = 95000 },
                new Barang { Id = 12, Nama = "Skintific Peptide Firming Eye Cream", Harga = 69000 },
                new Barang { Id = 13, Nama = "Skintific Acne Spot Treatment Gel", Harga = 39000 },
                new Barang { Id = 14, Nama = "Skintific Hydrating Sheet Mask (5pcs)", Harga = 35000 },
                new Barang { Id = 15, Nama = "Skintific Micellar Cleansing Water", Harga = 52000 },
                new Barang { Id = 16, Nama = "Skintific Clay Mask Pore Minimizer", Harga = 45000 },
                new Barang { Id = 17, Nama = "Skintific Lip Balm SPF 15", Harga = 29000 },
                new Barang { Id = 18, Nama = "Skintific Body Lotion Ceramide", Harga = 65000 },
                new Barang { Id = 19, Nama = "Skintific Face Mist Hydrating Spray", Harga = 42000 },
                new Barang { Id = 20, Nama = "Skintific Travel Kit Skincare Set", Harga = 125000 }
            });
        }

        static void TampilkanMenuUtama()
        {
            Console.WriteLine("==============================================");
            Console.WriteLine("     CISYA IRAFITRAH - SKINTIFIC STORE");
            Console.WriteLine("        APLIKASI PENJUALAN SEDERHANA");
            Console.WriteLine("==============================================");
            Console.WriteLine("1. Lihat Daftar Produk Skintific");
            Console.WriteLine("2. Tambah Produk ke Keranjang");
            Console.WriteLine("3. Lihat Keranjang");
            Console.WriteLine("4. Pembayaran & Struk");
            Console.WriteLine("5. Keluar");
            Console.WriteLine("==============================================");
            Console.Write("Pilih menu (1-5): ");
        }

        static void TampilkanDaftarBarang()
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("        DAFTAR PRODUK SKINTIFIC");
            Console.WriteLine("==============================================");
            Console.WriteLine("ID  | Nama Produk                                    | Harga");
            Console.WriteLine("----+-----------------------------------------------+-------------");
            
            foreach (var barang in daftarBarang)
            {
                Console.WriteLine($"{barang.Id,-3} | {barang.Nama,-45} | Rp {barang.Harga:N0}");
            }
            Console.WriteLine("==============================================");
        }

        static void TambahBarangKeKeranjang()
        {
            TampilkanDaftarBarang();
            
            Console.Write("\nMasukkan ID produk yang ingin dibeli: ");
            if (int.TryParse(Console.ReadLine(), out int idBarang))
            {
                var barang = daftarBarang.FirstOrDefault(b => b.Id == idBarang);
                if (barang != null)
                {
                    Console.Write("Masukkan jumlah: ");
                    if (int.TryParse(Console.ReadLine(), out int jumlah) && jumlah > 0)
                    {
                        var itemExisting = keranjang.FirstOrDefault(k => k.Barang.Id == idBarang);
                        if (itemExisting != null)
                        {
                            itemExisting.Jumlah += jumlah;
                        }
                        else
                        {
                            keranjang.Add(new ItemKeranjang { Barang = barang, Jumlah = jumlah });
                        }
                        Console.WriteLine($"Berhasil menambahkan {jumlah} {barang.Nama} ke keranjang!");
                    }
                    else
                    {
                        Console.WriteLine("Jumlah tidak valid!");
                    }
                }
                else
                {
                    Console.WriteLine("ID produk tidak ditemukan!");
                }
            }
            else
            {
                Console.WriteLine("ID tidak valid!");
            }
        }

        static void TampilkanKeranjang()
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("            KERANJANG BELANJA");
            Console.WriteLine("==============================================");
            
            if (keranjang.Count == 0)
            {
                Console.WriteLine("Keranjang masih kosong!");
                return;
            }

            Console.WriteLine("Nama Produk                     | Harga    | Qty | Subtotal");
            Console.WriteLine("--------------------------------+----------+-----+----------");
            
            decimal totalHarga = 0;
            foreach (var item in keranjang)
            {
                string namaPendek = item.Barang.Nama.Length > 30 ? 
                    item.Barang.Nama.Substring(0, 27) + "..." : item.Barang.Nama;
                Console.WriteLine($"{namaPendek,-31} | {item.Barang.Harga,8:N0} | {item.Jumlah,3} | {item.Subtotal,8:N0}");
                totalHarga += item.Subtotal;
            }
            
            Console.WriteLine("--------------------------------+----------+-----+----------");
            Console.WriteLine($"TOTAL HARGA: Rp {totalHarga:N0}");
            Console.WriteLine("==============================================");
        }

        static void Pembayaran()
        {
            if (keranjang.Count == 0)
            {
                Console.WriteLine("Keranjang masih kosong! Silakan tambahkan produk terlebih dahulu.");
                return;
            }

            TampilkanKeranjang();
            
            decimal totalHarga = keranjang.Sum(k => k.Subtotal);
            
            Console.Write($"\nTotal yang harus dibayar: Rp {totalHarga:N0}");
            Console.Write("\nMasukkan jumlah uang yang dibayarkan: Rp ");
            
            if (decimal.TryParse(Console.ReadLine(), out decimal uangBayar))
            {
                if (uangBayar >= totalHarga)
                {
                    decimal kembalian = uangBayar - totalHarga;
                    TampilkanStruk(totalHarga, uangBayar, kembalian);
                    
                    // Reset keranjang setelah pembayaran
                    keranjang.Clear();
                }
                else
                {
                    Console.WriteLine("Uang yang dibayarkan kurang!");
                }
            }
            else
            {
                Console.WriteLine("Jumlah uang tidak valid!");
            }
        }

        static void TampilkanStruk(decimal totalHarga, decimal uangBayar, decimal kembalian)
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("              STRUK BELANJA");
            Console.WriteLine("         CISYA IRAFITRAH - SKINTIFIC");
            Console.WriteLine("==============================================");
            Console.WriteLine($"Tanggal: {DateTime.Now:dd/MM/yyyy}");
            Console.WriteLine($"Waktu  : {DateTime.Now:HH:mm:ss}");
            Console.WriteLine("==============================================");
            Console.WriteLine("Produk Yang Dibeli:");
            Console.WriteLine("----------------------------------------------");
            
            foreach (var item in keranjang)
            {
                string namaPendek = item.Barang.Nama.Length > 35 ? 
                    item.Barang.Nama.Substring(0, 32) + "..." : item.Barang.Nama;
                Console.WriteLine($"{namaPendek}");
                Console.WriteLine($"  {item.Jumlah} x Rp {item.Barang.Harga:N0} = Rp {item.Subtotal:N0}");
            }
            
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine($"Total Harga    : Rp {totalHarga:N0}");
            Console.WriteLine($"Jumlah Bayar   : Rp {uangBayar:N0}");
            Console.WriteLine($"Kembalian      : Rp {kembalian:N0}");
            Console.WriteLine("==============================================");
            Console.WriteLine("    Terima kasih sudah berbelanja Skintific!");
            Console.WriteLine("         Stay beautiful with Skintific");
            Console.WriteLine("==============================================");
        }
    }
}
