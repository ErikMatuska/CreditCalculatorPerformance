using BenchmarkDotNet.Attributes;
using CreditCalculator.After.Domain;
using CreditCalculator.Console.Generator;
using CreditCalculator.Storage;

namespace CreditCalculator.Console
{
    public class ReaderBenchmark
    {
        [GlobalSetup]
        public void Setup()
        {
            new CustomerGeneratorRunner().GenerateData();
        }
    }
}
