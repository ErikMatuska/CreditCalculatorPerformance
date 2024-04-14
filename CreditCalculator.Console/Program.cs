using BenchmarkDotNet.Running;
using CreditCalculator.Console;
using CreditCalculator.Console.Generator;

var summary = BenchmarkRunner.Run<ReaderBenchmark>();

////new CustomerGeneratorRunner().GenerateData();