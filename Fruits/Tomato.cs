namespace gitflow_example.Fruits
{
    public class Tomato : FruitBase
    {
        public override string Name => nameof(Tomato);
        public override string Description => "Yes I'm a fruit";
        public override string Color => "Red";
    }
}