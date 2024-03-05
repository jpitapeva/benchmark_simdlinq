Este projeto tem objetivo de demonstrar performance usando um for, linq e simdlinq

Pre-requisitos</br>
1- Sdk Dotnet8 atualizada</br>
2- IDE VS atualizado

Como executar:</br>
Executar em Release Mode

```
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
```
