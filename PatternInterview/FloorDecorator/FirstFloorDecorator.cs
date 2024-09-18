namespace PatternInterview.FloorDecorator
{
    public class FirstFloorDecorator(bool doorWay, IFloor floor) : FloorDecorator(floor)
    {
        public bool DoorWay { set; get; } = doorWay;

        public IFloor Create()
        {
            return this;
        }
    }
}
