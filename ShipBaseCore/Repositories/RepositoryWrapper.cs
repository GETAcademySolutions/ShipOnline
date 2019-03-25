using System;
using System.Collections.Generic;
using System.Text;
using ShipBaseCore.Interfaces.Repositories;
using ShipBaseCore.RepositoryInterfaces;
using ShipOnline.Persistence;

namespace ShipBaseCore.Repositories
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private ShipBaseDbContext _shipBaseDbContext;
        private ICompanyRepository _company;
        private IShipRepository _ship;

        public ICompanyRepository Company => _company ?? (_company = new CompanyRepository(_shipBaseDbContext));
        public IShipRepository Ship => _ship ?? (_ship = new ShipRepository(_shipBaseDbContext));

        public RepositoryWrapper(ShipBaseDbContext shipDbContext)
        {
            _shipBaseDbContext = shipDbContext;
        }
    }
}
