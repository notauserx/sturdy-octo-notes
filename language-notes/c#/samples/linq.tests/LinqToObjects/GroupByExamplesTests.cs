namespace linq.tests.LinqToObjects;

public class GroupByExamplesTests
{
    [Fact]
    public void FindNCommonWords_finds_n_common_words()
    {
        var words = new List<string>()
        {
            "aa", "aa", "aa", "aa", "aa",
            "bb", "bb", "bb", "bb",
            "cc", "cc", "cc",
            "dd", "dd",
            "ee",
        }.AsEnumerable();

        var expected = new List<string>()
        {
            "aa", "bb",
        };

        var result = words.FindNCommonWords(2);

        Assert.Equal(expected, result);
    }
}