using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnExceptiosn
{
    //user-defined Exception
    class TicketBookingExcetion:Exception
    {
        public TicketBookingExcetion(string msg):base(msg)
        {
            
        }
        public TicketBookingExcetion() : base("Sorry!! you can not book more than 3 ticket")
        {

        }
    }
}
