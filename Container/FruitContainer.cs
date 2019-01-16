using gitflow_example.Fruits;
using System.Collections.Generic;

namespace gitflow_example.Container
{
    public class FruitContainer : FruitContainerBase
    {
        public FruitContainer()
        {
            this.Fruits = new List<IFruit>();
        }
    }
}