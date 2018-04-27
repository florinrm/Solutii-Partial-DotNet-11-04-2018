using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema2
{
    class UserInput
    {
        private string TextInput, NumericInput;

        public UserInput ()
        {
            TextInput = "";
            NumericInput = "";
        }

        public string GetTextInput ()
        {
            return TextInput;
        }

        public string GetNumericInput ()
        {
            return NumericInput;
        }

        public void Add (int digit)
        {
            NumericInput += digit;
        }

        public void Add (char letter)
        {
            TextInput += letter;
        }

        private bool IsVocal (char c)
        {
            string vocals = "aeiouAEIOU";
            for (int i = 0; i < vocals.Length; ++i)
            {
                if (c == vocals[i])
                    return true;
            }
            return false;
        }

        public void Codificare ()
        {
            string result = "";
            for (int i = 0; i < TextInput.Length; ++i)
            {
                if (IsVocal(TextInput[i]))
                    result += '*' + TextInput[i];
                else if (TextInput[i] == 'h' || TextInput[i] == 'H')
                    result += '#';
                else if (TextInput[i] == 's' || TextInput[i] == 'S')
                    result += "$";
            }
        }

        public void Decodificare ()
        {
            string result = "";
            for (int i = 0; i < TextInput.Length; ++i)
            {
                if (TextInput[i] == '*')
                    continue;
                else if (TextInput[i] == '#')
                    result += 'h';
                else if (TextInput[i] == '$')
                    result += "s";
                else
                    result += TextInput[i];
            }
        }
    }
}
