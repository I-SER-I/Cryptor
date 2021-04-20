using System;
using Cryptor.Core.Ciphers;
using Cryptor.Core.Interfaces;
using Cryptor.Core.Services;
using Cryptor.Dal.Interfaces;
using Cryptor.Dal.Repositories;

namespace Cryptor.Core
{
    class Program
    {
        static void Main(String[] args)
        {
            ILanguageService languageService = new LanguageService(new UnitOfWork("Data Source=I_SER_I;Initial Catalog=Languages;Integrated Security=True"));
            var language = languageService.GetLanguage(570);
            VigenereCipher vigenereCipher = new VigenereCipher(language, "пидор");
            Console.WriteLine(vigenereCipher.Encrypt("Робокопи"));
        }
    }
}