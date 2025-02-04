using System;
using static System.Console;


namespace DiceGamingProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Project game Dice : 
            /* 
            -If any two dice you roll result in the same value, you get two bonus points for rolling doubles.
            -If all three dice you roll result in the same value, you get six bonus points for rolling triples.
            -If the sum of the three dice rolls, plus any point bonuses, is 15 or greater, you win the game. Otherwise, you lose.*/

            Random dice = new Random();

            int roll1 = dice.Next(1, 7);
            int roll2 = dice.Next(1, 7);
            int roll3 = dice.Next(1, 7);

            //roll1 = 6;  >> we can use those to test our project if runs correctly!
            //roll2 = 6;
            //roll3 = 6;

            int total = roll1 + roll2 + roll3;

            WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total} ");

            // Now we add the decision logic bellow with statement if() see bellow:

            if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
            {
                if ((roll1 == roll2) && (roll2 == roll3))
                {
                    WriteLine("You rolled triples! +6 bonus to total!");
                    total += 6;
                }
                else
                {
                    WriteLine("You rolled doubles! +2 bonus to total!");
                    total += 2;
                }
                WriteLine($"Your total including the bonus: {total}");
                
            }

            if (total >= 16)  //We update our code from (total > 14) to (total >= 15) for readability our code.  we update to 16 for to put the prizes.
            {
                WriteLine("You Win a new Car!");
            }
            else if (total >= 10)
            {
                WriteLine("You win a new laptop!");
            }
            else if (total == 7)
            {
                WriteLine("You win a trip for two!");
            }
            else
            {
                WriteLine("You win a kitten!");
            }


            




            ReadKey();
        }
    }

}
