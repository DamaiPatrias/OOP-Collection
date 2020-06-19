using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_Colletion.KelasInduk;
using OOP_Colletion.KelasAnak;

namespace OOP_Colletion
{
    class Program
    {
        static void Main(string[] args)
        {
            KaryawanTetap karyawanTetap = new KaryawanTetap();
            karyawanTetap.nik = "19191919";
            karyawanTetap.nama = "Damai";
            karyawanTetap.gajibulanan = 8000000;

            KaryawanHarian karyawanHarian = new KaryawanHarian();
            karyawanHarian.nik = "20202020";
            karyawanHarian.nama = "Patria";
            karyawanHarian.jumlahjamkerja = 6;
            karyawanHarian.upahperjam = 100000;

            Sales sales = new Sales();
            sales.nik = "21212121";
            sales.nama = "Suyana";
            sales.jumlahpenjualan = 100;
            sales.komisi = 50000;

            List<Karyawan> ListKaryawan = new List<Karyawan>();
            ListKaryawan.Add(karyawanTetap);
            ListKaryawan.Add(karyawanHarian);
            ListKaryawan.Add(sales);

            int noUrut = 1;

            foreach (Karyawan karyawan in ListKaryawan)
            {
                Console.WriteLine("{0}. NIK = {1}, Nama = {2}, Gaji = {3}", 
                    noUrut, karyawan.nik, karyawan.nama, karyawan.Gaji());
                

                noUrut++;
            }

            Console.ReadKey();
        }
    }
}
