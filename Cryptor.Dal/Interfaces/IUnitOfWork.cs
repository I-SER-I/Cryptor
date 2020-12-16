using System;
using Cryptor.Dal.Entities;

namespace Cryptor.Dal.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Language> Languages { get; }
        void Save();
    }
}