using System;
using System.Collections.Generic;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        var distinct = new HashSet<int>();
        foreach(var number in A){
            if(!distinct.Contains(number)){
                distinct.Add(number);
            }
        }        
        return distinct.Count;
        // write your code in C# 6.0 with .NET 4.5 (Mono)
    }
}