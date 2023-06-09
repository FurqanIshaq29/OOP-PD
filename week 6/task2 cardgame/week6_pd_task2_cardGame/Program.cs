using week6_pd_task2_cardGame.BL;
using week6_pd_task2_cardGame;

int option = 0;
do
{
    Console.WriteLine("Enter 1 to Play the game.");

    Console.WriteLine("Enter 2 to Exit the game.");
    option = int.Parse(Console.ReadLine());
    Console.Clear();
    if (option == 1)
    {
        bool gameRunning = true;
        int score = 0;
        // to count score
        Deck obj = new Deck();
        obj.shuffle(); // to shuffle the deck
        Card card1 = obj.dealCard();
        // getting the dealt card object
        while (gameRunning)
        {
            int remain_check = obj.cardLeft();
            Card card2 = obj.dealCard();
            Console.WriteLine("********************************");
            Console.WriteLine(card1.toString());
            Console.WriteLine("");
            Console.WriteLine("*** Remaining cards *** : " + remain_check);
            Console.WriteLine("Enter 1 if the next card is higher.");
            Console.WriteLine("Enter 2 if the next card is lower.");
            int card_check = int.Parse(Console.ReadLine());
            Console.Clear();
            if (card_check == 1) // for greater than
            {
                if (card2.getValue() >= card1.getValue())
                {
                    // if next card is greater
                    score++;
                    card1 = card2;
                }
                else
                {
                    gameRunning = false;
                    Console.WriteLine("SORRY YOU LOSE! PRESS ANY KEY TO CONTINUE.");
                    Console.WriteLine("The Card was " + card2.toString());
                    Console.WriteLine("You Score is :" + score);
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            if (card_check == 2) //for less than
            {
                if (card2.getValue() < card1.getValue()) //if next card is smaller
                {
                    score++;
                    card1 = card2;
                }
                else
                {
                    gameRunning = false;
                    Console.WriteLine("SORRY YOU LOSE! PRESS ANY KEY TO CONTINUE.");
                    Console.WriteLine("The Card was " + card2.toString());
                    Console.WriteLine("You Score is :" + score);
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            if (obj.cardLeft() == 0 && card2 == null)
            {
                gameRunning = false;
                Console.WriteLine("Congrants u have scored maximum.");
                Console.ReadKey();
                Console.Clear();
                break;
            }
        }
    }
} while (option!=2);