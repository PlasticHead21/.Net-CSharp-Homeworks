using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    class Program
    {
        public static void Main()
        {
            int counter = 0;
            int players = 0;
            const int EDGE = 1000;
            Game game = new Game();
            List<Card> Cards = new List<Card>();
            Cards = game.CreateCardDeck();
            game.Shuffling(ref Cards);
            Console.WriteLine("Choose count of players (6 maximum).");
            try
            {
                players = Int32.Parse(Console.ReadLine());
                if (players == 1) { throw new Exception(message: "You cant choose only one player."); }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Main();
            }
            for (int i = 0; i < players; i++)
            {
                Console.WriteLine("Enter the name of player.");
                string nameOfPlayer = Console.ReadLine();               
                game.AddPlayer(new Player(nameOfPlayer));
                Console.Clear();
            }
            game.GiveCardsToPlayers();

            Console.WriteLine("Playing.....");
            while (!game.CardsOnTable())
            {
                game.CardsOnTable();
                counter++;
                if (counter == EDGE)
                {
                    Console.Clear();
                    Console.WriteLine("|||||||||||||||||||||||||DRAW|||||||||||||||||||||||||");
                    Console.ReadKey();
                    return;
                }
            }
            Console.Clear();
            Console.WriteLine(game.results);

            Console.ReadKey();
        }
    }
}
