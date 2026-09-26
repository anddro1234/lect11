using System;
using System.Collections.Generic;
using System.Text;

namespace lect11.Models
{
    internal class Room
    {
        public int Id { get; set; }
        public int equipment {  get; set; }
        public bool isdakavebuli{  get; set; }
        public string nurceroom {  get; set; }
        public Room()
        {
            
        }

        public Room(int id, int equipment , bool isdakavebuli, string nurceroom)
        {
            this.Id = id;
            this.equipment = equipment;
            this.isdakavebuli = isdakavebuli;
            this.nurceroom = nurceroom;
            
        }
    }
}
