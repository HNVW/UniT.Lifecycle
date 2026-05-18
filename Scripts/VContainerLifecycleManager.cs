#if UNIT_VCONTAINER
#nullable enable
namespace UniT.Lifecycle
{
    using System.Collections.Generic;
    using UniT.Logging;
    using UnityEngine.Scripting;
    using VContainer.Internal;

    public sealed class VContainerLifecycleManager : LifecycleManager
    {
        [Preserve]
        public VContainerLifecycleManager(
            ContainerLocal<IEnumerable<IAsyncEarlyLoadable>> asyncEarlyLoadableServices,
            ContainerLocal<IEnumerable<IAsyncLoadable>>      asyncLoadableServices,
            ContainerLocal<IEnumerable<IAsyncLateLoadable>>  asyncLateLoadableServices,
            ContainerLocal<IEnumerable<IUpdatable>>          updatableServices,
            ContainerLocal<IEnumerable<ILateUpdatable>>      lateUpdatableServices,
            ContainerLocal<IEnumerable<IFixedUpdatable>>     fixedUpdatableServices,
            ContainerLocal<IEnumerable<IFocusLostListener>>  focusLostListeners,
            ContainerLocal<IEnumerable<IFocusGainListener>>  focusGainListeners,
            ContainerLocal<IEnumerable<IPauseListener>>      pauseListeners,
            ContainerLocal<IEnumerable<IResumeListener>>     resumeListeners,
            ILoggerManager                                   loggerManager
        ) : base(
            asyncEarlyLoadableServices.Value,
            asyncLoadableServices.Value,
            asyncLateLoadableServices.Value,
            updatableServices.Value,
            lateUpdatableServices.Value,
            fixedUpdatableServices.Value,
            focusLostListeners.Value,
            focusGainListeners.Value,
            pauseListeners.Value,
            resumeListeners.Value,
            loggerManager
        )
        {
        }
    }
}
#endif