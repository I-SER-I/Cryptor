using System;
using Cryptor.Core.Ciphers;
using Cryptor.Dal.Interfaces;
using Cryptor.Dal.Repositories;

namespace Cryptor.Core
{
    class Program
    {
        static void Main(String[] args)
        {
            IUnitOfWork unitOfWork = new UnitOfWork("Data Source=I_SER_I;Initial Catalog=Languages;Integrated Security=True");
            VigenereCipher vigenereCipher = new VigenereCipher(unitOfWork.Languages.Read(1), );
        }
    }
}
