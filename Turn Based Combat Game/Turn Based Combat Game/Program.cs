class Program
{
    static void Main(string[] args)
    {
        int playerHealth = 40;
        int enemyHealth = 40;

        List<string> charmanderMoves = new List<string> { "Ember", "Growl", "Potion" };
        List<string> squirtleMoves = new List<string> { "Bubble", "Growl", "Potion" };
        List<string> bulbasaurMoves = new List<string> { "Vine whip", "Growl", "Potion" };

        List<string> playerSelection = new List<string>();
        string pokemonSelectionAnswer;
        string attackChoise;

        Console.WriteLine("Select your Pokemon: 1: Charmander. 2: Bulbasaur. 3: Squirtle");
        pokemonSelectionAnswer = Console.ReadLine();

        switch (pokemonSelectionAnswer)
        {
            case "1":
                Console.WriteLine("You've Chossen Charmander!!");
                foreach (string move in charmanderMoves)
                {
                    playerSelection.Add(move);
                }
                break;
            case "2":
                Console.WriteLine("You've Chossen Bulbasaur!!");
                foreach (string move in bulbasaurMoves)
                {
                    playerSelection.Add(move);
                }
                break;
            case "3":
                Console.WriteLine("You've Chossen Squirtle!!");
                foreach (string move in squirtleMoves)
                {
                    playerSelection.Add(move);
                }
                break;
        }

        Console.WriteLine("lets start the battle!!");
        Console.WriteLine("Player Health = " + playerHealth.ToString());
        Console.WriteLine("Enemy Health = " + enemyHealth.ToString());
        while(playerHealth > 0 && enemyHealth > 0)
        {
            PlayerTurn();
            EnemyTurn();
        }

        if (playerHealth <= 0)
        {
            Console.WriteLine("The enemy wins");
            Console.ReadLine();
        }
        else if (enemyHealth <= 0)
        {
            Console.WriteLine("You Win!!!");
            Console.ReadLine();
        }


        void PlayerTurn()
        {
            if (playerHealth > 0)
            {
                Console.WriteLine("---- Player Turn ----");
                Console.WriteLine("select your move");
                Console.WriteLine("1: " + playerSelection[0]);
                Console.WriteLine("2: " + playerSelection[1]);
                Console.WriteLine("3: " + playerSelection[2]);
                attackChoise = Console.ReadLine();
                if(attackChoise == "1")
                {
                    Console.WriteLine("you've delt 10 damage!!");
                    enemyHealth = enemyHealth - 10;
                }
                else if(attackChoise == "2")
                {
                    Console.WriteLine("you growl at the enemy!!");
                }
                else if(attackChoise == "3") 
                {
                    playerHealth = playerHealth + 5;
                }
                else
                {
                    Console.WriteLine("select a valid attack!!");
                    return;
                }

                Console.WriteLine("Player Health = " + playerHealth.ToString());
            }
        }
        void EnemyTurn()
        {
            if (enemyHealth > 0)
            {
                Console.WriteLine("---- Enemy Turn ----");
                if(enemyHealth <= 10) 
                {
                    Console.WriteLine("Enemy used a potion!!");
                    enemyHealth += 5;
                }
                else
                {
                    Console.WriteLine("the enemy attacked you!!");
                    playerHealth -= 10;
                }
            }
            Console.WriteLine("Enemy Health = " + enemyHealth.ToString());
        }
    }
}