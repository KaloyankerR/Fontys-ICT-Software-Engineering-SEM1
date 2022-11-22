using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lottery
{
    internal class Lottery
    {
        int maxValue;
        int ballsNr;
        int[] drawnNumbers;
        Random rnd;

        public Lottery(int maxValue, int ballsNr)
        {
            this.maxValue = maxValue;
            this.ballsNr = ballsNr;
            drawnNumbers = new int[ballsNr];
            rnd = new Random();
        }

        public int[] DrawAllNumbers()
        {
            int[] numbers = new int[ballsNr];
            int counter = 0;


            while (numbers.Length < ballsNr)
            {
                int rndNum = this.rnd.Next(maxValue);
                bool exists = Array.Exists(numbers, el => el == rndNum);

                if (exists)
                {
                    continue;
                }

                numbers[counter] = rndNum;
                counter++;
            }

            return numbers;
        }

        public int DrawNextNumber()
        {
            int rndNum = this.rnd.Next(maxValue);
            bool exists = Array.Exists(this.drawnNumbers, el => el == rndNum);

            while (!exists)
            {
                rndNum = this.rnd.Next(maxValue);
                exists = Array.Exists(this.drawnNumbers, el => el == rndNum);
            }

            drawnNumbers[drawnNumbers.Length] = rndNum;
            return rndNum;
        }

        public bool IsLotteryFinished()
        {
            return drawnNumbers.Length < ballsNr;
        }
    }
}
