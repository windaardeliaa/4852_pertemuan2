using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4852CalculatorTugas1
{
    internal class Program
    {
        static int Penjumlahan(int a, int b)
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
        static void Main(string[] args)
        {
            Console.Title = "Kalkulator Sederhana 4852";
            Console.Write("Operasi yang akan diterjemahkan \n1. '+' \n2. '-' \n3. 'x' \n4. '/' \n\ninput nomor 1...4 : ");
            char Operasi = char.Parse(Console.ReadLine());


            if(Operasi != '1' && Operasi != '2' && Operasi != '3' && Operasi != '4')
            {
                Console.WriteLine("\nOperasi yang anda masukan tidak tersedia");
            }
            else
            {
                Console.WriteLine("\nOperasi yang anda masukan tersedia");
            }

            switch(Operasi)
            {
                case '1':
                    Console.WriteLine("\nIni Operasi Penjumlahan\n");
                    
                    break;

                case '2':
                    Console.WriteLine("\nIni Operasi Pengurangan\n");
                    break;
                case '3':
                    Console.WriteLine("\nIni Operasi Perkalian\n");
                    break;
                case '4':
                    Console.WriteLine("\nIni Operasi Pembagian\n");
                    break;
            }

            if(Operasi == '1')
            {

                Console.WriteLine("Input nilai a : ");
                int inputa = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Input nilai b : ");
                int inputb = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Hasilnya : "+ Penjumlahan(inputa, inputb));

            } 
            else if(Operasi == '2')
            {
                Console.WriteLine("Input nilai a : ");
                int inputa = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Input nilai b :");
                int inputb = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Hasilnya :"+Pengurangan(inputa, inputb));
            }
            else if(Operasi == '3')
            {
                Console.WriteLine("Input nilai a :");
                int inputa = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Input nilai B :");
                int inputb = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Hasilnya :" + Perkalian(inputa, inputb));
            }
            else if(Operasi == '4')
            {
                Console.WriteLine("Input nilai a :");
                int inputa = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Input nilai b :");
                int inputb = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Hasilnya :" + Pembagian(inputa, inputb));
            }


            Console.ReadLine();

           
        }
    }
}
