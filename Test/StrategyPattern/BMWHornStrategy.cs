namespace Test.CarStrategyPattern
{
    public class BMWHornStrategy : IHornStrategy
    {
        public string Horn()
        {
            return "Bip from BMW";
        }
    }
}
