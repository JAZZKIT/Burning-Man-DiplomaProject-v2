using BurnTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BurnTest.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Ticket> Tickets { get; }
        IRepository<Order> Orders { get; }
        void Save();
    }
}
