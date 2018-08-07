using System;

namespace ArrayNames
{
    class Program
    {
        static void Main(string[] args)
        {
            //initializes the array of type string of size 30
            string[] names = new string[30];
            //sets counter to zero
            int counter = 0;
            //Prints instructions to the user
            Console.WriteLine("Enter each name followed by enter, when finished just press enter again:");
            //makes a loop to input the names in he array
            for (int i = 0; i < 30; i++)
            {
                //each name is stored in the array
                names[i] = Console.ReadLine();
                //need a counter to determine ending number for the random number
                counter = counter + 1;
                //stops input if the user hits enter or there has been 30 names inputted
                if (names[i] == "" || i == 29) break;
               
            }
            //Instantiates the random method?
            Random rnd = new Random();
            // creates a random number between 0 and the number of names in the array and assigns it to a variable winner
            int winner = rnd.Next(0, counter-1);
            //prints the winner's name to the screen
            
            Console.WriteLine("Yay, The winner is " + names[winner] + "!");
            //Console.WriteLine(winner); Here I was checking what the random number was 
            Console.WriteLine("Now I will print out all the losers:");
            //Loop to print out the losers from the array
            for (int i = 0; i < names.Length; i++)
            {
                //This line skips the array item that won and prints others
                if (i != winner) Console.WriteLine(names[i]);
            }
            //ends program with enter           
            Console.ReadLine();
        }
    }
}
