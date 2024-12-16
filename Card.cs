using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day19homework4
{
    enum Shape
    {
        Spade,Heart,Clover,Diamond
    }
    internal class Card
    {
        Shape _shapes;
        int _cardNumber;//a=1,j=11,q=12,k=13
        public int CardNumber { get { return _cardNumber; } set { _cardNumber = value; } }
        public Shape Shape { get { return _shapes; } set { _shapes = value; } }
    }
}
