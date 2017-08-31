using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldTimeRail
{
    class Booking
    {
        /// <summary>
        /// Booking Class - Inputs Passenger information and calculates time and day of travel from user input.
        /// </summary>

        public Booking()
        {
            /////////////////////////////////////////////////////////////////
            //////                                                     //////
            //////              User enters details                    //////
            //////              Store them in variables                //////
            //////                                                     //////
            /////////////////////////////////////////////////////////////////

            //Customer Information Variables
            string customerName;
            int carriageClass = 0;
            int carriageType = 0;
            int startStop = 0;
            int endStop = 0;
            int day = 0;
            int time = 0;
            string inputPartySize;
            int partySize;
            string inputSuitcaseNo;
            int suitcaseNo = 0;

            //Switch Statment variables
            string userSelection = "";
            int userInput = 0;




            //Input Customer Name
            Console.Clear();
            Console.WriteLine("_______________________________________________________________________");
            Console.WriteLine("");
            Console.WriteLine("                Please enter the passenger name:                    ");
            customerName = Console.ReadLine();

            //Input Carriage Class
            Console.WriteLine("_______________________________________________________________________");
            Console.WriteLine("");
            Console.WriteLine("                Please choose Carriage Class                            ");
            Console.WriteLine("1) First Class");
            Console.WriteLine("2) Third Class");
            userSelection = Console.ReadLine();
            userInput = Int32.Parse(userSelection);

            switch (userSelection)
            {
                case "1":
                    carriageClass = 1;
                    break;
                case "2":
                    carriageClass = 3;
                    break;
                default:
                    Console.WriteLine("Please enter a correct number");
                    break;
            }

            //Input Carriage Type
            Console.WriteLine("_______________________________________________________________________");
            Console.WriteLine("");
            Console.WriteLine("                Please choose Carriage Type                            ");
            Console.WriteLine("1) Compartment Carriage");
            Console.WriteLine("2) Standard Carriage");
            userSelection = Console.ReadLine();
            userInput = Int32.Parse(userSelection);

            switch (userSelection)
            {
                case "1":
                    carriageType = 1;
                    break;
                case "2":
                    carriageType = 2;
                    break;
                default:
                    Console.WriteLine("Please enter a correct number");
                    break;
            }

            //Input Start Stop
            Console.WriteLine("_______________________________________________________________________");
            Console.WriteLine("");
            Console.WriteLine("                Please select the start station                        ");
            Console.WriteLine("1) Beggin Terminal");
            Console.WriteLine("2) Sudden Halt");
            Console.WriteLine("3) Muthly Pass");
            Console.WriteLine("4) Conn Junction");
            Console.WriteLine("5) Endline Station");
            userSelection = Console.ReadLine();
            userInput = Int32.Parse(userSelection);


            switch (userSelection)
            {
                case "1":
                    startStop = 1;
                    break;
                case "2":
                    startStop = 2;
                    break;
                case "3":
                    startStop = 3;
                    break;
                case "4":
                    startStop = 4;
                    break;
                case "5":
                    startStop = 5;
                    break;
                default:
                    Console.WriteLine("Please enter a correct Station");
                    break;
            }

            //Input End Stop
            Console.WriteLine("_______________________________________________________________________");
            Console.WriteLine("");
            Console.WriteLine("                Please select the destination station");
            Console.WriteLine("1) Beggin Terminal");
            Console.WriteLine("2) Sudden Halt");
            Console.WriteLine("3) Muthly Pass");
            Console.WriteLine("4) Conn Junction");
            Console.WriteLine("5) Endline Station");
            userSelection = Console.ReadLine();
            userInput = Int32.Parse(userSelection);


            if (userInput == startStop)
            {
                Console.WriteLine("_______________________________________________________________________");
                Console.WriteLine("");
                Console.WriteLine("                Please enter different stops for start and destination.");
                //Input End Stop
                Console.WriteLine("                Please select the Destination station                    ");
                Console.WriteLine("1) Beggin Terminal");
                Console.WriteLine("2) Sudden Halt");
                Console.WriteLine("3) Muthly Pass");
                Console.WriteLine("4) Conn Junction");
                Console.WriteLine("5) Endline Station");
                userSelection = Console.ReadLine();
                userInput = Int32.Parse(userSelection);
            }
            else {

                switch (userSelection)
                {

                    case "1":
                        endStop = 1;
                        break;
                    case "2":
                        endStop = 2;
                        break;
                    case "3":
                        endStop = 3;
                        break;
                    case "4":
                        endStop = 4;
                        break;
                    case "5":
                        endStop = 5;
                        break;
                    default:
                        Console.WriteLine("Please enter a correct Station");
                        break;
                }
            }

            //Day of Travel
            Console.WriteLine("_______________________________________________________________________");
            Console.WriteLine("");
            Console.WriteLine("                Which Day would you like to travel?                    ");
            Console.WriteLine("1) Saturday");
            Console.WriteLine("2) Sunday");
            userSelection = Console.ReadLine();
            userInput = Int32.Parse(userSelection);

            switch (userSelection)
            {
                case "1":
                    day = 1;
                    break;
                case "2":
                    day = 2;
                    break;
                default:
                    Console.WriteLine("Please enter a correct number");
                    break;
            }

            //Time of Travel
            Console.WriteLine("_______________________________________________________________________");
            Console.WriteLine("");
            Console.WriteLine("                What time would you like to travel?");
            Console.WriteLine("1) AM");
            Console.WriteLine("2) PM");
            userSelection = Console.ReadLine();
            userInput = Int32.Parse(userSelection);

            switch (userSelection)
            {
                case "1":
                    time = 1;
                    break;
                case "2":
                    time = 2;
                    break;
                default:
                    Console.WriteLine("Please enter a correct number");
                    break;
            }

            //Input Party Size
            Console.WriteLine("_______________________________________________________________________");
            Console.WriteLine("");
            Console.WriteLine("                How many passengers will be travelling?");
            inputPartySize = Console.ReadLine();
            partySize = Int32.Parse(inputPartySize);

            //Baggage
            Console.WriteLine("_______________________________________________________________________");
            Console.WriteLine("");
            Console.WriteLine("                Would you like to add any bags?");
            Console.WriteLine("1) Yes");
            Console.WriteLine("2) No");
            userSelection = Console.ReadLine();
            userInput = Int32.Parse(userSelection);

            switch (userSelection)
            {
                case "1":
                    Console.WriteLine("Please enter how many bags you would like to add");
                    inputSuitcaseNo = Console.ReadLine();
                    suitcaseNo = Int32.Parse(inputSuitcaseNo);
                    break;
                case "2":
                    suitcaseNo = 0;
                    break;
                default:
                    break;
            }


            /////////////////////////////////////////////////////////////////
            //////                                                     //////
            //////              Create a new journey to calc direction //////
            //////              If statements  to calc carriage        //////
            //////                                                     //////
            /////////////////////////////////////////////////////////////////

            Journey journey = new Journey(startStop, endStop);
            //Now have all of the customer information need to work out what train they want

            //Saturday AM East
            if (day == 1 && time == 1 && journey.calculateDirection() == "east")
            {
                if (carriageClass == 1)
                {
                    SatEastAM.bookCarriageA(partySize, customerName, suitcaseNo);
                }
                else if (carriageClass == 3 && carriageType == 1)
                {
                    SatEastAM.bookCarriageB(partySize, customerName, suitcaseNo);
                }
                else if (carriageClass == 3 && carriageType == 2)
                {
                    SatEastAM.bookCarriageC(partySize, customerName, suitcaseNo);
                }
                else
                {
                    Console.WriteLine("You have entered incorrect details.");
                }

            }


            //Saturday AM West
            else if (day == 1 && time == 1 && journey.calculateDirection() == "west")
            {
                if (carriageClass == 1)
                {
                    SatWestAM.bookCarriageA(partySize, customerName, suitcaseNo);
                }
                else if (carriageClass == 3 && carriageType == 1)
                {
                    SatWestAM.bookCarriageB(partySize, customerName, suitcaseNo);
                }
                else if (carriageClass == 3 && carriageType == 2)
                {
                    SatWestAM.bookCarriageC(partySize, customerName, suitcaseNo);
                }
                else
                {
                    Console.WriteLine("You have entered incorrect details.");
                }
            }
            //Saturday PM East
            else if (day == 1 && time == 2 && journey.calculateDirection() == "east")
            {
                if (carriageClass == 1)
                {
                    SatEastPM.bookCarriageA(partySize, customerName, suitcaseNo);
                }

                else if (carriageClass == 3 && carriageType == 1)
                {
                    SatEastPM.bookCarriageB(partySize, customerName, suitcaseNo);
                }
                else if (carriageClass == 3 && carriageType == 2)
                {
                    SatEastPM.bookCarriageC(partySize, customerName, suitcaseNo);
                }
                else
                {
                    Console.WriteLine("You have entered incorrect details.");
                }
            }

            //Saturday PM West
            else if (day == 1 && time == 2 && journey.calculateDirection() == "west")
            {
                if (carriageClass == 1)
                {
                    SatWestPM.bookCarriageA(partySize, customerName, suitcaseNo);
                }
                else if (carriageClass == 3 && carriageType == 1)
                {
                    SatWestPM.bookCarriageB(partySize, customerName, suitcaseNo);
                }
                else if (carriageClass == 3 && carriageType == 2)
                {
                    SatWestPM.bookCarriageC(partySize, customerName, suitcaseNo);
                }
                else
                {
                    Console.WriteLine("You have entered incorrect details.");
                }

            }

            //Sunday AM East
            else if (day == 2 && time == 1 && journey.calculateDirection() == "east")
            {
                if (carriageClass == 1)
                {
                    SunEastAM.bookCarriageA(partySize, customerName, suitcaseNo);
                }
                else if (carriageClass == 3 && carriageType == 1)
                {
                    SunEastAM.bookCarriageB(partySize, customerName, suitcaseNo);
                }
                else if (carriageClass == 3 && carriageType == 2)
                {
                    SunEastAM.bookCarriageC(partySize, customerName, suitcaseNo);
                }
                else
                {
                    Console.WriteLine("You have selected incorrect details.");
                }

            }

            //Sunday AM West
            else if (day == 2 && time == 1 && journey.calculateDirection() == "west")
            {
                if (carriageClass == 1)
                {
                    SunWestAM.bookCarriageA(partySize, customerName, suitcaseNo);
                }
                else if (carriageClass == 3 && carriageType == 1)
                {
                    SunWestAM.bookCarriageB(partySize, customerName, suitcaseNo);
                }

                else if (carriageClass == 3 && carriageType == 2)
                {
                    SunWestAM.bookCarriageC(partySize, customerName, suitcaseNo);
                }
                else
                {
                    Console.WriteLine("You have selected incorrect details.");
                }
            }

            //Sunday PM East
            else if (day == 2 && time == 2 && journey.calculateDirection() == "east")
            {
                if (carriageClass == 1)
                {
                    SunEastPM.bookCarriageA(partySize, customerName, suitcaseNo);
                }
                else if (carriageClass == 3 && carriageType == 1)
                {
                    SunEastPM.bookCarriageB(partySize, customerName, suitcaseNo);
                }
                else if (carriageClass == 3 && carriageType == 2)
                {
                    SunEastPM.bookCarriageC(partySize, customerName, suitcaseNo);
                }
                else
                {
                    Console.WriteLine("You have selected incorrect details.");
                }
            }

            //Sunday PM West
            else if (day == 2 && time == 2 && journey.calculateDirection() == "west")
            {
                if (carriageClass == 1)
                {
                    SunWestPM.bookCarriageC(partySize, customerName, suitcaseNo);
                }
                else if (carriageClass == 3 && carriageType == 1)
                {
                    SunWestPM.bookCarriageB(partySize, customerName, suitcaseNo);
                }
                else if (carriageClass == 3 && carriageType == 2)
                {
                    SunWestPM.bookCarriageC(partySize, customerName, suitcaseNo);
                }
                else
                {
                    Console.WriteLine("You have entered incorrect details. Please try again.");
                }

            }
        }
    }
}
