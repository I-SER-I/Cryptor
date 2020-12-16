using System;
using System.Collections.Generic;
using Cryptor.Core.Models;

namespace Cryptor.Core.Interfaces
{
    public interface ILanguageService
    {
        Language GetLanguage(Int32 id);
        IEnumerable<Language> GetLanguages();
        void Dispose();
    }
}