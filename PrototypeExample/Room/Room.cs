namespace PrototypeExample.Room
{
    public class Room: IPrototypeRoom
    {
        public string RoomType { get; }

        public Room()
        {
            RoomType = "This is a normal room";
        }

        public IPrototypeRoom Clone()
        {
            return new Room();
        }
    }
}