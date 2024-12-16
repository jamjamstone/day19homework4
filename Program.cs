namespace day19homework4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CardDeck cardDeck = new CardDeck();
            for(int i = 0; i < 4 * 13; i++)
            {
                Console.WriteLine($"{i+1}번 카드");
                cardDeck.ShowTopCard();

                cardDeck.DrawCard();

            }
        }
    }
}
