using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Directions
{
    public class East : IBaseDirection
    {
        public IBaseDirection TurnGetDirection(string LorR)
        {
            if (LorR == "L")
            {
                return new North();
            }
            else
            {
                return new South();
            }
        }
        public int X { get; set; } = 1;
        public int Y { get; set; } = 0;
        public string Name { get; set; } = "E";
    }
}
