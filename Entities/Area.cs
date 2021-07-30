using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Area
    {
        public Area()
        {
            Robots = new List<Robot>();
        }

        public List<Robot> Robots { get; set; }
    }
}
