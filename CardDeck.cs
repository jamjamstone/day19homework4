using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day19homework4
{
    internal class CardDeck
    {
        Random random = new Random();
        Stack<Card> _unusedCards;
        Stack<Card> _usedCards;
        List<Card> _cards;
        public CardDeck()
        {
            Card oldCard;
            int cardNum = 0;
            int oldCardNum1 = 0;
            int oldCardNum2 = 0;
            _unusedCards = new Stack<Card>();
            _usedCards = new Stack<Card>();
            _cards = new List<Card>();
            for(int i = 0; i < 4; i++)
            {
                for(int j = 1; j < 14; j++)
                {
                    
                    _cards.Add(new Card());
                    _cards[cardNum].CardNumber = j;// 인데스
                    switch (i)
                    {
                        case 0:
                            _cards[cardNum].Shape = Shape.Spade;
                            break;
                        case 1:
                            _cards[cardNum].Shape = Shape.Heart;
                            break;
                        case 2:
                            _cards[cardNum].Shape = Shape.Clover;
                            break;
                        case 3:
                            _cards[cardNum].Shape = Shape.Diamond;
                            break;
                        default:
                            break;
                    }
                    cardNum++;
                }
            }
            //랜덤으로 섞기
            while (random.Next(1, 101) <= 70)
            {
                oldCardNum1 = random.Next(0, 4 * 13);
                oldCardNum2 = random.Next(0, 4 * 13);
                oldCard = _cards[oldCardNum1];
                _cards[oldCardNum1]=_cards[oldCardNum2];
                _cards[oldCardNum2] = oldCard;
            }
            //리스트에 랜덤끝
            for(int i = 0; i < 4 * 13; i++)
            {
                _unusedCards.Push(_cards[i]);
            }


        }

        public void ShowTopCard()
        {
            Console.WriteLine( _unusedCards?.Peek().CardNumber);
            Console.WriteLine( _unusedCards?.Peek().Shape);
        }
        public void DrawCard()
        {
            _usedCards.Push(_unusedCards?.Pop());
        }




    }//end
}
