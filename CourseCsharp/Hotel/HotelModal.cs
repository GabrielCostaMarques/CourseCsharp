using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseCsharp.Hotel
{
    internal class HotelModal
    {
        private string Name { get; set; }
        private string Email { get; set; }
        private int Room {  get; set; }

        public HotelModal()
        {
        }
        public HotelModal(string name, string email, int room)
        {
            Name = name;
            Email = email;
            Room = room;
        }


        public override string ToString()
        {
            return Name + " " + Email; 
        }
    }
}
