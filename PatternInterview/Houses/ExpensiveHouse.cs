using PatternInterview.Builder;
using PatternInterview.HouseFactory;

namespace PatternInterview.Houses
{
    internal class ExpensiveHouse : House, IHouse
    {
        public IHouse Build()
        {
            House house = new ExpensiveHouseBuilder().BuildFoundation("Утеплённая шведская плита").BuildFloors().BuildRoof().Build();

            return new ExpensiveHouse();
        }

        internal override string GetHouseInformation()
        {
            return "Дом высокой ценовой категории";
        }
    }
}
