namespace PatternInterview.FloorDecorator
{
    public class FloorDecorator(IFloor iFloor) : IFloor
    {
        protected IFloor floor = iFloor;

        public IFloor Create()
        {
            return floor;
        }
    }
}
