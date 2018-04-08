namespace PrototypeExample.Room
{
    public class EnchantedRoom: IPrototypeRoom
    {
        public string RoomType { get; }

        public EnchantedRoom()
        {
            RoomType = "This is an enchanted room";
        }

        public IPrototypeRoom Clone()
        {
            return new EnchantedRoom();
        }
    }
}