using System;

namespace MethodOverloadingExercise
{
    class Program
    {
        public static void Add(int numOne, int numTwo)
        {
            Console.WriteLine(numOne + numTwo);
        }
        public static void Add(decimal inputOne, decimal inputTwo)
        {
            Console.WriteLine(inputOne + inputTwo);
        }
        public static string Add(int first, int second, bool third)
        {
            int sum = first + second;
            if (third == true)
            {
                if(sum == 1)
                {
                    return $"{sum} dollar";
                }
                else
                {
                    return $"{sum} dollars";
                }
            }
            else
            {
                return $"{sum}";
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Im going to call the 1st Add Method.");
            Add(1, 2);

            Console.WriteLine("Im going to call the 2nd Add Method.");
            Add(55.25m, 9633.2m);

            var answer = Add(1, 0, true);
            Console.WriteLine($"Testing 3rd Add Method with true, singular. The sum is {answer}");

            var sum = Add(2, 36, true);
            Console.WriteLine($"Testing 3rd Add Method with true, plural. The sum is {sum}");

            var num = Add(8, 20, false);
            Console.WriteLine($"Testing 3rd Add Method with false. The sum is {num}");
        }
    }
}
