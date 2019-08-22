using System;

namespace DemoTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solution solution = new Solution();
            // Console.WriteLine("Hello World!");
            // //int[] tabSequence = new[] { 1, 2, 3, 7, 8, 9, 12, 15, 16, 17, 22, 23, 32 };            
            // int[] numbers = new[] {1,3,4,6};

            // // int[] numbers = new int[201];

            // // for(int i=0;i<=100;i++)
            // // {
            // //     numbers[i] = i;
            // // }

            // // for(int i=101;i<=200;i++)
            // // {
            // //     numbers[i-1] = i;
            // // }

            // Console.WriteLine(solution.solution(numbers));


            // BinaryGap binaryGap = new BinaryGap();
            // Console.WriteLine(binaryGap.FinMaxBinGap(989));

            // OddOccuranceInArray occuranceInArray = new OddOccuranceInArray();
            // Console.WriteLine(occuranceInArray.FindUnpaired(new[] {9999,9999,1000000000,9,3,9,3,9,7,9,3,3,7,-1,-1}));

            // CyclicRotation cyclicRotation = new CyclicRotation();
            // cyclicRotation.solution(new[] {3, 8, 9, 7, 6},3);

            // FrogJump frogJump = new FrogJump();
            // Console.WriteLine(frogJump.solution(10,85,30));

            // Console.WriteLine(frogJump.solution(12,900,5));

            // 1+10 = 11, 1+10+10=21, 1+10+10+10=31, 1+10+10+10+10=41,1+50=51,1+60=61,1+70=71,1+80=81,1+90=91,1+100=101

            Test2 test2 = new Test2();
            //Console.WriteLine(test2.solution(new[] {2,3,4,5,6,7,8,9,10,11,100},3));
            // Console.WriteLine(test2.solution(new[] {2,2,2,2,2,2,2,2,2,2},3));
            //Console.WriteLine(test2.solution(new[] {200,300,302,400,420,500,600,800,1000,1100,1200,10000},5));

            int[] array = new int[10000];

            for(int i=1;i<=10000;i++)
            {
                array[i-1] = i; 
            }
            Console.WriteLine(test2.solution(array,10));
            
        }
    }
}
