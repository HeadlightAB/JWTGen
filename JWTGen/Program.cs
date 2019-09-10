using JWTGen.Exceptions;
using Microsoft.Extensions.Configuration;

namespace JWTGen
{
    class Program
    {
        static void Main(string[] args)
        {
            var config =
                new ConfigurationBuilder()
                    .AddCommandLine(args).Build();

            EnsureParameters(config);
        }

        private static void EnsureParameters(IConfigurationRoot config)
        {
            EnsureAlgorithm(config["alg"]);
            EnsureType(config["typ"]);
        }

        private static void EnsureType(string typ)
        {
            if (string.IsNullOrWhiteSpace(typ))
            {
                throw new TypNotSupportedException(typ);
            }
        }

        private static void EnsureAlgorithm(string alg)
        {
            if (string.IsNullOrWhiteSpace(alg))
            {
                throw new AlgorithmNotSupportedException(alg);
            }
        }
    }
}
