using System;
using System.Collections.Generic;
using System.Text;
using ShipBaseCore.RepositoryInterfaces;

namespace ShipBaseCore.Interfaces.Repositories
{
    public interface IRepositoryWrapper
    {
        ICompanyRepository Company { get; }
        IShipRepository Ship { get; }
    }
}
