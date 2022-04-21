namespace PKR
{
    internal class Deck
    {

        private List<Card> Cards;

        public string DeckList
        {
            get
            {
                string res = "";

                foreach (Card c in Cards)
                {
                    res += c.RankSymbol + ", ";
                }

                return res;
            }
        }

        public Deck()
        {
            // Initialize deck
            Cards = new List<Card>();
            foreach (Card.Suit s in (Card.Suit[])Enum.GetValues(typeof(Card.Suit)))
            {
                for (int i = 1; i <= 13; i++)
                {
                    Card c = new Card(i, s);

                    Cards.Add(c);
                }
            }

            // Shuffle deck
            Shuffle();
        }

        public void Shuffle()
        {
            Random random = new Random();

            int a, b;

            for (int i = 0; i < Cards.Count; i++)
            {
                a = random.Next(0, Cards.Count);
                b = random.Next(0, Cards.Count);

                Card aux = Cards[a];
                Cards[a] = Cards[b];
                Cards[b] = aux;
            }
        }

        public Card Draw()
        {
            Card c = Cards[Cards.Count - 1];
            Cards.Remove(c);

            return c;
        }

        public List<Card> Draw(int n)
        {
            List<Card> robadas = new List<Card>();

            for (int i = 0; i < n; i++)
            {
                Card c = Cards[Cards.Count - 1];
                robadas.Add(c);
                Cards.Remove(c);
            }

            return robadas;
        }

        public override string ToString()
        {
            return DeckList;
        }
    }
}
