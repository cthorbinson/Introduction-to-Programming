using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldTimeRail
{
    class Journey
    {
        /// <summary>
        /// Journey Class calculates the direction of the train from the user input in the Booking Class.
        /// </summary>

        int startStop;
        int endStop;

        public Journey(int start, int end)
        {
            startStop = start;
            endStop = end;
        }

        public int[] eastJourney()
        {
            int[] east = new int[5];

            //"Beggin Terminal";
            east[0] = 1;
            //"Suddean Halt";
            east[1] = 2;
            //"Multhy Pass";
            east[2] = 3;
            //"Conn Junction";
            east[3] = 4;
            //"Endline Station";
            east[4] = 5;

            return east;
        }

        public String calculateDirection()
        {
            int[] direction = eastJourney();

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (direction[i] == (startStop)
                            && direction[j] == (endStop) && i < j)
                    {
                        return "east";
                    }


                    else if (direction[i] == (startStop)
                          && direction[j] == (endStop) && i > j)
                    {
                        return "west";
                    }

                }
            }
            return "error";
        }

    }
}
