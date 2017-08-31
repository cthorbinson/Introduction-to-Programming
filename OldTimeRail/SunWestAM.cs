using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldTimeRail
{
    class SunWestAM
    {
        static String trainName = "Sunday West AM";
        static String[,] carriageA = new String[32, 2];
        static String[,] carriageB = new String[32, 2];
        static String[,] carriageC = new String[50, 2];
        static String[,] carriageD = new String[50, 2];
        public static int baggageSpaces = 0;

        public static void initialiseA()
        {
            for (int i = 0; i < 32; i++)
            {
                StringBuilder seatNumber = new StringBuilder();
                seatNumber.Append('A');
                if (i < 10)
                {
                    seatNumber.Append('0');
                }
                seatNumber.Append(i);
                carriageA[i, 0] = seatNumber.ToString();
                carriageA[i, 1] = null;
            }
        }

        public static void initialiseB()
        {
            for (int i = 0; i < 32; i++)
            {
                StringBuilder seatNumber = new StringBuilder();
                seatNumber.Append('B');
                if (i < 10)
                {
                    seatNumber.Append('0');
                }
                seatNumber.Append(i);
                carriageB[i, 0] = seatNumber.ToString();
                carriageB[i, 1] = null;
            }
        }


        public static void initialiseC()
        {
            for (int i = 0; i < 50; i++)
            {
                StringBuilder seatNumber = new StringBuilder();
                seatNumber.Append('C');
                if (i < 10)
                {
                    seatNumber.Append('0');
                }
                seatNumber.Append(i);
                carriageC[i, 0] = seatNumber.ToString();
                carriageC[i, 1] = null;
            }
        }


        public static void initialiseD()
        {
            for (int i = 0; i < 50; i++)
            {
                StringBuilder seatNumber = new StringBuilder();
                seatNumber.Append('D');
                if (i < 10)
                {
                    seatNumber.Append('0');
                }
                seatNumber.Append(i);
                carriageD[i, 0] = seatNumber.ToString();
                carriageD[i, 1] = null;
            }
        }


        public static String[,] returnCarriageA()
        {
            return carriageA;
        }


        public static String[,] returnCarriageB()
        {
            return carriageB;
        }


        public static String[,] returnCarriageC()
        {
            return carriageC;
        }


        public static String[,] returnCarriageD()
        {
            return carriageD;
        }


        public static void bookCarriageA(int partySize, String name, int baggage)
        {
            if (partySize <= 8)
            {
                if (bookBaggage(baggage) == true)
                {
                    int freeSpaces = 0;
                    int seatNumber = 0;
                    int compartmentNumber = 0;
                    int amountBooked = 0;
                    bool success = false;
                    String[] seatNumbers = new String[partySize];

                    while (success == false)
                    {


                        for (seatNumber = 8 * compartmentNumber; seatNumber < 8 * (compartmentNumber + 1) && freeSpaces < partySize && seatNumber < 32; seatNumber++)
                        {
                            if (carriageA[seatNumber, 1] == null)
                            {
                                freeSpaces++;
                            }
                        }
                        if (freeSpaces >= partySize)
                        {
                            while (amountBooked < partySize)
                            {
                                for (seatNumber = compartmentNumber * 8; seatNumber < 8 * (compartmentNumber + 1); seatNumber++)
                                {
                                    if (carriageA[seatNumber, 1] == null && amountBooked < partySize)
                                    {
                                        seatNumbers[amountBooked] = carriageA[seatNumber, 0];
                                        carriageA[seatNumber, 1] = name;
                                        amountBooked++;
                                    }
                                }
                            }
                            success = true;
                            Console.WriteLine("Booking successful. Please remember your seat numbers:");
                            for (int i = 0; i < seatNumbers.Length; i++)
                            {
                                Console.WriteLine(seatNumbers[i] + " ");
                            }
                            Console.WriteLine("You have been booked onto " + trainName);
                        }
                        else
                        {
                            if (compartmentNumber == 3)
                            {
                                Console.WriteLine("Your booking has failed. There are not enough seats on this train.");
                                success = true;
                            }
                            else
                            {
                                compartmentNumber++;
                                seatNumber = 0;
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Booking cancelled.");
                }
            }

            else
            {
                Console.WriteLine("The maximum booking size is 8 for a compartment carriage");

            }

        }


        public static void bookCarriageB(int partySize, String name, int baggage)
        {
            if (partySize <= 8)
            {
                if (bookBaggage(baggage) == true)
                {

                    int freeSpaces = 0;
                    int seatNumber = 0;
                    int compartmentNumber = 0;
                    int amountBooked = 0;
                    bool success = false;
                    String[] seatNumbers = new String[partySize];

                    while (success == false)
                    {

                        for (seatNumber = 8 * compartmentNumber; seatNumber < 8 * (compartmentNumber + 1) && freeSpaces < partySize && seatNumber < 32; seatNumber++)
                        {
                            if (carriageB[seatNumber, 1] == null)
                            {
                                freeSpaces++;
                            }
                        }
                        if (freeSpaces >= partySize)
                        {
                            while (amountBooked < partySize)
                            {
                                for (seatNumber = compartmentNumber * 8; seatNumber < 8 * (compartmentNumber + 1); seatNumber++)
                                {
                                    if (carriageB[seatNumber, 1] == null && amountBooked < partySize)
                                    {
                                        seatNumbers[amountBooked] = carriageB[seatNumber, 0];
                                        carriageB[seatNumber, 1] = name;
                                        amountBooked++;
                                    }
                                }
                            }
                            success = true;
                            Console.WriteLine("Booking successful. Please remember your seat numbers:");
                            for (int i = 0; i < seatNumbers.Length; i++)
                            {
                                Console.WriteLine(seatNumbers[i] + " ");
                            }
                            Console.WriteLine("You have been booked onto " + trainName);
                        }
                        else
                        {
                            if (compartmentNumber == 3)
                            {
                                Console.WriteLine("Your booking has failed. There are not enough seats on this train.");
                                success = true;
                            }
                            else
                            {
                                compartmentNumber++;
                                seatNumber = 0;
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Booking cancelled.");
                }
            }

            else
            {
                Console.WriteLine("The maximum booking size is 8 for a compartment carriage");

            }
        }


        public static void bookCarriageC(int partySize, String name, int baggage)
        {
            if (bookBaggage(baggage) == true)
            {
                int freeSpaces = 0;
                int seatNumber = 0;
                int compartmentNumber = 0;
                int amountBooked = 0;
                bool success = false;
                String[] seatNumbers = new String[partySize];

                while (success == false)
                {
                    if (partySize <= 4)
                    {
                        //Search the first 4 out of 10 as they are the group of 4 seats (0-3)(10-13)
                        for (seatNumber = compartmentNumber * 10; seatNumber < (compartmentNumber * 10) + 4; seatNumber++)
                        {
                            if (carriageC[seatNumber, 1] == null)
                            {
                                freeSpaces++;
                            }
                        }

                        if (freeSpaces >= partySize)
                        {
                            while (amountBooked < partySize)
                            {
                                for (seatNumber = compartmentNumber * 10; seatNumber < (compartmentNumber * 10) + 4; seatNumber++)
                                {
                                    if (carriageC[seatNumber, 1] == null && amountBooked < partySize)
                                    {
                                        seatNumbers[amountBooked] = carriageC[seatNumber, 0];
                                        carriageC[seatNumber, 1] = name;
                                        amountBooked++;
                                    }
                                }
                            }
                            success = true;
                            Console.WriteLine("Booking successful. Please remember your seat numbers:");
                            for (int i = 0; i < seatNumbers.Length; i++)
                            {
                                Console.WriteLine(seatNumbers[i] + " ");
                            }
                            Console.WriteLine("You have been booked onto " + trainName);
                        }

                        else
                        {
                            if (compartmentNumber == 4)
                            {
                                //success = true;
                                bookCarriageD(partySize, name, baggage);
                                break;
                            }
                            else
                            {
                                compartmentNumber++;
                                seatNumber = 0;
                            }
                        }
                    }








                    else if (partySize > 4 && partySize <= 6)
                    {
                        // Else check the last 6 (4-9)
                        for (seatNumber = (compartmentNumber * 10) + 4; seatNumber < (compartmentNumber + 1) * 10; seatNumber++)
                        {
                            if (carriageC[seatNumber, 1] == null)
                            {
                                freeSpaces++;
                            }
                        }

                        if (freeSpaces >= partySize)
                        {
                            while (amountBooked < partySize)
                            {
                                for (seatNumber = (compartmentNumber * 10) + 4; seatNumber < (compartmentNumber + 1) * 10; seatNumber++)
                                {
                                    if (carriageC[seatNumber, 1] == null && amountBooked < partySize)
                                    {
                                        seatNumbers[amountBooked] = carriageC[seatNumber, 0];
                                        carriageC[seatNumber, 1] = name;
                                        amountBooked++;
                                    }
                                }
                            }
                            success = true;
                            Console.WriteLine("Booking successful. Please remember your seat numbers:");
                            for (int i = 0; i < seatNumbers.Length; i++)
                            {
                                Console.WriteLine(seatNumbers[i] + " ");
                            }
                            Console.WriteLine("You have been booked onto " + trainName);
                        }
                        else
                        {
                            if (compartmentNumber == 4)
                            {
                                success = true;
                                bookCarriageD(partySize, name, baggage);

                                break;
                            }
                            else
                            {
                                compartmentNumber++;
                                seatNumber = 0;
                            }
                        }


                    }

                    else if (partySize > 6 && partySize <= 10)
                    {
                        //Else check in the set of 10 to assign seats
                        for (seatNumber = (compartmentNumber * 10); seatNumber < (compartmentNumber + 1) * 10; seatNumber++)
                        {
                            if (carriageC[seatNumber, 1] == null)
                            {
                                freeSpaces++;
                            }
                        }

                        if (freeSpaces >= partySize)
                        {
                            while (amountBooked < partySize)
                            {
                                for (seatNumber = (compartmentNumber * 10); seatNumber < (compartmentNumber + 1) * 10; seatNumber++)
                                {
                                    if (carriageC[seatNumber, 1] == null && amountBooked < partySize)
                                    {
                                        seatNumbers[amountBooked] = carriageC[seatNumber, 0];
                                        carriageC[seatNumber, 1] = name;
                                        amountBooked++;
                                    }
                                }
                            }
                            success = true;
                            Console.WriteLine("Booking successful. Please remember your seat numbers:");
                            for (int i = 0; i < seatNumbers.Length; i++)
                            {
                                Console.WriteLine(seatNumbers[i] + " ");
                            }
                            Console.WriteLine("You have been booked onto " + trainName);
                        }

                        else
                        {
                            if (compartmentNumber == 4)
                            {
                                bookCarriageD(partySize, name, baggage);
                                success = true;
                                break;
                            }
                            else
                            {
                                compartmentNumber++;
                                seatNumber = 0;
                            }
                        }

                    }

                    else
                    {
                        Console.WriteLine("You have entered too many people. You can only book a maximum 10 tickets at a time.");
                        success = true;
                    }

                }
            }
            else
            {
                Console.WriteLine("Booking cancelled.");
            }

        }


        public static void bookCarriageD(int partySize, String name, int baggage)
        {

            if (bookBaggage(baggage) == true)
            {
                int freeSpaces = 0;
                int seatNumber = 0;
                int compartmentNumber = 0;
                int amountBooked = 0;
                bool success = false;
                String[] seatNumbers = new String[partySize];

                while (success == false)
                {

                    if (partySize <= 4)
                    {
                        //Search the first 4 out of 10 as they are the group of 4 seats (0-3)(10-13)
                        for (seatNumber = compartmentNumber * 10; seatNumber < (compartmentNumber * 10) + 4; seatNumber++)
                        {
                            if (carriageD[seatNumber, 1] == null)
                            {
                                freeSpaces++;
                            }
                        }



                        if (freeSpaces >= partySize)
                        {
                            while (amountBooked < partySize)
                            {
                                for (seatNumber = compartmentNumber * 10; seatNumber < (compartmentNumber * 10) + 4; seatNumber++)
                                {
                                    if (carriageD[seatNumber, 1] == null && amountBooked < partySize)
                                    {
                                        seatNumbers[amountBooked] = carriageD[seatNumber, 0];
                                        carriageD[seatNumber, 1] = name;
                                        amountBooked++;
                                    }
                                }
                            }
                            success = true;
                            Console.WriteLine("Booking successful. Please remember your seat numbers:");
                            for (int i = 0; i < seatNumbers.Length; i++)
                            {
                                Console.WriteLine(seatNumbers[i] + " ");
                            }
                            Console.WriteLine("You have been booked onto " + trainName);
                        }
                        else
                        {
                            if (compartmentNumber == 4)
                            {
                                Console.WriteLine("Your booking has failed. There are not enough seats on this train.");
                                success = true;
                            }
                            else
                            {
                                compartmentNumber++;
                                seatNumber = 0;
                            }
                        }

                    }
                    else if (partySize > 4 && partySize <= 6)
                    {
                        // Else check the last 6 (4-9)
                        for (seatNumber = (compartmentNumber * 10) + 4; seatNumber < (compartmentNumber + 1) * 10; seatNumber++)
                        {
                            if (carriageD[seatNumber, 1] == null)
                            {
                                freeSpaces++;
                            }
                        }



                        if (freeSpaces >= partySize)
                        {
                            while (amountBooked < partySize)
                            {
                                for (seatNumber = (compartmentNumber * 10) + 4; seatNumber < (compartmentNumber + 1) * 10; seatNumber++)
                                {
                                    if (carriageD[seatNumber, 1] == null && amountBooked < partySize)
                                    {
                                        seatNumbers[amountBooked] = carriageD[seatNumber, 0];
                                        carriageD[seatNumber, 1] = name;
                                        amountBooked++;
                                    }
                                }
                            }
                            success = true;
                            Console.WriteLine("Booking successful. Please remember your seat numbers:");
                            for (int i = 0; i < seatNumbers.Length; i++)
                            {
                                Console.WriteLine(seatNumbers[i] + " ");
                            }
                            Console.WriteLine("You have been booked onto " + trainName);
                        }
                        else
                        {
                            if (compartmentNumber == 4)
                            {
                                Console.WriteLine("Your booking has failed. There are not enough seats on this train.");
                                success = true;
                            }
                            else
                            {
                                compartmentNumber++;
                                seatNumber = 0;
                            }
                        }


                    }

                    else if (partySize > 6 && partySize <= 10)
                    {
                        //Else check in the set of 10 to assign seats
                        for (seatNumber = (compartmentNumber * 10); seatNumber < (compartmentNumber + 1) * 10; seatNumber++)
                        {
                            if (carriageD[seatNumber, 1] == null)
                            {
                                freeSpaces++;
                            }
                        }


                        if (freeSpaces >= partySize)
                        {
                            while (amountBooked < partySize)
                            {
                                for (seatNumber = (compartmentNumber * 10); seatNumber < (compartmentNumber + 1) * 10; seatNumber++)
                                {
                                    if (carriageD[seatNumber, 1] == null && amountBooked < partySize)
                                    {
                                        seatNumbers[amountBooked] = carriageD[seatNumber, 0];
                                        carriageD[seatNumber, 1] = name;
                                        amountBooked++;
                                    }
                                }
                            }
                            success = true;
                            Console.WriteLine("Booking successful. Please remember your seat numbers:");
                            for (int i = 0; i < seatNumbers.Length; i++)
                            {
                                Console.WriteLine(seatNumbers[i] + " ");
                            }
                            Console.WriteLine("You have been booked onto " + trainName);
                        }

                        else
                        {
                            if (compartmentNumber == 4)
                            {
                                Console.WriteLine("Your booking has failed. There are not enough seats on this train.");
                                success = true;
                            }
                            else
                            {
                                compartmentNumber++;
                                seatNumber = 0;
                            }
                        }
                    }

                    else
                    {
                        Console.WriteLine("You have entered too many people. You can only book a maximum 10 tickets at a time.");
                        success = true;
                    }

                }
            }
            else
            {
                Console.WriteLine("Booking cancelled.");
            }
        }


        public static bool bookBaggage(int baggage)
        {
            if (baggageSpaces + baggage <= 40)
            {
                baggageSpaces = baggageSpaces + baggage;
                Console.WriteLine(baggage + " bags have been added.");
                return true;
            }

            else
            {

                string userSelection = "";
                int userInput = 0;
                Console.WriteLine("There are only " + (40 - baggageSpaces) + " available. Please select one of the following options:");
                Console.WriteLine("1) Enter less baggage.");
                Console.WriteLine("2) Continue without bags.");
                Console.WriteLine("3) Cancel booking.");
                userSelection = Console.ReadLine();
                userInput = Int32.Parse(userSelection);

                switch (userSelection)
                {
                    case "1":
                        Console.WriteLine("Please enter how many bags you would like.");
                        bookBaggage(Int32.Parse(Console.ReadLine()));
                        return true;
                    case "2":
                        return true;
                    case "3":
                        return false;
                    default:
                        Console.WriteLine("Please enter a correct number.");
                        break;
                }
            }
            return false;
        }


    }
}

