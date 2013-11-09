using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreedKata.Models
{
    public class Game : IGame
    {
        private bool isStraight = false;

        public int Score(int[] dice)
        {
            int score = 0;

            score += GetStraightScore(dice);

            if (!isStraight)
            {
                if (dice.Where(x => x.Equals(1)).Count() == 1)
                    score += 100;

                if (dice.Where(x => x.Equals(5)).Count() == 1)
                    score += 50;

                for (var i = 1; i <= 6; i++)
                    score += GetMultipleScore(dice, i);

                score += GetThreePairScore(dice);
            }
    
            return score;
        }

        private int GetStraightScore(int[] dice)
        {
            int retVal = 0;

            if ((dice.Where(x => x.Equals(1)).Count() == 1)
            && (dice.Where(x => x.Equals(2)).Count() == 1)
            && (dice.Where(x => x.Equals(3)).Count() == 1)
            && (dice.Where(x => x.Equals(4)).Count() == 1)
            && (dice.Where(x => x.Equals(5)).Count() == 1)
            && (dice.Where(x => x.Equals(6)).Count() == 1))
            {
                retVal = 1200;
                isStraight = true;
            }

            return retVal;
        }

        private int GetThreePairScore(int[] dice)
        {
            int retVal = 0;
            int count = 0;

            for (var i = 1; i <= 6; i++)
                if (dice.Where(x => x.Equals(i)).Count() == 2)
                    count++;

            if (count == 3)
                retVal = 800;

            return retVal;
        }

        private static int GetMultipleScore(int[] dice, int check)
        {
            int retVal = 0;
            int multiScore = 0;

            switch (check)
            {
                case 1:
                    multiScore = 1000;
                    break;
                case 2:
                    multiScore = 200;
                    break;
                case 3:
                    multiScore = 300;
                    break;
                case 4:
                    multiScore = 400;
                    break;
                case 5:
                    multiScore = 500;
                    break;
                case 6:
                    multiScore = 600;
                    break;
                default:
                    break;
            }

            if (dice.Where(x => x.Equals(check)).Count() == 6)
                retVal += multiScore * 8;
            else if (dice.Where(x => x.Equals(check)).Count() == 5)
                retVal += multiScore * 4;
            else if (dice.Where(x => x.Equals(check)).Count() == 4)
                retVal += multiScore * 2;
            else if (dice.Where(x => x.Equals(check)).Count() == 3)
                retVal += multiScore;

            return retVal;
        }
    }
}
