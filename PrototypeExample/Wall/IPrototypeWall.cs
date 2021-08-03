namespace PrototypeExample.Wall
{
    public interface IPrototypeWall
    {
        string WallType { get; }

        IPrototypeWall Clone();
    }
}