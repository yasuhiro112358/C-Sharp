using System;
using System.Collections.Generic;
using System.Text;

public class TextNormalizer
{
    private static readonly Dictionary<string, string> ConversionMap = new Dictionary<string, string>
    {
        { "０", "0" }, { "１", "1" }, { "２", "2" }, { "３", "3" }, { "４", "4" },
        { "５", "5" }, { "６", "6" }, { "７", "7" }, { "８", "8" }, { "９", "9" },

        { "Ａ", "A" }, { "Ｂ", "B" }, { "Ｃ", "C" }, { "Ｄ", "D" }, { "Ｅ", "E" },
        { "Ｆ", "F" }, { "Ｇ", "G" }, { "Ｈ", "H" }, { "Ｉ", "I" }, { "Ｊ", "J" },
        { "Ｋ", "K" }, { "Ｌ", "L" }, { "Ｍ", "M" }, { "Ｎ", "N" }, { "Ｏ", "O" },
        { "Ｐ", "P" }, { "Ｑ", "Q" }, { "Ｒ", "R" }, { "Ｓ", "S" }, { "Ｔ", "T" },
        { "Ｕ", "U" }, { "Ｖ", "V" }, { "Ｗ", "W" }, { "Ｘ", "X" }, { "Ｙ", "Y" }, { "Ｚ", "Z" },

        { "ａ", "a" }, { "ｂ", "b" }, { "ｃ", "c" }, { "ｄ", "d" }, { "ｅ", "e" },
        { "ｆ", "f" }, { "ｇ", "g" }, { "ｈ", "h" }, { "ｉ", "i" }, { "ｊ", "j" },
        { "ｋ", "k" }, { "ｌ", "l" }, { "ｍ", "m" }, { "ｎ", "n" }, { "ｏ", "o" },
        { "ｐ", "p" }, { "ｑ", "q" }, { "ｒ", "r" }, { "ｓ", "s" }, { "ｔ", "t" },
        { "ｕ", "u" }, { "ｖ", "v" }, { "ｗ", "w" }, { "ｘ", "x" }, { "ｙ", "y" }, { "ｚ", "z" },

        { "！", "!" }, { "＃", "#" }, { "＄", "$" }, { "％", "%" },
        { "＆", "&" }, { "（", "(" }, { "）", ")" }, { "＊", "*" },
        { "＋", "+" }, { "－", "-" }, { "．", "." }, { "／", "/" },
        { "：", ":" }, { "；", ";" }, { "＜", "<" }, { "＝", "=" },
        { "＞", ">" }, { "？", "?" }, { "＠", "@" }, { "［", "[" },
        { "￥", "¥" }, { "］", "]" }, { "＾", "^" }, { "＿", "_" },
        { "｀", "`" }, { "｛", "{" }, { "｜", "|" }, { "｝", "}" }, { "～", "~" },
        { "”", "\"" }, { "’", "\'" }
    };

    /// <summary>
    /// NXタグの除去、全角文字を半角に変換、禁則文字を半角スペースに置換、改行コードを半角スペースに変換、30文字以内に制限
    /// </summary>
    public static string CleanAndTrimText(string originalText)
    {
        string cleanText = originalText;

        cleanText = RemoveNXTags(cleanText);
        cleanText = ConvertFullWidthToHalfOrSpace(cleanText);
        cleanText = ConvertProhibitedToSpace(cleanText);
        cleanText = ConvertLineBreaksToSpace(cleanText);
        cleanText = LimitTo30Characters(cleanText);

        return cleanText;
    }

    /// <summary>
    /// NXタグを削除
    /// </summary>
    private static string RemoveNXTags(string text)
    {
        return System.Text.RegularExpressions.Regex.Replace(text, "<[^>]*>", "");
    }

    /// <summary>
    /// 全角文字を半角に変換、マルチバイト文字は半角スペースに変換
    /// </summary>
    private static string ConvertFullWidthToHalfOrSpace(string text)
    {
        StringBuilder sb = new StringBuilder();

        foreach (char c in text)
        {
            if (ConversionMap.TryGetValue(c.ToString(), out var half))
            {
                sb.Append(half);
            }
            else if (IsMultibyteCharacter(c))
            {
                sb.Append(" ");
            }
            else
            {
                sb.Append(c);
            }
        }

        return sb.ToString();
    }

    /// <summary>
    /// 禁則文字を半角スペースに置換
    /// </summary>
    private static string ConvertProhibitedToSpace(string text)
    {
        return text.Replace("\"", " ")
                   .Replace("\'", " ")
                   .Replace("|", " ");
    }

    /// <summary>
    /// 改行コードを半角スペースに変換
    /// </summary>
    private static string ConvertLineBreaksToSpace(string text)
    {
        return text.Replace("\r\n", " ")
                   .Replace("\r", " ")
                   .Replace("\n", " ");
    }

    /// <summary>
    /// テキストを30文字以内に制限
    /// </summary>
    private static string LimitTo30Characters(string text)
    {
        return text.Length <= 30 ? text : text.Substring(0, 30);
    }

    /// <summary>
    /// マルチバイト文字を判定
    /// </summary>
    private static bool IsMultibyteCharacter(char c)
    {
        int codePoint = (int)c;
        return codePoint > 127;
    }
}
