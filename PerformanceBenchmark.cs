using BenchmarkDotNet.Attributes;

[MemoryDiagnoser(false)]
public class PerformanceBenchmark
{
  private const int N = 50_000;
  private const int M = 20;
  private readonly int[] numberArray = Enumerable.Range(0, M).ToArray();
  private readonly List<int> numberList = Enumerable.Range(0, M).ToList();

  [Benchmark]
  public int ForArray()
  {
    var step = 0;
    while (step < N)
    {
      for (int i = 0; i < numberArray.Length; i++)
      {
      }
      step++;
    }
    return 0;
  }

  [Benchmark]
  public int ForeachArray()
  {
    var step = 0;
    while (step < N)
    {
      foreach (var number in numberArray)
      {
      }
      step++;
    }
    return 0;
  }

  [Benchmark]
  public int ForList()
  {
    var step = 0;
    while (step < N)
    {
      for (int i = 0; i < numberList.Count; i++)
      {
      }
      step++;
    }
    return 0;
  }

  [Benchmark]
  public int ForeachList()
  {
    var step = 0;
    while (step < N)
    {
      foreach (var number in numberList)
      {
      }
      step++;
    }
    return 0;
  }

  [Benchmark]
  public int ForEachList()
  {
    var step = 0;
    while (step < N)
    {
      numberList.ForEach(number =>
      {
      });
      step++;
    }
    return 0;
  }

  [Benchmark]
  public int ParallelForArray()
  {
    var step = 0;
    while (step < N)
    {
      Parallel.For(0, numberArray.Length, i =>
      {
      });
      step++;
    }
    return 0;
  }

  [Benchmark]
  public int ParallelForEachArray()
  {
    var step = 0;
    while (step < N)
    {
      Parallel.ForEach(numberArray, number =>
      {
      });
      step++;
    }
    return 0;
  }

  [Benchmark]
  public int ParallelForList()
  {
    var step = 0;
    while (step < N)
    {
      Parallel.For(0, numberList.Count, i =>
      {
      });
      step++;
    }
    return 0;
  }

  [Benchmark]
  public int ParallelForEachList()
  {
    var step = 0;
    while (step < N)
    {
      Parallel.ForEach(numberList, number =>
      {
      });
      step++;
    }
    return 0;
  }
}