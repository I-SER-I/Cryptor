using System;

namespace Cryptor.Core.Abstractions
{
    public interface ICipher
    {
        String Encrypt(String text);
        String Decrypt(String text);
    }
}