using PatternInterview.Enums;
using PatternInterview.Houses;

namespace PatternInterview.HouseFactory
{
    internal static class HouseBuildingFactory
    {
        public static IHouse CreateHouse(TypeHouseEnum houseType)
        {
            return houseType switch
            {
                TypeHouseEnum.Ordinary => new OrdinaryHouse().Build(),
                TypeHouseEnum.Advanced => new AdvancedHouse().Build(),
                TypeHouseEnum.Expensive => new ExpensiveHouse().Build(),
                _ => throw new ArgumentException("Пока невозможно посторить такой дом"),
            };
        }
    }
}
