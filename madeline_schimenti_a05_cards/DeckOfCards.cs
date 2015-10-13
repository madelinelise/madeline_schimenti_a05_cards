using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace madeline_schimenti_a05_cards
{
    public class DeckOfCards
    {
        private PlayingCards[] deck;
        private int currentCard;
        private const int NUM_CARDS = 52;
        private Random randomNumbers;

        public DeckOfCards()
        {
         PlayingCards.CardSuits[] faces = { PlayingCards.CardSuits.Club, PlayingCards.CardSuits.Diamond,
                                            PlayingCards.CardSuits.Heart, PlayingCards.CardSuits.Spade };

         PlayingCards.CardValues[] value = { PlayingCards.CardValues.Ace, PlayingCards.CardValues.Deuce,
                                            PlayingCards.CardValues.Eight, PlayingCards.CardValues.Five,
                                            PlayingCards.CardValues.Four, PlayingCards.CardValues.Jack,
                                            PlayingCards.CardValues.King, PlayingCards.CardValues.Nine,
                                            PlayingCards.CardValues.Queen, PlayingCards.CardValues.Seven,
                                            PlayingCards.CardValues.Six, PlayingCards.CardValues.Ten,
                                            PlayingCards.CardValues.Three };
         }

    }
}
