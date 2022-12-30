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
            
                if (userInput <= 88)
            {        
                Console.WriteLine("too low");
            }
            
                else if (userInput >= 90)
            {        
                Console.WriteLine("too high");
            }
           
                else
            { 
                Console.WriteLine("You guessed it!!");
            }
            

        }
    }
}
