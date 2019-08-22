using System;
using System.Collections.Generic;

class OddOccuranceInArray
{
    public int FindUnpaired(int[] A)
    {
        if(A.Length%2 == 0)
        {
            return 0;
        }

        Dictionary<int,int> dictionary = new Dictionary<int, int>();

        foreach(int number in A)
        {
            if(dictionary.ContainsKey(number))
            {
                dictionary[number]++;
            }
            else
            {
                dictionary[number] = 1;
            }            
        }

        foreach(KeyValuePair<int, int> entry in dictionary)
        {
            if(entry.Value %2 != 0)
            {
                return entry.Key;
            }
        }

        return 0;
    }
}