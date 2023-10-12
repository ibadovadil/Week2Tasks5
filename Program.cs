namespace Week2._5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*Task 1*/

            Console.Write("Enter  number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int firstNumber = 0;
            int secondNumber = 1;

            while (secondNumber <= number)
            {
                Console.WriteLine(secondNumber);
                int temp = firstNumber;
                firstNumber = secondNumber;
                secondNumber = temp + secondNumber;
            }

            Console.WriteLine("Fibonacci Sequence:");


            /*Task 2*/

            int NumberOne = 14;
            int NumberTwo = 9;

            NumberOne = NumberOne - NumberTwo;
            NumberTwo = NumberOne + NumberTwo;
            NumberOne = NumberTwo - NumberOne;

            Console.WriteLine("NumberOne = " + NumberOne);
            Console.WriteLine("NumberTwo = " + NumberTwo);
        }
    }
}