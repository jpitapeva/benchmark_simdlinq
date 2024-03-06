```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22621.3007/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-11390H 3.40GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.200
  [Host]     : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  DefaultJob : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI


```
| Method          | Mean       | Error    | StdDev    | Allocated |
|---------------- |-----------:|---------:|----------:|----------:|
| ForLoopExample  | 3,315.7 ns | 65.85 ns | 151.31 ns |         - |
| LinqExample     |   810.4 ns | 12.05 ns |  11.28 ns |         - |
| SimdLinqExample |   470.9 ns |  8.23 ns |   7.70 ns |         - |
