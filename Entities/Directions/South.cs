using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Directions
{
    public class South : IBaseDirection
    {
        public string Name { get; set; } = "S";
        public int X { get; set; } = 0;
        public int Y { get; set; } = -1;

        public IBaseDirection TurnGetDirection(string LorR)
        {
            if (LorR == "L")
            {
                return new East();
            }
            else
            {
                return new West();
            }
        }
    }
}
