using hotel_listing.Data;
using System;
using System.Threading.Tasks;
using System.Linq;


namespace hotel_listing.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<Country> Countries { get; }
        IGenericRepository<Hotel> Hotels { get; }

        Task Save();
    }
}
