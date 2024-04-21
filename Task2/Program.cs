public class Program
{
    public static void Main()
    {
        var arrA = Console.ReadLine()?.Split(" ").Select(int.Parse).ToArray();
        var arrB = Console.ReadLine()?.Split(" ").Select(int.Parse).ToArray();

        Sort(arrA, arrB);

        foreach (var num in arrA)
        {
            Console.Write(num + " ");
        }
    }

    private static void Sort(int[] arrA, int[] arrB)
    {
        var dict = new Dictionary<int, int>();
        for (var i = 0; i < arrB.Length; i++)
        {
            dict[arrB[i]] = i;
        }

        var filteredA = arrA.Where(x => dict.ContainsKey(x)).ToList();
        filteredA.Sort((a, b) => dict[a].CompareTo(dict[b]));

        var remainingA = arrA.Where(x => !dict.ContainsKey(x)).OrderByDescending(x => x);

        var result = filteredA.Concat(remainingA).ToArray();
        Array.Copy(result, arrA, result.Length);
    }
}