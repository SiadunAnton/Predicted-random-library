using System;
using PredictedRandom;

namespace RandomUsing
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var arrayFactory = new ArrayFactory<int>(9, (1,33), (2,33), (5,33)); 

            
            for (int i = 0; i < 5; i++)
            {
                var anArray = arrayFactory.Generate();

                foreach (var item in anArray)
                    Console.Write($"{item}  ");
                Console.WriteLine();
            }
        }
    }
}
