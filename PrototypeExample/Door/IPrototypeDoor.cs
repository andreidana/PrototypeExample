namespace PrototypeExample.Door
{
    public interface IPrototypeDoor
    {
        string DoorType { get;}

        IPrototypeDoor Clone();
    }
}