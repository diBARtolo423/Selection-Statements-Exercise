namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var r = new Random(89);
            var favNumber = r.Next(1, 1000);
            Console.WriteLine("What is my favorite number?");
            var userInput = int.Parse(Console.ReadLine());

            //    if (userInput < favNumber)
            //{        
            //    Console.WriteLine("too low");
            //}

            //    else if (userInput > favNumber)
            //{        
            //    Console.WriteLine("too high");
            //}

            //    else
            //{ 
            //    Console.WriteLine("You guessed it!!");
            //}

            Console.WriteLine((userInput < favNumber) ? "too low" : (userInput > favNumber) ? "too high" : "You guessed it!!");
        }
    }
}
