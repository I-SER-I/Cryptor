using System;
using Cryptor.Dal.DataBase;
using Cryptor.Dal.Entities;
using Cryptor.Dal.Interfaces;

namespace Cryptor.Dal.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly CryptorContext _dbContext; 
        private LanguageRepository _languageRepository;
        private Boolean _disposed;

        public UnitOfWork(String connectionString) => _dbContext = new CryptorContext(connectionString);
            
        public IRepository<Language> Languages =>
            _languageRepository ?? (_languageRepository = new LanguageRepository(_dbContext));

        public void Save() => _dbContext.SaveChanges();

        public virtual void Dispose(Boolean disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _dbContext.Dispose();
                }

                _disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}