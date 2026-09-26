using System;
using System.Collections.Generic;
using System.Text;

namespace lect11.Models
{
    internal class User
    {
        public int Id { get; set; }
        public string Fullname { get; set; }
        public int Age { get; set; }
        public string PersonId {  get; set; }
        public string Phonenumber { get; set; }


        public User()
        {
            
        }
        public User(int id, string fullname, int age , string personid ,string phonenumber)
        {
            Id = id;
            Fullname = fullname;
            Age = age;
            PersonId = personid;
            Phonenumber = phonenumber;

        }

        public void Getuser()
        {
            Console.WriteLine($"fullname: {Fullname}, age : {Age}, phone number: {Phonenumber}");
        }
    }
}
