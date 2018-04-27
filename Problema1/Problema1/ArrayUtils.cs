using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema1
{
    public enum Operatie {Adunare, Scadere, Inmultire, Impartire}
    class ArrayUtils
    {
        public static int ElementePare (int[] vector)
        {
            int count = 0;
            for (int i = 0; i < vector.Length; ++i)
            {
                if (vector[i] % 2 == 0)
                    ++count;
            }
            return count;
        }

        public static int ElementeImpare(int[] vector)
        {
            int count = 0;
            for (int i = 0; i < vector.Length; ++i)
            {
                if (vector[i] % 2 != 0)
                    ++count;
            }
            return count;
        }

        public static int NumarAparitii (int[] vector, int x)
        {
            int count = 0;
            for (int i = 0; i < vector.Length; ++i)
            {
                if (x == vector[i])
                    ++count;
            }
            return count;
        }

        public static int Index (int[] vector, int x)
        {
            for (int i = 0; i < vector.Length; ++i)
            {
                if (vector[i] == x)
                    return i;
            }
            return -1;
        }

        public static void AplicaOperatie (int[] vector, int x, Operatie op)
        {
            for (int i = 0; i < vector.Length; ++i)
            {
                switch (op)
                {
                    case Operatie.Adunare:
                        vector[i] += x;
                        break;
                    case Operatie.Scadere:
                        vector[i] -= x;
                        break;
                    case Operatie.Inmultire:
                        vector[i] *= x;
                        break;
                    case Operatie.Impartire:
                        if (x == 0)
                            throw new DivideByZeroException("Impartirea la zero strict interzisa!");
                        vector[i] /= x;
                        break;
                }
            }
        }

        public static int[] MergeArrays (int[] a, int[] b)
        {
            int[] result = new int[a.Length + b.Length];
            int i = 0, j = 0, k = 0;
            while (i < a.Length && j < b.Length)
            {
                if (a[i] <= b[j]) // le intercalam prin parcurgerea celor 2 vectori in acelasi timp
                    result[k++] = a[i++];
                else
                    result[k++] = b[j++];
            }
            // daca mai avem un vector de parcurs
            while (i < a.Length)
                result[k++] = a[i++];
            while (j < b.Length)
                result[k++] = b[j++];
            return result;
        }

        // verific daca vectorul dat e sortat crescator
        public static bool IsSorted (int[] vector)
        {
            for (int i = 0; i < vector.Length - 1; ++i)
            {
                if (vector[i] > vector[i + 1])
                    return false;
            }
            return true;
        }
    }
}
