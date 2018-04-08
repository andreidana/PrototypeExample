using System;

namespace PrototypeExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var mazePrototypeFactory = new MazePrototypeFactory(new Wall.Wall(), new Room.Room(), new Door.Door());
        }
    }
}
