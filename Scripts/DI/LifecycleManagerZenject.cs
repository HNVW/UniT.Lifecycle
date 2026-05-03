#if UNIT_ZENJECT
#nullable enable
namespace UniT.Lifecycle.DI
{
    using UniT.Logging.DI;
    using Zenject;

    public static class LifecycleManagerZenject
    {
        public static void BindLifecycleManager(this DiContainer container)
        {
            if (container.HasBinding<ILifecycleManager>()) return;
            container.BindLoggerManager();
            container.BindInterfacesTo<ZenjectLifecycleManager>().AsSingle();
        }
    }
}
#endif