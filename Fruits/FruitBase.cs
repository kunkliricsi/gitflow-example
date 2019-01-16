namespace gitflow_example.Fruits
{
    public abstract class FruitBase : IFruit
    {
        public abstract string Name { get; }
        public abstract string Description { get; }
        public abstract string Color { get; }

        public override string ToString()
        {
            return $"I'am a(n) {this.Name}, my color is {this.Color}";
        }
    }
}