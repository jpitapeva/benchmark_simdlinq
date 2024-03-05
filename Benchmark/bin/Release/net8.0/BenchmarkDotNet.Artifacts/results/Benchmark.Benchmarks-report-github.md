```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22621.3007/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-11390H 3.40GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.200
  [Host]     : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI [AttachedDebugger]
  DefaultJob : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI


```
| Method          | Mean       | Error    | StdDev    | Median     | Allocated |
|---------------- |-----------:|---------:|----------:|-----------:|----------:|
| ForLoopExample  | 3,604.7 ns | 98.71 ns | 284.80 ns | 3,508.7 ns |         - |
| LinqExample     |   817.0 ns | 12.66 ns |  13.00 ns |   814.9 ns |         - |
| SimdLinqExample |   501.5 ns |  9.75 ns |  25.01 ns |   493.9 ns |         - |
