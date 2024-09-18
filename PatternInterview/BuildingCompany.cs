namespace PatternInterview
{
    public class BuildingCompany
    {
        private static BuildingCompany instance;
        private static readonly object locker = new();

        public string Name { get; }
        public string Description { get; }
        public string INN { get; }

        private BuildingCompany()
        {
            Name = "ДомСтрой РФ";
            Description = "Делаем дома для жизни";
            INN = "813298923";
        }

        public static BuildingCompany Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                        instance = new BuildingCompany();
                    return instance;
                }

            }
        }
    }
}
