namespace PatternInterview.FloorDecorator
{
    public class SecondFloorDecorator(bool haveBalcony, IFloor floor) : FloorDecorator(floor)
    {
        public bool Balcony { set; get; } = haveBalcony;

        public IFloor Create()
        {
            return this;
        }
    }
}
