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
                String armenian = "աբգդեզէըթժիլխծկհձղճմյնշոչպջռսվտրցւփքօֆ";
                String georgian = "აბგდევზჱთიკლმნჲოპჟრსტჳუფქღყშჩცძწჭხჴჯჰჵჶჷჸ";
                String greek = "αβγδεζηθικλμνξοπρσςτυφχψω";
                dbContext.Language.Add(new Language
                    { Id = 570, Name = "Русский", Alphabet = russian, Count = (Byte)russian.Length });
                dbContext.Language.Add(new Language
                    { Id = 45, Name = "English", Alphabet = english, Count = (Byte)english.Length });
                dbContext.Language.Add(new Language
                    { Id = 55, Name = "Հայերեն", Alphabet = armenian, Count = (Byte)armenian.Length });
                dbContext.Language.Add(new Language
                    { Id = 158, Name = "ქართული", Alphabet = georgian, Count = (Byte)georgian.Length });
                dbContext.Language.Add(new Language
                    { Id = 157, Name = "Ελληνικα", Alphabet = greek, Count = (Byte)greek.Length });
                dbContext.SaveChanges();
            }
        }
    }
}