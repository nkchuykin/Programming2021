using System;

internal class Program
{
    private static void Main(string[] args)
    {
        // Для завершения программы в Windows необходимо нажать комбинацию Ctrl+Z(символ конца потока), а затем нажать Enter
        string type = Console.ReadLine();
        if (type == "int_array")
        {
            TestIntArray();
        }
        else
        {
            TestString();
        }
    }

    private static void TestString()
    {
        var myList = CreateMyList<string>();
        string line;
        
        while ((line = Console.ReadLine()) != null)
        {
            string[] command = line.Split();
            switch (command[0])
            {
                case "add":
                {
                    myList.Add(string.Join(' ', command[1..]));
                    break;
                }
                case "get":
                {
                    try
                    {
                        Console.WriteLine(myList[int.Parse(command[1])]);
                    }
                    catch (IndexOutOfRangeException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                }
                case "count":
                {
                    Console.WriteLine(myList.Count);
                    break;
                }
                case "capacity":
                {
                    Console.WriteLine(myList.Capacity);
                    break;
                }
                case "clear":
                {
                    myList.Clear();
                    break;
                }
                case "remove_last":
                {
                    try
                    {
                        myList.RemoveLast();
                    }
                    catch (IndexOutOfRangeException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                }
                case "remove_at":
                {
                    try
                    {
                        myList.RemoveAt(int.Parse(command[1]));
                    }
                    catch (IndexOutOfRangeException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                }
                case "max":
                {
                    try
                    {
                        Console.WriteLine(myList.Max());
                    }
                    catch (IndexOutOfRangeException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                }
                case "print":
                {
                    Console.WriteLine(myList);
                    break;
                }
            }
        }
    }


    private static void TestIntArray()
    {
        var myList = CreateMyList<int[]>();
        string line;
        
        while ((line = Console.ReadLine()) != null)
        {
            string[] command = line.Split();
            switch (command[0])
            {
                case "add":
                {
                    myList.Add(Array.ConvertAll(command[1..], int.Parse));
                    break;
                }
                case "get":
                {
                    try
                    {
                        Console.WriteLine(myList[int.Parse(command[1])]);
                    }
                    catch (IndexOutOfRangeException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                }
                case "count":
                {
                    Console.WriteLine(myList.Count);
                    break;
                }
                case "capacity":
                {
                    Console.WriteLine(myList.Capacity);
                    break;
                }
                case "clear":
                {
                    myList.Clear();
                    break;
                }
                case "remove_last":
                {
                    try
                    {
                        myList.RemoveLast();
                    }
                    catch (IndexOutOfRangeException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                }
                case "remove_at":
                {
                    try
                    {
                        myList.RemoveAt(int.Parse(command[1]));
                    }
                    catch (IndexOutOfRangeException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                }
                case "max":
                {
                    try
                    {
                        Console.WriteLine(myList.Max());
                    }
                    catch (NotSupportedException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                }
                case "print":
                {
                    Console.WriteLine(myList);
                    break;
                }
            }
        }
    }

    private static MyList<T> CreateMyList<T>()
    {
        string construct = Console.ReadLine();

        return construct == "empty" ? new MyList<T>() : new MyList<T>(int.Parse(construct.Split()[1]));
    }
}