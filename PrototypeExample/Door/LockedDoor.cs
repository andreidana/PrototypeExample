namespace PrototypeExample.Door
{
    public class LockedDoor: IPrototypeDoor
    {
        public string DoorType { get; }

        public LockedDoor()
        {
            DoorType = "This is a locked door";
        }

        public IPrototypeDoor Clone()
        {
            return new LockedDoor();
        }
    }
}