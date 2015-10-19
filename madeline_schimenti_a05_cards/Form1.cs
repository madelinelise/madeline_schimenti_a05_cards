using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace madeline_schimenti_a05_cards
{
    public partial class Form1 : Form
    {



        public Random randomNumbers;
        int currentCard = 0;
        const int NUMBER_OF_CARDS = 52;

        public Form1()
        {
            InitializeComponent();
        }


        

        private void buttonShuffle_Click(object sender, EventArgs e)
        {
            Shuffle2();

            

        }

        public void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public void buttonDeal_Click(object sender, EventArgs e)
        {
            
            PlayingCards.Deck theDeck = new PlayingCards.Deck();
            DeckOfCards deckOfCards = new DeckOfCards();
            
            CreateDeck();
            
        }

        public void CreateDeck()
        {
            PlayingCards.Deck theDeck = new PlayingCards.Deck();
            DeckOfCards deckOfCards = new DeckOfCards();



            PlayingCards.Card CA = new PlayingCards.Card(deckOfCards.Face[0], deckOfCards.Values[0]);
            PlayingCards.Card C2 = new PlayingCards.Card(deckOfCards.Face[0], deckOfCards.Values[1]);
            PlayingCards.Card C8 = new PlayingCards.Card(deckOfCards.Face[0], deckOfCards.Values[2]);
            PlayingCards.Card C5 = new PlayingCards.Card(deckOfCards.Face[0], deckOfCards.Values[3]);
            PlayingCards.Card C4 = new PlayingCards.Card(deckOfCards.Face[0], deckOfCards.Values[4]);
            PlayingCards.Card CJ = new PlayingCards.Card(deckOfCards.Face[0], deckOfCards.Values[5]);
            PlayingCards.Card CK = new PlayingCards.Card(deckOfCards.Face[0], deckOfCards.Values[6]);
            PlayingCards.Card C9 = new PlayingCards.Card(deckOfCards.Face[0], deckOfCards.Values[7]);
            PlayingCards.Card CQ = new PlayingCards.Card(deckOfCards.Face[0], deckOfCards.Values[8]);
            PlayingCards.Card C7 = new PlayingCards.Card(deckOfCards.Face[0], deckOfCards.Values[9]);
            PlayingCards.Card C6 = new PlayingCards.Card(deckOfCards.Face[0], deckOfCards.Values[10]);
            PlayingCards.Card C10 = new PlayingCards.Card(deckOfCards.Face[0], deckOfCards.Values[11]);
            PlayingCards.Card C3 = new PlayingCards.Card(deckOfCards.Face[0], deckOfCards.Values[12]);

            PlayingCards.Card DA = new PlayingCards.Card(deckOfCards.Face[0], deckOfCards.Values[0]);
            PlayingCards.Card D2 = new PlayingCards.Card(deckOfCards.Face[0], deckOfCards.Values[1]);
            PlayingCards.Card D8 = new PlayingCards.Card(deckOfCards.Face[0], deckOfCards.Values[2]);
            PlayingCards.Card D5 = new PlayingCards.Card(deckOfCards.Face[0], deckOfCards.Values[3]);
            PlayingCards.Card D4 = new PlayingCards.Card(deckOfCards.Face[0], deckOfCards.Values[4]);
            PlayingCards.Card DJ = new PlayingCards.Card(deckOfCards.Face[0], deckOfCards.Values[5]);
            PlayingCards.Card DK = new PlayingCards.Card(deckOfCards.Face[0], deckOfCards.Values[6]);
            PlayingCards.Card D9 = new PlayingCards.Card(deckOfCards.Face[0], deckOfCards.Values[7]);
            PlayingCards.Card DQ = new PlayingCards.Card(deckOfCards.Face[0], deckOfCards.Values[8]);
            PlayingCards.Card D7 = new PlayingCards.Card(deckOfCards.Face[0], deckOfCards.Values[9]);
            PlayingCards.Card D6 = new PlayingCards.Card(deckOfCards.Face[0], deckOfCards.Values[10]);
            PlayingCards.Card D10 = new PlayingCards.Card(deckOfCards.Face[0], deckOfCards.Values[11]);
            PlayingCards.Card D3 = new PlayingCards.Card(deckOfCards.Face[0], deckOfCards.Values[12]);

            PlayingCards.Card HA = new PlayingCards.Card(deckOfCards.Face[0], deckOfCards.Values[0]);
            PlayingCards.Card H2 = new PlayingCards.Card(deckOfCards.Face[0], deckOfCards.Values[1]);
            PlayingCards.Card H8 = new PlayingCards.Card(deckOfCards.Face[0], deckOfCards.Values[2]);
            PlayingCards.Card H5 = new PlayingCards.Card(deckOfCards.Face[0], deckOfCards.Values[3]);
            PlayingCards.Card H4 = new PlayingCards.Card(deckOfCards.Face[0], deckOfCards.Values[4]);
            PlayingCards.Card HJ = new PlayingCards.Card(deckOfCards.Face[0], deckOfCards.Values[5]);
            PlayingCards.Card HK = new PlayingCards.Card(deckOfCards.Face[0], deckOfCards.Values[6]);
            PlayingCards.Card H9 = new PlayingCards.Card(deckOfCards.Face[0], deckOfCards.Values[7]);
            PlayingCards.Card HQ = new PlayingCards.Card(deckOfCards.Face[0], deckOfCards.Values[8]);
            PlayingCards.Card H7 = new PlayingCards.Card(deckOfCards.Face[0], deckOfCards.Values[9]);
            PlayingCards.Card H6 = new PlayingCards.Card(deckOfCards.Face[0], deckOfCards.Values[10]);
            PlayingCards.Card H10 = new PlayingCards.Card(deckOfCards.Face[0], deckOfCards.Values[11]);
            PlayingCards.Card H3 = new PlayingCards.Card(deckOfCards.Face[0], deckOfCards.Values[12]);


            PlayingCards.Card SA = new PlayingCards.Card(deckOfCards.Face[0], deckOfCards.Values[0]);
            PlayingCards.Card S2 = new PlayingCards.Card(deckOfCards.Face[0], deckOfCards.Values[1]);
            PlayingCards.Card S8 = new PlayingCards.Card(deckOfCards.Face[0], deckOfCards.Values[2]);
            PlayingCards.Card S5 = new PlayingCards.Card(deckOfCards.Face[0], deckOfCards.Values[3]);
            PlayingCards.Card S4 = new PlayingCards.Card(deckOfCards.Face[0], deckOfCards.Values[4]);
            PlayingCards.Card SJ = new PlayingCards.Card(deckOfCards.Face[0], deckOfCards.Values[5]);
            PlayingCards.Card SK = new PlayingCards.Card(deckOfCards.Face[0], deckOfCards.Values[6]);
            PlayingCards.Card S9 = new PlayingCards.Card(deckOfCards.Face[0], deckOfCards.Values[7]);
            PlayingCards.Card SQ = new PlayingCards.Card(deckOfCards.Face[0], deckOfCards.Values[8]);
            PlayingCards.Card S7 = new PlayingCards.Card(deckOfCards.Face[0], deckOfCards.Values[9]);
            PlayingCards.Card S6 = new PlayingCards.Card(deckOfCards.Face[0], deckOfCards.Values[10]);
            PlayingCards.Card S10 = new PlayingCards.Card(deckOfCards.Face[0], deckOfCards.Values[11]);
            PlayingCards.Card S3 = new PlayingCards.Card(deckOfCards.Face[0], deckOfCards.Values[12]);


            theDeck.Cards.Add(CA);
            theDeck.Cards.Add(C2);
            theDeck.Cards.Add(C8);
            theDeck.Cards.Add(C5);
            theDeck.Cards.Add(C4);
            theDeck.Cards.Add(CJ);
            theDeck.Cards.Add(CK);
            theDeck.Cards.Add(C9);
            theDeck.Cards.Add(CQ);
            theDeck.Cards.Add(C7);
            theDeck.Cards.Add(C6);
            theDeck.Cards.Add(C10);
            theDeck.Cards.Add(C3);

            theDeck.Cards.Add(DA);
            theDeck.Cards.Add(D2);
            theDeck.Cards.Add(D8);
            theDeck.Cards.Add(D5);
            theDeck.Cards.Add(D4);
            theDeck.Cards.Add(DJ);
            theDeck.Cards.Add(DK);
            theDeck.Cards.Add(D9);
            theDeck.Cards.Add(DQ);
            theDeck.Cards.Add(D7);
            theDeck.Cards.Add(D6);
            theDeck.Cards.Add(D10);
            theDeck.Cards.Add(D3);

            theDeck.Cards.Add(HA);
            theDeck.Cards.Add(H2);
            theDeck.Cards.Add(H8);
            theDeck.Cards.Add(H5);
            theDeck.Cards.Add(H4);
            theDeck.Cards.Add(HJ);
            theDeck.Cards.Add(HK);
            theDeck.Cards.Add(H9);
            theDeck.Cards.Add(HQ);
            theDeck.Cards.Add(H7);
            theDeck.Cards.Add(H6);
            theDeck.Cards.Add(H10);
            theDeck.Cards.Add(H3);

            theDeck.Cards.Add(SA);
            theDeck.Cards.Add(S2);
            theDeck.Cards.Add(S8);
            theDeck.Cards.Add(S5);
            theDeck.Cards.Add(S4);
            theDeck.Cards.Add(SJ);
            theDeck.Cards.Add(SK);
            theDeck.Cards.Add(S9);
            theDeck.Cards.Add(SQ);
            theDeck.Cards.Add(S7);
            theDeck.Cards.Add(S6);
            theDeck.Cards.Add(S10);
            theDeck.Cards.Add(S3);

            PictureBox[] cardimg = new PictureBox[52];

            for (var i = 0; i < cardimg.Length; i++)
            {
                PictureBox maincardImg = new PictureBox();
                maincardImg.SizeMode = PictureBoxSizeMode.AutoSize;
                maincardImg.Image = theDeck.Cards[i].FaceImage;
                cardimg[i] = maincardImg;
                maincardImg.Parent = this;
                maincardImg.Visible = true;
                maincardImg.Left = 50 + (i * 20);
                maincardImg.Top = 78;
                maincardImg.BringToFront();

            }
        }


        public void Shuffle()
        {

            PlayingCards.Deck theDeck = new PlayingCards.Deck();

            randomNumbers = new Random();

            for (int i = 0; i < theDeck.Cards.Count; i++)
            {
                int second = randomNumbers.Next(NUMBER_OF_CARDS);
                PlayingCards.Card
                    temp = theDeck.Cards[i];
                theDeck.Cards[i] = theDeck.Cards[second];
                theDeck.Cards[second] = temp;
            }
        }

        public void Shuffle2()
        {
            
            PlayingCards.Deck theDeck = new PlayingCards.Deck();
            randomNumbers = new Random();

            
            for (int firstNum = 0; firstNum > theDeck.Cards.Count; ++firstNum)
            {
                
                int secondNum = randomNumbers.Next(52);
                PlayingCards.Card tempCard = theDeck.Cards[firstNum];
                theDeck.Cards[firstNum] = theDeck.Cards[secondNum];
                theDeck.Cards[secondNum] = tempCard;
            }

        } // end method Shuffle



    }
}

