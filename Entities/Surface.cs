using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Surface
    {
        public Surface(int xTopRight, int yTopRight)
        {
            Areas = new Area[xTopRight, yTopRight];
            LoadAreas();
        }

        public Area[,] Areas { get; set; }

        private void LoadAreas()
        {
            for (int i = 0; i < Areas.GetLength(0); i++)
            {
                for (int j = 0; j < Areas.GetLength(1); j++)
                {
                    Areas[i, j] = new Area();
                }
            }
        }
    }
}
