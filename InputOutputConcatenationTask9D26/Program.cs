namespace InputOutputConcatenationTask9D26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ask
            // First Name, Last Name, Age, Height,
            // Is it raining, a symbol of any type
            // output the information in a sentence
            // this must only be one console.writeline statement
            Console.Write("Please enter your first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Please enter your last name: ");
            string lastName = Console.ReadLine();
            Console.Write("Please enter your age: ");
            string age = Console.ReadLine();
            Console.Write("Please enter your height: ");
            string height = Console.ReadLine();
            Console.Write("Is it raining? (true/false): ");
            string isRaining = Console.ReadLine();
            Console.Write("Please enter a symbol: ");
            string symbol = Console.ReadLine();
            // using concatenation (+)
            Console.WriteLine("Your name is " + firstName + " " + lastName + ", you are " + age + " years old, and you are " + height + " tall. It is " + isRaining + " that it is raining, and your symbol is " + symbol + ".");
            // using string interpolation ($)
            Console.WriteLine($"Your name is {firstName} {lastName}, you are {age} years old, and you are {height} tall. It is {isRaining} that it is raining, and your symbol is {symbol}.");
        }
    }
}
