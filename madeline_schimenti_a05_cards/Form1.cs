﻿using System;
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
        public Form1()
        {
            InitializeComponent();
        }


        

        private void button1_Click(object sender, EventArgs e)
        {
            DeckOfCards deckOfCards = new DeckOfCards();
            deckOfCards.Shuffle();
            for (int i = 0; i < 52; ++i)
            {

            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
