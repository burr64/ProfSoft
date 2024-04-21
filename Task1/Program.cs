// Не делаю проверки на NULL для ReadLine
var array = Console.ReadLine()?.Split(" ").Select(int.Parse).ToArray();
Sort(array);
foreach (var num in array)
{
    Console.Write($"{num} ");
}

// Работаю с ссылкой
void Sort(int[]? arr)
{
    for (var i = 0; i < arr.Length - 1; i++)
    {
        if (arr[i] <= arr[i + 1]) continue;
        (arr[i], arr[i + 1]) = (arr[i + 1], arr[i]);
        Sort(arr);
    }
}