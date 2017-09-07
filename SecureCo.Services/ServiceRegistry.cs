using System;
using SecureCo.Data;
using SecureCo.Services.Implementations;
using SecureCo.Services.Interfaces;
using StructureMap;

namespace SecureCo.Services
{
    public class ServicesRegistry : Registry
    {
        public ServicesRegistry(IoC container)
        {

            For<IChequeRepository>().Use<ChequeRepository>();

            IncludeRegistry(new DataRegistry());
            For<IoC>().Use(container);
        }
    }
}
