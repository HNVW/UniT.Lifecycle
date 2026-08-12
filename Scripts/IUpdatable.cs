#nullable enable
namespace UniT.Lifecycle
{
    public interface IUpdatable : IHasOrder
    {
        public void Update();
    }

    public interface ILateUpdatable : IHasOrder
    {
        public void LateUpdate();
    }

    public interface IFixedUpdatable : IHasOrder
    {
        public void FixedUpdate();
    }
}