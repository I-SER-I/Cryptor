using System;
using System.Text;
using Cryptor.Core.Abstractions;
using Cryptor.Core.Enums;
using Cryptor.Core.Models;

namespace Cryptor.Core.Ciphers
{
    public class CaesarCipher : Cipher
    {
        private readonly Int32 _step;

        public CaesarCipher(Language language, Int32 step) : base(language)
        {
            Language = language;
            _step = step;
        }

        private String Crypt(String text, CryptMode mode)
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (Char symbol in text)
            {
                var value = symbol.ToString().ToLower();
                if (!Language.Alphabet.Contains(value))
                {
                    stringBuilder.Append(symbol);
                    continue;
                }

                var index = (Language.Count + Language.Alphabet.IndexOf(value, StringComparison.OrdinalIgnoreCase) +
                             _step * (Int32) mode) % Language.Count;
                var symbolNew = Language.GetSymbolByIndex(index);
                stringBuilder.Append
                (
                    char.IsUpper(symbol) ? char.ToUpper(symbolNew) : symbolNew
                );
            }

            return stringBuilder.ToString();
        }

        public override String Decrypt(String text) => Crypt(text, CryptMode.Decrypt);

        public override String Encrypt(String text) => Crypt(text, CryptMode.Encrypt);
    }
}