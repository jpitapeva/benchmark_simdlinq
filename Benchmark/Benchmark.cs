using BenchmarkDotNet.Attributes;

namespace Benchmark
{
    [MemoryDiagnoser(false)]
    public class Benchmarks
    {
        private static readonly int[] Array = Enumerable.Range(1, 10000).ToArray();

        [Benchmark]
        public int ForLoopExample()
        {
            Span<int> span = Array;
            var length = span.Length;
            var result = 0;
            for (int i = 0; i < length; i++)
            {
                result += span[i];
            }
            return result;

        }

        [Benchmark]
        public int LinqExample()
        {
            return Array.Sum();
        }

        [Benchmark]
        public int SimdLinqExample()
        {
            return SimdLinq.SimdLinqExtensions.Sum(Array);
        }
    }
}
