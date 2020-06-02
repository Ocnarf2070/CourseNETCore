using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPropieties
{
    public class Studients
    {
        //Part 1
        //public String name { get; set; } = "Jesus";
        private String nameaux;
        public String name
        {
            //set { nameaux = value; }
            //Part 2
            //get { return nameaux; }

            get => nameaux;
            set => nameaux = value;
        }
    }
}
