using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSIApotek
{
    class ViewData
    {
        private int hargaObat = 0;
        private int uangBayar = 0;

        public void HargaObat(int hrg)
        {
            hargaObat = Convert.ToInt32(hrg);
        }

        public void UangBayar(int byr)
        {
            uangBayar = Convert.ToInt32(byr);
        }

        public void Resume()
        {

            Console.WriteLine("Harga Obat : " + hargaObat);
            Console.WriteLine("Kembalian Anda : " + (uangBayar - hargaObat));
            Console.WriteLine("");
            Console.WriteLine("Tekan Apa Saja Untuk Keluar. . .");
        }


        class hitungan
        {
            public static void Main(string[] args)
            {

                int HargaObt = 0;
                Console.WriteLine("APOTEK SEHAT");
                Console.WriteLine("");
                Console.Write("Masukan Harga Obat : ");
                HargaObt = Convert.ToInt32(Console.ReadLine());

                int UangByr = 0;
                Console.Write("Masukan Uang Anda : ");
                UangByr = Convert.ToInt32(Console.ReadLine());

                //masuk class ViewData
                ViewData proses = new ViewData();
                proses.HargaObat(HargaObt);
                proses.UangBayar(UangByr);
                Console.WriteLine("");
                proses.Resume();
                Console.ReadKey(true);
            }
        }
    }
}
