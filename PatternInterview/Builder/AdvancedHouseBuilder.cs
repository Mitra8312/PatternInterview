using PatternInterview.FloorDecorator;
using PatternInterview.Houses;

namespace PatternInterview.Builder
{
    internal class AdvancedHouseBuilder : IHouseBuilder
    {
        private AdvancedHouse House { get; set; } = new();

        public House Build()
        {
            return House;
        }

        public IHouseBuilder BuildFloors()
        {
            IFloor fFloor = new Floor(true, 5, 9);
            IFloor sFloor = new Floor(true, 3, 5);

            IFloor firstFloor = new FirstFloorDecorator(true, fFloor);
            IFloor secondFloor = new SecondFloorDecorator(true, sFloor);

            House.Floors.Add(firstFloor);
            House.Floors.Add(secondFloor);
            return this;
        }

        public IHouseBuilder BuildFoundation(string nameFoundation)
        {
            House.Foundation = nameFoundation;
            return this;
        }

        public IHouseBuilder BuildRoof()
        {
            House.Roof = "Крыша из шифера с чердаком";
            return this;
        }
    }
}
