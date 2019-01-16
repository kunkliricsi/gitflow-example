using System;
using gitflow_example.Fruits;
using System.Collections.Generic;

namespace gitflow_example.Container
{
    public abstract class FruitContainerBase : IFruitContainer
    {
        protected IList<IFruit> Fruits { get; set; }

        public virtual void Add(IFruit fruit)
        {
            Fruits.Add(fruit);
        }

        public virtual void Write()
        {
            foreach (var fruit in Fruits)
            {
                Console.WriteLine(fruit.ToString());
            }
        }
    }
}