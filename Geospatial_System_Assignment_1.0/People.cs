using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT365_Assignment1
{
    class People
    {
        /// <summary>
        /// class for people variables
        /// </summary>
        private string firstName, lastName, relationship, address, contact, photopath; 

        public People() { }     //default constructor

        //constructor with parameters
        public People(string firstName, string lastName, string relationship, string address, string contact, string photopath)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.relationship = relationship;
            this.address = address;
            this.contact = contact;
            this.photopath = photopath; 
        }
        
        //getter/setter for first name
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }

        //getter/setter for last name
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }

        //getter/setter for relationship 
        public string Relationship
        {
            get
            {
                return relationship;
            }
            set
            {
                relationship = value;
            }
        }

        //getter/setter for address
        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }

        //getter/setter for contact number
        public string Contact
        {
            get
            {
                return contact;
            }
            set
            {
                contact = value;
            }
        }
        
        //getter/setter for photo filepath
        public string Photopath
        {
            get
            {
                return photopath;
            }
            set
            {
                photopath = value; 
            }
        }
    }
}
