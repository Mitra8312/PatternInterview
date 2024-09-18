using PatternInterview.Houses;

namespace PatternInterview.Builder
{
    internal interface IHouseBuilder
    {
        IHouseBuilder BuildFoundation(string nameFoundation);
        IHouseBuilder BuildFloors();
        IHouseBuilder BuildRoof();

        House Build();
    }
}
