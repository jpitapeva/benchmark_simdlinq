//var array = Enumerable.Range(1,2000).ToArray();

//var sum = array.Sum();

//Console.WriteLine(sum.ToString());


using Benchmark;
using BenchmarkDotNet.Running;

BenchmarkRunner.Run<Benchmarks>();



