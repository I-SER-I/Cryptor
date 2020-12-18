using Cryptor.Core.Models;
using System;
using System.Text;
using Cryptor.Core.Abstraction;
using Cryptor.Core.Enums;

namespace Cryptor.Core.Ciphers
{
    public class VigenereCipher : Cipher
    {
        private readonly String _keyWord;

        public VigenereCipher(Language language, String key) : base(language)
        {
            _keyWord = key.ToLower();
            Language = language;
        }

        private String GetRepeatKeyWord(Int32 inputTextLength)
        {
            StringBuilder stringBuilder = new StringBuilder(_keyWord);
            while (_keyWord.Length < inputTextLength)
            {
                stringBuilder.Append(_keyWord);
            }

            return stringBuilder.Remove(0, inputTextLength).ToString();
        }

        private String Crypt(String text, CryptMode mode)
        {
            StringBuilder stringBuilder = new StringBuilder();
            String keyWord = GetRepeatKeyWord(text.Length);
            for (var i = 0; i < text.Length; i++)
            {
                Char textSymbol = text[i];
                Char keyWordSymbol = keyWord[i];
                var value = char.ToLower(textSymbol);
                if (!Language.Alphabet.Contains(value))
                {
                    stringBuilder.Append(textSymbol);
                    continue;
                }

                var index = (Language.Count + Language.Alphabet.IndexOf(value, StringComparison.OrdinalIgnoreCase) +
                             Language.Alphabet.IndexOf(keyWordSymbol, StringComparison.OrdinalIgnoreCase) *
                             (Int32) mode) %
                            Language.Count;
                var symbolNew = Language.GetSymbolByIndex(index);
                stringBuilder.Append
                (
                    char.IsUpper(textSymbol) ? char.ToUpper(symbolNew) : symbolNew
                );
            }

            return stringBuilder.ToString();
        }

        public override String Decrypt(String text) => Crypt(text, CryptMode.Decrypt);

        public override String Encrypt(String text) => Crypt(text, CryptMode.Encrypt);
    }
}