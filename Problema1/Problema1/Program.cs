using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti numarul de elemente pentru primul vector");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti numarul de elemente pentru al doilea vector");
            int m = int.Parse(Console.ReadLine());
            int[] v1 = new int[n];
            int[] v2 = new int[m];
            Console.WriteLine("Introduceti elementele pentru primul vector");
            for (int i = 0; i < n; ++i)
                v1[i] = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti elementele pentru al doilea vector");
            for (int i = 0; i < m; ++i)
                v2[i] = int.Parse(Console.ReadLine());
            if (!ArrayUtils.IsSorted(v1) || !ArrayUtils.IsSorted(v2))
                throw new ArgumentException("Avem cel putin un vector care nu e sortat crescator");
            ArrayUtils.AplicaOperatie(v1, 4, Operatie.Adunare);
            for (int i = 0; i < v1.Length; ++i)
                Console.Write(v1[i] + " ");
            Console.WriteLine("\n3 apare in v2 de " + ArrayUtils.NumarAparitii(v2, 3) + " ori");
            Console.WriteLine("Indexul lui 3 in v1 este:" + ArrayUtils.Index(v1, 3));
            int[] v3 = ArrayUtils.MergeArrays(v1, v2);
            Console.WriteLine("Vectorul intercalat format din v1 si v2 este: ");
            for (int i = 0; i < v3.Length; ++i)
                Console.Write(v3[i] + " ");
        }
    }
}
