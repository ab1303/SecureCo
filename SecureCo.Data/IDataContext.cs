using System;
using System.Data.Entity;
using SecureCo.Data.Models;


namespace SecureCo.Data
{
    public interface IDataContext : IDisposable
    {
        IDbSet<Cheque> Cheques { get; set; }
        int SaveChanges();
    }
}
