#nullable enable
namespace UniT.Lifecycle.Default.DI
{
    using System.Collections.Generic;
    using Logging;
    using VContainer;
    using VContainer.Internal;

    public static class LifecycleManagerVContainer
    {
        public static void RegisterLifecycleManager(this IContainerBuilder builder)
        {
            builder.Register<VContainerLifecycleManager>(Lifetime.Singleton).AsImplementedInterfaces();
        }

        private sealed class VContainerLifecycleManager : LifecycleManager
        {
            [Preserve]
            public VContainerLifecycleManager(
                ContainerLocal<IReadOnlyList<ILoadOrder>> loadableServices,
                ContainerLocal<IReadOnlyList<IUpdatable>> updatableServices,
                ContainerLocal<IReadOnlyList<ILateUpdatable>> lateUpdatableServices,
                ContainerLocal<IReadOnlyList<IFixedUpdatable>> fixedUpdatableServices,
                ContainerLocal<IReadOnlyList<IApplicationFocusLostListener>> focusLostListeners,
                ContainerLocal<IReadOnlyList<IApplicationFocusGainListener>> focusGainListeners,
                ContainerLocal<IReadOnlyList<IApplicationPausedListener>> pausedListeners,
                ContainerLocal<IReadOnlyList<IApplicationResumedListener>> resumedListeners,
                ContainerLocal<IReadOnlyList<IApplicationQuitedListener>> quitedListeners,
                ILoggerManager loggerManager
            ) : base(
                loadableServices.Value,
                updatableServices.Value,
                lateUpdatableServices.Value,
                fixedUpdatableServices.Value,
                focusLostListeners.Value,
                focusGainListeners.Value,
                pausedListeners.Value,
                resumedListeners.Value,
                quitedListeners.Value,
                loggerManager
            )
            {
            }
        }
    }
}