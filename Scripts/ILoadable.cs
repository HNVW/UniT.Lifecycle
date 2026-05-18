#nullable enable
namespace UniT.Lifecycle
{
    using System;
    using System.Threading;
    using Cysharp.Threading.Tasks;

    public interface IAsyncEarlyLoadable
    {
        public UniTask LoadAsync(IProgress<float>? progress = null, CancellationToken cancellationToken = default);
    }

    public interface IAsyncLoadable
    {
        public UniTask LoadAsync(IProgress<float>? progress = null, CancellationToken cancellationToken = default);
    }

    public interface IAsyncLateLoadable
    {
        public UniTask LoadAsync(IProgress<float>? progress = null, CancellationToken cancellationToken = default);
    }
}