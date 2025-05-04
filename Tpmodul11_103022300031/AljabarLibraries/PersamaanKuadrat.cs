namespace Tpmodul11_103022300031.AljabarLibraries
{
    namespace AljabarLibraries
    {
        public class PersamaanKuadrat
        {
            public static double[] AkarPersamaanKuadrat(double[] persamaan)
            {
                double a = persamaan[0];
                double b = persamaan[1];
                double c = persamaan[2];
                double diskriminan = b * b - 4 * a * c;

                if (diskriminan < 0)
                    return new double[] { }; // tidak ada akar real

                double akar1 = (-b + Math.Sqrt(diskriminan)) / (2 * a);
                double akar2 = (-b - Math.Sqrt(diskriminan)) / (2 * a);
                return new double[] { akar1, akar2 };
            }

            public static double[] HasilKuadrat(double[] persamaan)
            {
                double a = persamaan[0];
                double b = persamaan[1];

                double a_kuadrat = a * a;
                double dua_ab = 2 * a * b;
                double b_kuadrat = b * b;

                return new double[] { a_kuadrat, dua_ab, b_kuadrat };
            }
        }
    }
}
