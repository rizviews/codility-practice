using System;

class FrogJump
{
    public int solution(int X, int Y, int D)
    {
        if(X>Y)
        {
            return 0;
        }        
        
        decimal value = (decimal)(Y-X)/(decimal)D;        
        return Convert.ToInt32(Math.Ceiling(value));
                                
    }
}