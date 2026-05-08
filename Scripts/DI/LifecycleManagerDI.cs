#if UNIT_DI
#nullable enable
namespace UniT.Lifecycle.DI
{
    using UniT.DI;
    using UniT.Logging.DI;

    public static class LifecycleManagerDI
    {
        public static void AddLifecycleManager(this DependencyContainer container)
        {
            if (container.Contains<ILifecycleManager>()) return;
            container.AddLoggerManager();
            container.AddInterfaces<DILifecycleManager>();
        }
    }
}
#endif