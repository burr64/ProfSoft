// Не делаю проверки на NULL для ReadLine
var array = Console.ReadLine()?.Split(" ").Select(int.Parse).ToArray();
Console.Write($"{LargestSum(array)}");


int LargestSum(int[] arr)
{
    return arr.Max()+arr.Where(x => x != arr.Max()).Max();
}