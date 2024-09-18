using PatternInterview.FloorDecorator;
using PatternInterview.HouseFactory;

namespace PatternInterview.Houses
{
    public abstract class House : IHouse
    {
        public string Foundation { get; set; }
        public string Roof { get; set; }
        public List<IFloor> Floors { get; set; } = [];

        public IHouse Build()
        {
            return this;
        }

        internal virtual string GetHouseInformation()
        {
            return "Обычный дом";
        }
    }
}
