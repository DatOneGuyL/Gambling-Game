class Game_TaiXiu
{
    static int rollDice()
    {
        Random rnd = new Random();
        int die1 = rnd.Next(6) + 1;
        int die2 = rnd.Next(6) + 1;
        int die3 = rnd.Next(6) + 1;
        int sum_of_dice = die1 + die2 + die3;
        return sum_of_dice;
    }
    static void playOneRound()
    {
        int dice_value = rollDice();
        Console.WriteLine("Chọn Tài hoặc Xỉu");
        string user = Console.ReadLine();
        if (user.Contains('T') || user.Contains('t'))
        {
            if (dice_value >= 10) //Tài
            {
                Console.WriteLine("You win!");
            }
            else Console.WriteLine("You lose!");
        }
        else if (user.Contains('X') || user.Contains('x'))
        {
            if (dice_value >= 10) //Xỉu
            {
                Console.WriteLine("You lose!");
            }
            else Console.WriteLine("You win!");
        }
        else Console.WriteLine("Please choose a side");
    }
    static void game_engine()
    {
        do
        {
            playOneRound();
            Console.WriteLine("Do you want to play again?");
            string choice = Console.ReadLine();
            if (choice.ToUpper().Equals("K") || choice.ToUpper().Equals("N"))
            {
                break;
            }
        }
        while (true);
        Console.WriteLine("Please play again!");
    }
    static void Main()
    {
        game_engine();
    }
}