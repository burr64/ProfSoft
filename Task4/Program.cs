// Не делаю проверки на NULL для ReadLine и отсортирован ли массив
var array = Console.ReadLine()?.Split(" ").Select(int.Parse).ToArray();
var searchedValue = int.Parse(Console.ReadLine());
Console.Write($"{BinarySearch(array, searchedValue)}");

int BinarySearch(int[] arr, int target)
{
    for (int left = 0, right = arr.Length-1; left<=right;)
    {
        var middle = left + (right - left) / 2;
        if (arr[middle] == target)
        {
            return middle;
        }
        if (arr[middle] < target)
        {
            left = middle + 1;
        }
        else
        {
            right = middle - 1;
        }
    }
    return -1;
}