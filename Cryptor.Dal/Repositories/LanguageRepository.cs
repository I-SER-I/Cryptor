using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Cryptor.Dal.DataBase;
using Cryptor.Dal.Entities;
using Cryptor.Dal.Interfaces;

namespace Cryptor.Dal.Repositories
{
    public class LanguageRepository : IRepository<Language>
    {
        public CryptorContext DbContext;

        public LanguageRepository(CryptorContext dbContext) => DbContext = dbContext;

        public void Create(Language language) => DbContext.Language.Add(language);

        public Language Read(Int32 id) => DbContext.Language.Find(id);

        public void Update(Language language) => DbContext.Entry(language).State = EntityState.Modified;

        public void Delete(Int32 id)
        {
            Language language = DbContext.Language.Find(id);
            if (language != null)
            {
                DbContext.Language.Remove(language);
            }
        }

        public IEnumerable<Language> Find(Func<Language, Boolean> predicate) => DbContext.Language.Where(predicate).ToList();

        public IEnumerable<Language> GetAll() => DbContext.Language;
    }
}