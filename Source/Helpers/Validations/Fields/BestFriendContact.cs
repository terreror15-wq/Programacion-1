using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactProyect.Helpers.Validations.Fields
{
    public class BestFriendContact
    {
        public static bool FieldBestFriend()
        {
            bool BestFriend;
            while (true)
            {
                Console.WriteLine("is this your best friend (yes/no");
                string input = Console.ReadLine()!.ToLower().Trim();

                if (input == "yes")
                {
                    BestFriend = true;
                    break;
                }
                else if (input == "no")
                {
                    BestFriend = false;
                    break;

                }
                else
                {
                    Console.WriteLine("please write yes or no");
                }
            }

            return BestFriend;
        }
    }
}