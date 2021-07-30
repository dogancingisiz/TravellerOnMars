using Entities;
using Entities.Directions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public interface IRobotManager
    {
        void Move(Robot robot, char[] directives);
        List<Robot> GetRobotInformations();
        IBaseDirection GetDirection(string direction);
    }
}
