namespace Test.CarStrategyPattern
{
    public class AudiHornStrategy : IHornStrategy
    {
        public string Horn()
        {
            return "Bip Biiiiip from Audi";
        }
    }
}
