using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var w = Console.ReadLine();
        List<string> list = new List<string>();
        while (true)
        {
            string Input = Console.ReadLine();
            if (Input == "END_OF_TEXT") break;
            else list.Add(Input.ToLower());
        }
        string T1 = string.Join(" ", list);
        string[] T2 = T1.Split(' ');
        int ans = 0;
        for(int i = 0; i < T2.Length; i++)
        { 
            if(T2[i] == w)
            {
                ans++;
            }
        }
        Console.WriteLine(ans);
    }
}