using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldTimeRail
{
    class Help
    {
        /// <summary>
        /// Help File Class. 
        /// </summary>
        public void HelpMe()
        {
            Console.Clear();
            Console.WriteLine("_______________________________________________________________________");
            Console.WriteLine("");
            Console.WriteLine("             Welcome to the Old Time Rail Booking System               ");
            Console.WriteLine("_______________________________________________________________________");
            Console.WriteLine("");
            Console.WriteLine("                               Help Section!                           ");
            Console.WriteLine("_______________________________________________________________________");
            Console.WriteLine("");
            Console.WriteLine("Booking Questions");
            Console.WriteLine("");
            Console.WriteLine("How do i create a new booking?");
            Console.WriteLine("");
            Console.WriteLine("To book a passenger onto a new train press option 1 on the Main Menu, then follow the on screen instructions. ");
            Console.WriteLine("");
            Console.WriteLine("Is there a maximum number of passengers i can book at once?");
            Console.WriteLine("");
            Console.WriteLine("Yes! You can only book a maximum of 8 passengers onto a Compartment car and a maximum of 10 on a standard car.");
            Console.WriteLine("");
            Console.WriteLine("Will passengers be grouped together?");
            Console.WriteLine("");
            Console.WriteLine("Depending on the party size the system will ensure that when possible passengers will be grouped together.");
            Console.WriteLine("");
            Console.WriteLine("Why cant i book passengers onto Carriage D?");
            Console.WriteLine("");
            Console.WriteLine("The system will automatically book passengers onto Carriage C and group them together, Once Carriage C is full it will \nstart booking passengers onto Carriage D");
            Console.WriteLine("");
            Console.WriteLine("Report Questions");
            Console.WriteLine("");
            Console.WriteLine("To have access to the reports section select option 4 from the Main Menu");
            Console.WriteLine("");
            Console.WriteLine("");

        }
    }
}
