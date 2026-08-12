#nullable enable
namespace UniT.Lifecycle
{
    using System;
    using System.Threading;
    using Cysharp.Threading.Tasks;

    public interface ILoadable : IHasOrder
    {
        public void Load();
    }

    public interface IAsyncLoadable : IHasOrder
    {
        public UniTask LoadAsync(IProgress<float>? progress = null, CancellationToken cancellationToken = default);
    }

    public interface IEarlyLoadable : ILoadable
    {
        int IHasOrder.Order => int.MinValue / 2;
    }

    public interface IAsyncEarlyLoadable : IAsyncLoadable
    {
        int IHasOrder.Order => int.MinValue / 2;
    }

    public interface ILateLoadable : ILoadable
    {
        int IHasOrder.Order => int.MaxValue / 2;
    }

    public interface IAsyncLateLoadable : IAsyncLoadable
    {
        int IHasOrder.Order => int.MaxValue / 2;
    }
}