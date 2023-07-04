﻿
var sentence = "This is going to be a really really really really long text";
var summary= SummerizeText(sentence, 25); 
Console.WriteLine(summary);

static string SummerizeText(string sentence, int maxLength=20)
{
if (sentence.Length < maxLength)
    return sentence;

    var words = sentence.Split(' ');
    var totalChar = 0;
    var summaryWords = new List<string>();

    foreach (var word in words)
    {
        summaryWords.Add(word);
        totalChar += word.Length + 1;
        if (totalChar > maxLength)
            break;
    }
    return String.Join(" ", summaryWords) + "...";
}