using System;

namespace SH.Core.Utility
{
    public abstract class Disposable : IDisposable
    {
        ~Disposable()
        {
            Dispose(true);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool canDispose)
        {
            if (canDispose) DisposeCore();
        }

        /// <summary>
        /// To release resources held
        /// by the current object.
        /// </summary>
        protected abstract void DisposeCore();
    }
}
