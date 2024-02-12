using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Takumi_Saito_Project
{
    public class Deck //Class for decks of cards. A deck has a name and a list of cards.
    {
        public string Name { get; set; }
        public List<Card> Cards { get; set; }

        public Deck(string name)
        {
            Name = name;
            Cards = new List<Card>();
        }
        public void Shuffle()
        {
            // Seed the Random class with a unique value, usually based on time
            Random random = new Random(DateTime.Now.Millisecond);

            // Use Fisher-Yates shuffle algorithm to shuffle the list (written with help of ChatGPT)
            int n = this.Cards.Count();
            for (int i = n - 1; i > 0; i--)
            {
                int j = random.Next(0, i + 1);
                Swap<Card>(this.Cards, i, j);
            }

            static void Swap<Card>(List<Card> list, int index1, int index2)
            {
                Card temp = list[index1];
                list[index1] = list[index2];
                list[index2] = temp;
            }
        }
    }
}
