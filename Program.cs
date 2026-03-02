
namespace Topic_1_6_Summative
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Die die1, die2;
            bool done;
            string play;
            double bet;
            double balance = 100;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Welcome To Josh's Dice Game!");
            Console.WriteLine();
            Console.ForegroundColor= ConsoleColor.Red;
            Console.WriteLine("Rules:");
            Console.ForegroundColor=(ConsoleColor) ConsoleColor.White;
            Console.WriteLine("You will be given a set amount of money");
            Console.WriteLine("You will then be given four options to bet on:");
            Console.WriteLine("Doubles (Pays 2x), Not Doubles (Pays 0.5x), Even Sum (1x), Odd Sum (1x)");
            Console.WriteLine("After your bet the dice will roll and you will be payed upon a correct bet");
            Console.WriteLine("Any other roll or incorrect bet will result in loss of bet");
            Console.WriteLine("After each round you will be given the option to quit");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Press ENTER to begin!");


            done = false;

            while (!done)
            {
                Console.WriteLine("Press ENTER to start the round or enter Q to quit");
                play = Console.ReadLine();
                play = play.ToUpper();
                if (play == "Q" || play == "QUIT")
                {
                    done = true;
                }

                else
                {
                    Console.WriteLine($"Your balance is {balance.ToString("C")}");
                    Console.WriteLine("How much would you like to bet");
                    while (!double.TryParse(Console.ReadLine(), out bet) || bet > balance)
                    {
                        Console.WriteLine($"Invalid input! Please ensure your bet is a valid number and less than your current balance of {balance}");
                    }
                }







            }
        }
    }
}
