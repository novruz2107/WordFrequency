using System.Text.RegularExpressions;


//Could be exported from http or file
string sentence = "This is brand new sentence. This potato is very good brand.";

sentence = sentence.ToLower();

var words = Regex.Split(sentence, @"[^\p{L}]*\p{Z}[^\p{L}]*");

Dictionary<string, int> wordFreqs = new Dictionary<string, int>();
foreach (var word in words)
{
    wordFreqs.TryGetValue(word, out int frequency);
    wordFreqs[word] = frequency + 1;
}

foreach (var pair in wordFreqs)
    Console.WriteLine($"{pair.Key} -> {pair.Value}");