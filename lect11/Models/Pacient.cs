using lect11.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace lect11.Models
{
    internal class Pacient : User
    {
        public Pacient() : base()
        {

            
        }

        public Pacient(int id, string fullname, int age, string personid, string phonenumber) : base(id, fullname, age, personid, phonenumber)
        {
            
        }

        public void pacientinfo()
        {
            Console.WriteLine($"pacient id {Id} ; fullname {Fullname} ; person id {PersonId} ; phone number {Phonenumber} , age {Age}");
        }

        
    }
}
