namespace PKR
{
    public class Card
    {
        public enum Suit
        {
            Clubs = 1,
            Diamonds = 2,
            Hearts = 3,
            Spades = 4
        }

        public Dictionary<Suit, char> SuitChar = new Dictionary<Suit, char>
        {
            { Suit.Clubs, '♣' },
            { Suit.Diamonds, '♦' },
            { Suit.Hearts, '♥' },
            { Suit.Spades, '♠' },
        };

        public char Symbol { get { return SuitChar[CardSuit]; } }
        public string RankSymbol { get { return Rank(null) + Symbol; } }
        public string Top { get { return "╔═════╗"; } }
        public string NumTop { get { return $"║{Rank(false)}   ║"; } }
        public string Mid { get { return $"║  {Symbol}  ║"; } }
        public string NumBot { get { return $"║   {Rank(true)}║"; } }
        public string Bot { get { return "╚═════╝"; } }
        public string FullArt { get { return Top + Environment.NewLine + NumTop + Environment.NewLine + Mid + Environment.NewLine + NumBot + Environment.NewLine + Bot; } }

        public int CardRank { get; }
        public Suit CardSuit { get; }

        public Card Current => throw new NotImplementedException();

        public Card(int CardNumber, Suit CardSuit)
        {
            this.CardRank = Functions.Clamp(CardNumber, 1, 13);
            this.CardSuit = CardSuit;
        }

        public string Rank(bool? izq)
        {
            string res;

            switch (CardRank)
            {
                case 1:
                    res = "A";
                    break;
                case 10:
                    return "10";
                case 11:
                    res = "J";
                    break;
                case 12:
                    res = "Q";
                    break;
                case 13:
                    res = "K";
                    break;
                default:
                    res = CardRank.ToString();
                    break;
            }

            switch (izq)
            {
                case null: return res;
                case true: return " " + res;
                case false: return res + " ";
            }

        }

        public override string ToString()
        {
            return FullArt;
        }
    }
}
