using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldTimeRail
{
    class Program
    {
        /// <summary>
        /// Old Time Rail Booking System.
        /// Created by SID: 1503126
        /// Program class to intiate new carriages and run Main Menu.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Initialise Saturday East AM Train
            SatEastAM.initialiseA();
            SatEastAM.initialiseB();
            SatEastAM.initialiseC();
            SatEastAM.initialiseD();

            //Initialise Saturday East PM Train
            SatEastPM.initialiseA();
            SatEastPM.initialiseB();
            SatEastPM.initialiseC();
            SatEastPM.initialiseD();

            //Initialise Saturday West AM Train
            SatWestAM.initialiseA();
            SatWestAM.initialiseB();
            SatWestAM.initialiseC();
            SatWestAM.initialiseD();

            //Initalise Saturday West PM Train
            SatWestPM.initialiseA();
            SatWestPM.initialiseB();
            SatWestPM.initialiseC();
            SatWestPM.initialiseD();

            //Initalise Sunday East AM Train
            SunEastAM.initialiseA();
            SunEastAM.initialiseB();
            SunEastAM.initialiseC();
            SunEastAM.initialiseD();

            //Initalise Sunday East PM Train
            SunEastPM.initialiseA();
            SunEastPM.initialiseB();
            SunEastPM.initialiseC();
            SunEastPM.initialiseD();

            //Initalise Sunday West AM Train
            SunWestAM.initialiseA();
            SunWestAM.initialiseB();
            SunWestAM.initialiseC();
            SunWestAM.initialiseD();

            //Initalise Sunday West PM Train
            SunWestPM.initialiseA();
            SunWestPM.initialiseB();
            SunWestPM.initialiseC();
            SunWestPM.initialiseD();

            //Test Bookings Without UI
            /* SatEastAM.bookCarriageA(5, "Thorbinson", 8);
             SatEastAM.bookCarriageB(4, "Lewis", 3);
             SatEastAM.bookCarriageC(7, "Harris", 8);
             SatEastAM.bookCarriageD(3, "Smith", 0);

             SatEastPM.bookCarriageA(4, "Styles", 2);
             SatEastPM.bookCarriageB(6, "Mouse", 6);
             SatEastPM.bookCarriageC(1, "Yankee", 0);
             SatEastPM.bookCarriageD(2, "Litt", 1);
            SatEastAM.bookCarriageA(8, "hi", 10);
            SatEastAM.bookCarriageA(8, "hi", 10);
            SatEastAM.bookCarriageA(8, "hi", 10);
            SatEastAM.bookCarriageA(8, "hi", 9);
            */

            //User Interface

            bool replay = true;
            while (replay == true)
            {
                string userInput;
                int userSelection;
                Console.WriteLine("_______________________________________________________________________");
                Console.WriteLine("");
                Console.WriteLine("             Welcome to the Old Time Rail Booking System               ");
                Console.WriteLine("_______________________________________________________________________");
                Console.WriteLine("");
                Console.WriteLine("             Please select an option from the list below.              ");
                Console.WriteLine("_______________________________________________________________________");
                Console.WriteLine("");
                Console.WriteLine("1) New booking");
                Console.WriteLine("2) Reports");
                Console.WriteLine("3) View timetable");
                Console.WriteLine("4) Help");
                Console.WriteLine("9) Exit");
                userInput = Console.ReadLine();
                userSelection = int.Parse(userInput);

                switch (userSelection)
                {
                    case 1:
                        Console.WriteLine("New Booking");
                        Booking Booking = new Booking();
                        break;
                    case 2:
                        Report Report = new Report();
                        Report.NewReport();
                        break;
                    case 3:
                        Console.WriteLine("Timetable");
                        Timetable Timetable = new Timetable();
                        Timetable.timetable();
                        break;
                    case 4:
                        Help help = new Help();
                        help.HelpMe();
                        break;
                    case 9:
                        Console.WriteLine("Exit");
                        replay = false;
                        break;

                }
                Console.ReadLine();
            }
        }
    }
}
