using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int hipstersCount = int.Parse(Console.ReadLine());
        int bloggersCount = int.Parse(Console.ReadLine());
        
        var hipsters = new Hipster[hipstersCount];
        var bloggers = new Blogger[bloggersCount];
        var calendar = new Calendar();
        
        for (int i = 0; i < bloggersCount; i++)
        {
            bloggers[i] = new Blogger((DayOfWeek) int.Parse(Console.ReadLine()));
            calendar.EveryDayNotification += bloggers[i].MakePost;
        }

        ReadHipsters(hipstersCount, hipsters, bloggers);
        calendar.Simulate(new DateTime(2019, 1, 1), new DateTime(2019, 12, 31));
        PrintResult(hipsters);
    }

    private static void PrintResult(Hipster[] arr)
    {
        foreach (var hipster in arr)
        {
            Console.WriteLine(hipster.PostsRead);
        }
    }

    private static void ReadHipsters(int hipstersCount, Hipster[] hipsters, Blogger[] bloggers)
    {
        for (int i = 0; i < hipstersCount; i++)
        {
            string[] arr = Console.ReadLine().Split();
            hipsters[i] = new Hipster(int.Parse(arr[0]), int.Parse(arr[1]));
            for (int j = 2; j < arr.Length; j++)
            {
                hipsters[i].Subscribe(bloggers[int.Parse(arr[j])]);
            }
        }
    }
}