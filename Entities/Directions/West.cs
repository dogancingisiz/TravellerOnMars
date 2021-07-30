using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Directions
{
    public class West : IBaseDirection
    {
        public string Name { get; set; } = "W";
        public int X { get; set; } = -1;
        public int Y { get; set; } = 0;

        public IBaseDirection TurnGetDirection(string LorR)
        {
            if (LorR == "L")
            {
                return new South();
            }
            else
            {
                return new North();
            }
        }
    }
}
