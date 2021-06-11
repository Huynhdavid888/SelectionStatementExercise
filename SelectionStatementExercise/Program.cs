using System;

namespace SelectionStatementExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            var r = new Random();
            var favNumber = r.Next(1, 50);

            Console.WriteLine("Try to guess my favorite number");
            var userinput = int.Parse(Console.ReadLine());

            if (favNumber == 25)
            {
                Console.WriteLine("You guessed it!");
            }

            else if (favNumber < 20)
            {
                Console.WriteLine("So close!");
            }


            else if (favNumber < 10)
            {
                Console.WriteLine("Not even close");
            }

            else if (favNumber > 25)
            {
                Console.WriteLine("you're right there!");

            }

            else if (favNumber > 30)
            {
                Console.WriteLine("You're getting farther away");

            }

            else 
            {
                Console.WriteLine("Just give up");
            }

            #endregion
        }

    }
}