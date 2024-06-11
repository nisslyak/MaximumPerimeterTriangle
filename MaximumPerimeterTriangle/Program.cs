using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;
using System.Xml.Linq;

static class Result
{
    public static List<int> maximumPerimeterTriangle(List<int> sticks)
    {
        sticks.Sort();
        for (int i = sticks.Count - 3; i >= 0; i--)
        {
            if (sticks[i] + sticks[i + 1] > sticks[i + 2])
            {
                return new List<int> { sticks[i], sticks[i + 1], sticks[i + 2] };
            }
        }
        return new List<int> { -1 };
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> sticks = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(sticksTemp => Convert.ToInt32(sticksTemp)).ToList();

        List<int> result = Result.maximumPerimeterTriangle(sticks);

        textWriter.WriteLine(String.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
