using Entities;
using Entities.Directions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class RobotManager : IRobotManager
    {
        public Surface _surface { get; set; }
        public RobotManager(Surface surface)
        {
            _surface = surface;
        }

        public void Move(Robot robot, char[] directives)
        {
            foreach (var directive in directives)
            {
                if (directive == 'L')
                {
                    var newDirection = robot.Direction.TurnGetDirection("L");
                    robot.Direction = newDirection;
                }
                if (directive == 'R')
                {
                    var newDirection = robot.Direction.TurnGetDirection("R");
                    robot.Direction = newDirection;
                }
                if (directive == 'M')
                {
                    var currentDirection = robot.Direction;
                    int currentX = robot.xCoordinate;
                    int currentY = robot.yCoordinate;

                    int newCurrentX = currentX + currentDirection.X;
                    int newCurrentY = currentY + currentDirection.Y;

                    int maxX = _surface.Areas.GetLength(0) - 1;
                    int maxY = _surface.Areas.GetLength(1) - 1;

                    //Max Kontrolü
                    if (newCurrentX > maxX) newCurrentX = maxX;
                    if (newCurrentX < 0) newCurrentX = 0;

                    if (newCurrentY > maxX) newCurrentY = maxY;
                    if (newCurrentY < 0) newCurrentY = 0;

                    _surface.Areas[currentX, currentY].Robots.Remove(robot);

                    _surface.Areas[newCurrentX, newCurrentY].Robots.Add(robot);
                    robot.xCoordinate = newCurrentX;
                    robot.yCoordinate = newCurrentY;
                }
            }
        }

        public List<Robot> GetRobotInformations()
        {
            List<Robot> robots = new List<Robot>();
            foreach (var item in _surface.Areas)
            {
                if (item.Robots.Count > 0)
                {
                    foreach (var robot in item.Robots)
                    {
                        robots.Add(robot);
                    }
                }
            }

            return robots.OrderBy(x => x.Id).ToList();
        }

        public IBaseDirection GetDirection(string direction)
        {
            IBaseDirection baseDirection;
            if (direction == "N") baseDirection = new North();
            else if (direction == "W") baseDirection = new West();
            else if (direction == "E") baseDirection = new East();
            else if (direction == "S") baseDirection = new South();
            else baseDirection = new North();

            return baseDirection;
        }
    }
}
