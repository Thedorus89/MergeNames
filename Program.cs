using System;
using System.Linq;
using System.Collections.Generic;

public class MergeNames
{
    public static string[] UniqueNames(string[] names1, string[] names2)
    {
        HashSet<string> uniqueNamesSet = new HashSet<string>();

        foreach (var name in names1)
        {
            uniqueNamesSet.Add(name);
        }

        foreach (var name in names2)
        {
            uniqueNamesSet.Add(name);
        }

        return uniqueNamesSet.ToArray();
    }

    public static void Main(string[] args)
    {
        string[] names1 = new string[] { "Ava", "Emma", "Olivia" };
        string[] names2 = new string[] { "Olivia", "Sophia", "Emma" };
        Console.WriteLine(string.Join(", ", MergeNames.UniqueNames(names1, names2))); // should print Ava, Emma, Olivia, Sophia
    }
}