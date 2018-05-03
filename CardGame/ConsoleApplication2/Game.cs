using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    class Game
    {
        #region FIELDS
        private SortedDictionary<Player, Card> table;
        private List<Card> cardsDeck;
        private List<Player> players;
        public string results { get; private set; }
        private int countOfPlayers;
        public int CountOfPlayers
        {
            get { return countOfPlayers; }  
        }
        Random rand;

        #endregion
        #region CONSTRUCTORS
        public Game()
        {
            table = new SortedDictionary<Player, Card>();
            cardsDeck = new List<Card>();
            players = new List<Player>();
            rand = new Random(DateTime.Now.Millisecond);
            results = "";
        }
        #endregion
        #region METHODS
        /// <summary>
        /// Переставляет (перетасовывает) значения 
        /// в списке, заполненном типом Card
        /// </summary>
        /// <param name="cardsDeck">Изначально сгенерированный
        /// (не перемешаный) список</param>
        public void Shuffling(ref List<Card> cardsDeck)
        {
            for (int i = 0; i < cardsDeck.Count; i++)
            {
                int j = rand.Next(i + 1);
                if (cardsDeck[j] != cardsDeck[i])
                {
                    Card temp = cardsDeck[i];
                    cardsDeck[i] = cardsDeck[j];
                    cardsDeck[j] = temp;
                }
            }
        }
        /// <summary>
        /// Создаёт список (колоду карт)
        /// заполненный типом Card
        /// </summary>
        /// <returns>List<Card>Cписок заполненный типом Card</returns>
        public List<Card> CreateCardDeck()
        {
            Array types = Enum.GetValues(typeof(CardTypes));
            Array values = Enum.GetValues(typeof(CardValues));
            for (int i = 0; i < types.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    Card newCard = new Card()
                    {
                        type = (CardTypes)types.GetValue(i),
                        value = (CardValues)values.GetValue(j)
                    };
                    cardsDeck.Add(newCard);
                }
            }
            return cardsDeck;
        }
        /// <summary>
        /// Добавляет объект типа Player в
        /// список players
        /// </summary>
        /// <param name="player">Объект типа Player</param>
        public void AddPlayer(Player player)
        {
            if (players.Count < 6)
                players.Add(player);
            else
                throw new Exception(message: "Your added the limit of players.");
        }
        /// <summary>
        /// Метод заполняющий равным количеством карт (Card card)
        /// Список (List<Card> cards) у каждого игрока.
        /// Также удаляющий карты, которые розданы игрокам,
        /// из основного списка карт (List<Card> cardsDeck).
        /// </summary>
        public void GiveCardsToPlayers()
        {
            int countOfCards = cardsDeck.Count / players.Count;
            foreach (var player in players)
            {
                for (int j = 0; j != countOfCards; j++)
                {
                    player.GetCards(cardsDeck[j]);
                }
                foreach (var card in player.Cards)
                {
                    cardsDeck.Remove(card);
                }
            }
        }

        /// <summary>
        /// Каждый игрок из списка <list type="Player">players</list>
        /// добавляется в <SortedDictionary type="Player, Card">table</SortedDictionary>
        /// и добавляет по объекту типа Card из <Stack type="Card">cards</Stack>.
        /// После сортировки по возрастанию, последнему ключу
        /// словаря передаются все значения словаря <SortedDictionary type="Player, Card">table</SortedDictionary>.
        /// </summary>
        public bool CardsOnTable()
        {
            if (players.Count != 1)
            {

                foreach (var player in players)
                {
                    table.Add(player, player.Stroke());
                }
                cardsDeck = table.Values.ToList<Card>();

               for(int i = 0; i < players.Count; i++)
                {
                    if(players[i].countOfCards != 0)
                    {
                        players[i].RemoveUsedCards();
                    }
                    if(players[i].countOfCards == 0 && players.Count != 1)
                    {
                        results += $"Player {players[i].Name} left game.\n"+
                            $"Time {DateTime.Now}.\n"+
                            $"Number of moves: {players[i].CounterOfMoves}\n\n";
                        players.Remove(players[i]);
                        countOfPlayers = players.Count;
                    }     
                }

                while (cardsDeck.Count != 0)
                {
                    int i = 0;
                    table.Last().Key.GetCapturedCards(cardsDeck[i]);
                    cardsDeck.Remove(cardsDeck[i]);
                    i++;
                }
                table.Clear();
            }
            if (players.Count == 1)
            {
                results += $"Winner is {players.Last().Name}.\n Time:{DateTime.Now}\n" +
                                    $"Number of moves: { players.Last().CounterOfMoves}\n";
                return true;
            }
            return false;
        }
        /// <summary>
        /// Показывает карты находящиеся в <list type="Cards">cards</list>
        /// </summary>
        public void ShowCardsOfPlayers()
        {
            foreach (var player in players)
            {
                Console.WriteLine($"Player: {player.Name}");
                player.ShowCards();
            }
        }
        /// <summary>
        /// Метод для вывода результатов иры. 
        /// </summary>
        /// <param name="res">результат игры для каждого объекта типа Player</param>
      
       #endregion
    }
}
