namespace PKR
{
    internal class Game
    {
        public Deck deck;
        public Hand hand;

        public Game()
        {
            deck = new Deck();
            hand = new Hand();
        }

        public void Start()
        {
            ConsoleKey key = ConsoleKey.Spacebar;

            while (key != ConsoleKey.Escape)
            {
                while (hand.IsNotFull)
                {
                    Card card = deck.Draw();
                    hand.Add(card);
                }

                Console.Clear();
                Console.WriteLine(hand);
                Console.WriteLine(deck);

                key = Console.ReadKey().Key;

                hand.Clear();
                deck = new Deck();
            }
        }
    }
}
