using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactProyect.Helpers.Validations.Messages
{
    public class BestFriendMessage
    {
        public static string isBestFriendstrd(bool yesBestFriend)
        {
            if (yesBestFriend == true)
            {
                return "yes";
            }
            else
            {
                return "No";
            }
        }
    }
}