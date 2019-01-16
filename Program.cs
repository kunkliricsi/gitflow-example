using gitflow_example.Container;
using gitflow_example.Fruits;

namespace gitflow_example
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new FruitContainer();

            container.Add(new Banana());
            container.Add(new Mango());
            container.Add(new Tomato());
            container.Add(new Apple());

            container.Write();
        }
    }
}
