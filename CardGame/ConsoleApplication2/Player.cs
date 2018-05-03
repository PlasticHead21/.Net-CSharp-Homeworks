using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    class Player:IComparable<Player>, IEquatable<Player> 
    {
        #region FIELDS
        public int CounterOfMoves { get; private set; }
        public string Name { get; set; }
        public int countOfCards { get { return Cards.Count; } set { countOfCards = Cards.Count; } }
        public Stack<Card> Cards;
        #endregion
        #region CONSTRUCTORS
        public Player()
        {
            CounterOfMoves = 0;
            Cards = new Stack<Card>();        
        }
        public Player(string name): this()
        {
            this.Name = name;
        }
        #endregion
        #region METHODS
        /// <summary>
        /// Метод для получения карт из основной колоды <list type="Card">CardsDeck</list>
        /// </summary>
        /// <param name="card"></param>
        public void GetCards(Card card)
        {
             Cards.Push(card);          
        }
        /// <summary>
        /// Метод для сбора выигранных карт
        /// реализован так, для того, 
        /// что бы заносить карты в нижнюю часть стэка.
        /// </summary>
        /// <param name="card"></param>
        public void GetCapturedCards(Card card)
        {
            List<Card> reversed = Cards.ToList();
            reversed.Add(card);
            reversed.Reverse();
            Cards = new Stack<Card>(reversed);
        }
        /// <summary>
        /// Игрок ходит значением из стека
        /// </summary>
        /// <returns>Объект типа Card</returns>
        public Card Stroke()
        {
            CounterOfMoves++;
            return Cards.Peek();
        }
        public void ShowCards()
        {
            int counter = 0;
            foreach(var i in Cards)
            {
                Console.WriteLine($"Type: {i.type} Value: {i.value}");
                counter++;
            }
            Console.WriteLine(counter);
        }
        /// <summary>
        /// Переопределение метода СompareTo IComparable
        /// </summary>
        /// <param name="p">Сравниваемый объект</param>
        /// <returns>Значение, указывающее, каков относительный порядок сравниваемых объектов.</returns>
        public int CompareTo(Player p)
        {
            if(this.Cards.Peek().value.CompareTo(p.Cards.Peek().value) == 0)
            {
                if(Cards.Count == 1 || p.Cards.Count == 1)
                {
                     return 1;                   
                }
                else
                {
                    if (IfCardsAreEqual(p) != 0)
                        return IfCardsAreEqual(p);
                }
            }
            return this.Cards.Peek().value.CompareTo(p.Cards.Peek().value); 
        }
        /// <summary>
        /// Переопределение Equals из IEquatable
        /// </summary>
        /// <param name="other">Объект, который требуется сравнить с данным объектом.</param>
        /// <returns>true, если текущий объект равен параметру other, в противном случае — false.</returns>
        public bool Equals(Player other)
        {
            if (this.Name == other.Name) { return true; }
            else return false;
        }

        public void RemoveUsedCards()
        {
            Cards.Pop();
        }
        /// <summary>
        /// Если два элемента в стэке равны, то 
        /// игроки сравнивают ещё по карте.
        /// Данный метод сделан для исключения бесконечной игры
        /// в случае совпадения карт.
        /// </summary>
        /// <param name="p">Сравниваемый объект</param>
        /// <returns>Значение, указывающее, каков относительный порядок сравниваемых объектов.</returns>
        private int IfCardsAreEqual(Player p)
        {
            int temp = 0;
            int i = 0;
            Card[] right = new Card[countOfCards]; Card[] left = new Card[p.countOfCards];
            if (countOfCards <= 1)
            {
                while (this.Cards.Peek().value.CompareTo(p.Cards.Peek().value) == 0)
                {
                    right[i] = this.Cards.Pop();
                    left[i] = p.Cards.Pop();
                    i++;
                }
                temp = this.Cards.Peek().value.CompareTo(p.Cards.Peek().value);
                i = 0;
                while (right.Length != 0 && left.Length != 0)
                {
                    this.Cards.Push(right[i]);
                    p.Cards.Push(left[i]);
                }
            }

            if (temp == 0)
            {
                return 1;
            }
            return temp;
        }
        #endregion
    }
}
