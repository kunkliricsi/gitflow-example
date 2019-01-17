namespace gitflow_example.Fruits
{
    public class Banana : FruitBase
    {
        public override string Name => nameof(Banana);
        public override string Description => "Short yellow boi";
        public override string Color => "Yellow";
    }
}