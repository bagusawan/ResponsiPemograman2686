using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectCustomer
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek Customer
        static List<Customer> daftarCustomer = new List<Customer>();
        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";
            while (true)
            {
                TampilMenu();
                Console.Write("\nNomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());
                switch (nomorMenu)
                {
                    case 1:
                        TambahCustomer();
                        break;

                    case 2:
                        HapusCustomer();
                        break;

                    case 3:
                        TampilCustomer();
                        break;

                    case 4: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();
            // PERINTAH: lengkapi kode untuk menampilkan menu
            Console.Clear();
            Console.WriteLine("Pilih Menu Aplikasi");
            Console.WriteLine("1. Tambah Costumer");
            Console.WriteLine("2. Hapus Costumer");
            Console.WriteLine("3. Tampilkan Costumer");
            Console.WriteLine("4. Keluar");
        }
        static void TambahCustomer()
        {
            Console.Clear();
            // PERINTAH: lengkapi kode untuk menambahkan Customer ke dalam collection
            Console.WriteLine();
            Console.WriteLine("Tambah Data Customer\n");
            Custumer Customer = new Customer();
            Console.Write("Kode Customer : ");
            Customer.KodeCustomer = Console.ReadLine();
            Console.Write("Nama Customer : ");
            Kostumer.NamaCustomer = Console.ReadLine();
            Console.Write("Total Piutang  : ");
            Kostumer.TotalPiutang = Convert.ToDouble(Console.ReadLine());
            daftarCustomer.Add(Customer);
            Console.WriteLine();
            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusCustomer()
        {
            Console.Clear();
            // PERINTAH: lengkapi kode untuk menghapus Customer dari dalam collection
            int i = -1, hapus = -1;
            Console.WriteLine("Hapus Data Customer\n");
            Console.Write("Kode Customer : ");
            string kode = Console.ReadLine();
            foreach (Customer Customer in daftarCustomer)
            {
                i++;
                if (Customer.KodeCustomer == kode)
                {
                    hapus = i;
                }
            }
            if (hapus != -1)
            {
                daftarCustomer.RemoveAt(hapus);
                Console.WriteLine("\nData Customer Berhasil dihapus");
            }
            else
            {
                Console.WriteLine("\nKode Customer tidak ditemukan!!!");
            }

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilCustomer()
        {
            Console.Clear();
            // PERINTAH: lengkapi kode untuk menampilkan daftar Customer yang ada di dalam collection
            int Urut = 0;
            Console.WriteLine("Data Customer\n");
            foreach (Customer Customer in daftarCustomer)
            {
                Urut++;
                Console.WriteLine("{0}. {1}, {2}, {3:N0}", Urut, Customer.KodeCustomer, Customer.NamaCustomer, Customer.TotalPiutang);
            }
            if (Urut < 1)
            {
                Console.WriteLine("Data Customer Kosong!!!");
            }

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
