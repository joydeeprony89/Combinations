using System;
using System.Collections.Generic;

namespace Combinations
{
  class Program
  {
    static void Main(string[] args)
    {
      Solution s = new Solution();
      int n = 5; int k = 3;
      var answer = s.Combine(n, k);
      foreach (var a in answer) Console.WriteLine(string.Join(",", a));
    }
  }

  public class Solution
  {
    public IList<IList<int>> Combine(int n, int k)
    {
      var result = new List<IList<int>>();
      Backtrack(result, new List<int>(), n, k, 1);

      return result;
    }

    private void Backtrack(List<IList<int>> result, List<int> temp, int n, int k, int start)
    {
      if (temp.Count == k)
      { 
        result.Add(new List<int>(temp));
        return;
      }

      for (int i = start; i <= n; i++)
      {
        temp.Add(i);
        Backtrack(result, temp, n, k, i + 1);
        temp.RemoveAt(temp.Count - 1);
      }
    }
  }
}
