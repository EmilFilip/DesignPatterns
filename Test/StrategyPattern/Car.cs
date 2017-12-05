namespace Test.CarStrategyPattern
{
    public class Car
    {
        public readonly IHornStrategy IHornStrategy;

        public Car(IHornStrategy iHornStrategy)
        {
            this.IHornStrategy = iHornStrategy;
        }

        public string PressHorn()
        {
            return IHornStrategy.Horn();
        }
    }
}
