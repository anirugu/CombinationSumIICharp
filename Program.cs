namespace CombinationSumIICharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution sol = new Solution();
            sol.CombinationSum2(new int[] { 10, 1, 2, 7, 6, 1, 5 }, 8);
        }
    }
}

public class Solution
{
    public IList<IList<int>> CombinationSum2(int[] candidates, int target)
    {
        foreach (var item in candidates)
        {
            var remain = target - item;
            candidates.First();
            
        }
        return new List<IList<int>>();
    }
}