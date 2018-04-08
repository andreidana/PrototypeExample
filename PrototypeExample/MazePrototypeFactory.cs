using PrototypeExample.Door;
using PrototypeExample.Room;
using PrototypeExample.Wall;

namespace PrototypeExample
{
    public class MazePrototypeFactory
    {
        private IPrototypeWall _wall;
        private IPrototypeRoom _room;
        private IPrototypeDoor _door;

        public MazePrototypeFactory(IPrototypeWall wall, IPrototypeRoom room, IPrototypeDoor door)
        {
            _wall = wall;
            _room = room;
            _door = door;
        }

        public IPrototypeWall CreateWall()
        {
            return _wall.Clone();
        }

        public IPrototypeRoom CreateRoom()
        {
            return _room.Clone();
        }

        public IPrototypeDoor CreateDoor()
        {
            return _door.Clone();
        }
    }
}