using PatternInterview.FloorDecorator;
using PatternInterview.Houses;

namespace PatternInterview.Builder
{
    internal class ExpensiveHouseBuilder : IHouseBuilder
    {
        private AdvancedHouse House { get; set; } = new();

        public House Build()
        {
            return House;
        }

        public IHouseBuilder BuildFloors()
        {
            IFloor downFloor = new Floor(true, 6, 10);
            IFloor upFloor = new Floor(false, 3, 6);
            IFloor endFloor = new Floor(true, 0, 0);

            IFloor firstFloor = new FirstFloorDecorator(true, downFloor).Create();
            IFloor secondFloor = new SecondFloorDecorator(true, upFloor).Create();
            IFloor roofFloor = new ThirdFloorDecorator(true, endFloor).Create();

            House.Floors.Add(firstFloor);
            House.Floors.Add(secondFloor);
            House.Floors.Add(roofFloor);

            return this;
        }

        public IHouseBuilder BuildFoundation(string nameFoundation)
        {
            House.Foundation = nameFoundation;
            return this;
        }

        public IHouseBuilder BuildRoof()
        {
            House.Roof = "Нет классической крыши";
            return this;
        }
    }
}
