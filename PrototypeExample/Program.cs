namespace PrototypeExample
{
    internal class Program
    {
        private static void Main()
        {
            var _ = new MazePrototypeFactory(new Wall.Wall(), new Room.Room(), new Door.Door());
        }
    }
}
