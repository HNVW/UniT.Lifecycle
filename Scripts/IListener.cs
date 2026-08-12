#nullable enable
namespace UniT.Lifecycle
{
    public interface IApplicationFocusLostListener : IHasOrder
    {
        public void OnFocusLost();
    }

    public interface IApplicationFocusGainListener : IHasOrder
    {
        public void OnFocusGain();
    }

    public interface IApplicationPausedListener : IHasOrder
    {
        public void OnPaused();
    }

    public interface IApplicationResumedListener : IHasOrder
    {
        public void OnResumed();
    }

    public interface IApplicationQuitedListener : IHasOrder
    {
        public void OnQuited();
    }
}