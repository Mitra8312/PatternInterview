namespace PatternInterview.FloorDecorator
{
    public class Floor(bool walls, int rooms, int windows) : IFloor
    {
        public bool Walls { set; get; } = walls;
        public int Rooms { set; get; } = rooms;
        public int Windows { set; get; } = windows;

        public IFloor Create()
        {
            return this;
        }
    }
}
