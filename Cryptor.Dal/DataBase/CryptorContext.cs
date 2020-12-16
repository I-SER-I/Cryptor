using System;
using System.Data.Entity;
using Cryptor.Dal.Entities;

namespace Cryptor.Dal.DataBase
{
    public class CryptorContext : DbContext
    {
        public CryptorContext(String connectionString) : base(connectionString) { }

        static CryptorContext() => Database.SetInitializer<CryptorContext>(new LanguagesDbInitializer());

        public DbSet<Language> Language { get; set; }

        public class LanguagesDbInitializer : DropCreateDatabaseIfModelChanges<CryptorContext>
        {
            protected override void Seed(CryptorContext dbContext)
            {
                String russian = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
                String english = "abcdefghijklmnopqrstuvwxyz";
                dbContext.Language.Add(new Language
                    {Id = 1, Name = "Русский", Alphabet = russian, Count = (Byte) russian.Length});
                dbContext.Language.Add(new Language
                    {Id = 2, Name = "English", Alphabet = english, Count = (Byte) english.Length});
                dbContext.SaveChanges();
            }
        }
    }
}