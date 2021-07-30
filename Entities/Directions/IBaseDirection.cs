using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Directions
{
    public interface IBaseDirection
    {
        string Name { get; set; }
        int X { get; set; }
        int Y { get; set; }
        IBaseDirection TurnGetDirection(string LorR);
    }
}
