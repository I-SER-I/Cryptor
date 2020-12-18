using System;

namespace Cryptor.Core.Interfaces
{
    public interface ICipher
    {
        String Encrypt(String text);
        String Decrypt(String text);
    }
}