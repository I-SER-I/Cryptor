using System;
using Cryptor.Core.Interfaces;
using Cryptor.Core.Models;

namespace Cryptor.Core.Abstraction
{
   public abstract class Cipher : ICipher
    {
        protected Language Language;
        protected Cipher(Language language) => Language = language;
        public abstract String Encrypt(String text);
        public abstract String Decrypt(String text);
    }
}