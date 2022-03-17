using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktikum1_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Calculator";
            Console.WriteLine("Pilih Menu Calculator");
            Console.WriteLine();//baris kosong
            Console.WriteLine("1. Penambahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");
            Console.WriteLine();//baris kosong
            Console.Write("Input nomor menu (1-4) : ");
            int nomor = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();//baris kosong

            //Percabangan
            if (nomor == 1)
            {
                Console.WriteLine("Operasi Penjumlahan");
                Console.WriteLine();//baris kosong
                Console.Write("Inputkan nilai a = ");
                int a = int.Parse(Console.ReadLine());//proses casting
                Console.Write("Inputkan nilai b = ");
                int b = Convert.ToInt32(Console.ReadLine());//proses casting
                Console.WriteLine();//baris kosong
                Console.WriteLine("Hasil Penambahan " + a + " + " + b + " = " + Penambahan(a, b));
            }
            else if (nomor == 2)
            {
                Console.WriteLine("Operasi Pengurangan");
                Console.WriteLine();//baris kosong
                Console.Write("Inputkan nilai a = ");
                int a = int.Parse(Console.ReadLine());//proses casting
                Console.Write("Inputkan nilai b = ");
                int b = Convert.ToInt32(Console.ReadLine());//proses casting
                Console.WriteLine();//baris kosong
                Console.WriteLine("Hasil Pengurangan {0} - {1} = {2}", a, b, Pengurangan(a, b));
            }
            else if (nomor == 3)
            {
                Console.WriteLine("Operasi Perkalian");
                Console.WriteLine();//baris kosong
                Console.Write("Inputkan nilai a = ");
                int a = int.Parse(Console.ReadLine());//proses casting
                Console.Write("Inputkan nilai b = ");
                int b = Convert.ToInt32(Console.ReadLine());//proses casting
                Console.WriteLine();//baris kosong
                Console.WriteLine("Hasil Perkalian {0} * {1} = {2}", a, b, Perkalian(a, b));
            }
            else if (nomor == 4)
            {
                Console.WriteLine("Operasi Pembagian");
                Console.WriteLine();//baris kosong
                Console.Write("Inputkan nilai a = ");
                int a = int.Parse(Console.ReadLine());//proses casting
                Console.Write("Inputkan nilai b = ");
                int b = Convert.ToInt32(Console.ReadLine());//proses casting
                Console.WriteLine();//baris kosong
                Console.WriteLine("Hasil Pembagian {0} / {1} = {2}", a, b, Pembagian(a, b));
            }
            else
            {
                Console.WriteLine("Maaf, menu yang anda pilih tidak tersedia");
            }

            Console.WriteLine("\nTekan sembarang key untuk keluar");
            Console.ReadKey();
        }
        static int Penambahan(int a, int b)
        {
            return a + b;
        }
        static int Pengurangan(int a, int b)
        {
            return a - b;
        }
        static int Perkalian(int a, int b)
        {
            return a * b;
        }
        static int Pembagian(int a, int b)
        {
            return a / b;
        }
    }
}
