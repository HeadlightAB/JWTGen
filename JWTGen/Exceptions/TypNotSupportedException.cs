using System;

namespace JWTGen.Exceptions
{
    internal class TypNotSupportedException : Exception
    {
        public TypNotSupportedException(string typ)
        {
            throw new NotImplementedException();
        }
    }
}