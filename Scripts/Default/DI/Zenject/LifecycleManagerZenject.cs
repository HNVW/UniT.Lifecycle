#nullable enable
namespace UniT.Lifecycle.DI
{
    using System.Collections.Generic;
    using Logging;
    using Zenject;
    using Zenject.Internal;

    public static class LifecycleManagerZenject
    {
        public static void BindLifecycleManager(this DiContainer container)
        {
            container.BindInterfacesTo<ZenjectLifecycleManager>().AsSingle();
        }

        private sealed class ZenjectLifecycleManager : LifecycleManager
        {
            [Preserve]
            public ZenjectLifecycleManager(
                [InjectLocal] IReadOnlyList<ILoadOrder> loadableServices,
                [InjectLocal] IReadOnlyList<IUpdatable> updatableServices,
                [InjectLocal] IReadOnlyList<ILateUpdatable> lateUpdatableServices,
                [InjectLocal] IReadOnlyList<IFixedUpdatable> fixedUpdatableServices,
                [InjectLocal] IReadOnlyList<IApplicationFocusLostListener> focusLostListeners,
                [InjectLocal] IReadOnlyList<IApplicationFocusGainListener> focusGainListeners,
                [InjectLocal] IReadOnlyList<IApplicationPausedListener> pausedListeners,
                [InjectLocal] IReadOnlyList<IApplicationResumedListener> resumedListeners,
                [InjectLocal] IReadOnlyList<IApplicationQuitedListener> quitedListeners,
                ILoggerManager loggerManager
            ) : base(
                loadableServices,
                updatableServices,
                lateUpdatableServices,
                fixedUpdatableServices,
                focusLostListeners,
                focusGainListeners,
                pausedListeners,
                resumedListeners,
                quitedListeners,
                loggerManager
            )
            {
            }
        }
    }
}