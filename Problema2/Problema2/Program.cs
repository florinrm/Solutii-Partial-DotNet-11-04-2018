using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema2
{
    class Program
    {
        static void Main(string[] args)
        {
            UserInput obj = new UserInput();
            int i = 0;
            Console.WriteLine("Adauga caracterele");
            while (i < 5)
            {
                char c = char.Parse(Console.ReadLine());
                if (Char.IsDigit(c)) // vad daca e cifra
                {
                    Console.WriteLine("Este o cifra!");
                    obj.Add(int.Parse("" + c)); // ia argument ca string si asa fac o conversie de la char la string :D
                }
                else
                {
                    obj.Add(c);
                    Console.WriteLine("Este o litera!");
                }
                ++i;
            }
            Console.WriteLine("TextInput original: " + obj.GetTextInput());
            Console.WriteLine("NumericInput original: " + obj.GetNumericInput());
            obj.Codificare();
            Console.WriteLine("TextInput codificat: " + obj.GetTextInput());
            obj.Decodificare();
            Console.WriteLine("TextInput decodificat: " + obj.GetTextInput());
        }
    }
}
