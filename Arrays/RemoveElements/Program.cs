using System;

namespace RemoveElements
{
    class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            var arr1 = new int[N];
            for (int i = 0; i < N; i++)
            {
                arr1[i] = int.Parse(Console.ReadLine());
            }

            int maxLength = 0;
            var arr2 = new int[N];
    
            for (int end = 0; end < arr1.Length; end++)
            {
                maxLength = 0;
                                            
                for (int startPoint = 0; startPoint < end; startPoint++)
                {
                    if (arr1[end] >= arr1[startPoint])
                    {
                        if (arr2[startPoint] > maxLength)   
                        {                                            
                            maxLength = arr2[startPoint];   
                        }                                           
                    }                                                
                }                                                    
                
                arr2[end] = maxLength + 1;
            }

            maxLength = 0;

            for (int i = 0; i < N; i++)
            {                      
                if (arr2[i] > maxLength)
                {
                    maxLength = arr2[i];
                }
            }

            Console.WriteLine(N - maxLength);
        }
    }
}
