using PatternInterview.Enums;
using PatternInterview.HouseFactory;
using PatternInterview.Houses;

namespace PatternInterview
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BuildingCompany buildingCompany = BuildingCompany.Instance;

            IHouse house = HouseBuildingFactory.CreateHouse(TypeHouseEnum.Advanced);

            Console.WriteLine(((AdvancedHouse)house).GetHouseInformation());
        }
    }
}
