using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Takumi_Saito_Project
{
    public class Card //Class for cards. A card can have one word and multiple meanings
    {
        public string Word { get; set; }   
        public List<Meaning> Meanings { get; set; }

        public Card(string word)
        {
            Word = word;
            Meanings = new List<Meaning>();
        }
    }
}
