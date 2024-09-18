using PatternInterview.FloorDecorator;
using PatternInterview.Houses;

namespace PatternInterview.Builder
{
    internal class OrdinaryHouseBuilder : IHouseBuilder
    {
        private OrdinaryHouse House { set; get; } = new();

        public House Build()
        {
            return House;
        }

        public IHouseBuilder BuildFloors()
        {
            IFloor floor = new Floor(true, 3, 5);

            IFloor firstFloor = new FirstFloorDecorator(true, floor).Create();

            House.Floors.Add(firstFloor);

            return this;
        }

        public IHouseBuilder BuildFoundation(string nameFoundation)
        {
            House.Foundation = nameFoundation;
            return this;
        }

        public IHouseBuilder BuildRoof()
        {
            House.Roof = "Крыша из шифера";
            return this;
        }
    }
}
