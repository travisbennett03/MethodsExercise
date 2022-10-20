namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("What is your name?");
            //string userName = Console.ReadLine();

            //Console.WriteLine("What is your favorite color?");
            //string color = Console.ReadLine();

            //Console.WriteLine("What is your favorite animal?");
            //string animal = Console.ReadLine();

            //Console.WriteLine("What is your favorite band
            //Console.WriteLine($"There was a man named {userName}, his favorite color is {color}.");
            //Console.WriteLine($"His favorite animal was a {animal}. He loves the band {band}.");

            Console.WriteLine("Give me a number to add");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to add to the first one");
            int num2 = int.Parse(Console.ReadLine());

            int sum = Sum(num1, num2);
            Console.WriteLine($"The sum is: {sum}");

            int multiply = Multiply(num1, num2);
            Console.WriteLine($"The answer is: {multiply}");

            int subtract = Subtract(num1, num2);
            Console.WriteLine($"The answer is: {subtract}");

            int divide = Divide(num1, num2);
            Console.WriteLine($"The answer is: {divide}");

            int modulus = Modulus(num1, num2);
            Console.WriteLine($"The answer is: {modulus}");

            int bigsum = SumWithParams(num1, num2, modulus, divide, subtract, multiply, sum);
            Console.WriteLine($"The answer is; {bigsum}");

        }

        public static int Sum(int num1, int num2)
        { return num1 + num2; }

        public static int SumWithParams(params int[] nums)
        { return nums.Sum(x => x); }

        public static int Multiply(int num1, int num2)
        { return num1 * num2; }

        public static int Subtract(int num1, int num2)
        { return num1 - num2; }

        public static int Divide(int num1, int num2)
        { return num1 / num2; }

        public static int Modulus(int num1, int num2)
        { return num1 % num2; }
    }
}
