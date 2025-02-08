public class Program
{
    public static void Main(string[] args)
    {
        Solution solution = new Solution();
        Console.WriteLine(solution.DetectCapitalUse("USA"));
        Console.WriteLine(solution.DetectCapitalUse("leetcode"));
        Console.WriteLine(solution.DetectCapitalUse("Google"));       
    }
}