var sequence = Console.ReadLine();
Console.WriteLine(CheckBrackets(sequence));

bool CheckBrackets(string sequence)
{
    if (sequence == "") return true;
    var firstIndex = sequence.IndexOfAny(new char[] {')', ']', '}'});
    if (firstIndex == -1) return false;

    var openingBracket = sequence[firstIndex] switch
    {
        ')' => '(',
        ']' => '[',
        '}' => '{',
        _ => '\0'
    };
    if (firstIndex > 0 && sequence[firstIndex - 1] == openingBracket)
    {
        return CheckBrackets(sequence.Remove(firstIndex - 1, 2));
    }

    return false;
}