using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Directions
{
    public class North : IBaseDirection
    {
        public string Name { get; set; } = "N";
        public int X { get; set; } = 0;
        public int Y { get; set; } = 1;
        public IBaseDirection TurnGetDirection(string LorR)
        {
            if (LorR == "L")
            {
                return new West();
            }
            else
            {
                return new East();
            }
        }
    }
}
