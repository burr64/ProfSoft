const string filePath = "NewFile1.txt";
var wordCounts = CountWordOccurrences(filePath);

foreach (var (key, value) in wordCounts.OrderByDescending(pair => pair.Value))
{
    Console.WriteLine($"{key}: {value}");
}

static Dictionary<string, int> CountWordOccurrences(string filePath)
{
    var wordCounts = new Dictionary<string, int>();

    try
    {
        var lines = File.ReadAllLines(filePath);

        foreach (var line in lines)
        {
            var words = line.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var word in words)
            {
                var cleanedWord = CleanWord(word);
                if (string.IsNullOrWhiteSpace(cleanedWord)) continue;
                if (wordCounts.ContainsKey(cleanedWord))
                {
                    wordCounts[cleanedWord]++;
                }
                else
                {
                    wordCounts[cleanedWord] = 1;
                }
            }
        }
    }
    catch (FileNotFoundException)
    {
        Console.WriteLine("Файл не найден.");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"ошибка при чтении: {ex.Message}");
    }

    return wordCounts;
}

static string CleanWord(string word)
{
    return new string(word.Where(c => char.IsLetter(c) || c == '\'').ToArray()).ToLower();
}