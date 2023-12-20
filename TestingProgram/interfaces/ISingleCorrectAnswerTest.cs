interface ISingleCorrectAnswerTest
{
    List<Dictionary<int, string>> Options { get; set; }

    Dictionary<int, string> CorrectOption { get; set; }
}