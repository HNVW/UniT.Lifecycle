#nullable enable
namespace UniT.Lifecycle.DI
{
    using InternalDI;

    public static class LifecycleManagerInternalDI
    {
        public static void AddLifecycleManager(this DependencyContainer container)
        {
            container.AddInterfaces<LifecycleManager>();
        }
    }
}