namespace PrototypeExample.Wall
{
    public class Wall: IPrototypeWall
    {
        public string WallType { get; }

        public Wall()
        {
            WallType = "This is a normal wall";
        }

        public IPrototypeWall Clone()
        {
            return new Wall();
        }
    }
}