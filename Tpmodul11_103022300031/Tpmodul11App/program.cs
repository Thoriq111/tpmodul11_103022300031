using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tpmodul11_103022300031.Tpmodul11App
{
    using AljabarLibraries;
    using Tpmodul11_103022300031.AljabarLibraries.AljabarLibraries;

    class Program
    {
        static void Main(string[] args)
        {
            double[] persamaan1 = { 1, -3, -10 };
            double[] akar = PersamaanKuadrat.AkarPersamaanKuadrat(persamaan1);
            Console.WriteLine("Akar dari x^2 - 3x - 10 = 0:");
            foreach (var item in akar)
                Console.WriteLine(item);

            double[] persamaan2 = { 2, -3 };
            double[] hasilKuadrat = PersamaanKuadrat.HasilKuadrat(persamaan2);
            Console.WriteLine("Hasil kuadrat dari (2x - 3)^2:");
            foreach (var item in hasilKuadrat)
                Console.WriteLine(item);
        }
    }
}
