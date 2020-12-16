using System;
using Cryptor.Core.Abstractions;
using Cryptor.Core.Entities;
using Cryptor.Core.Models;

namespace Cryptor.Core.Ciphers
{
    public abstract class Cipher : ICipher
    {
        protected Language Language;
        protected Cipher(Language language) => Language = language;
        public abstract String Encrypt(String text);
        public abstract String Decrypt(String text);
    }
}