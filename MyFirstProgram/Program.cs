using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {

            // Console.Write "Hello, World!\n" 
            // Both (Above and Below) are the same and will end the line and begin on the next with next in qoutation text 
            // Console.WriteLine "Hello, World!" 

            // semi colon ; tells our program, “Okay, this line of code is finished.”

            Console.WriteLine("Hello. What is your name? ");

            int playerScore = 0;
            string playerName = "";


            playerName = Console.ReadLine();

            int add = 0;

            while (playerScore < 10)
            {
                // request input 
                Console.Write("Incriment score: ");
                add = Convert.ToInt32(Console.ReadLine());
                // add score
                playerScore += add;
                Console.Write("Curent score ");
                Console.WriteLine(playerScore);
            }

            Console.Write("Score of " + playerName);
            Console.WriteLine(playerScore);

            // when you place quotation marks in C# code, you are defining what is called a string
            // strings are generally used to display text to the user 

            Console.WriteLine("This is my first program. Neat!");
            // When user presses enter game closes

            Console.ReadLine();

            /*C# types of data
             * string - text done to the user:  
             * int - Numbers such as, Hitpoints, enemyCounts: 
             * float - decimal numbers:   
             * char - letters and objects: 
             * double -same as float but bigger numbers:

             * Initializing variables storgae type
             * float
             * int
             * bool
             * char
             

            * Assignment Operators  
             * = - Assigns values to preeceding 
             * += - Adds then assigns 
             * -= - Subtracts then assigns 
             * %= - Modulus and then assigns 
              
             * Logical operators
             * && - The AND operator: allows for multiple trues in one line
             * || - The OR operator: if Allows for another passage that is true without all other true being present 
             * ! - The OPPOSITE or NOT operator: Flips the true to falso or vise versa in one line 
             * == - The ASK operator: Checks to see if two operands are equal 
             
             * PEMDAS: plus Negation = !
             */

        }
    }
}
