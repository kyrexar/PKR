namespace PKR
{
    public class Hand
    {
        const int MAX_HAND_SIZE = 5;
        public bool IsNotFull { get { return Cards.Count < MAX_HAND_SIZE; } }
        public int Size { get { return Cards.Count; } }

        private List<Card> Cards;

        public Hand()
        {
            this.Cards = new List<Card>();
        }

        public void Add(Card c)
        {
            if (Cards.Count < MAX_HAND_SIZE && !this.Contains(c))
            {
                Cards.Add(c);
            }
        }

        public bool Contains(Card c)
        {
            foreach (Card card in Cards)
            {
                if (c.CardRank == card.CardRank && c.CardSuit == card.CardSuit)
                {
                    return true;
                }
            }

            return false;
        }

        public void Remove(Card c)
        {
            for (int i = 0; i < Cards.Count; i++)
            {
                Card card = Cards[i];

                if (c.CardRank == card.CardRank && c.CardSuit == card.CardSuit)
                {
                    Cards.RemoveAt(i);
                }
            }
        }

        public void Clear()
        {
            Cards.Clear();
        }

        public string FullArt
        {
            get
            {
                string res = "";

                foreach (Card c in Cards) res += c.Top;
                res += Environment.NewLine;
                foreach (Card c in Cards) res += c.NumTop;
                res += Environment.NewLine;
                foreach (Card c in Cards) res += c.Mid;
                res += Environment.NewLine;
                foreach (Card c in Cards) res += c.NumBot;
                res += Environment.NewLine;
                foreach (Card c in Cards) res += c.Bot;

                return res;
            }
        }

        public override string ToString()
        {
            return FullArt;
        }
    }
}
