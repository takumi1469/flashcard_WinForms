using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;/*
using System.Threading.Tasks;*/

namespace Takumi_Saito_Project
{
    //Class for meanings. A meaning has a translation.
    //This class may not be necessary at this point, but will be useful when the function to add example sentences is implemented.
    public class Meaning 
    {
        public string Translation { get; set; }
        public Meaning (string translation)
        {
            Translation = translation;
        }
    }
}
