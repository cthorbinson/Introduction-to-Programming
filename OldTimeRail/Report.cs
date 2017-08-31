using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OldTimeRail
{
    class Report
    {
        /// <summary>
        /// Displays and Runs the reports. Files write to the root of the Program. (OldTimeRail\OldTimeRail\bin\Debug)
        /// </summary>
        public void NewReport()
        {
            string userSelection = "";
            int userInput = 0;

            Console.WriteLine("Please select the train you would like to print a report for.");
            Console.WriteLine("1) Saturday AM East Train");
            Console.WriteLine("2) Saturday PM East Train");
            Console.WriteLine("3) Saturday AM West Train");
            Console.WriteLine("4) Saturday PM West Train");
            Console.WriteLine("5) Sunday AM East Train");
            Console.WriteLine("6) Sunday PM East Train");
            Console.WriteLine("7) Sunday AM West Train");
            Console.WriteLine("8) Sunday PM West Train");
            userSelection = Console.ReadLine();
            userInput = Int32.Parse(userSelection);

            switch (userSelection)
            {
                case "1":
                    satEastAM();
                    break;
                case "2":
                    satEastPM();
                    break;
                case "3":
                    satWestAM();
                    break;
                case "4":
                    satWestPM();
                    break;
                case "5":
                    sunEastAM();
                    break;
                case "6":
                    sunEastPM();
                    break;
                case "7":
                    sunWestAM();
                    break;
                case "8":
                    sunWestPM();
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Saturday East AM Report
        /// </summary>
        public void satEastAM()
        {

            string[,] carriageA = SatEastAM.returnCarriageA();
            string[,] carriageB = SatEastAM.returnCarriageB();
            string[,] carriageC = SatEastAM.returnCarriageC();
            string[,] carriageD = SatEastAM.returnCarriageD();
            StreamWriter file = new System.IO.StreamWriter(@".\\SatEastAM.txt", true);

            for (int i = 0; i < carriageA.Length / 2; i++)
            {
                Console.WriteLine("Seat Number: " + carriageA[i, 0]);
                file.WriteLine("Seat Number: " + carriageA[i, 0]);
                Console.WriteLine("Passenger Name: " + carriageA[i, 1]);
                file.WriteLine("Passenger Name: " + carriageA[i, 1]);

            }
            for (int i = 0; i < carriageB.Length / 2; i++)
            {
                Console.WriteLine("Seat Number: " + carriageB[i, 0]);
                file.WriteLine("Seat Number: " + carriageB[i, 0]);
                Console.WriteLine("Passenger Name: " + carriageB[i, 1]);
                file.WriteLine("Passenger Name: " + carriageB[i, 1]);
            }
            for (int i = 0; i < carriageC.Length / 2; i++)
            {
                Console.WriteLine("Seat Number: " + carriageC[i, 0]);
                Console.WriteLine("Passenger Name: " + carriageC[i, 1]);
                file.WriteLine("Passenger Seat: " + carriageC[i, 0]);
                file.WriteLine("Passenger Name: " + carriageC[i, 1]);
            }
            for (int i = 0; i < carriageD.Length / 2; i++)
            {
                Console.WriteLine("Seat Number: " + carriageD[i, 0]);
                Console.WriteLine("Passenger Name: " + carriageD[i, 1]);
                file.WriteLine("Seat Number: " + carriageD[i, 0]);
                file.WriteLine("Passenger Name: " + carriageD[i, 1]);
            }
            Console.WriteLine("Bags booked:" + SatEastAM.baggageSpaces);
            file.WriteLine("Bags booked:" + SatEastAM.baggageSpaces);
            Console.WriteLine("Report files written to the Project File. File Location (OldTimeRail - OldTimeRail - bin - Debug)");
        }
        /// <summary>
        /// Saturday East PM Report
        /// </summary>
        public void satEastPM()
        {
            string[,] carriageA = SatEastPM.returnCarriageA();
            string[,] carriageB = SatEastPM.returnCarriageB();
            string[,] carriageC = SatEastPM.returnCarriageC();
            string[,] carriageD = SatEastPM.returnCarriageD();
            StreamWriter file = new System.IO.StreamWriter(@".\\SatEastPM.txt", true);
            for (int i = 0; i < carriageA.Length / 2; i++)
            {
                Console.WriteLine("Seat Number: " + carriageA[i, 0]);
                Console.WriteLine("Passenger Name: " + carriageA[i, 1]);
                file.WriteLine("Seat Number: " + carriageA[i, 0]);
                file.WriteLine("Passenger Name: " + carriageA[i, 1]);
            }
            for (int i = 0; i < carriageB.Length / 2; i++)
            {
                Console.WriteLine("Seat Number: " + carriageB[i, 0]);
                Console.WriteLine("Passenger Name: " + carriageB[i, 1]);
                file.WriteLine("Seat Number: " + carriageB[i, 0]);
                file.WriteLine("Passenger Name: " + carriageB[i, 1]);
            }
            for (int i = 0; i < carriageC.Length / 2; i++)
            {
                Console.WriteLine("Seat Number: " + carriageC[i, 0]);
                Console.WriteLine("Passenger Name: " + carriageC[i, 1]);
                file.WriteLine("Seat Number: " + carriageC[i, 0]);
                file.WriteLine("Passenger Name: " + carriageC[i, 1]);
            }
            for (int i = 0; i < carriageD.Length / 2; i++)
            {
                Console.WriteLine("Seat Number: " + carriageD[i, 0]);
                Console.WriteLine("Passenger Name: " + carriageD[i, 1]);
                file.WriteLine("Seat Number: " + carriageD[i, 0]);
                file.WriteLine("Passenger Name: " + carriageD[i, 1]);
            }
            Console.WriteLine("Bags booked:" + SatEastPM.baggageSpaces);
            file.WriteLine("Bags booked:" + SatEastPM.baggageSpaces);
            Console.WriteLine("Report files written to the Project File. File Location (OldTimeRail - OldTimeRail - bin - Debug)");
        }
        /// <summary>
        /// Saturday West AM Report
        /// </summary>
        public void satWestAM()
        {
            string[,] carriageA = SatWestAM.returnCarriageA();
            string[,] carriageB = SatWestAM.returnCarriageB();
            string[,] carriageC = SatWestAM.returnCarriageC();
            string[,] carriageD = SatWestAM.returnCarriageD();
            StreamWriter file = new System.IO.StreamWriter(@".\\SatWestAM.txt", true);
            for (int i = 0; i < carriageA.Length / 2; i++)
            {
                Console.WriteLine("Seat Number: " + carriageA[i, 0]);
                Console.WriteLine("Passenger Name: " + carriageA[i, 1]);
                file.WriteLine("Seat Number: " + carriageA[i, 0]);
                file.WriteLine("Passenger Name: " + carriageA[i, 1]);
            }
            for (int i = 0; i < carriageB.Length / 2; i++)
            {
                Console.WriteLine("Seat Number: " + carriageB[i, 0]);
                Console.WriteLine("Passenger Name: " + carriageB[i, 1]);
                file.WriteLine("Seat Number: " + carriageB[i, 0]);
                file.WriteLine("Passenger Name: " + carriageB[i, 1]);
            }
            for (int i = 0; i < carriageC.Length / 2; i++)
            {
                Console.WriteLine("Seat Number: " + carriageC[i, 0]);
                Console.WriteLine("Passenger Name: " + carriageC[i, 1]);
                file.WriteLine("Seat Number: " + carriageC[i, 0]);
                file.WriteLine("Passenger Name: " + carriageC[i, 1]);
            }
            for (int i = 0; i < carriageD.Length / 2; i++)
            {
                Console.WriteLine("Seat Number: " + carriageD[i, 0]);
                Console.WriteLine("Passenger Name: " + carriageD[i, 1]);
                file.WriteLine("Seat Number: " + carriageD[i, 0]);
                file.WriteLine("Passenger Name: " + carriageD[i, 1]);

            }
            Console.WriteLine("Bags booked:" + SatWestAM.baggageSpaces);
            file.WriteLine("Bags booked:" + SatWestAM.baggageSpaces);
            Console.WriteLine("Report files written to the Project File. File Location (OldTimeRail - OldTimeRail - bin - Debug)");

        }
        /// <summary>
        /// Saturday West PM Report
        /// </summary>
        public void satWestPM()
        {
            string[,] carriageA = SatWestPM.returnCarriageA();
            string[,] carriageB = SatWestPM.returnCarriageB();
            string[,] carriageC = SatWestPM.returnCarriageC();
            string[,] carriageD = SatWestPM.returnCarriageD();
            StreamWriter file = new System.IO.StreamWriter(@".\\SatWestPM.txt", true);
            for (int i = 0; i < carriageA.Length / 2; i++)
            {
                Console.WriteLine("Seat Number: " + carriageA[i, 0]);
                Console.WriteLine("Passenger Name: " + carriageA[i, 1]);
                file.WriteLine("Seat Number: " + carriageA[i, 0]);
                file.WriteLine("Passenger Name: " + carriageA[i, 1]);
            }
            for (int i = 0; i < carriageB.Length / 2; i++)
            {
                Console.WriteLine("Seat Number: " + carriageB[i, 0]);
                Console.WriteLine("Passenger Name: " + carriageB[i, 1]);
                file.WriteLine("Seat Number: " + carriageB[i, 0]);
                file.WriteLine("Passenger Name: " + carriageB[i, 1]);
            }
            for (int i = 0; i < carriageC.Length / 2; i++)
            {
                Console.WriteLine("Seat Number: " + carriageC[i, 0]);
                Console.WriteLine("Passenger Name: " + carriageC[i, 1]);
                file.WriteLine("Seat Number: " + carriageC[i, 0]);
                file.WriteLine("Passenger Name: " + carriageC[i, 1]);
            }
            for (int i = 0; i < carriageD.Length / 2; i++)
            {
                Console.WriteLine("Seat Number: " + carriageD[i, 0]);
                Console.WriteLine("Passenger Name: " + carriageD[i, 1]);
                file.WriteLine("Seat Number: " + carriageD[i, 0]);
                file.WriteLine("Passenger Name: " + carriageD[i, 1]);
            }
            Console.WriteLine("Bags booked:" + SatWestPM.baggageSpaces);
            file.WriteLine("Bags booked:" + SatWestPM.baggageSpaces);
            Console.WriteLine("Report files written to the Project File. File Location (OldTimeRail - OldTimeRail - bin - Debug)");
        }
        /// <summary>
        /// Sunday East AM Report
        /// </summary>
        public void sunEastAM()
        {
            string[,] carriageA = SunEastAM.returnCarriageA();
            string[,] carriageB = SunEastAM.returnCarriageB();
            string[,] carriageC = SunEastAM.returnCarriageC();
            string[,] carriageD = SunEastAM.returnCarriageD();
            StreamWriter file = new System.IO.StreamWriter(@".\\SunEastAM.txt", true);
            for (int i = 0; i < carriageA.Length / 2; i++)
            {
                Console.WriteLine("Seat Number: " + carriageA[i, 0]);
                Console.WriteLine("Passenger Name: " + carriageA[i, 1]);
                file.WriteLine("Seat Number: " + carriageA[i, 0]);
                file.WriteLine("Passenger Name: " + carriageA[i, 1]);
            }
            for (int i = 0; i < carriageB.Length / 2; i++)
            {
                Console.WriteLine("Seat Number: " + carriageB[i, 0]);
                Console.WriteLine("Passenger Name: " + carriageB[i, 1]);
                file.WriteLine("Seat Number: " + carriageB[i, 0]);
                file.WriteLine("Passenger Name: " + carriageB[i, 1]);
            }
            for (int i = 0; i < carriageC.Length / 2; i++)
            {
                Console.WriteLine("Seat Number: " + carriageC[i, 0]);
                Console.WriteLine("Passenger Name: " + carriageC[i, 1]);
                file.WriteLine("Seat Number: " + carriageC[i, 0]);
                file.WriteLine("Passenger Name: " + carriageC[i, 1]);
            }
            for (int i = 0; i < carriageD.Length / 2; i++)
            {
                Console.WriteLine("Seat Number: " + carriageD[i, 0]);
                Console.WriteLine("Passenger Name: " + carriageD[i, 1]);
                file.WriteLine("Seat Number: " + carriageD[i, 0]);
                file.WriteLine("Passenger Name: " + carriageD[i, 1]);
            }

            Console.WriteLine("Bags booked:" + SunEastPM.baggageSpaces);
            file.WriteLine("Bags booked:" + SunEastPM.baggageSpaces);
            Console.WriteLine("Report files written to the Project File. File Location (OldTimeRail - OldTimeRail - bin - Debug)");
        }
        /// <summary>
        /// Sunday East PM Report
        /// </summary>
        public void sunEastPM()
        {
            string[,] carriageA = SunEastPM.returnCarriageA();
            string[,] carriageB = SunEastPM.returnCarriageB();
            string[,] carriageC = SunEastPM.returnCarriageC();
            string[,] carriageD = SunEastPM.returnCarriageD();
            StreamWriter file = new System.IO.StreamWriter(@".\\SunEastPM.txt", true);
            for (int i = 0; i < carriageA.Length / 2; i++)
            {
                Console.WriteLine("Seat Number: " + carriageA[i, 0]);
                Console.WriteLine("Passenger Name: " + carriageA[i, 1]);
                file.WriteLine("Seat Number: " + carriageA[i, 0]);
                file.WriteLine("Passenger Name: " + carriageA[i, 1]);

            }
            for (int i = 0; i < carriageB.Length / 2; i++)
            {
                Console.WriteLine("Seat Number: " + carriageB[i, 0]);
                Console.WriteLine("Passenger Name: " + carriageB[i, 1]);
                file.WriteLine("Seat Number: " + carriageB[i, 0]);
                file.WriteLine("Passenger Name: " + carriageB[i, 1]);
            }
            for (int i = 0; i < carriageC.Length / 2; i++)
            {
                Console.WriteLine("Seat Number: " + carriageC[i, 0]);
                Console.WriteLine("Passenger Name: " + carriageC[i, 1]);
                file.WriteLine("Seat Number: " + carriageC[i, 0]);
                file.WriteLine("Passenger Name: " + carriageC[i, 1]);
            }
            for (int i = 0; i < carriageD.Length / 2; i++)
            {
                Console.WriteLine("Seat Number: " + carriageD[i, 0]);
                Console.WriteLine("Passenger Name: " + carriageD[i, 1]);
                file.WriteLine("Seat Number: " + carriageD[i, 0]);
                file.WriteLine("Passenger Name: " + carriageD[i, 1]);
            }
            Console.WriteLine("Bags booked:" + SunEastPM.baggageSpaces);
            file.WriteLine("Bags booked:" + SunEastPM.baggageSpaces);
            Console.WriteLine("Report files written to the Project File. File Location (OldTimeRail - OldTimeRail - bin - Debug)");
        }
        /// <summary>
        /// Sunday West AM Report
        /// </summary>
        public void sunWestAM()
        {
            string[,] carriageA = SunWestAM.returnCarriageA();
            string[,] carriageB = SunWestAM.returnCarriageB();
            string[,] carriageC = SunWestAM.returnCarriageC();
            string[,] carriageD = SunWestAM.returnCarriageD();
            StreamWriter file = new System.IO.StreamWriter(@".\\SunWestAM.txt", true);
            for (int i = 0; i < carriageA.Length / 2; i++)
            {
                Console.WriteLine("Seat Number: " + carriageA[i, 0]);
                Console.WriteLine("Passenger Name: " + carriageA[i, 1]);
                file.WriteLine("Seat Number: " + carriageA[i, 0]);
                file.WriteLine("Passenger Name: " + carriageA[i, 1]);
            }
            for (int i = 0; i < carriageB.Length / 2; i++)
            {
                Console.WriteLine("Seat Number: " + carriageB[i, 0]);
                Console.WriteLine("Passenger Name: " + carriageB[i, 1]);
                file.WriteLine("Seat Number: " + carriageB[i, 0]);
                file.WriteLine("Passenger Name: " + carriageB[i, 1]);
            }
            for (int i = 0; i < carriageC.Length / 2; i++)
            {
                Console.WriteLine("Seat Number: " + carriageC[i, 0]);
                Console.WriteLine("Passenger Name: " + carriageC[i, 1]);
                file.WriteLine("Seat Number: " + carriageC[i, 0]);
                file.WriteLine("Passenger Name: " + carriageC[i, 1]);
            }
            for (int i = 0; i < carriageD.Length / 2; i++)
            {
                Console.WriteLine("Seat Number: " + carriageD[i, 0]);
                Console.WriteLine("Passenger Name: " + carriageD[i, 1]);
                file.WriteLine("Seat Number: " + carriageD[i, 0]);
                file.WriteLine("Passenger Name: " + carriageD[i, 1]);
            }

            Console.WriteLine("Bags booked:" + SunWestAM.baggageSpaces);
            file.WriteLine("Bags booked:" + SunWestAM.baggageSpaces);
            Console.WriteLine("Report files written to the Project File. File Location (OldTimeRail - OldTimeRail - bin - Debug)");
        }

        public void sunWestPM()
        {
            string[,] carriageA = SunWestPM.returnCarriageA();
            string[,] carriageB = SunWestPM.returnCarriageB();
            string[,] carriageC = SunWestPM.returnCarriageC();
            string[,] carriageD = SunWestPM.returnCarriageD();
            StreamWriter file = new System.IO.StreamWriter(@".\\SunWestPM.txt", true);
            for (int i = 0; i < carriageA.Length / 2; i++)
            {
                Console.WriteLine("Seat Number: " + carriageA[i, 0]);
                Console.WriteLine("Passenger Name: " + carriageA[i, 1]);
                file.WriteLine("Seat Number: " + carriageA[i, 0]);
                file.WriteLine("Passenger Name: " + carriageA[i, 1]);
            }
            for (int i = 0; i < carriageB.Length / 2; i++)
            {
                Console.WriteLine("Seat Number: " + carriageB[i, 0]);
                Console.WriteLine("Passenger Name: " + carriageB[i, 1]);
                file.WriteLine("Seat Number: " + carriageB[i, 0]);
                file.WriteLine("Passenger Name: " + carriageB[i, 1]);
            }
            for (int i = 0; i < carriageC.Length / 2; i++)
            {
                Console.WriteLine("Seat Number: " + carriageC[i, 0]);
                Console.WriteLine("Passenger Name: " + carriageC[i, 1]);
                file.WriteLine("Seat Number: " + carriageC[i, 0]);
                file.WriteLine("Passenger Name: " + carriageC[i, 1]);
            }
            for (int i = 0; i < carriageD.Length / 2; i++)
            {
                Console.WriteLine("Seat Number: " + carriageD[i, 0]);
                Console.WriteLine("Passenger Name: " + carriageD[i, 1]);
                file.WriteLine("Seat Number: " + carriageD[i, 0]);
                file.WriteLine("Passenger Name: " + carriageD[i, 1]);
            }
            Console.WriteLine("Bags booked:" + SunWestPM.baggageSpaces);
            file.WriteLine("Bags booked:" + SunWestPM.baggageSpaces);
            Console.WriteLine("Report files written to the Project File. File Location (OldTimeRail - OldTimeRail - bin - Debug)");

        }
    }
}
