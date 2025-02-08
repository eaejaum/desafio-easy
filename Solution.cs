public class Solution
{
    public bool DetectCapitalUse(string word) =>
        word.All(char.IsLower)
        || word.All(char.IsUpper)
        || (char.IsUpper(word[0]) && word.AsSpan(1).ToArray().All(char.IsLower));
}