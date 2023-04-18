namespace linq.LinqToObjects;

public static class GroupByExamples
{
    public static IEnumerable<string> FindNCommonWords(this IEnumerable<string> words, int n) 
    {
        return
            (from word in words
            group word by word into g
            orderby g.Count() descending
            select g.Key)
                .Take(n);
    }
}