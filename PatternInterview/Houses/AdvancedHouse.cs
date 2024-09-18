using PatternInterview.Builder;
using PatternInterview.HouseFactory;

namespace PatternInterview.Houses
{
    internal class AdvancedHouse : House, IHouse
    {
        public IHouse Build()
        {
            House house = new AdvancedHouseBuilder().BuildFloors().BuildFoundation("Фундамент на сваях").Build();

            return house;
        }

        internal override string GetHouseInformation()
        {
            return "Дом средней ценовой категории";
        }
    }
}
