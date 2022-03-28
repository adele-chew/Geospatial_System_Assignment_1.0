using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT365_Assignment1
{
    /// <summary>
    /// Dictionary to store people
    /// </summary>
    class PeopleDictionary
    {
        Dictionary<string, People> dict = new Dictionary<string, People>();             //new dict

        public PeopleDictionary()
        {
            //add values
            dict.Add("Person 1", new People("John", "Lee", "Son", "Blk 304 Serangoon Ave 2, Singapore 550304", "9481 3142", "..\\..\\people\\son.png"));
            dict.Add("Person 2", new People("Jacintha", "Lee", "Daughter", "Blk 141 Potong Pasir Ave 3, Singapore 350141", "9481 4373", "..\\..\\people\\daughter.png"));
            dict.Add("Person 3", new People("Roy", "Tan", "Doctor", "Blk 263 Serangoon Central Drive, #01-59, 550263", "6487 6583", "..\\..\\people\\doctor.png"));
        }

        public Dictionary<string, People> GetDict()                                     //getter for peoples dict
        {
            return dict; 
        }

        /// add event into the dictionary 
        public void addPeople(int i, string firstName, string lastName, string relationship, string address, string contact, string photopath)
        {
            dict.Add("Person " + i.ToString(), new People(firstName, lastName, relationship, address, contact, photopath));
        }
    }
}
