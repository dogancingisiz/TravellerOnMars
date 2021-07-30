using Entities.Directions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Robot
    {
        public int Id { get; set; }
        public int xCoordinate { get; set; }
        public int yCoordinate { get; set; }
        public IBaseDirection Direction { get; set; }
    }
}
