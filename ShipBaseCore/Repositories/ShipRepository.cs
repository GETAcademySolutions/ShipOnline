using System.Collections.Generic;
using ShipBaseCore.Models.Domain;
using ShipBaseCore.RepositoryInterfaces;
using ShipOnline.Persistence;

namespace ShipBaseCore.Repositories
{
    public class ShipRepository : RepositoryBase<Ship>, IShipRepository
    {
        public ShipRepository(ShipBaseDbContext context) : base(context)
        {
        }

        public IEnumerable<Ship> GetShips()
        {
            return FindAll();
        }

    }
}