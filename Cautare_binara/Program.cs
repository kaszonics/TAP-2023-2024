using System;

namespace Cautare_binara
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] v = new int[100];
            int i, x;
            // se citeste numarul de elemente din vector
            Console.Write("Numarul de elemente din vector:");
            int n = Convert.ToInt32(Console.ReadLine());

            // se citesc elementele vectorului
            for (i = 1; i <= n; i++)
            {
                Console.Write("v[" + i + "]=");
                v[i] = Convert.ToInt32(Console.ReadLine());
            }
            // se citeste valoare cautata
            Console.Write("Valoarea cautata din vector:");
            x = Convert.ToInt32(Console.ReadLine());
            int gasit = -1, left = 0, right = n;
            while (left <=right)
            {
                int mid = (left + right) / 2;
                if (v[mid]==x)
                {
                    gasit = mid;
                    break;
                }
                if (v[mid] > x)
                    right = mid - 1;
                if (v[mid] < x)
                    left = mid + 1;
            }
            Console.WriteLine("Valoare gasita: " + gasit);

            Console.ReadLine();
        }
    }
}
