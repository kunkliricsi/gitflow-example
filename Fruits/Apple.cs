using System;

namespace gitflow_example.Fruits
{
    public class Apple : FruitBase
    {
        private static readonly Random random = new Random();

        public override string Name => nameof(Apple);
        public override string Description => "Big round boi";
        public override string Color { get; }

        public Apple()
        {
            var colorIndex = random.Next(5);

            switch (colorIndex)
            {
                case 0:
                    this.Color = "Red";
                    break;
                case 1:
                    this.Color = "Green";
                    break;
                case 2:
                    this.Color = "Yellow";
                    break;
                case 3:
                    this.Color = "Orange";
                    break;
                case 4:
                    this.Color = "White";
                    break;
            }
        }
    }
}