using System;

namespace Cryptor.Core.Models
{
    public class Language
    {
        public Int32 Id { get; set; }
        public String Name { get; set; }
        public String Alphabet { get; set; }
        public Byte Count { get; set; }
        public Char GetSymbolByIndex(Int32 index) => Alphabet[index];
    }
}