namespace PrototypeExample.Wall
{
    public class BombedWall: IPrototypeWall
    {
        public string WallType { get; }

        public BombedWall()
        {
            WallType = "This is a bombed wall";
        }

        public IPrototypeWall Clone()
        {
            return new BombedWall();
        }
    }
}