# 📱 Aplikasi Penjualan Skintific Store

### Cisya Irafitrah - SMK Swasta RK Bintang Timur

---

## 📋 Deskripsi Project

Aplikasi desktop sederhana menggunakan **C# Console** untuk mencatat penjualan produk **Skintific**. Dibuat sebagai tugas **Ujian Akhir Semester Genap 2024/2025** mata pelajaran Kejuruan - Rekayasa Perangkat Lunak.

## 👤 Informasi Developer

- **Nama**: Cisya Irafitrah
- **Sekolah**: SMK Swasta RK Bintang Timur, Pematangsiantar
- **Kelas**: X (Rekayasa Perangkat Lunak)
- **Kurikulum**: Merdeka
- **Brand**: Skintific Skincare Products

---

## ✨ Fitur Utama

### 🛍️ **1. Daftar Produk Skintific**

- Menampilkan 20 produk Skintific lengkap
- Informasi: ID, Nama Produk, Harga
- Produk skincare terlengkap dari Skintific

### 🛒 **2. Keranjang Belanja**

- Tambah produk ke keranjang dengan jumlah
- Update jumlah otomatis jika produk sama
- Tampilan keranjang yang rapi dan jelas

### 💰 **3. System Pembayaran**

- Hitung total harga otomatis
- Input jumlah uang pembayaran
- Hitung kembalian secara akurat

### 🧾 **4. Struk Transaksi**

- Detail produk yang dibeli
- Total harga, jumlah bayar, kembalian
- Tanggal dan waktu transaksi
- Header khusus Skintific Store

---

## 🛍️ Daftar Produk Skintific (20 Items)

| ID  | Nama Produk                            | Harga      |
| --- | -------------------------------------- | ---------- |
| 1   | 5X Ceramide Barrier Repair Moisturizer | Rp 89.000  |
| 2   | 2% Salicylic Acid Anti Acne Serum      | Rp 75.000  |
| 3   | Hyaluronic Acid Deep Hydrating Toner   | Rp 65.000  |
| 4   | 10% Niacinamide Brightening Serum      | Rp 79.000  |
| 5   | Gentle Face Wash Oily Skin             | Rp 45.000  |
| 6   | Sunscreen SPF 50 PA++++                | Rp 55.000  |
| 7   | Vitamin C + E Serum                    | Rp 85.000  |
| 8   | AHA BHA PHA Triple Care Serum          | Rp 89.000  |
| 9   | Low pH Good Morning Gel Cleanser       | Rp 49.000  |
| 10  | Centella Asiatica Calming Toner        | Rp 59.000  |
| 11  | Retinol Anti Aging Serum               | Rp 95.000  |
| 12  | Peptide Firming Eye Cream              | Rp 69.000  |
| 13  | Acne Spot Treatment Gel                | Rp 39.000  |
| 14  | Hydrating Sheet Mask (5pcs)            | Rp 35.000  |
| 15  | Micellar Cleansing Water               | Rp 52.000  |
| 16  | Clay Mask Pore Minimizer               | Rp 45.000  |
| 17  | Lip Balm SPF 15                        | Rp 29.000  |
| 18  | Body Lotion Ceramide                   | Rp 65.000  |
| 19  | Face Mist Hydrating Spray              | Rp 42.000  |
| 20  | Travel Kit Skincare Set                | Rp 125.000 |

---

## 🚀 Cara Install & Menjalankan

### **Metode 1: Visual Studio (Recommended)**

1. Download **Visual Studio 2022 Community** (gratis)
2. Install dengan workload **.NET desktop development**
3. Buat **New Project** → **Console App**
4. Copy-paste kode dari `Program.cs`
5. Tekan **F5** untuk run

### **Metode 2: Visual Studio Code**

1. Install **VS Code** dan **.NET SDK**
2. Install extension **C#**
3. Buat folder project baru
4. Terminal: `dotnet new console`
5. Edit `Program.cs`, lalu `dotnet run`

### **Metode 3: Command Prompt**

```bash
# Install .NET SDK terlebih dahulu
dotnet new console -n SkintificStore
cd SkintificStore
# Edit Program.cs
dotnet run


Metode 4: Online (Tanpa Install)

- Gunakan: https://dotnetfiddle.net/
- Copy-paste kode dan klik Run

_________________________________________________________

📱 Cara Menggunakan
1. Jalankan aplikasi
2. Menu 1: Lihat daftar produk Skintific
3. Menu 2: Tambah produk ke keranjang
  - Masukkan ID produk
  - Masukkan jumlah yang diinginkan
4. Menu 3: Lihat isi keranjang belanja
5. Menu 4: Lakukan pembayaran
  - Masukkan jumlah uang
  - Lihat struk transaksi
6. Menu 5: Keluar dari aplikasi

__________________________________________________________

Menu Utama
🖼️ Screenshot Interface

==============================================
     CISYA IRAFITRAH - SKINTIFIC STORE
        APLIKASI PENJUALAN SEDERHANA
==============================================
1. Lihat Daftar Produk Skintific
2. Tambah Produk ke Keranjang
3. Lihat Keranjang
4. Pembayaran & Struk
5. Keluar
==============================================


Struk Transaksi
==============================================
              STRUK BELANJA
         CISYA IRAFITRAH - SKINTIFIC
==============================================
Tanggal: 30/05/2025
Waktu  : 14:30:15
==============================================
Produk Yang Dibeli:
----------------------------------------------
5X Ceramide Barrier Repair Moisturizer
  2 x Rp 89,000 = Rp 178,000
----------------------------------------------
Total Harga    : Rp 178,000
Jumlah Bayar   : Rp 200,000
Kembalian      : Rp 22,000
==============================================
    Terima kasih sudah berbelanja Skintific!
         Stay beautiful with Skintific
==============================================

🛠️ Teknologi yang Digunakan
- Bahasa: C# (.NET)
- Platform: Console Application
- IDE: Visual Studio / Visual Studio Code
- Framework: .NET Core/Framework


SkintificStore/
│
├── Program.cs              # File utama aplikasi
├── SkintificStore.csproj   # File konfigurasi project
├── README.md               # Dokumentasi ini
└── bin/                    # File executable
    └── Debug/
        └── SkintificStore.exe

_________________________________________________________

👨‍💻 Kode Program
File lengkap tersedia di: Program.cs
Classes yang digunakan:
1. Barang: Model untuk produk Skintific
2. ItemKeranjang: Model untuk item di keranjang
3. Program: Main class dengan semua logika aplikasi

_________________________________________________________


🎓 Informasi Akademik
Mata Pelajaran: Kejuruan (Rekayasa Perangkat Lunak)
Jenis Soal: Praktek & Teori
Waktu Pengerjaan: 120 menit
Kurikulum: Merdeka
Semester: Genap 2024/2025

_________________________________________________________

📞 Kontak
Sekolah: SMK Swasta RK Bintang Timur
Alamat: Jalan Melanthon Siregar Gang Sipahutar, Pematangsiantar
Website: www.smkbintangtimur.sch.id
Email: smkbt_siantar@yahoo.co.id

________________________________________________________


🌟 Fitur Unggulan
1. Brand Focus: Khusus produk Skintific
2. User Experience: Interface yang mudah dipahami
3. Accurate Calculation: Perhitungan yang akurat
4. Professional Receipt: Struk yang profesional
5. Error Handling: Penanganan error yang baik

________________________________________________________

© 2025 Cisya Irafitrah - SMK Swasta RK Bintang Timur
Stay beautiful with Skintific! 💫

File README.md ini sudah lengkap dan profesional untuk dokumentasi project ujian Cisya Irafitrah! 📋✨
