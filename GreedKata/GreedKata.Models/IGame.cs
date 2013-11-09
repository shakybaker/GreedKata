using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreedKata.Models
{
    public interface IGame
    {
        int Score(int[] dice);
    }
}
