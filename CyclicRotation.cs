using System;

class CyclicRotation
{
    public int[] solution(int[] A, int K)
    {
        if(A.Length == 0 || K<=0)
        {
            return new int[0];
        }

        int[] reversed = new int[A.Length];        

        for(int i=0;i<K;i++)
        {            
            reversed[0] = A[A.Length-1];            
            for(int j=0;j<A.Length-1;j++)
            {                
                reversed[j+1] = A[j];
            }            
            reversed.CopyTo(A,0);
        }

        return reversed;
    }
}