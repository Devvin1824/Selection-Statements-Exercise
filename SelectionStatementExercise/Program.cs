namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            var r = new Random();
            var favNumber = r.Next(1,1000);
            Console.WriteLine("Try to guess my favorite number");
            var userInput = int.Parse(Console.ReadLine());
            bool car = true;

            while (car)
            {
                if (userInput < favNumber)
                {
                    Console.WriteLine("Too low, try again.");
                    Console.WriteLine("Try to guess my favorite number");
                    userInput = int.Parse(Console.ReadLine());
                }
                else if (userInput > favNumber)
                {
                    Console.WriteLine("Too high, try again.");
                    Console.WriteLine("Try to guess my favorite number");
                    userInput = int.Parse(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("Congratulations, you guessed it!");
                    car = false;
                }
            }

            // let user enter another guess 
            // Exercise 2 

            Console.WriteLine("What is your favorite subject in school?");
            var favSubject = (Console.ReadLine());
            switch (favSubject.ToLower())
            {
                case "math":
                    Console.WriteLine("Your favorite subject is math, alot of people don't like math");
                    break;
                case "history":
                    Console.WriteLine("Your favorite subject is history, don't let the past repeat itself!");
                    break;
                case "science":
                    Console.WriteLine("Your favorite subject is science, we need more scientists!");
                    break;
                case "english":
                    Console.WriteLine("Your favorite subject is english, do you like poetry?");
                    break;
                case "anatomy":
                    Console.WriteLine("Your favorite subject is anatomy, what is your favorite part about the human body?");
                    break;
                default:
                    Console.WriteLine($"Your favorite subject is {favSubject}, that is really interesting!");
                    break;
            }




            

            

            

        }
    }
}
