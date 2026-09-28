using System;
using System.Collections.Generic;
using System.Text;

namespace lect11.Models
{
    internal class Room
    {
        public int Id { get; set; }
        public string equipment {  get; set; }
        public bool isdakavebuli{  get; set; }
        public string nurceroom {  get; set; }
        
        
        public string GetRoom()
        {
            return $"equipment: {equipment}, isdakavebuli: {isdakavebuli}, nurceroom: {nurceroom}";
        }


        public Room()
        {
            
        }

        public Room(string equipment , bool isdakavebuli, string nurceroom)
        {
         
            this.equipment = equipment;
            this.isdakavebuli = isdakavebuli;
            this.nurceroom = nurceroom;
            
        }
    }
}
