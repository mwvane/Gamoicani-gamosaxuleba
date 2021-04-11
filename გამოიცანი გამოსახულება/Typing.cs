using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace გამოიცანი_გამოსახულება
{
    static class Typing
    {
        private static readonly Dictionary<char, char> _translate;

        static Typing()
        {
            _translate = new Dictionary<char, char>()
            {
                {'a','ა'},{'b','ბ'},{'c','ც'},{'d','დ'},{'e','ე'},
                {'f','ფ' },{'g','გ' },{'h','ჰ' },{'i','ი' },
                {'j','ჯ' },{'k','კ' },{'l','ლ' },{'m','მ' },{'n','ნ' },{'o','ო' },
                {'p','პ' },{'q','ქ' },{'r','რ' },{'s','ს' },{'t','ტ' },{'u','უ' },
                {'v','ვ' },{'w','წ' },{'x','ხ' },{'y','ყ' },{'z','ზ' },{'T','თ'},
                {'W','ჭ'},{'R','ღ'},{'S','შ'},{'Z','ძ'},{'C','ჩ'},{'J','ჟ'},{(char)' ',(char)' '},
                {'\b','\b'},{(char)127,(char)127 }
            };
        }
        public static char ConvertToGeorgian(char symbol)
        {
            try
            {
                return _translate[symbol];
            }
            catch
            {
                return '\0';
            }

        }
        public static bool SymbolFilter(char symbol)
        {
            if (((int)symbol >= (int)'A' && (int)symbol <= (int)'Z') || ((int)symbol >= (int)'a' && (int)symbol <= (int)'z') || (((int)symbol >= (int)'ა' && (int)symbol <= (int)'ჰ')) || (int)symbol == (int)' ' || symbol == '\b' || (int)symbol == 127)
            {
                return true;
            }
            return false;
        }
        public static bool IsDigit(char symbol)
        {
            if(((int)symbol >= '0' && (int)symbol <= '9') || (int)symbol == 8)
            {
                return true;
            }
            return false;
        }
    }
}

