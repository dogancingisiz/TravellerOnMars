using Business;
using Entities;
using Entities.Directions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the surface of mars");
            Console.WriteLine("-----------------------------------");

            Console.WriteLine("Sağ üst köşe koordinatı:");
            string topRightCoordinate = Console.ReadLine();
            int xTopRight = int.Parse(topRightCoordinate[0].ToString());
            int yTopRight = int.Parse(topRightCoordinate[2].ToString());

            Surface surface = new Surface(xTopRight + 1, yTopRight + 1);
            IRobotManager robotManager = new RobotManager(surface);

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("İlk bulunduğu konum : ");
                string firstCoordinate = Console.ReadLine();

                Console.WriteLine("Harf katarı : ");
                char[] directives = Console.ReadLine().ToCharArray();

                
                string direction = firstCoordinate.Split(' ')[2];
                IBaseDirection baseDirection = robotManager.GetDirection(direction);

                Robot robot = new Robot
                {
                    Id = i + 1,
                    xCoordinate = int.Parse(firstCoordinate[0].ToString()),
                    yCoordinate = int.Parse(firstCoordinate[2].ToString()),
                    Direction = baseDirection
                };

                surface.Areas[robot.xCoordinate, robot.yCoordinate].Robots.Add(robot);
                robotManager.Move(robot, directives);
            }

            Console.WriteLine("-----------------------------------");

            List<Robot> robotInformations = robotManager.GetRobotInformations();
            foreach (var item in robotInformations)
            {
                Console.WriteLine("{0}.Robot -> {1} {2} {3}", item.Id, item.xCoordinate, item.yCoordinate, item.Direction.Name);
            }

            Console.ReadLine();
        }
    }
}
