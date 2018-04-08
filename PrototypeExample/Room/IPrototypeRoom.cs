namespace PrototypeExample.Room
{
    public interface IPrototypeRoom
    {
        string RoomType { get; }

        IPrototypeRoom Clone();
    }
}