namespace PatternInterview.FloorDecorator
{
    public class ThirdFloorDecorator(bool hasSwimmingPool, IFloor floor) : FloorDecorator(floor)
    {
        public bool HasSwimmingPool { set; get; } = hasSwimmingPool;

        public IFloor Create()
        {
            return this;
        }
    }
}
