using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    class Card: IEquatable<Card>
    {
        public CardTypes type;
        public CardValues value;
        /// <summary>
        /// Переопределение Equals из IEquatable
        /// </summary>
        /// <param name="other">Объект, который требуется сравнить с данным объектом.</param>
        /// <returns>true, если текущий объект равен параметру other, в противном случае — false.</returns>
        public bool Equals(Card other)
        {
            if (this.type == other.type && this.value == other.value) { return true; }
            else return false;
        }
    }
}
