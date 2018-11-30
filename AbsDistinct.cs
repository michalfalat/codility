using System;
// you can also use other imports, for example:
using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
 

class Solution {
    public int solution(int[] A) {
        var absDistinct = new HashSet<int>();
        var overflowDetected = false;
        foreach(int number in A){
            if(number == int.MinValue){
                overflowDetected = true;
            }
            else if(!absDistinct.Contains(Math.Abs(number))){
                absDistinct.Add(Math.Abs(number));
            }
        }
        return overflowDetected ? absDistinct.Count + 1 : absDistinct.Count;
        // write your code in C# 6.0 with .NET 4.5 (Mono)
    }
}