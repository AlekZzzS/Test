using Microsoft.EntityFrameworkCore;
using WebApplication2.Data;

namespace WebApplication2.Repositories
{
    /// <summary>
    /// Базовый репозиторий
    /// </summary>
    public abstract class BaseRepository<T> : Disposable where T : class
    {
        public ApplicationContext _context { get; private set; }
        private DbSet<T> _dbSet;

        protected BaseRepository(ApplicationContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        protected override void DisposeCore()
        {
            if (_context != null)
            {
                _context.Dispose();
            }
        }
    }

    public class Disposable : IDisposable
    {
        private bool isDisposed;

        ~Disposable()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (!isDisposed && disposing)
            {
                DisposeCore();
            }

            isDisposed = true;
        }

        // Override this to dispose custom objects
        protected virtual void DisposeCore() { }
    }
}
