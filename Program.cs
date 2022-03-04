using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class OperatorExercise
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;
            int quotient = a / b;
            int remainder = a % b;
            if (a == 17 && b == 4) {
                Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");
            }
        }
    }
}
