
namespace Topic_1_6_Summative
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Die die1, die2;
            bool done;
            string play;
            int bet;
            double betAmount;
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
            Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.White;


            done = false;

            while (!done)
            {
                Console.Clear();
                Console.WriteLine("Press ENTER to start the round or enter Q to quit");
                play = Console.ReadLine();
                play = play.ToUpper();
                if (play == "Q" || play == "QUIT")
                {
                    Console.WriteLine("Thanks for playing!");
                    done = true;
                }

                else
                {
                    Console.WriteLine($"Your balance is {balance.ToString("C")}");
                    Console.WriteLine("How much would you like to bet");
                    while (!double.TryParse(Console.ReadLine(), out betAmount) || betAmount > balance || betAmount <= 0)
                    {
                        Console.WriteLine($"Invalid input! Please ensure your bet is a valid number and less than your current balance of {balance.ToString("C")}");
                    }
                    Console.WriteLine("What would you like to bet on? (Enter number)");
                    Console.WriteLine("1. DOUBLES");
                    Console.WriteLine("2. NOT DOUBLES");
                    Console.WriteLine("3. EVEN SUM");
                    Console.WriteLine("4. ODD SUM");

                    while (!Int32.TryParse(Console.ReadLine(), out bet) || bet > 4 || bet < 0)
                    {
                        Console.WriteLine("Invalid input! Please ensure your input is the number of one of the listed options");
                    }

                    Console.WriteLine("Press ENTER to Roll!");
                    Console.ReadLine();
                    Console.WriteLine("Rolling Dice!");

                    die1 = new Die(ConsoleColor.Blue);
                    die2 = new Die(ConsoleColor.Yellow);

                    Thread.Sleep(1000);
                    die1.RollDie();
                    die1.DrawRoll();
                    Thread.Sleep(1000);
                    die2.RollDie();
                    die2.DrawRoll();

                    Console.ForegroundColor = ConsoleColor.White;

                    if (bet == 1 && die1.Roll == die2.Roll)
                    {
                        Console.WriteLine("Congratulations! Your bet on DOUBLES was correct!");
                        Console.WriteLine($"You won {(betAmount * 2).ToString("C")}");
                        balance += (betAmount * 2);
                    }

                    else if (bet == 2 && die1.Roll != die2.Roll)
                    {
                        Console.WriteLine("Congratulations! Your bet on NOT DOUBLES was correct!");
                        Console.WriteLine($"You won {(betAmount / 2).ToString("C")}");
                        balance += (betAmount / 2);

                    }

                    else if (bet == 3 && (die1.Roll + die2.Roll) % 2 == 0)
                    {
                        Console.WriteLine("Congratulations! Your bet on EVEN SUM was correct!");
                        Console.WriteLine($"You won {(betAmount).ToString("C")}");
                        balance += betAmount;

                    }

                    else if (bet == 4 && (die1.Roll + die2.Roll) % 2 != 0)
                    {
                        Console.WriteLine("Congratulations! Your bet on ODD SUM was correct!");
                        Console.WriteLine($"You won {(betAmount).ToString("C")}");
                        balance += betAmount;

                    }

                    else
                    {
                        Console.WriteLine("Sorry! Your bet was incorrect");
                        balance -= betAmount;
                    }


                        Console.WriteLine("Press ENTER to continue");
                    Console.ReadLine();

                
                }

                if (balance == 0)
                {
                    Console.WriteLine("Sorry. You are out of money");
                    Console.WriteLine("Thanks for playing!");
                    done = true;
                }





            }
        }
    }
}
