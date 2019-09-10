using System;

namespace JWTGen.Exceptions
{
    internal class AlgorithmNotSupportedException : Exception
    {
        public AlgorithmNotSupportedException(string s)
        {
            throw new NotImplementedException();
        }
    }
}