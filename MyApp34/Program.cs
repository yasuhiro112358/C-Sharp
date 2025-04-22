using System;

class Program
{
    static void Main(string[] args)
    {
        // string originalText = "<tag1>テストテキスト！＠|<tag2>￥＃＄｜％＾＆＊（）＿＋－＝<tag3>[”][’]Kanji[漢字]aaaaaaaaaaaaaaaaaaaaa";
        string originalText = "＜T＞<tag1>Kanji[漢字][｜][\n][\r\n][\"][　]aaaaaaaaaa";
        Console.WriteLine($"OriginalText: {originalText}, Length: {originalText.Length}");

        string cleanText = TextNormalizer.CleanAndTrimText(originalText);
        Console.WriteLine($"cleanText: {cleanText}, Length: {cleanText.Length}");
    }
}