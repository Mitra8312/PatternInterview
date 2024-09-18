using PatternInterview.Builder;
using PatternInterview.HouseFactory;

namespace PatternInterview.Houses
{
    internal class OrdinaryHouse : House, IHouse
    {
        public IHouse Build()
        {
            House house = new OrdinaryHouseBuilder().BuildFloors().BuildRoof().BuildFoundation("Блочный").Build();

            return house;
        }

        internal override string GetHouseInformation()
        {
            return "Обычный дом";
        }
    }
}
