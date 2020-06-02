using CSharpPropieties;
using System;
using System.Collections.Generic;
using System.Text;

namespace School
{
    public class School_
    {
        private List<Studients> studients;
        public School_()
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
            bool found = i < studients.Count;
            if (found)
                Console.WriteLine("Name: {0}\n" +
                    "Age: {1}\n" +
                    "Qualification: {2}",studients[i-1].Name, studients[i-1].Age, studients[i-1].Score);
            else Console.WriteLine($"Name {name} not found.\nPlease try again.");
            return !found;
        }
            
        
    }
}
