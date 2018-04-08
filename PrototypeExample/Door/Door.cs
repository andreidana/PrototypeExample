namespace PrototypeExample.Door
{
    public class Door: IPrototypeDoor
    {
        public string DoorType { get; }

        public Door()
        {
            DoorType = "This is a normal door";
        }

        public IPrototypeDoor Clone()
        {
            return new Door();
        }
    }
}