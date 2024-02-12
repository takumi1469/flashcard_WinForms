using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Takumi_Saito_Project
{
    public class Subject //Class for subjects. A subject has a name, and a list of decks
    {
        public string Name { get; set; }
        public List<Deck> Decks { get; set; }

        public Subject(string name) 
        {
            Name = name;
            Decks = new List<Deck>();
        }

    }
}
