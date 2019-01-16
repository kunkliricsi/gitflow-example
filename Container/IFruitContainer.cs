using gitflow_example.Fruits;

namespace gitflow_example.Container
{
    public interface IFruitContainer
    {
        void Add(IFruit fruit);
        void Write();
    }
}