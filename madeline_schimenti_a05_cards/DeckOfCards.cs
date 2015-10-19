using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace madeline_schimenti_a05_cards
{
    public class DeckOfCards
    {

        PlayingCards.CardSuits[] faces = { PlayingCards.CardSuits.Club, PlayingCards.CardSuits.Diamond,
                                            PlayingCards.CardSuits.Heart, PlayingCards.CardSuits.Spade };

        PlayingCards.CardValues[] values = { PlayingCards.CardValues.Ace, PlayingCards.CardValues.Deuce,
                                            PlayingCards.CardValues.Eight, PlayingCards.CardValues.Five,
                                            PlayingCards.CardValues.Four, PlayingCards.CardValues.Jack,
                                            PlayingCards.CardValues.King, PlayingCards.CardValues.Nine,
                                            PlayingCards.CardValues.Queen, PlayingCards.CardValues.Seven,
                                            PlayingCards.CardValues.Six, PlayingCards.CardValues.Ten,
                                            PlayingCards.CardValues.Three };

        public PlayingCards.CardSuits[] Face
        {
            get { return faces; }
            set { faces = value; }
        }

        public PlayingCards.CardValues[] Values
        {
            get { return values; }
            set { values = value; }
        }

    }
}
        
    

