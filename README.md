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


Resultados

| Method          | Mean       | Error    | StdDev    | Median     | Allocated |
|---------------- |-----------:|---------:|----------:|-----------:|----------:|
| ForLoopExample  | 3,604.7 ns | 98.71 ns | 284.80 ns | 3,508.7 ns |         - |
| LinqExample     |   817.0 ns | 12.66 ns |  13.00 ns |   814.9 ns |         - |
| SimdLinqExample |   501.5 ns |  9.75 ns |  25.01 ns |   493.9 ns |         - |
