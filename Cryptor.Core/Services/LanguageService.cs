using System;
using System.Collections.Generic;
using System.Linq;
using Cryptor.Core.Interfaces;
using Cryptor.Core.Models;
using Cryptor.Dal.Interfaces;

namespace Cryptor.Core.Services
{
    public class LanguageService : ILanguageService
    {
        private IUnitOfWork Database { get; }

        public LanguageService(IUnitOfWork unitOfWork) => Database = unitOfWork;

        public Language GetLanguage(Int32 id)
        {
            var language = Database.Languages.Read(id);
            if (language == null)
            {
                throw new Exception();
            }

            return new Language
            {
                Id = language.Id,
                Name = language.Name,
                Alphabet = language.Alphabet,
                Count = language.Count
            };
        }

        public IEnumerable<Language> GetLanguages()
        {
            var languages = Database.Languages.GetAll();
            return languages.Select(language => new Language
            {
                Id = language.Id,
                Name = language.Name,
                Alphabet = language.Alphabet,
                Count = language.Count
            });
        }

        public void Dispose() => Database.Dispose();
    }
}