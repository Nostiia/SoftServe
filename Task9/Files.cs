using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

static class FileAnalyzer
{
    public static List<int> GetSumbolsCountInEachLine()
    {
        string path = "client.test.js";
        List<string> files = new List<string>();
        List<int> counters = new List<int>();
        using (StreamReader str = new StreamReader(path, System.Text.Encoding.Default))
        {
            string line;
            while ((line = str.ReadLine()) != null)
            {
                files.Add(line);
            }
        }
        foreach (string file in files)
        {
            int counter = file.Length;
            counters.Add(counter);
        }
        return counters;
    }
    public static string GetLongestLine()
    {
        string path = "client.test.js";
        List<string> files = new List<string>();
        using (StreamReader str = new StreamReader(path, System.Text.Encoding.Default))
        {
            string line;
            while ((line = str.ReadLine()) != null)
            {
                files.Add(line);
            }
        }
        string longest = files[0];
        foreach (string str in files)
        {
            if (str.Length > longest.Length)
            {
                longest = str;
            }
        }
        return longest;
    }
    public static string GetShortestLine()
    {
        string path = "client.test.js";
        List<string> files = new List<string>();
        using (StreamReader str = new StreamReader(path, System.Text.Encoding.Default))
        {
            string line;
            while ((line = str.ReadLine()) != null)
            {
                files.Add(line);
            }
        }
        string shortest = files[0];
        foreach (string str in files)
        {
            if (str.Length < shortest.Length)
            {
                shortest = str;
            }
        }
        return shortest;
    }
    public static List<string> GetLinesWithLet()
    {
        string path = "client.test.js";
        List<string> files = new List<string>();
        using (StreamReader str = new StreamReader(path, System.Text.Encoding.Default))
        {
            string line;
            while ((line = str.ReadLine()) != null)
            {
                files.Add(line);
            }
        }
        List<string> lines = new List<string>();
        Regex regex = new Regex("let");
        foreach (string str in files)
        {
            if (regex.IsMatch(str))
            {
                lines.Add(str);
            }
        }
        return lines;
    }
}
