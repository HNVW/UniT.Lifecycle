#nullable enable
namespace UniT.Lifecycle
{
    public interface IApplicationFocusLostListener
    {
        public void OnFocusLost();
    }

    public interface IApplicationFocusGainListener
    {
        public void OnFocusGain();
    }

    public interface IApplicationPausedListener
    {
        public void OnPaused();
    }

    public interface IApplicationResumedListener
    {
        public void OnResumed();
    }

    public interface IApplicationQuitedListener
    {
        public void OnQuited();
    }
}