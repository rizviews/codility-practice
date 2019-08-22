using System;
using System.Linq;

class BinaryGap
{
    public int FinMaxBinGap(int N)
    {        
        string binary = Convert.ToString(N,2);
        Console.WriteLine(binary);
        int maxGap = 0;
        int temp = 0;

        char[] binChars = binary.ToCharArray();

        for(int i=0;i<binChars.Length;i++)
        {
            if(binChars[i] == '0')
            {
                maxGap++;
            }
            if(binChars[i] =='1')
            {
                if(temp < maxGap)
                {
                    temp = maxGap;
                }
                maxGap = 0;
            }

        }
        return temp;                    
    }
} 