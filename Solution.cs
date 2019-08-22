using System;
using System.Linq;
using System.Collections.Generic;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {        
        // // write your code in C# 6.0 with .NET 4.5 (Mono)
        // if(A.Min()<0 || (A.Count() == 1 && A.Min() == 1))
        // {
        //     return 1;
        // }
        // int min = A.Min();

        // if(A.Count() == 1)
        // {
        //     min = 1;            
        // }
        // var results = Enumerable.Range(min, A.Max()).Except(A);
        
        // if(results.Count() == 0)
        // {
        //     return A.Max()+1;
        // }
        // else
        // {            
        //     return results.Min();
        // }    

        // the minimum possible answer is 1
        int result = 1; 
        // let's keep track of what we find
        Dictionary<int,bool> found = new Dictionary<int,bool>();

        // loop through the given array  
        for(int i=0;i<A.Length;i++) {
            // if we have a positive integer that we haven't found before
            if(A[i] > 0 && !found.ContainsKey(A[i])) {
                // record the fact that we found it
                found.Add(A[i], true);
            }
        }

        // crawl through what we found starting at 1
        while(found.ContainsKey(result)) {
            // look for the next number
            result++;
            Console.WriteLine(result);
        }

        // return the smallest positive number that we couldn't find.
        return result;    
    } 
}
