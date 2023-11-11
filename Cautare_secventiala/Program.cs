using System;

namespace Cautare_secventiala
{

    class Program
    {
        static void Main(string[] args)
        {
            int[] v = new int[100];
            int i, x, ok;

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
            ok = 0;

            for(i=1;i<=n;i++)
            {
                if (v[i] == x)
                    ok = 1;
            }
            if (ok == 1)
                Console.WriteLine("Valoare gasita!");
            else
                Console.WriteLine("Valoarea nu exista in vector!");

            Console.ReadLine();
        }
}
}
