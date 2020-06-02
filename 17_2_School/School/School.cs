using CSharpPropieties;
using System;
using System.Collections.Generic;
using System.Text;

namespace School
{
    public class School
    {
        private List<Studients> studients;
        public School()
        {
            studients = new List<Studients>();
        }

        public void addStudient(Studients newStudient)
        {
            studients.Add(newStudient);
        }
        public bool searchStudient(String name)
        {
            int i = 0;
            while (i < studients.Count && !studients[i].Name.Equals(name)) i++;
            return i < studients.Count;
        }
            
        
    }
}
