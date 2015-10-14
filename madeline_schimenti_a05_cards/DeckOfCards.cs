using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace madeline_schimenti_a05_cards
{
    public class DeckOfCards
    {

        private PlayingCards.Card[] deck;
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

            deck = new PlayingCards.Card[NUM_CARDS];

            currentCard = 0;
            randomNumbers = new Random();

            for (int count = 0; count < 52; ++count)
                deck[count] = new PlayingCards.Card(faces[count/13], value[count%13]);


        } // end constructor

        public void Shuffle()
        {
            currentCard = 0;

            for (int index = 0; index < deck.Length; ++index)
            {
                int index_Next = randomNumbers.Next(NUM_CARDS);


                PlayingCards.Card temp = deck[index];
                deck[index] = deck[index_Next];
                deck[index_Next] = temp;
            }

        } // end shuffle method

        public PlayingCards.Card DealCard()
        {
            
           if ( currentCard < deck.Length )
                return deck[currentCard++]; 
            else
                return null; 
        }
    }
}
