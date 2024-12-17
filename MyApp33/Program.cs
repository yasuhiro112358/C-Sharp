// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Collection
// - List
// - HashSet
// - Dictionary

using System;
using System.Collections.Generic; // List, HashSet, Dictionary

class MyApp33
{
    static void Main()
    {
        // List<int> scores = new List<int>();
        // scores.Add(30);
        // scores.Add(80);
        // scores.Add(60);

        List<int> scores = new List<int>() {
            30,
            80,
            60
        };

        scores[1] = 100;

        Console.WriteLine(scores.Count);

        foreach (var score in scores)
        {
            Console.WriteLine(score);
        }

        // =====================

        HashSet<int> answers = new HashSet<int>() {
            3,
            5,
            8,
            5,
        };
        answers.Add(10); // 3, 5, 8, 10
        answers.Remove(3); // 5, 8, 10
        Console.WriteLine(answers.Contains(3)); // false
        foreach (var answer in answers)
        {
            Console.WriteLine(answer);
        }

        // =====================

        Dictionary<string, int> scores2 = new Dictionary<string, int>() {
            {"Math", 80},
            {"English", 90},
            {"History", 70},
        };
        scores2.Add("Science", 85);
        Console.WriteLine(scores2["English"]); // 90
        scores2["Math"] = 88;
        foreach (KeyValuePair<string, int> score2 in scores2)
        {
            Console.WriteLine($"{score2.Key}: {score2.Value}");
        }
    }
}
