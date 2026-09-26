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
    }
}
